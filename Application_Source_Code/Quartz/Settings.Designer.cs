namespace Quartz
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label admin_NameLabel;
            System.Windows.Forms.Label admin_PasswordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTb = new System.Windows.Forms.TabPage();
            this.showNotifIconCb = new System.Windows.Forms.CheckBox();
            this.close = new System.Windows.Forms.Button();
            this.applyGen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.themeSelect = new System.Windows.Forms.ComboBox();
            this.themeLbl = new System.Windows.Forms.Label();
            this.showInTaskbarCb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publishBackupLoc = new System.Windows.Forms.TextBox();
            this.defPublishBtn = new System.Windows.Forms.Button();
            this.clientBackupLoc = new System.Windows.Forms.TextBox();
            this.clientBackupsCb = new System.Windows.Forms.CheckBox();
            this.defClientBtn = new System.Windows.Forms.Button();
            this.startWithWindowsCb = new System.Windows.Forms.CheckBox();
            this.directoryTb = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.BackupGb = new System.Windows.Forms.GroupBox();
            this.BackupDirTxt = new System.Windows.Forms.TextBox();
            this.BackupBkBtn = new System.Windows.Forms.Button();
            this.close2 = new System.Windows.Forms.Button();
            this.applyDir = new System.Windows.Forms.Button();
            this.PublishGb = new System.Windows.Forms.GroupBox();
            this.PublishDirTxt = new System.Windows.Forms.TextBox();
            this.PublishBkBrowse = new System.Windows.Forms.Button();
            this.ClientGb = new System.Windows.Forms.GroupBox();
            this.ClientDirTxt = new System.Windows.Forms.TextBox();
            this.ClientBkBrowse = new System.Windows.Forms.Button();
            this.programTb = new System.Windows.Forms.TabPage();
            this.close3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.adminTb = new System.Windows.Forms.TabPage();
            this.close4 = new System.Windows.Forms.Button();
            this.adminIDLabel = new System.Windows.Forms.Label();
            this.adminIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.adminIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartzDataDataSet1 = new Quartz.QuartzDataDataSet1();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.adminIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adminIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDTextBox = new System.Windows.Forms.TextBox();
            this.admin_NameTextBox = new System.Windows.Forms.TextBox();
            this.admin_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.progDefLb = new System.Windows.Forms.ListBox();
            this.closeDefault = new System.Windows.Forms.Button();
            this.loadDefaultsBtn = new System.Windows.Forms.Button();
            this.adminIDTableAdapter = new Quartz.QuartzDataDataSet1TableAdapters.AdminIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSet1TableAdapters.TableAdapterManager();
            this.BackupLocation = new System.Windows.Forms.FolderBrowserDialog();
            admin_NameLabel = new System.Windows.Forms.Label();
            admin_PasswordLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.generalTb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.directoryTb.SuspendLayout();
            this.BackupGb.SuspendLayout();
            this.PublishGb.SuspendLayout();
            this.ClientGb.SuspendLayout();
            this.programTb.SuspendLayout();
            this.adminTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIDBindingNavigator)).BeginInit();
            this.adminIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminIDDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_NameLabel
            // 
            admin_NameLabel.AutoSize = true;
            admin_NameLabel.Location = new System.Drawing.Point(18, 41);
            admin_NameLabel.Name = "admin_NameLabel";
            admin_NameLabel.Size = new System.Drawing.Size(70, 13);
            admin_NameLabel.TabIndex = 2;
            admin_NameLabel.Text = "Admin Name:";
            // 
            // admin_PasswordLabel
            // 
            admin_PasswordLabel.AutoSize = true;
            admin_PasswordLabel.Location = new System.Drawing.Point(18, 67);
            admin_PasswordLabel.Name = "admin_PasswordLabel";
            admin_PasswordLabel.Size = new System.Drawing.Size(88, 13);
            admin_PasswordLabel.TabIndex = 4;
            admin_PasswordLabel.Text = "Admin Password:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTb);
            this.tabControl.Controls.Add(this.directoryTb);
            this.tabControl.Controls.Add(this.programTb);
            this.tabControl.Controls.Add(this.adminTb);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(-3, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(264, 343);
            this.tabControl.TabIndex = 8;
            // 
            // generalTb
            // 
            this.generalTb.BackColor = System.Drawing.SystemColors.Control;
            this.generalTb.Controls.Add(this.showNotifIconCb);
            this.generalTb.Controls.Add(this.close);
            this.generalTb.Controls.Add(this.applyGen);
            this.generalTb.Controls.Add(this.groupBox2);
            this.generalTb.Controls.Add(this.showInTaskbarCb);
            this.generalTb.Controls.Add(this.groupBox1);
            this.generalTb.Controls.Add(this.startWithWindowsCb);
            this.generalTb.Location = new System.Drawing.Point(4, 22);
            this.generalTb.Name = "generalTb";
            this.generalTb.Padding = new System.Windows.Forms.Padding(3);
            this.generalTb.Size = new System.Drawing.Size(256, 317);
            this.generalTb.TabIndex = 2;
            this.generalTb.Text = "General";
            // 
            // showNotifIconCb
            // 
            this.showNotifIconCb.AutoSize = true;
            this.showNotifIconCb.Location = new System.Drawing.Point(17, 206);
            this.showNotifIconCb.Name = "showNotifIconCb";
            this.showNotifIconCb.Size = new System.Drawing.Size(167, 17);
            this.showNotifIconCb.TabIndex = 15;
            this.showNotifIconCb.Text = "Show Quartz Notification Icon";
            this.showNotifIconCb.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(165, 284);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 14;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // applyGen
            // 
            this.applyGen.Location = new System.Drawing.Point(84, 284);
            this.applyGen.Name = "applyGen";
            this.applyGen.Size = new System.Drawing.Size(75, 23);
            this.applyGen.TabIndex = 13;
            this.applyGen.Text = "Apply";
            this.applyGen.UseVisualStyleBackColor = true;
            this.applyGen.Click += new System.EventHandler(this.applyGen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.themeSelect);
            this.groupBox2.Controls.Add(this.themeLbl);
            this.groupBox2.Location = new System.Drawing.Point(11, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theme Selection";
            // 
            // themeSelect
            // 
            this.themeSelect.FormattingEnabled = true;
            this.themeSelect.Items.AddRange(new object[] {
            "Default"});
            this.themeSelect.Location = new System.Drawing.Point(58, 18);
            this.themeSelect.Name = "themeSelect";
            this.themeSelect.Size = new System.Drawing.Size(121, 21);
            this.themeSelect.TabIndex = 1;
            this.themeSelect.Text = "Default";
            // 
            // themeLbl
            // 
            this.themeLbl.AutoSize = true;
            this.themeLbl.Location = new System.Drawing.Point(6, 21);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(46, 13);
            this.themeLbl.TabIndex = 2;
            this.themeLbl.Text = "Theme: ";
            // 
            // showInTaskbarCb
            // 
            this.showInTaskbarCb.AutoSize = true;
            this.showInTaskbarCb.Location = new System.Drawing.Point(17, 183);
            this.showInTaskbarCb.Name = "showInTaskbarCb";
            this.showInTaskbarCb.Size = new System.Drawing.Size(140, 17);
            this.showInTaskbarCb.TabIndex = 11;
            this.showInTaskbarCb.Text = "Show Quartz in Taskbar";
            this.showInTaskbarCb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.publishBackupLoc);
            this.groupBox1.Controls.Add(this.defPublishBtn);
            this.groupBox1.Controls.Add(this.clientBackupLoc);
            this.groupBox1.Controls.Add(this.clientBackupsCb);
            this.groupBox1.Controls.Add(this.defClientBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Removed Client Actions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Backup client folder name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Backup publish folder name";
            // 
            // publishBackupLoc
            // 
            this.publishBackupLoc.Location = new System.Drawing.Point(6, 103);
            this.publishBackupLoc.Name = "publishBackupLoc";
            this.publishBackupLoc.Size = new System.Drawing.Size(142, 20);
            this.publishBackupLoc.TabIndex = 5;
            // 
            // defPublishBtn
            // 
            this.defPublishBtn.Location = new System.Drawing.Point(154, 101);
            this.defPublishBtn.Name = "defPublishBtn";
            this.defPublishBtn.Size = new System.Drawing.Size(75, 23);
            this.defPublishBtn.TabIndex = 4;
            this.defPublishBtn.Text = "Default";
            this.defPublishBtn.UseVisualStyleBackColor = true;
            this.defPublishBtn.Click += new System.EventHandler(this.defPublishBtn_Click);
            // 
            // clientBackupLoc
            // 
            this.clientBackupLoc.Location = new System.Drawing.Point(6, 55);
            this.clientBackupLoc.Name = "clientBackupLoc";
            this.clientBackupLoc.Size = new System.Drawing.Size(142, 20);
            this.clientBackupLoc.TabIndex = 1;
            // 
            // clientBackupsCb
            // 
            this.clientBackupsCb.AutoSize = true;
            this.clientBackupsCb.Location = new System.Drawing.Point(6, 19);
            this.clientBackupsCb.Name = "clientBackupsCb";
            this.clientBackupsCb.Size = new System.Drawing.Size(184, 17);
            this.clientBackupsCb.TabIndex = 3;
            this.clientBackupsCb.Text = "Keep backups of removed clients";
            this.clientBackupsCb.UseVisualStyleBackColor = true;
            this.clientBackupsCb.CheckedChanged += new System.EventHandler(this.clientBackupsCb_CheckedChanged);
            // 
            // defClientBtn
            // 
            this.defClientBtn.Location = new System.Drawing.Point(154, 53);
            this.defClientBtn.Name = "defClientBtn";
            this.defClientBtn.Size = new System.Drawing.Size(75, 23);
            this.defClientBtn.TabIndex = 0;
            this.defClientBtn.Text = "Default";
            this.defClientBtn.UseVisualStyleBackColor = true;
            this.defClientBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // startWithWindowsCb
            // 
            this.startWithWindowsCb.AutoSize = true;
            this.startWithWindowsCb.Location = new System.Drawing.Point(17, 160);
            this.startWithWindowsCb.Name = "startWithWindowsCb";
            this.startWithWindowsCb.Size = new System.Drawing.Size(186, 17);
            this.startWithWindowsCb.TabIndex = 0;
            this.startWithWindowsCb.Text = "Start Quartz when Windows starts";
            this.startWithWindowsCb.UseVisualStyleBackColor = true;
            // 
            // directoryTb
            // 
            this.directoryTb.BackColor = System.Drawing.SystemColors.Control;
            this.directoryTb.Controls.Add(this.label1);
            this.directoryTb.Controls.Add(this.BackupGb);
            this.directoryTb.Controls.Add(this.close2);
            this.directoryTb.Controls.Add(this.applyDir);
            this.directoryTb.Controls.Add(this.PublishGb);
            this.directoryTb.Controls.Add(this.ClientGb);
            this.directoryTb.Location = new System.Drawing.Point(4, 22);
            this.directoryTb.Name = "directoryTb";
            this.directoryTb.Padding = new System.Windows.Forms.Padding(3);
            this.directoryTb.Size = new System.Drawing.Size(256, 317);
            this.directoryTb.TabIndex = 1;
            this.directoryTb.Text = "Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change or Set Default Directoires";
            // 
            // BackupGb
            // 
            this.BackupGb.Controls.Add(this.BackupDirTxt);
            this.BackupGb.Controls.Add(this.BackupBkBtn);
            this.BackupGb.Location = new System.Drawing.Point(10, 161);
            this.BackupGb.Name = "BackupGb";
            this.BackupGb.Size = new System.Drawing.Size(235, 58);
            this.BackupGb.TabIndex = 7;
            this.BackupGb.TabStop = false;
            this.BackupGb.Tag = "";
            this.BackupGb.Text = "Default Backup Directory";
            // 
            // BackupDirTxt
            // 
            this.BackupDirTxt.Location = new System.Drawing.Point(6, 22);
            this.BackupDirTxt.Name = "BackupDirTxt";
            this.BackupDirTxt.Size = new System.Drawing.Size(142, 20);
            this.BackupDirTxt.TabIndex = 1;
            // 
            // BackupBkBtn
            // 
            this.BackupBkBtn.Location = new System.Drawing.Point(154, 19);
            this.BackupBkBtn.Name = "BackupBkBtn";
            this.BackupBkBtn.Size = new System.Drawing.Size(75, 23);
            this.BackupBkBtn.TabIndex = 0;
            this.BackupBkBtn.Text = "Browse";
            this.BackupBkBtn.UseVisualStyleBackColor = true;
            this.BackupBkBtn.Click += new System.EventHandler(this.BackupBkBtn_Click);
            // 
            // close2
            // 
            this.close2.Location = new System.Drawing.Point(165, 284);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(75, 23);
            this.close2.TabIndex = 6;
            this.close2.Text = "Close";
            this.close2.UseVisualStyleBackColor = true;
            this.close2.Click += new System.EventHandler(this.close_Click);
            // 
            // applyDir
            // 
            this.applyDir.Location = new System.Drawing.Point(84, 284);
            this.applyDir.Name = "applyDir";
            this.applyDir.Size = new System.Drawing.Size(75, 23);
            this.applyDir.TabIndex = 5;
            this.applyDir.Text = "Apply";
            this.applyDir.UseVisualStyleBackColor = true;
            this.applyDir.Click += new System.EventHandler(this.applyGen_Click);
            // 
            // PublishGb
            // 
            this.PublishGb.Controls.Add(this.PublishDirTxt);
            this.PublishGb.Controls.Add(this.PublishBkBrowse);
            this.PublishGb.Location = new System.Drawing.Point(11, 100);
            this.PublishGb.Name = "PublishGb";
            this.PublishGb.Size = new System.Drawing.Size(235, 58);
            this.PublishGb.TabIndex = 4;
            this.PublishGb.TabStop = false;
            this.PublishGb.Tag = "";
            this.PublishGb.Text = "Default Publish Directory";
            // 
            // PublishDirTxt
            // 
            this.PublishDirTxt.Location = new System.Drawing.Point(6, 22);
            this.PublishDirTxt.Name = "PublishDirTxt";
            this.PublishDirTxt.Size = new System.Drawing.Size(142, 20);
            this.PublishDirTxt.TabIndex = 1;
            // 
            // PublishBkBrowse
            // 
            this.PublishBkBrowse.Location = new System.Drawing.Point(154, 19);
            this.PublishBkBrowse.Name = "PublishBkBrowse";
            this.PublishBkBrowse.Size = new System.Drawing.Size(75, 23);
            this.PublishBkBrowse.TabIndex = 0;
            this.PublishBkBrowse.Text = "Browse";
            this.PublishBkBrowse.UseVisualStyleBackColor = true;
            this.PublishBkBrowse.Click += new System.EventHandler(this.PublishBkBrowse_Click);
            // 
            // ClientGb
            // 
            this.ClientGb.Controls.Add(this.ClientDirTxt);
            this.ClientGb.Controls.Add(this.ClientBkBrowse);
            this.ClientGb.Location = new System.Drawing.Point(11, 36);
            this.ClientGb.Name = "ClientGb";
            this.ClientGb.Size = new System.Drawing.Size(235, 58);
            this.ClientGb.TabIndex = 3;
            this.ClientGb.TabStop = false;
            this.ClientGb.Text = "Default Client Directory";
            // 
            // ClientDirTxt
            // 
            this.ClientDirTxt.Location = new System.Drawing.Point(6, 22);
            this.ClientDirTxt.Name = "ClientDirTxt";
            this.ClientDirTxt.Size = new System.Drawing.Size(142, 20);
            this.ClientDirTxt.TabIndex = 1;
            // 
            // ClientBkBrowse
            // 
            this.ClientBkBrowse.Location = new System.Drawing.Point(154, 19);
            this.ClientBkBrowse.Name = "ClientBkBrowse";
            this.ClientBkBrowse.Size = new System.Drawing.Size(75, 23);
            this.ClientBkBrowse.TabIndex = 0;
            this.ClientBkBrowse.Text = "Browse";
            this.ClientBkBrowse.UseVisualStyleBackColor = true;
            this.ClientBkBrowse.Click += new System.EventHandler(this.ClientBkBrowse_Click);
            // 
            // programTb
            // 
            this.programTb.BackColor = System.Drawing.SystemColors.Control;
            this.programTb.Controls.Add(this.close3);
            this.programTb.Controls.Add(this.button6);
            this.programTb.Location = new System.Drawing.Point(4, 22);
            this.programTb.Name = "programTb";
            this.programTb.Size = new System.Drawing.Size(256, 317);
            this.programTb.TabIndex = 3;
            this.programTb.Text = "Programs";
            // 
            // close3
            // 
            this.close3.Location = new System.Drawing.Point(165, 284);
            this.close3.Name = "close3";
            this.close3.Size = new System.Drawing.Size(75, 23);
            this.close3.TabIndex = 8;
            this.close3.Text = "Close";
            this.close3.UseVisualStyleBackColor = true;
            this.close3.Click += new System.EventHandler(this.close_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(84, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Apply";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // adminTb
            // 
            this.adminTb.AutoScroll = true;
            this.adminTb.BackColor = System.Drawing.SystemColors.Control;
            this.adminTb.Controls.Add(this.close4);
            this.adminTb.Controls.Add(this.adminIDLabel);
            this.adminTb.Controls.Add(this.adminIDBindingNavigator);
            this.adminTb.Controls.Add(this.adminIDDataGridView);
            this.adminTb.Controls.Add(this.adminIDTextBox);
            this.adminTb.Controls.Add(admin_NameLabel);
            this.adminTb.Controls.Add(this.admin_NameTextBox);
            this.adminTb.Controls.Add(admin_PasswordLabel);
            this.adminTb.Controls.Add(this.admin_PasswordTextBox);
            this.adminTb.Location = new System.Drawing.Point(4, 22);
            this.adminTb.Name = "adminTb";
            this.adminTb.Padding = new System.Windows.Forms.Padding(3);
            this.adminTb.Size = new System.Drawing.Size(256, 317);
            this.adminTb.TabIndex = 0;
            this.adminTb.Text = "Admin";
            // 
            // close4
            // 
            this.close4.Location = new System.Drawing.Point(165, 284);
            this.close4.Name = "close4";
            this.close4.Size = new System.Drawing.Size(75, 23);
            this.close4.TabIndex = 12;
            this.close4.Text = "Close";
            this.close4.UseVisualStyleBackColor = true;
            this.close4.Click += new System.EventHandler(this.close_Click);
            // 
            // adminIDLabel
            // 
            this.adminIDLabel.AutoSize = true;
            this.adminIDLabel.Location = new System.Drawing.Point(109, 9);
            this.adminIDLabel.Name = "adminIDLabel";
            this.adminIDLabel.Size = new System.Drawing.Size(53, 13);
            this.adminIDLabel.TabIndex = 10;
            this.adminIDLabel.Text = "Admin ID:";
            this.adminIDLabel.Visible = false;
            // 
            // adminIDBindingNavigator
            // 
            this.adminIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adminIDBindingNavigator.BindingSource = this.adminIDBindingSource;
            this.adminIDBindingNavigator.CountItem = null;
            this.adminIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adminIDBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.adminIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.adminIDBindingNavigatorSaveItem});
            this.adminIDBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.adminIDBindingNavigator.MoveFirstItem = null;
            this.adminIDBindingNavigator.MoveLastItem = null;
            this.adminIDBindingNavigator.MoveNextItem = null;
            this.adminIDBindingNavigator.MovePreviousItem = null;
            this.adminIDBindingNavigator.Name = "adminIDBindingNavigator";
            this.adminIDBindingNavigator.PositionItem = null;
            this.adminIDBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.adminIDBindingNavigator.TabIndex = 9;
            this.adminIDBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // adminIDBindingSource
            // 
            this.adminIDBindingSource.DataMember = "AdminID";
            this.adminIDBindingSource.DataSource = this.quartzDataDataSet1;
            // 
            // quartzDataDataSet1
            // 
            this.quartzDataDataSet1.DataSetName = "QuartzDataDataSet1";
            this.quartzDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // adminIDBindingNavigatorSaveItem
            // 
            this.adminIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adminIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adminIDBindingNavigatorSaveItem.Image")));
            this.adminIDBindingNavigatorSaveItem.Name = "adminIDBindingNavigatorSaveItem";
            this.adminIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.adminIDBindingNavigatorSaveItem.Text = "Save Data";
            this.adminIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.adminIDBindingNavigatorSaveItem_Click_1);
            // 
            // adminIDDataGridView
            // 
            this.adminIDDataGridView.AllowUserToAddRows = false;
            this.adminIDDataGridView.AllowUserToDeleteRows = false;
            this.adminIDDataGridView.AutoGenerateColumns = false;
            this.adminIDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adminIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminIDDataGridView.ColumnHeadersVisible = false;
            this.adminIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.adminIDDataGridView.DataSource = this.adminIDBindingSource;
            this.adminIDDataGridView.Location = new System.Drawing.Point(21, 97);
            this.adminIDDataGridView.Name = "adminIDDataGridView";
            this.adminIDDataGridView.ReadOnly = true;
            this.adminIDDataGridView.RowHeadersVisible = false;
            this.adminIDDataGridView.Size = new System.Drawing.Size(211, 181);
            this.adminIDDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdminID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdminID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Admin Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Admin Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Admin Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Admin Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // adminIDTextBox
            // 
            this.adminIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminIDBindingSource, "AdminID", true));
            this.adminIDTextBox.Location = new System.Drawing.Point(172, 6);
            this.adminIDTextBox.Name = "adminIDTextBox";
            this.adminIDTextBox.Size = new System.Drawing.Size(74, 20);
            this.adminIDTextBox.TabIndex = 1;
            this.adminIDTextBox.Visible = false;
            // 
            // admin_NameTextBox
            // 
            this.admin_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminIDBindingSource, "Admin Name", true));
            this.admin_NameTextBox.Location = new System.Drawing.Point(112, 38);
            this.admin_NameTextBox.Name = "admin_NameTextBox";
            this.admin_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.admin_NameTextBox.TabIndex = 3;
            // 
            // admin_PasswordTextBox
            // 
            this.admin_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminIDBindingSource, "Admin Password", true));
            this.admin_PasswordTextBox.Location = new System.Drawing.Point(112, 64);
            this.admin_PasswordTextBox.Name = "admin_PasswordTextBox";
            this.admin_PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.admin_PasswordTextBox.TabIndex = 5;
            this.admin_PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.progDefLb);
            this.tabPage1.Controls.Add(this.closeDefault);
            this.tabPage1.Controls.Add(this.loadDefaultsBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 317);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Properties changed by loading defaults";
            // 
            // progDefLb
            // 
            this.progDefLb.FormattingEnabled = true;
            this.progDefLb.Location = new System.Drawing.Point(6, 26);
            this.progDefLb.Name = "progDefLb";
            this.progDefLb.Size = new System.Drawing.Size(235, 147);
            this.progDefLb.TabIndex = 3;
            // 
            // closeDefault
            // 
            this.closeDefault.Location = new System.Drawing.Point(165, 284);
            this.closeDefault.Name = "closeDefault";
            this.closeDefault.Size = new System.Drawing.Size(75, 23);
            this.closeDefault.TabIndex = 2;
            this.closeDefault.Text = "Close";
            this.closeDefault.UseVisualStyleBackColor = true;
            this.closeDefault.Click += new System.EventHandler(this.close_Click);
            // 
            // loadDefaultsBtn
            // 
            this.loadDefaultsBtn.Location = new System.Drawing.Point(6, 179);
            this.loadDefaultsBtn.Name = "loadDefaultsBtn";
            this.loadDefaultsBtn.Size = new System.Drawing.Size(235, 47);
            this.loadDefaultsBtn.TabIndex = 0;
            this.loadDefaultsBtn.Text = "Load Program Defaults";
            this.loadDefaultsBtn.UseVisualStyleBackColor = true;
            this.loadDefaultsBtn.Click += new System.EventHandler(this.loadDefaultsBtn_Click);
            // 
            // adminIDTableAdapter
            // 
            this.adminIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminIDTableAdapter = this.adminIDTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BandIDTableAdapter = null;
            this.tableAdapterManager.MemberIDTableAdapter = null;
            this.tableAdapterManager.PaymentIDTableAdapter = null;
            this.tableAdapterManager.SongIDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quartz.QuartzDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 340);
            this.Controls.Add(this.tabControl);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.generalTb.ResumeLayout(false);
            this.generalTb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.directoryTb.ResumeLayout(false);
            this.directoryTb.PerformLayout();
            this.BackupGb.ResumeLayout(false);
            this.BackupGb.PerformLayout();
            this.PublishGb.ResumeLayout(false);
            this.PublishGb.PerformLayout();
            this.ClientGb.ResumeLayout(false);
            this.ClientGb.PerformLayout();
            this.programTb.ResumeLayout(false);
            this.adminTb.ResumeLayout(false);
            this.adminTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIDBindingNavigator)).EndInit();
            this.adminIDBindingNavigator.ResumeLayout(false);
            this.adminIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminIDDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage adminTb;
        private System.Windows.Forms.TabPage directoryTb;
        private QuartzDataDataSet1 quartzDataDataSet1;
        private System.Windows.Forms.BindingSource adminIDBindingSource;
        private Quartz.QuartzDataDataSet1TableAdapters.AdminIDTableAdapter adminIDTableAdapter;
        private Quartz.QuartzDataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator adminIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton adminIDBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView adminIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox adminIDTextBox;
        private System.Windows.Forms.TextBox admin_NameTextBox;
        private System.Windows.Forms.TextBox admin_PasswordTextBox;
        private System.Windows.Forms.Label adminIDLabel;
        private System.Windows.Forms.FolderBrowserDialog BackupLocation;
        private System.Windows.Forms.Button ClientBkBrowse;
        private System.Windows.Forms.GroupBox PublishGb;
        private System.Windows.Forms.TextBox PublishDirTxt;
        private System.Windows.Forms.Button PublishBkBrowse;
        private System.Windows.Forms.GroupBox ClientGb;
        private System.Windows.Forms.TextBox ClientDirTxt;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.Button applyDir;
        private System.Windows.Forms.TabPage generalTb;
        private System.Windows.Forms.TabPage programTb;
        private System.Windows.Forms.GroupBox BackupGb;
        private System.Windows.Forms.TextBox BackupDirTxt;
        private System.Windows.Forms.Button BackupBkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox themeSelect;
        private System.Windows.Forms.CheckBox startWithWindowsCb;
        private System.Windows.Forms.Label themeLbl;
        private System.Windows.Forms.CheckBox clientBackupsCb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clientBackupLoc;
        private System.Windows.Forms.Button defClientBtn;
        private System.Windows.Forms.CheckBox showInTaskbarCb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button applyGen;
        private System.Windows.Forms.Button close3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button close4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button loadDefaultsBtn;
        private System.Windows.Forms.Button closeDefault;
        private System.Windows.Forms.TextBox publishBackupLoc;
        private System.Windows.Forms.Button defPublishBtn;
        private System.Windows.Forms.CheckBox showNotifIconCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox progDefLb;
        private System.Windows.Forms.Label label4;
    }
}