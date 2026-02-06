namespace DemoApplication;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        btConnect = new System.Windows.Forms.Button();
        tbIpAddress = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        comboTemplates = new System.Windows.Forms.ComboBox();
        btStartWebHook = new System.Windows.Forms.Button();
        btResumeFeeder = new System.Windows.Forms.Button();
        tbInfoGhost = new System.Windows.Forms.TextBox();
        btStartProcess = new System.Windows.Forms.Button();
        cbNoLaser = new System.Windows.Forms.CheckBox();
        btStopProcess = new System.Windows.Forms.Button();
        tbStatus = new System.Windows.Forms.TextBox();
        dgvEntity = new System.Windows.Forms.DataGridView();
        Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        UniqueEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ImageToPrint = new System.Windows.Forms.DataGridViewImageColumn();
        PathImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
        panelString = new System.Windows.Forms.Panel();
        btDefaultString = new System.Windows.Forms.Button();
        tbStringToPrint = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        panelImage = new System.Windows.Forms.Panel();
        btDefaultImage = new System.Windows.Forms.Button();
        picImageToPrint = new System.Windows.Forms.PictureBox();
        label4 = new System.Windows.Forms.Label();
        btProcessCard = new System.Windows.Forms.Button();
        dgvOrder = new System.Windows.Forms.DataGridView();
        btAddToOrder = new System.Windows.Forms.Button();
        btProcessOrder = new System.Windows.Forms.Button();
        btClearOrder = new System.Windows.Forms.Button();
        btDeleteRowOrder = new System.Windows.Forms.Button();
        picLogo = new System.Windows.Forms.PictureBox();
        btImportOrder = new System.Windows.Forms.Button();
        btExportOrder = new System.Windows.Forms.Button();
        btUp = new System.Windows.Forms.Button();
        btDown = new System.Windows.Forms.Button();
        cbCreateBadgeTrack = new System.Windows.Forms.CheckBox();
        gbWebhook = new System.Windows.Forms.GroupBox();
        lbWebhookIp = new System.Windows.Forms.Label();
        CancelJob = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvEntity).BeginInit();
        panelString.SuspendLayout();
        panelImage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picImageToPrint).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        gbWebhook.SuspendLayout();
        SuspendLayout();
        // 
        // btConnect
        // 
        btConnect.BackColor = System.Drawing.Color.LightCoral;
        btConnect.Location = new System.Drawing.Point(536, 1);
        btConnect.Name = "btConnect";
        btConnect.Size = new System.Drawing.Size(95, 35);
        btConnect.TabIndex = 0;
        btConnect.Text = "Connect";
        btConnect.UseVisualStyleBackColor = false;
        btConnect.Click += btConnect_Click;
        // 
        // tbIpAddress
        // 
        tbIpAddress.AcceptsReturn = true;
        tbIpAddress.Location = new System.Drawing.Point(402, 8);
        tbIpAddress.Name = "tbIpAddress";
        tbIpAddress.Size = new System.Drawing.Size(114, 27);
        tbIpAddress.TabIndex = 1;
        tbIpAddress.Text = "0.0.0.0";
        tbIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(324, 8);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(76, 23);
        label1.TabIndex = 2;
        label1.Text = "IP Address";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(342, 56);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(102, 23);
        label2.TabIndex = 3;
        label2.Text = "Templates List:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // comboTemplates
        // 
        comboTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboTemplates.Enabled = false;
        comboTemplates.FormattingEnabled = true;
        comboTemplates.Location = new System.Drawing.Point(440, 57);
        comboTemplates.Name = "comboTemplates";
        comboTemplates.Size = new System.Drawing.Size(121, 28);
        comboTemplates.TabIndex = 4;
        comboTemplates.SelectedIndexChanged += comboTemplates_SelectedIndexChanged;
        // 
        // btStartWebHook
        // 
        btStartWebHook.Location = new System.Drawing.Point(16, 22);
        btStartWebHook.Name = "btStartWebHook";
        btStartWebHook.Size = new System.Drawing.Size(95, 40);
        btStartWebHook.TabIndex = 5;
        btStartWebHook.Text = "Start Webhook Server";
        btStartWebHook.UseVisualStyleBackColor = true;
        btStartWebHook.Click += btStartWebHook_Click;
        // 
        // btResumeFeeder
        // 
        btResumeFeeder.Location = new System.Drawing.Point(648, 123);
        btResumeFeeder.Name = "btResumeFeeder";
        btResumeFeeder.Size = new System.Drawing.Size(147, 23);
        btResumeFeeder.TabIndex = 7;
        btResumeFeeder.Text = "Resume Feeder Empty";
        btResumeFeeder.UseVisualStyleBackColor = true;
        btResumeFeeder.Click += btResumeFeeder_Click;
        // 
        // tbInfoGhost
        // 
        tbInfoGhost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        tbInfoGhost.Location = new System.Drawing.Point(27, 123);
        tbInfoGhost.Name = "tbInfoGhost";
        tbInfoGhost.ReadOnly = true;
        tbInfoGhost.Size = new System.Drawing.Size(604, 27);
        tbInfoGhost.TabIndex = 9;
        tbInfoGhost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // btStartProcess
        // 
        btStartProcess.Enabled = false;
        btStartProcess.Location = new System.Drawing.Point(27, 170);
        btStartProcess.Name = "btStartProcess";
        btStartProcess.Size = new System.Drawing.Size(95, 40);
        btStartProcess.TabIndex = 10;
        btStartProcess.Text = "Start Scheduler";
        btStartProcess.UseVisualStyleBackColor = true;
        btStartProcess.Click += btStartProcess_Click;
        // 
        // cbNoLaser
        // 
        cbNoLaser.Checked = true;
        cbNoLaser.CheckState = System.Windows.Forms.CheckState.Checked;
        cbNoLaser.Enabled = false;
        cbNoLaser.Location = new System.Drawing.Point(141, 179);
        cbNoLaser.Name = "cbNoLaser";
        cbNoLaser.Size = new System.Drawing.Size(134, 24);
        cbNoLaser.TabIndex = 11;
        cbNoLaser.Text = "Disable Laser Source";
        cbNoLaser.UseVisualStyleBackColor = true;
        // 
        // btStopProcess
        // 
        btStopProcess.Enabled = false;
        btStopProcess.Location = new System.Drawing.Point(27, 220);
        btStopProcess.Name = "btStopProcess";
        btStopProcess.Size = new System.Drawing.Size(95, 40);
        btStopProcess.TabIndex = 12;
        btStopProcess.Text = "Stop Scheduler";
        btStopProcess.UseVisualStyleBackColor = true;
        btStopProcess.Click += btStopProcess_Click;
        // 
        // tbStatus
        // 
        tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        tbStatus.Location = new System.Drawing.Point(27, 89);
        tbStatus.Name = "tbStatus";
        tbStatus.ReadOnly = true;
        tbStatus.Size = new System.Drawing.Size(604, 27);
        tbStatus.TabIndex = 13;
        tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // dgvEntity
        // 
        dgvEntity.AllowUserToAddRows = false;
        dgvEntity.AllowUserToResizeRows = false;
        dgvEntity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Type, Name, UniqueEntityName, Value, ImageToPrint, PathImage });
        dgvEntity.Enabled = false;
        dgvEntity.Location = new System.Drawing.Point(297, 170);
        dgvEntity.MultiSelect = false;
        dgvEntity.Name = "dgvEntity";
        dgvEntity.ReadOnly = true;
        dgvEntity.RowHeadersVisible = false;
        dgvEntity.Size = new System.Drawing.Size(498, 309);
        dgvEntity.TabIndex = 14;
        dgvEntity.CellClick += dgvEntity_CellClick;
        // 
        // Type
        // 
        Type.FillWeight = 32F;
        Type.HeaderText = "Entity Type";
        Type.Name = "Type";
        Type.ReadOnly = true;
        Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        Type.Width = 75;
        // 
        // Name
        // 
        Name.HeaderText = "Entity Name";
        Name.Name = "Name";
        Name.ReadOnly = true;
        Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        Name.Width = 233;
        // 
        // UniqueEntityName
        // 
        UniqueEntityName.HeaderText = "Unique Entity Name";
        UniqueEntityName.Name = "UniqueEntityName";
        UniqueEntityName.ReadOnly = true;
        UniqueEntityName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        UniqueEntityName.Visible = false;
        UniqueEntityName.Width = 100;
        // 
        // Value
        // 
        Value.FillWeight = 80F;
        Value.HeaderText = "Entity String Value";
        Value.Name = "Value";
        Value.ReadOnly = true;
        Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        Value.Width = 187;
        // 
        // ImageToPrint
        // 
        ImageToPrint.HeaderText = "Print Image";
        ImageToPrint.Name = "ImageToPrint";
        ImageToPrint.ReadOnly = true;
        ImageToPrint.Visible = false;
        ImageToPrint.Width = 100;
        // 
        // PathImage
        // 
        PathImage.HeaderText = "Path Image";
        PathImage.Name = "PathImage";
        PathImage.ReadOnly = true;
        PathImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        PathImage.Visible = false;
        PathImage.Width = 100;
        // 
        // panelString
        // 
        panelString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelString.Controls.Add(btDefaultString);
        panelString.Controls.Add(tbStringToPrint);
        panelString.Controls.Add(label3);
        panelString.Location = new System.Drawing.Point(27, 307);
        panelString.Name = "panelString";
        panelString.Size = new System.Drawing.Size(245, 172);
        panelString.TabIndex = 15;
        panelString.Visible = false;
        // 
        // btDefaultString
        // 
        btDefaultString.Location = new System.Drawing.Point(165, 5);
        btDefaultString.Name = "btDefaultString";
        btDefaultString.Size = new System.Drawing.Size(75, 38);
        btDefaultString.TabIndex = 18;
        btDefaultString.Text = "Set Default String";
        btDefaultString.UseVisualStyleBackColor = true;
        btDefaultString.Click += btDefaultString_Click;
        // 
        // tbStringToPrint
        // 
        tbStringToPrint.Location = new System.Drawing.Point(12, 75);
        tbStringToPrint.Name = "tbStringToPrint";
        tbStringToPrint.Size = new System.Drawing.Size(221, 27);
        tbStringToPrint.TabIndex = 1;
        tbStringToPrint.TextChanged += tbStringToPrint_TextChanged;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(26, 19);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 24);
        label3.TabIndex = 0;
        label3.Text = "String to Print";
        // 
        // panelImage
        // 
        panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelImage.Controls.Add(btDefaultImage);
        panelImage.Controls.Add(picImageToPrint);
        panelImage.Controls.Add(label4);
        panelImage.Location = new System.Drawing.Point(27, 307);
        panelImage.Name = "panelImage";
        panelImage.Size = new System.Drawing.Size(245, 172);
        panelImage.TabIndex = 2;
        panelImage.Visible = false;
        // 
        // btDefaultImage
        // 
        btDefaultImage.Location = new System.Drawing.Point(164, 5);
        btDefaultImage.Name = "btDefaultImage";
        btDefaultImage.Size = new System.Drawing.Size(75, 38);
        btDefaultImage.TabIndex = 17;
        btDefaultImage.Text = "Set Default Image";
        btDefaultImage.UseVisualStyleBackColor = true;
        btDefaultImage.Click += btDefaultImage_Click;
        // 
        // picImageToPrint
        // 
        picImageToPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        picImageToPrint.Image = ((System.Drawing.Image)resources.GetObject("picImageToPrint.Image"));
        picImageToPrint.Location = new System.Drawing.Point(54, 56);
        picImageToPrint.Name = "picImageToPrint";
        picImageToPrint.Size = new System.Drawing.Size(143, 104);
        picImageToPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picImageToPrint.TabIndex = 1;
        picImageToPrint.TabStop = false;
        picImageToPrint.Click += picImageToPrint_Click;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(26, 19);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 24);
        label4.TabIndex = 0;
        label4.Text = "Image to Print";
        // 
        // btProcessCard
        // 
        btProcessCard.Enabled = false;
        btProcessCard.Location = new System.Drawing.Point(167, 220);
        btProcessCard.Name = "btProcessCard";
        btProcessCard.Size = new System.Drawing.Size(95, 40);
        btProcessCard.TabIndex = 16;
        btProcessCard.Text = "Process Card";
        btProcessCard.UseVisualStyleBackColor = true;
        btProcessCard.Click += btProcessCard_Click;
        // 
        // dgvOrder
        // 
        dgvOrder.AllowUserToAddRows = false;
        dgvOrder.AllowUserToResizeRows = false;
        dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrder.Enabled = false;
        dgvOrder.Location = new System.Drawing.Point(27, 552);
        dgvOrder.MultiSelect = false;
        dgvOrder.Name = "dgvOrder";
        dgvOrder.ReadOnly = true;
        dgvOrder.RowHeadersWidth = 24;
        dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        dgvOrder.Size = new System.Drawing.Size(768, 242);
        dgvOrder.TabIndex = 17;
        dgvOrder.CellContentClick += dgvOrder_CellClick;
        // 
        // btAddToOrder
        // 
        btAddToOrder.Enabled = false;
        btAddToOrder.Location = new System.Drawing.Point(420, 496);
        btAddToOrder.Name = "btAddToOrder";
        btAddToOrder.Size = new System.Drawing.Size(95, 40);
        btAddToOrder.TabIndex = 18;
        btAddToOrder.Text = "Add to Orders Table";
        btAddToOrder.UseVisualStyleBackColor = true;
        btAddToOrder.Click += btAddToOrder_Click;
        // 
        // btProcessOrder
        // 
        btProcessOrder.Enabled = false;
        btProcessOrder.Location = new System.Drawing.Point(27, 496);
        btProcessOrder.Name = "btProcessOrder";
        btProcessOrder.Size = new System.Drawing.Size(95, 40);
        btProcessOrder.TabIndex = 19;
        btProcessOrder.Text = "Process Orders";
        btProcessOrder.UseVisualStyleBackColor = true;
        btProcessOrder.Click += btProcessOrder_Click;
        // 
        // btClearOrder
        // 
        btClearOrder.Enabled = false;
        btClearOrder.Location = new System.Drawing.Point(158, 496);
        btClearOrder.Name = "btClearOrder";
        btClearOrder.Size = new System.Drawing.Size(95, 40);
        btClearOrder.TabIndex = 20;
        btClearOrder.Text = "Clear Orders Table";
        btClearOrder.UseVisualStyleBackColor = true;
        btClearOrder.Click += btClearOrder_Click;
        // 
        // btDeleteRowOrder
        // 
        btDeleteRowOrder.Enabled = false;
        btDeleteRowOrder.Location = new System.Drawing.Point(289, 496);
        btDeleteRowOrder.Name = "btDeleteRowOrder";
        btDeleteRowOrder.Size = new System.Drawing.Size(95, 40);
        btDeleteRowOrder.TabIndex = 21;
        btDeleteRowOrder.Text = "Delete Row Order";
        btDeleteRowOrder.UseVisualStyleBackColor = true;
        btDeleteRowOrder.Click += btDeleteRowOrder_Click;
        // 
        // picLogo
        // 
        picLogo.Image = ((System.Drawing.Image)resources.GetObject("picLogo.Image"));
        picLogo.Location = new System.Drawing.Point(27, 8);
        picLogo.Name = "picLogo";
        picLogo.Size = new System.Drawing.Size(138, 71);
        picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 22;
        picLogo.TabStop = false;
        // 
        // btImportOrder
        // 
        btImportOrder.Enabled = false;
        btImportOrder.Location = new System.Drawing.Point(593, 496);
        btImportOrder.Name = "btImportOrder";
        btImportOrder.Size = new System.Drawing.Size(95, 40);
        btImportOrder.TabIndex = 24;
        btImportOrder.Text = "Import Orders List";
        btImportOrder.UseVisualStyleBackColor = true;
        btImportOrder.Click += btImportOrder_Click;
        // 
        // btExportOrder
        // 
        btExportOrder.Enabled = false;
        btExportOrder.Location = new System.Drawing.Point(700, 496);
        btExportOrder.Name = "btExportOrder";
        btExportOrder.Size = new System.Drawing.Size(95, 40);
        btExportOrder.TabIndex = 23;
        btExportOrder.Text = "Export Orders List";
        btExportOrder.UseVisualStyleBackColor = true;
        btExportOrder.Click += btExportOrder_Click;
        // 
        // btUp
        // 
        btUp.Image = ((System.Drawing.Image)resources.GetObject("btUp.Image"));
        btUp.Location = new System.Drawing.Point(1, 625);
        btUp.Name = "btUp";
        btUp.Size = new System.Drawing.Size(24, 23);
        btUp.TabIndex = 25;
        btUp.UseVisualStyleBackColor = true;
        btUp.Click += btUp_Click;
        // 
        // btDown
        // 
        btDown.Image = ((System.Drawing.Image)resources.GetObject("btDown.Image"));
        btDown.Location = new System.Drawing.Point(1, 697);
        btDown.Name = "btDown";
        btDown.Size = new System.Drawing.Size(24, 23);
        btDown.TabIndex = 26;
        btDown.UseVisualStyleBackColor = true;
        btDown.Click += btDown_Click;
        // 
        // cbCreateBadgeTrack
        // 
        cbCreateBadgeTrack.Checked = true;
        cbCreateBadgeTrack.CheckState = System.Windows.Forms.CheckState.Checked;
        cbCreateBadgeTrack.Location = new System.Drawing.Point(31, 269);
        cbCreateBadgeTrack.Name = "cbCreateBadgeTrack";
        cbCreateBadgeTrack.Size = new System.Drawing.Size(186, 24);
        cbCreateBadgeTrack.TabIndex = 27;
        cbCreateBadgeTrack.Text = "Create Random Badge Tracks";
        cbCreateBadgeTrack.UseVisualStyleBackColor = true;
        // 
        // gbWebhook
        // 
        gbWebhook.Controls.Add(lbWebhookIp);
        gbWebhook.Controls.Add(btStartWebHook);
        gbWebhook.Location = new System.Drawing.Point(667, 8);
        gbWebhook.Name = "gbWebhook";
        gbWebhook.Size = new System.Drawing.Size(128, 104);
        gbWebhook.TabIndex = 28;
        gbWebhook.TabStop = false;
        gbWebhook.Text = "Webhook";
        // 
        // lbWebhookIp
        // 
        lbWebhookIp.Location = new System.Drawing.Point(0, 74);
        lbWebhookIp.Name = "lbWebhookIp";
        lbWebhookIp.Size = new System.Drawing.Size(128, 20);
        lbWebhookIp.TabIndex = 6;
        lbWebhookIp.Text = "0.0.0.0";
        lbWebhookIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // CancelJob
        // 
        CancelJob.Location = new System.Drawing.Point(237, 12);
        CancelJob.Name = "CancelJob";
        CancelJob.Size = new System.Drawing.Size(78, 54);
        CancelJob.TabIndex = 29;
        CancelJob.Text = "Cancel Job";
        CancelJob.UseVisualStyleBackColor = true;
        CancelJob.Click += CancelJob_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(823, 806);
        Controls.Add(CancelJob);
        Controls.Add(gbWebhook);
        Controls.Add(cbCreateBadgeTrack);
        Controls.Add(btDown);
        Controls.Add(btUp);
        Controls.Add(btImportOrder);
        Controls.Add(btExportOrder);
        Controls.Add(picLogo);
        Controls.Add(btDeleteRowOrder);
        Controls.Add(btClearOrder);
        Controls.Add(btProcessOrder);
        Controls.Add(btAddToOrder);
        Controls.Add(dgvOrder);
        Controls.Add(btProcessCard);
        Controls.Add(dgvEntity);
        Controls.Add(tbStatus);
        Controls.Add(btStopProcess);
        Controls.Add(cbNoLaser);
        Controls.Add(btStartProcess);
        Controls.Add(tbInfoGhost);
        Controls.Add(btResumeFeeder);
        Controls.Add(comboTemplates);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(tbIpAddress);
        Controls.Add(btConnect);
        Controls.Add(panelImage);
        Controls.Add(panelString);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "IXLA Demo Application";
        Load += FormMain_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEntity).EndInit();
        panelString.ResumeLayout(false);
        panelString.PerformLayout();
        panelImage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picImageToPrint).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        gbWebhook.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button CancelJob;

    private System.Windows.Forms.PictureBox picLogo;

    private System.Windows.Forms.Button btProcessCard;

    private System.Windows.Forms.TextBox tbStringToPrint;
    private System.Windows.Forms.Panel panelImage;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox picImageToPrint;

    private System.Windows.Forms.Panel panelString;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.DataGridView dgvEntity;

    private System.Windows.Forms.TextBox tbStatus;

    private System.Windows.Forms.Button btStopProcess;

    private System.Windows.Forms.CheckBox cbNoLaser;

    private System.Windows.Forms.Button btStartProcess;

    private System.Windows.Forms.Button btResumeFeeder;

    private System.Windows.Forms.Button btStartWebHook;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboTemplates;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btConnect;
    private System.Windows.Forms.TextBox tbIpAddress;

    #endregion

    private System.Windows.Forms.TextBox tbInfoGhost;
    private System.Windows.Forms.DataGridView dgvOrder;
    private System.Windows.Forms.Button btAddToOrder;
    private System.Windows.Forms.Button btProcessOrder;
    private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    private System.Windows.Forms.DataGridViewTextBoxColumn UniqueEntityName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    private DataGridViewImageColumn ImageToPrint;
    private System.Windows.Forms.DataGridViewTextBoxColumn PathImage;
    private System.Windows.Forms.Button btClearOrder;
    private System.Windows.Forms.Button btDefaultImage;
    private System.Windows.Forms.Button btDefaultString;
    private System.Windows.Forms.Button btDeleteRowOrder;
    private System.Windows.Forms.Button btImportOrder;
    private System.Windows.Forms.Button btExportOrder;
    private System.Windows.Forms.Button btUp;
    private System.Windows.Forms.Button btDown;
    private System.Windows.Forms.CheckBox cbCreateBadgeTrack;
    private GroupBox gbWebhook;
    private System.Windows.Forms.Label lbWebhookIp;
}