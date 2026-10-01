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
        btConnect = new Button();
        tbIpAddress = new TextBox();
        label1 = new Label();
        label2 = new Label();
        comboTemplates = new ComboBox();
        btStartWebHook = new Button();
        btResumeFeeder = new Button();
        tbInfoGhost = new TextBox();
        btStartProcess = new Button();
        cbNoLaser = new CheckBox();
        btStopProcess = new Button();
        tbStatus = new TextBox();
        dgvEntity = new DataGridView();
        Type = new DataGridViewTextBoxColumn();
        Name = new DataGridViewTextBoxColumn();
        UniqueEntityName = new DataGridViewTextBoxColumn();
        Value = new DataGridViewTextBoxColumn();
        ImageToPrint = new DataGridViewImageColumn();
        PathImage = new DataGridViewTextBoxColumn();
        panelString = new Panel();
        btDefaultString = new Button();
        tbStringToPrint = new TextBox();
        label3 = new Label();
        panelImage = new Panel();
        btDefaultImage = new Button();
        picImageToPrint = new PictureBox();
        label4 = new Label();
        btProcessCard = new Button();
        dgvOrder = new DataGridView();
        btAddToOrder = new Button();
        btProcessOrder = new Button();
        btClearOrder = new Button();
        btDeleteRowOrder = new Button();
        picLogo = new PictureBox();
        btImportOrder = new Button();
        btExportOrder = new Button();
        btUp = new Button();
        btDown = new Button();
        cbCreateBadgeTrack = new CheckBox();
        gbWebhook = new GroupBox();
        lbWebhookIp = new Label();
        CancelJob = new Button();
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
        btConnect.BackColor = Color.LightCoral;
        btConnect.Location = new Point(871, 2);
        btConnect.Margin = new Padding(5, 5, 5, 5);
        btConnect.Name = "btConnect";
        btConnect.Size = new Size(154, 56);
        btConnect.TabIndex = 1;
        btConnect.Text = "Connect";
        btConnect.UseVisualStyleBackColor = false;
        btConnect.Click += btConnect_Click;
        // 
        // tbIpAddress
        // 
        tbIpAddress.AcceptsReturn = true;
        tbIpAddress.Location = new Point(653, 13);
        tbIpAddress.Margin = new Padding(5, 5, 5, 5);
        tbIpAddress.Name = "tbIpAddress";
        tbIpAddress.Size = new Size(183, 39);
        tbIpAddress.TabIndex = 2;
        tbIpAddress.Text = "0.0.0.0";
        tbIpAddress.TextAlign = HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.Location = new Point(526, 13);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(124, 37);
        label1.TabIndex = 2;
        label1.Text = "IP Address";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new Point(556, 90);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(166, 37);
        label2.TabIndex = 3;
        label2.Text = "Templates List:";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // comboTemplates
        // 
        comboTemplates.DropDownStyle = ComboBoxStyle.DropDownList;
        comboTemplates.Enabled = false;
        comboTemplates.FormattingEnabled = true;
        comboTemplates.Location = new Point(715, 86);
        comboTemplates.Margin = new Padding(5, 5, 5, 5);
        comboTemplates.Name = "comboTemplates";
        comboTemplates.Size = new Size(308, 40);
        comboTemplates.TabIndex = 4;
        comboTemplates.SelectedIndexChanged += comboTemplates_SelectedIndexChanged;
        // 
        // btStartWebHook
        // 
        btStartWebHook.Location = new Point(10, 35);
        btStartWebHook.Margin = new Padding(5, 5, 5, 5);
        btStartWebHook.Name = "btStartWebHook";
        btStartWebHook.Size = new Size(188, 77);
        btStartWebHook.TabIndex = 5;
        btStartWebHook.Text = "Start Webhook Server";
        btStartWebHook.UseVisualStyleBackColor = true;
        btStartWebHook.Click += btStartWebHook_Click;
        // 
        // btResumeFeeder
        // 
        btResumeFeeder.Location = new Point(1053, 192);
        btResumeFeeder.Margin = new Padding(5, 5, 5, 5);
        btResumeFeeder.Name = "btResumeFeeder";
        btResumeFeeder.Size = new Size(239, 51);
        btResumeFeeder.TabIndex = 7;
        btResumeFeeder.Text = "Resume Feeder Empty";
        btResumeFeeder.UseVisualStyleBackColor = true;
        btResumeFeeder.Click += btResumeFeeder_Click;
        // 
        // tbInfoGhost
        // 
        tbInfoGhost.BorderStyle = BorderStyle.FixedSingle;
        tbInfoGhost.Location = new Point(44, 197);
        tbInfoGhost.Margin = new Padding(5, 5, 5, 5);
        tbInfoGhost.Name = "tbInfoGhost";
        tbInfoGhost.ReadOnly = true;
        tbInfoGhost.Size = new Size(980, 39);
        tbInfoGhost.TabIndex = 9;
        tbInfoGhost.TextAlign = HorizontalAlignment.Center;
        // 
        // btStartProcess
        // 
        btStartProcess.Enabled = false;
        btStartProcess.Location = new Point(44, 250);
        btStartProcess.Margin = new Padding(5, 5, 5, 5);
        btStartProcess.Name = "btStartProcess";
        btStartProcess.Size = new Size(154, 80);
        btStartProcess.TabIndex = 10;
        btStartProcess.Text = "Start Scheduler";
        btStartProcess.UseVisualStyleBackColor = true;
        btStartProcess.Click += btStartProcess_Click;
        // 
        // cbNoLaser
        // 
        cbNoLaser.Enabled = false;
        cbNoLaser.Location = new Point(231, 272);
        cbNoLaser.Margin = new Padding(5, 5, 5, 5);
        cbNoLaser.Name = "cbNoLaser";
        cbNoLaser.Size = new Size(211, 38);
        cbNoLaser.TabIndex = 11;
        cbNoLaser.Text = "Disable Laser Source";
        cbNoLaser.UseVisualStyleBackColor = true;
        // 
        // btStopProcess
        // 
        btStopProcess.Enabled = false;
        btStopProcess.Location = new Point(44, 349);
        btStopProcess.Margin = new Padding(5, 5, 5, 5);
        btStopProcess.Name = "btStopProcess";
        btStopProcess.Size = new Size(154, 80);
        btStopProcess.TabIndex = 12;
        btStopProcess.Text = "Stop Scheduler";
        btStopProcess.UseVisualStyleBackColor = true;
        btStopProcess.Click += btStopProcess_Click;
        // 
        // tbStatus
        // 
        tbStatus.BorderStyle = BorderStyle.FixedSingle;
        tbStatus.Location = new Point(44, 142);
        tbStatus.Margin = new Padding(5, 5, 5, 5);
        tbStatus.Name = "tbStatus";
        tbStatus.ReadOnly = true;
        tbStatus.Size = new Size(980, 39);
        tbStatus.TabIndex = 13;
        tbStatus.TextAlign = HorizontalAlignment.Center;
        // 
        // dgvEntity
        // 
        dgvEntity.AllowUserToAddRows = false;
        dgvEntity.AllowUserToResizeRows = false;
        dgvEntity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEntity.ColumnHeadersHeight = 38;
        dgvEntity.Columns.AddRange(new DataGridViewColumn[] { Type, Name, UniqueEntityName, Value, ImageToPrint, PathImage });
        dgvEntity.Enabled = false;
        dgvEntity.Location = new Point(483, 272);
        dgvEntity.Margin = new Padding(5, 5, 5, 5);
        dgvEntity.MultiSelect = false;
        dgvEntity.Name = "dgvEntity";
        dgvEntity.ReadOnly = true;
        dgvEntity.RowHeadersVisible = false;
        dgvEntity.RowHeadersWidth = 82;
        dgvEntity.Size = new Size(809, 494);
        dgvEntity.TabIndex = 14;
        dgvEntity.CellClick += dgvEntity_CellClick;
        // 
        // Type
        // 
        Type.FillWeight = 32F;
        Type.HeaderText = "Entity Type";
        Type.MinimumWidth = 10;
        Type.Name = "Type";
        Type.ReadOnly = true;
        Type.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // Name
        // 
        Name.HeaderText = "Entity Name";
        Name.MinimumWidth = 10;
        Name.Name = "Name";
        Name.ReadOnly = true;
        Name.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // UniqueEntityName
        // 
        UniqueEntityName.HeaderText = "Unique Entity Name";
        UniqueEntityName.MinimumWidth = 10;
        UniqueEntityName.Name = "UniqueEntityName";
        UniqueEntityName.ReadOnly = true;
        UniqueEntityName.SortMode = DataGridViewColumnSortMode.NotSortable;
        UniqueEntityName.Visible = false;
        // 
        // Value
        // 
        Value.FillWeight = 80F;
        Value.HeaderText = "Entity String Value";
        Value.MinimumWidth = 10;
        Value.Name = "Value";
        Value.ReadOnly = true;
        Value.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // ImageToPrint
        // 
        ImageToPrint.HeaderText = "Print Image";
        ImageToPrint.MinimumWidth = 10;
        ImageToPrint.Name = "ImageToPrint";
        ImageToPrint.ReadOnly = true;
        ImageToPrint.Visible = false;
        // 
        // PathImage
        // 
        PathImage.HeaderText = "Path Image";
        PathImage.MinimumWidth = 10;
        PathImage.Name = "PathImage";
        PathImage.ReadOnly = true;
        PathImage.SortMode = DataGridViewColumnSortMode.NotSortable;
        PathImage.Visible = false;
        // 
        // panelString
        // 
        panelString.BorderStyle = BorderStyle.FixedSingle;
        panelString.Controls.Add(btDefaultString);
        panelString.Controls.Add(tbStringToPrint);
        panelString.Controls.Add(label3);
        panelString.Location = new Point(44, 491);
        panelString.Margin = new Padding(5, 5, 5, 5);
        panelString.Name = "panelString";
        panelString.Size = new Size(397, 274);
        panelString.TabIndex = 15;
        panelString.Visible = false;
        // 
        // btDefaultString
        // 
        btDefaultString.Location = new Point(228, 6);
        btDefaultString.Margin = new Padding(5, 5, 5, 5);
        btDefaultString.Name = "btDefaultString";
        btDefaultString.Size = new Size(162, 82);
        btDefaultString.TabIndex = 18;
        btDefaultString.Text = "Set Default String";
        btDefaultString.UseVisualStyleBackColor = true;
        btDefaultString.Click += btDefaultString_Click;
        // 
        // tbStringToPrint
        // 
        tbStringToPrint.Location = new Point(20, 120);
        tbStringToPrint.Margin = new Padding(5, 5, 5, 5);
        tbStringToPrint.Name = "tbStringToPrint";
        tbStringToPrint.Size = new Size(357, 39);
        tbStringToPrint.TabIndex = 1;
        tbStringToPrint.TextChanged += tbStringToPrint_TextChanged;
        // 
        // label3
        // 
        label3.Location = new Point(42, 30);
        label3.Margin = new Padding(5, 0, 5, 0);
        label3.Name = "label3";
        label3.Size = new Size(162, 38);
        label3.TabIndex = 0;
        label3.Text = "String to Print";
        // 
        // panelImage
        // 
        panelImage.BorderStyle = BorderStyle.FixedSingle;
        panelImage.Controls.Add(btDefaultImage);
        panelImage.Controls.Add(picImageToPrint);
        panelImage.Controls.Add(label4);
        panelImage.Location = new Point(44, 491);
        panelImage.Margin = new Padding(5, 5, 5, 5);
        panelImage.Name = "panelImage";
        panelImage.Size = new Size(397, 274);
        panelImage.TabIndex = 2;
        panelImage.Visible = false;
        // 
        // btDefaultImage
        // 
        btDefaultImage.Location = new Point(228, 5);
        btDefaultImage.Margin = new Padding(5, 5, 5, 5);
        btDefaultImage.Name = "btDefaultImage";
        btDefaultImage.Size = new Size(162, 82);
        btDefaultImage.TabIndex = 17;
        btDefaultImage.Text = "Set Default Image";
        btDefaultImage.UseVisualStyleBackColor = true;
        btDefaultImage.Click += btDefaultImage_Click;
        // 
        // picImageToPrint
        // 
        picImageToPrint.BorderStyle = BorderStyle.FixedSingle;
        picImageToPrint.Image = (Image)resources.GetObject("picImageToPrint.Image");
        picImageToPrint.Location = new Point(88, 96);
        picImageToPrint.Margin = new Padding(5, 5, 5, 5);
        picImageToPrint.Name = "picImageToPrint";
        picImageToPrint.Size = new Size(231, 165);
        picImageToPrint.SizeMode = PictureBoxSizeMode.Zoom;
        picImageToPrint.TabIndex = 1;
        picImageToPrint.TabStop = false;
        picImageToPrint.Click += picImageToPrint_Click;
        // 
        // label4
        // 
        label4.Location = new Point(42, 30);
        label4.Margin = new Padding(5, 0, 5, 0);
        label4.Name = "label4";
        label4.Size = new Size(162, 38);
        label4.TabIndex = 0;
        label4.Text = "Image to Print";
        // 
        // btProcessCard
        // 
        btProcessCard.Enabled = false;
        btProcessCard.Location = new Point(273, 349);
        btProcessCard.Margin = new Padding(5, 5, 5, 5);
        btProcessCard.Name = "btProcessCard";
        btProcessCard.Size = new Size(154, 80);
        btProcessCard.TabIndex = 16;
        btProcessCard.Text = "Process Card";
        btProcessCard.UseVisualStyleBackColor = true;
        btProcessCard.Click += btProcessCard_Click;
        // 
        // dgvOrder
        // 
        dgvOrder.AllowUserToAddRows = false;
        dgvOrder.AllowUserToResizeRows = false;
        dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrder.Enabled = false;
        dgvOrder.Location = new Point(44, 883);
        dgvOrder.Margin = new Padding(5, 5, 5, 5);
        dgvOrder.MultiSelect = false;
        dgvOrder.Name = "dgvOrder";
        dgvOrder.ReadOnly = true;
        dgvOrder.RowHeadersWidth = 24;
        dgvOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        dgvOrder.Size = new Size(1248, 387);
        dgvOrder.TabIndex = 17;
        dgvOrder.CellContentClick += dgvOrder_CellClick;
        // 
        // btAddToOrder
        // 
        btAddToOrder.Enabled = false;
        btAddToOrder.Location = new Point(682, 790);
        btAddToOrder.Margin = new Padding(5, 5, 5, 5);
        btAddToOrder.Name = "btAddToOrder";
        btAddToOrder.Size = new Size(154, 80);
        btAddToOrder.TabIndex = 18;
        btAddToOrder.Text = "Add to Orders Table";
        btAddToOrder.UseVisualStyleBackColor = true;
        btAddToOrder.Click += btAddToOrder_Click;
        // 
        // btProcessOrder
        // 
        btProcessOrder.Enabled = false;
        btProcessOrder.Location = new Point(44, 790);
        btProcessOrder.Margin = new Padding(5, 5, 5, 5);
        btProcessOrder.Name = "btProcessOrder";
        btProcessOrder.Size = new Size(154, 80);
        btProcessOrder.TabIndex = 19;
        btProcessOrder.Text = "Process Orders";
        btProcessOrder.UseVisualStyleBackColor = true;
        btProcessOrder.Click += btProcessOrder_Click;
        // 
        // btClearOrder
        // 
        btClearOrder.Enabled = false;
        btClearOrder.Location = new Point(257, 790);
        btClearOrder.Margin = new Padding(5, 5, 5, 5);
        btClearOrder.Name = "btClearOrder";
        btClearOrder.Size = new Size(154, 80);
        btClearOrder.TabIndex = 20;
        btClearOrder.Text = "Clear Orders Table";
        btClearOrder.UseVisualStyleBackColor = true;
        btClearOrder.Click += btClearOrder_Click;
        // 
        // btDeleteRowOrder
        // 
        btDeleteRowOrder.Enabled = false;
        btDeleteRowOrder.Location = new Point(470, 790);
        btDeleteRowOrder.Margin = new Padding(5, 5, 5, 5);
        btDeleteRowOrder.Name = "btDeleteRowOrder";
        btDeleteRowOrder.Size = new Size(154, 80);
        btDeleteRowOrder.TabIndex = 21;
        btDeleteRowOrder.Text = "Delete Row Order";
        btDeleteRowOrder.UseVisualStyleBackColor = true;
        btDeleteRowOrder.Click += btDeleteRowOrder_Click;
        // 
        // picLogo
        // 
        picLogo.Image = (Image)resources.GetObject("picLogo.Image");
        picLogo.Location = new Point(44, 13);
        picLogo.Margin = new Padding(5, 5, 5, 5);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(224, 114);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 22;
        picLogo.TabStop = false;
        // 
        // btImportOrder
        // 
        btImportOrder.Enabled = false;
        btImportOrder.Location = new Point(964, 790);
        btImportOrder.Margin = new Padding(5, 5, 5, 5);
        btImportOrder.Name = "btImportOrder";
        btImportOrder.Size = new Size(154, 80);
        btImportOrder.TabIndex = 24;
        btImportOrder.Text = "Import Orders List";
        btImportOrder.UseVisualStyleBackColor = true;
        btImportOrder.Click += btImportOrder_Click;
        // 
        // btExportOrder
        // 
        btExportOrder.Enabled = false;
        btExportOrder.Location = new Point(1138, 790);
        btExportOrder.Margin = new Padding(5, 5, 5, 5);
        btExportOrder.Name = "btExportOrder";
        btExportOrder.Size = new Size(154, 80);
        btExportOrder.TabIndex = 23;
        btExportOrder.Text = "Export Orders List";
        btExportOrder.UseVisualStyleBackColor = true;
        btExportOrder.Click += btExportOrder_Click;
        // 
        // btUp
        // 
        btUp.Image = (Image)resources.GetObject("btUp.Image");
        btUp.Location = new Point(2, 1000);
        btUp.Margin = new Padding(5, 5, 5, 5);
        btUp.Name = "btUp";
        btUp.Size = new Size(39, 37);
        btUp.TabIndex = 25;
        btUp.UseVisualStyleBackColor = true;
        btUp.Click += btUp_Click;
        // 
        // btDown
        // 
        btDown.Image = (Image)resources.GetObject("btDown.Image");
        btDown.Location = new Point(2, 1115);
        btDown.Margin = new Padding(5, 5, 5, 5);
        btDown.Name = "btDown";
        btDown.Size = new Size(39, 37);
        btDown.TabIndex = 26;
        btDown.UseVisualStyleBackColor = true;
        btDown.Click += btDown_Click;
        // 
        // cbCreateBadgeTrack
        // 
        cbCreateBadgeTrack.Checked = true;
        cbCreateBadgeTrack.CheckState = CheckState.Checked;
        cbCreateBadgeTrack.Location = new Point(50, 430);
        cbCreateBadgeTrack.Margin = new Padding(5, 5, 5, 5);
        cbCreateBadgeTrack.Name = "cbCreateBadgeTrack";
        cbCreateBadgeTrack.Size = new Size(302, 38);
        cbCreateBadgeTrack.TabIndex = 27;
        cbCreateBadgeTrack.Text = "Create Random Badge Tracks";
        cbCreateBadgeTrack.UseVisualStyleBackColor = true;
        // 
        // gbWebhook
        // 
        gbWebhook.Controls.Add(lbWebhookIp);
        gbWebhook.Controls.Add(btStartWebHook);
        gbWebhook.Location = new Point(1084, 13);
        gbWebhook.Margin = new Padding(5, 5, 5, 5);
        gbWebhook.Name = "gbWebhook";
        gbWebhook.Padding = new Padding(5, 5, 5, 5);
        gbWebhook.Size = new Size(208, 166);
        gbWebhook.TabIndex = 28;
        gbWebhook.TabStop = false;
        gbWebhook.Text = "Webhook";
        // 
        // lbWebhookIp
        // 
        lbWebhookIp.Location = new Point(0, 117);
        lbWebhookIp.Margin = new Padding(5, 0, 5, 0);
        lbWebhookIp.Name = "lbWebhookIp";
        lbWebhookIp.Size = new Size(208, 37);
        lbWebhookIp.TabIndex = 6;
        lbWebhookIp.Text = "0.0.0.0";
        lbWebhookIp.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // CancelJob
        // 
        CancelJob.Location = new Point(385, 19);
        CancelJob.Margin = new Padding(5, 5, 5, 5);
        CancelJob.Name = "CancelJob";
        CancelJob.Size = new Size(127, 86);
        CancelJob.TabIndex = 29;
        CancelJob.Text = "Cancel Job";
        CancelJob.UseVisualStyleBackColor = true;
        CancelJob.Click += CancelJob_Click;
        // 
        // FormMain
        // 
        AcceptButton = btConnect;
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1337, 1290);
        Controls.Add(CancelJob);
        Controls.Add(gbWebhook);
        Controls.Add(cbCreateBadgeTrack);
        Controls.Add(panelImage);
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
        Controls.Add(panelString);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5, 6, 5, 6);
        StartPosition = FormStartPosition.CenterScreen;
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
    private System.Windows.Forms.GroupBox gbWebhook;
    private System.Windows.Forms.Label lbWebhookIp;
}