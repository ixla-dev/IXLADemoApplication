using System.Resources;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Aida.Sdk.Mini;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Hosting;
using Npgsql;
using System.Data;
using System.Xml;

#nullable disable

namespace WinFormsApp1;
public partial class FormMain : Form
{
    enum DgvColumns : int
    {
        ValueType,
        Name,
        UniqueName,
        StringToPrint,
        ImageToPrint,
        PathImage
    }
    
    private const string POPUP_TITLE = "IXLA Demo Application";

    private const string DEFAULT_IMAGE = "Default Image";
    private const string DGV_ORDER_COLUMN_NAME = "Entity_";

    private SearchJobTemplatesResultDto _templates;
    private bool _deviceConnected = false;
    private DeviceDB _deviceDb;
    private Image _defautlImage;

    private int dgvOrderOriginalSize;

#nullable disable

    public FormMain()
    {
        InitializeComponent();

        dgvOrderOriginalSize = dgvOrder.Width;
        
        _templates = new SearchJobTemplatesResultDto();
        _defautlImage = null;

        ReadConfiguration();

        this.Closing += OnFormClosing;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        if (_defautlImage == null)
            _defautlImage = picImageToPrint.Image;
    }

    private void OnFormClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        SaveConfiguration();
    }

    const string XML_CONFIG_FILE = "DemoApplication.xml";
    const string XML_ROOT = "IXLATool";
    const string XML_IP_ADDRESS = "IpAddress";

    private void ReadConfiguration()
    {
        // Read last configuration
        XmlDocument xd = new XmlDocument();
        //reading from the file
        try
        {
            xd.Load(Application.StartupPath + "\\" + XML_CONFIG_FILE);

            XmlNode root = xd.SelectSingleNode(XML_ROOT);

            if (root != null)
            {
                // Leggo configurazione di rete
                tbIpAddress.Text = root[XML_IP_ADDRESS].InnerText;
            }
        }
        catch (Exception ex)
        {
            tbIpAddress.Text = @"0.0.0.0";

            //if (ex is FileNotFoundException)
            //    // Se non c'è il file, lascio il default !
            //    MessageBox.Show("Error on read configuration file !\n\n" + ex.Message, POPUP_TITLE);

            //else if (ex is NullReferenceException)
            //    // Se non c'è il file, lascio il default !
            //    MessageBox.Show("Error on read configuration file !\n\n" + ex.Message, POPUP_TITLE);

            //else
            //    // Se il file è stato manomesso, lascio il default !
            //    MessageBox.Show("Error file configuration !\n\n" + ex.Message, POPUP_TITLE);
        }
    }

    private void SaveConfiguration()
    {
        // Salvo la configurazione
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode docNode = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        xmlDoc.AppendChild(docNode);

        XmlNode rootNode = xmlDoc.CreateElement(XML_ROOT);
        xmlDoc.AppendChild(rootNode);

        // IP Address parameters
        XmlNode xNode = xmlDoc.CreateElement(XML_IP_ADDRESS);
        xNode.InnerText = tbIpAddress.Text;
        rootNode.AppendChild(xNode);

        try
        {
            xmlDoc.Save(Application.StartupPath + "\\" + XML_CONFIG_FILE);
        }
        catch (Exception /*ex*/)
        {
        }
    }

    private void CheckStatus(IntegrationApi api)
    {
        // Check device status
        var state = api.GetWorkflowSchedulerState();
        tbStatus.Text = $"Device Status: {state.Status}";
        tbInfoGhost.Text = "";
        if (!String.IsNullOrEmpty(state.ErrorDetails))
            tbInfoGhost.Text = state.ErrorDetails;
        if (!String.IsNullOrEmpty(state.StopReason.ToString()))
            tbInfoGhost.Text = state.StopReason.ToString();

        // Check the scheduler state
        if (state.Status == WorkflowSchedulerStatus.Running || state.Status == WorkflowSchedulerStatus.FeederEmpty)
        {
            btStartProcess.Enabled = false;
            btProcessOrder.Enabled = true;
        }
        else
        {
            btStartProcess.Enabled = true;
            btProcessCard.Enabled = false;
            btProcessOrder.Enabled = false;
        }
    }

    private string GetUrl()
    {
        string ipAddress = tbIpAddress.Text;
        string baseUrla = $"http://{ipAddress}:5000";
        return baseUrla;
    }
    
    private void btConnect_Click(object sender, EventArgs e)
    {
        if (!_deviceConnected)
        {
            btConnect.Enabled = false;
            
            // Connect the device
            var api = new IntegrationApi(GetUrl());

            try
            {
                // Get the list of the job templates present in the device
                _templates = api.FindJobTemplates(pageSize:1000);

                if (_templates.Total > 0)
                {
                    int iiTemplate = 0;
                    // Add the work templates present in the device to the ComboBox
                    for (int i = 0; i < _templates.Total; i++)
                        comboTemplates.Items.Add(_templates.Items[i].Name);

                    // handle controls
                    tbIpAddress.Enabled = false;
                    comboTemplates.Enabled = true;
                    btStartProcess.Enabled = true;
                    cbNoLaser.Enabled = true;

                    // Check scheduler Status(api)
                    var state = api.GetWorkflowSchedulerState();
                    if (state.Status == WorkflowSchedulerStatus.Running)
                    {
                        for (iiTemplate = 0; iiTemplate < comboTemplates.Items.Count; iiTemplate++)
                        {
                            if (comboTemplates.Items[iiTemplate]?.ToString() == state.CurrentJobTemplateName)
                                break;
                        }

                        // If the template is already running ...
                        var template = api.GetJobTemplateById((int)state.CurrentJobTemplateId);

                        // ... and webhook is needed
                        if (template.WebhooksTarget != null)
                        {
                            btStartWebHook.BackColor = Color.LightGreen;
                            btStartWebHook.Enabled = false;
                            // Restart the Webhook
                            btStartWebHook_Click(sender, e);
                        }

                        // handle controls
                        comboTemplates.Enabled = false;
                        btStartProcess.Enabled = false;
                        cbNoLaser.Enabled = false;
                        btProcessCard.Enabled = true;
                        btProcessOrder.Enabled = true;
                        btStopProcess.Enabled = true;
                    }

                    comboTemplates.SelectedIndex = iiTemplate;
                }
                else
                {
                    // There is no model configured in the device
                    comboTemplates.Text = "NO templates";
                }

                _deviceConnected = true;
                btConnect.Text = @"Disconnect";
                btConnect.BackColor = Color.LightGreen;

                // Connecting to the device DB
                if (_deviceDb == null)
                {
                    _deviceDb = new DeviceDB(tbIpAddress.Text);
                    _deviceDb.Connect();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, @"Device not connected or incorrect IP address !", POPUP_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            _deviceConnected = false;

            var api = new IntegrationApi(GetUrl());
 
            if (_deviceDb != null)
            {
                _deviceDb.Disconnect();
                _deviceDb = null;
            }

            _templates = null;
            api.Dispose();

            btConnect.Text = @"Connect";
            btConnect.BackColor = Color.LightCoral;

            dgvEntity.Rows.Clear();
            dgvOrder.Columns.Clear();
            comboTemplates.Items.Clear();

            // handle controls
            tbIpAddress.Enabled = true;
            comboTemplates.Enabled = false;
            btStartProcess.Enabled = false;
            cbNoLaser.Enabled = false;
            btStopProcess.Enabled = false;
            btProcessCard.Enabled = false;
            EnableEntityControls(false);
            panelImage.Visible = false;
            panelString.Visible = false;
        }
        
        btConnect.Enabled = true;
    }

    public void AppendTextBox(string value)
    {
        if (InvokeRequired)
        {
            this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
            return;
        }
        tbInfoGhost.Text += value;
    }

    private ClientWebHost _webHost;

    private void btStartWebHook_Click(object sender, EventArgs e)
    {
        _webHost = new ClientWebHost();
        try
        {
            var wb = _webHost.CreateHost("192.168.3.216", 4);
            _webHost.StartWebHook();

            btStartWebHook.BackColor = Color.LightGreen;
            btStartWebHook.Enabled = false;
        }
        catch
        {
        }
    }

    private void btShowProcess_Click(object sender, EventArgs e)
    {
        // Show the process list
        if (_templates != null)
        {
            foreach (var jobTemplate in _templates.Items)
            {
                if (jobTemplate.Name == comboTemplates.Text)
                {

                }
            }
        }
    }

    private void btResumeFeeder_Click(object sender, EventArgs e)
    {
        var api = new IntegrationApi(GetUrl());
        api.ResumeWorkflowScheduler();
    }

    private List<EntityDescriptor> _listEntity;

    private void comboTemplates_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComboBox combo = (ComboBox)sender;

        int id = 0;
        if (_templates != null)
            id = (int)_templates.Items[combo.SelectedIndex].Id;

        var api = new IntegrationApi(GetUrl());
        {
            int iiRow = 0;
            int widthColumns = 0;

            CheckStatus(api);

            EnableEntityControls(false);
            dgvEntity.Rows.Clear();
            dgvOrder.Columns.Clear();
            dgvOrder.Width = dgvOrderOriginalSize;
            _lastRow = -1;

            // Check Template Entity
            _listEntity = api.GetEntityDescriptorsByJobTemplateId(id);// Async(id).ConfigureAwait(false);
            foreach (var f in _listEntity)
            {
                if (f.ValueType == EntityFieldValueType.String)
                {
                    dgvEntity.Rows.Add(f.ValueType, f.DisplayName, f.EntityName, f.DisplayName);
                    dgvEntity.Rows[iiRow].Cells[(int)DgvColumns.StringToPrint].ToolTipText = f.DisplayName;
                }
                else
                    dgvEntity.Rows.Add(f.ValueType, f.DisplayName, f.EntityName);

                var newCol = new DataGridViewTextBoxColumn();
                newCol.Name = f.EntityName;
                newCol.HeaderText = f.DisplayName;
                newCol.ToolTipText = f.DisplayName;
                newCol.SortMode = DataGridViewColumnSortMode.NotSortable;

                int cc = dgvOrder.Columns.Add(newCol);
                widthColumns += newCol.Width;

                iiRow++;
            }

            //if( widthColumns < dgvOrder.Width)
            //    dgvOrder.Width = widthColumns;

            if (_listEntity.Count > 0)
                EnableEntityControls(true);
        }
    }

    private void EnableEntityControls(bool enabled)
    {
        dgvEntity.Enabled = enabled;
        dgvOrder.Enabled = enabled;
        btClearOrder.Enabled = enabled;
        btDeleteRowOrder.Enabled = enabled;
        btAddToOrder.Enabled = enabled;
        btProcessOrder.Enabled = enabled;
        btProcessOrder.Enabled = btStartProcess.Enabled ? false : enabled;
    }


    private void btStartProcess_Click(object sender, EventArgs e)
    {
        var api = new IntegrationApi(GetUrl());
        {
            btStartProcess.Enabled = false;

            var state = api.GetWorkflowSchedulerState(); // Async().ConfigureAwait(false);
            if (state.Status == WorkflowSchedulerStatus.Running)
            {
                CheckStatus(api);

                // handle controls
                cbNoLaser.Enabled = false;
                btProcessCard.Enabled = true;
                btStopProcess.Enabled = true;
                return;
            }

            var startupParams = new WorkflowSchedulerStartupParamsDto
            {
                // Template name to process
                JobTemplateName = comboTemplates.Text,
                // Obsolete
                DisableRedPointer = false,
                // Enable disable the laser source
                DryRun = cbNoLaser.Checked,
                // Execute or not a reset of the transport at the start of the scheduler
                NoReset = false,
                // Set to false, used for testing only
                SkipEntityUpdates = false, 
                // Process a batch of n cards, -1 means all cards in the stacker
                StopAfter = -1,
                // Obsolete
                TaskAllocationStrategy = null,
                // Obsolete
                WorkflowTypeName = @"AutoGeneratedWorkflow",
                // Additional data
                MetadataFields = new Dictionary<string, object> { ["machine_id"] = "00003" },
                // Additional data returned with webhook callback
                FilterJobsBy = new List<FilterDto>()
            };

            try
            {
                state = api.StartWorkflowScheduler(startupParams); // Async(startupParams).ConfigureAwait(false);

                if (state.StopReason == WorkflowSchedulerStopReason.WebhooksServerUnreachable)
                {
                    // Enable Webhook Server and retry start scheduler
                    btStartWebHook_Click(sender, e);

                    state = api.StartWorkflowScheduler(startupParams); // Async(startupParams).ConfigureAwait(false);
                }

                CheckStatus(api);

                // handle controls
                comboTemplates.Enabled = false;
                cbNoLaser.Enabled = false;
                btProcessCard.Enabled = true;
                btStopProcess.Enabled = true;
                btStartProcess.Enabled = false;
            }
            catch
            {
                state = api.GetWorkflowSchedulerState(); // Async().ConfigureAwait(false);
                btStartProcess.Enabled = true;
            }
        }
    }

    private async void btStopProcess_Click(object sender, EventArgs e)
    {
        var api = new IntegrationApi(GetUrl());
        {
            await api.StopWorkflowSchedulerAsync(true);

            CheckStatus(api);
        }

        // handle controls
        comboTemplates.Enabled = true;
        btStartProcess.Enabled = true;
        cbNoLaser.Enabled = true;
        btProcessCard.Enabled = false;
        btStopProcess.Enabled = false;
    }

    private int _lastRow = -1;
    private void dgvEntity_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView dgv = (DataGridView)sender;

        if (e.RowIndex == -1)
            return;
        
        DataGridViewRow dgvr = dgv.Rows[e.RowIndex];

        if (_lastRow != -1)
        {
            dgv.Rows[_lastRow].Cells[(int)DgvColumns.StringToPrint].Value = tbStringToPrint.Text;
            dgv.Rows[_lastRow].Cells[(int)DgvColumns.StringToPrint].ToolTipText = tbStringToPrint.Text;
            if (picImageToPrint.Image != _defautlImage)
                dgv.Rows[_lastRow].Cells[(int)DgvColumns.ImageToPrint].Value = picImageToPrint.Image;
        }

        // EntityDescriptor entity = new EntityDescriptor();
        // for(int ii = 0; ii < dgv.Rows.Count; ii++)
        //     if (ii == listEntity[ii].EntityIndex)
        //         entity = listEntity[ii];

        tbStringToPrint.TextChanged -= tbStringToPrint_TextChanged; 
        tbStringToPrint.Text = "";
        tbStringToPrint.TextChanged += tbStringToPrint_TextChanged;

        if (dgvr.Cells[(int)DgvColumns.ValueType].Value.ToString() == nameof(EntityFieldValueType.String))
        {
            panelImage.Visible = false;
            panelString.Visible = true;
            if (dgvr.Cells[(int)DgvColumns.StringToPrint].Value != null)
                tbStringToPrint.Text = dgvr.Cells[(int)DgvColumns.StringToPrint].Value.ToString();
        }
        picImageToPrint.Image = _defautlImage;
        if (dgvr.Cells[(int)DgvColumns.ValueType].Value.ToString() == nameof(EntityFieldValueType.Image) ||
            dgvr.Cells[(int)DgvColumns.ValueType].Value.ToString() == nameof(EntityFieldValueType.InkjetImage))
        {
            panelString.Visible = false;
            panelImage.Visible = true;
            if (dgvr.Cells[(int)DgvColumns.ImageToPrint].Value != null)
                picImageToPrint.Image = (Image)dgvr.Cells[(int)DgvColumns.ImageToPrint].Value;
        }

        _lastRow = e.RowIndex;
    }

    private void picImageToPrint_Click(object sender, EventArgs e)
    {
        var fd = new OpenFileDialog() { Title = "Choose Image" };
        if (fd.ShowDialog() == DialogResult.OK)
        {
            picImageToPrint.Image = Image.FromFile(fd.FileName);
            // Save the path filename
            dgvEntity.Rows[dgvEntity.CurrentCell.RowIndex].Cells[(int)DgvColumns.PathImage].Value = fd.FileName;
        }

    }

    private int _correlationId = 0;
    private void btProcessCard_Click(object sender, EventArgs e)
    {
        int idxCombo = comboTemplates.SelectedIndex;
       
        // Build the string for create the INSERT INTO DB command
        _deviceDb.CreateNewCommand();
        
        foreach (DataGridViewRow row in dgvEntity.Rows)
        {
            if ((row.Cells[(int)DgvColumns.StringToPrint].Value != null &&
                 row.Cells[(int)DgvColumns.StringToPrint].Value.ToString() != "") ||
                row.Cells[(int)DgvColumns.PathImage].Value != null)
            {
                string fieldName = row.Cells[(int)DgvColumns.UniqueName].Value.ToString();
                _deviceDb.AddParameter(fieldName);
            }
        }

        // Add job_status parameter
        _deviceDb.AddParameter("job_status");

        // Add optional correlation_id parameters
        _deviceDb.AddParameter("correlation_id");

        var api = new IntegrationApi(GetUrl());
        {
            var dbTable = api.GetDataExchangeTableDefinition((int)_templates.Items[idxCombo].Id);

            // Compile the string to send at DB
            _deviceDb.BuildCommand(dbTable.TableName);

            foreach (DataGridViewRow row in dgvEntity.Rows)
            {
                // if (row.Cells[(int)DgvColumns.ValueType].Value.ToString() == nameof(EntityFieldValueType.String))
                {
                    if (row.Cells[(int)DgvColumns.StringToPrint].Value != null && row.Cells[(int)DgvColumns.StringToPrint].Value.ToString() != "")
                    {
                        _deviceDb.SetParameterString(row.Cells[(int)DgvColumns.UniqueName].Value.ToString(), row.Cells[(int)DgvColumns.StringToPrint].Value.ToString());
                    }
                }

                // if (row.Cells[(int)DgvColumns.ValueType].Value.ToString() == nameof(EntityFieldValueType.Image))
                {
                    if (row.Cells[(int)DgvColumns.PathImage].Value != null)
                    {
                        _deviceDb.SetParameterImage(row.Cells[(int)DgvColumns.UniqueName].Value.ToString(), row.Cells[(int)DgvColumns.PathImage].Value.ToString());
                    }
                }
            }

            _correlationId++;
            var correlationId = $"job:{_correlationId:0000}";
            // Set correlation_id and job_status parameter
            _deviceDb.SetParameterString("correlation_Id", correlationId);
            _deviceDb.SetParameterString("job_status", "Waiting");

            // Execute the command (add item at DB) 
            _deviceDb.ExecuteCmd();
        }
    }

    private void btProcessOrder_Click(object sender, EventArgs e)
    {
        int idxCombo;

        EnableEntityControls(false);

        idxCombo = comboTemplates.SelectedIndex;

        var api = new IntegrationApi(GetUrl());
        {
            var dbTable = api.GetDataExchangeTableDefinition((int)_templates.Items[idxCombo].Id);

            // Send items to DB
            foreach (DataGridViewRow rowOrder in dgvOrder.Rows)
            {
                // Build the string for create the INSERT INTO DB command 
                _deviceDb.CreateNewCommand();
   
                for(int iiEntity = 0; iiEntity < _listEntity.Count; iiEntity++) 
                {
                    if (_listEntity[iiEntity].ValueType == EntityFieldValueType.String)
                    {
                        string fieldName = dgvOrder.Columns[iiEntity].Name;
                        _deviceDb.AddParameter(fieldName);
                    }
                    
                    if ((_listEntity[iiEntity].ValueType == EntityFieldValueType.Image ||
                         _listEntity[iiEntity].ValueType == EntityFieldValueType.InkjetImage) &&
                        rowOrder.Cells[iiEntity].Value.ToString() != DEFAULT_IMAGE)
                    {
                        string fieldName = dgvOrder.Columns[iiEntity].Name;
                        _deviceDb.AddParameter(fieldName);
                    }
                }
                
                // Add job_status parameter
                _deviceDb.AddParameter("job_status");
                
                // Add optional correlation_id parameters
                _deviceDb.AddParameter("correlation_id");

                // Compile the string to send at DB
                _deviceDb.BuildCommand(dbTable.TableName);
                
                for(int iiEntity = 0; iiEntity < _listEntity.Count; iiEntity++) 
                {
                    if (_listEntity[iiEntity].ValueType == EntityFieldValueType.String)
                    {
                        _deviceDb.SetParameterString(dgvOrder.Columns[iiEntity].Name, rowOrder.Cells[iiEntity].Value.ToString());
                    }
                
                    if ((_listEntity[iiEntity].ValueType == EntityFieldValueType.Image ||
                        _listEntity[iiEntity].ValueType == EntityFieldValueType.InkjetImage) &&
                        rowOrder.Cells[iiEntity].Value.ToString() != DEFAULT_IMAGE)
                    {
                        _deviceDb.SetParameterImage(dgvOrder.Columns[iiEntity].Name, rowOrder.Cells[iiEntity].Value.ToString());
                    }
                }

                _correlationId++;
                var correlationId = $"job:{_correlationId:0000}";
                _deviceDb.SetParameterString("correlation_Id", correlationId);
                _deviceDb.SetParameterString("job_status", "Waiting");
            
                _deviceDb.ExecuteCmd();
            }
        }

        EnableEntityControls(true);
    }

    private void btAddToOrder_Click(object sender, EventArgs e)
    {
        int iiCol = 0;
        int newRow = dgvOrder.Rows.Add();

        foreach (DataGridViewRow row in dgvEntity.Rows)
        {
            if (row.Cells[(int)DgvColumns.StringToPrint].Value != null)
                dgvOrder.Rows[newRow].Cells[iiCol].Value = row.Cells[(int)DgvColumns.StringToPrint].Value.ToString();
            if (_listEntity[iiCol].ValueType == EntityFieldValueType.Image || _listEntity[iiCol].ValueType == EntityFieldValueType.InkjetImage)
            {
                if (row.Cells[(int)DgvColumns.PathImage].Value == null)
                {
                    dgvOrder.Rows[newRow].Cells[iiCol].Value = DEFAULT_IMAGE;
                    dgvOrder.Rows[newRow].Cells[iiCol].Style.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    dgvOrder.Rows[newRow].Cells[iiCol].Value = row.Cells[(int)DgvColumns.PathImage].Value.ToString();
                    dgvOrder.Rows[newRow].Cells[iiCol].ToolTipText = row.Cells[(int)DgvColumns.PathImage].Value.ToString();
                    dgvOrder.Rows[newRow].Cells[iiCol].Style.BackColor = Color.LightGreen;
                }
            }
            else
            {
                dgvOrder.Rows[newRow].Cells[iiCol].Style.BackColor = Color.LightCyan;

            }
            iiCol++;
        }
    }

    private void btClearOrder_Click(object sender, EventArgs e)
    {
        dgvOrder.Rows.Clear();
    }

    private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btDefaultString_Click(object sender, EventArgs e)
    {
        DataGridViewRow row = dgvEntity.CurrentRow;

        foreach (var entity in _listEntity)
        {
            if (entity.EntityName == row.Cells[(int)DgvColumns.UniqueName].Value.ToString())
            {
                row.Cells[(int)DgvColumns.StringToPrint].Value = entity.DisplayName;
                tbStringToPrint.Text = entity.DisplayName;
                break;
            }
        }
    }

    private void btDefaultImage_Click(object sender, EventArgs e)
    {
        DataGridViewRow row = dgvEntity.CurrentRow;

        row.Cells[(int)DgvColumns.PathImage].Value = null;

        //if (picImageToPrint.Image != null)
        //{
        //    picImageToPrint.Image.Dispose();
        //    picImageToPrint = null;
        //}
        picImageToPrint.Image = _defautlImage;
    }

    private void btDeleteRowOrder_Click(object sender, EventArgs e)
    {
        dgvOrder.Rows.Remove(dgvOrder.CurrentRow);
    }

    private void tbStringToPrint_TextChanged(object sender, EventArgs e)
    {
        DataGridViewRow row = dgvEntity.CurrentRow;

        foreach (var entity in _listEntity)
        {
            if (entity.EntityName == row.Cells[(int)DgvColumns.UniqueName].Value.ToString())
            {
                row.Cells[(int)DgvColumns.StringToPrint].Value = tbStringToPrint.Text;
                break;
            }
        }
    }
}