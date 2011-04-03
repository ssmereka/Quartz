namespace Quartz
{
    partial class BandInfo
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
            System.Windows.Forms.Label band_NameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandInfo));
            this.bandIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bandIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartzDataDataSet = new Quartz.QuartzDataDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bandIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.editMember = new System.Windows.Forms.ToolStripButton();
            this.editSong = new System.Windows.Forms.ToolStripButton();
            this.editPayment = new System.Windows.Forms.ToolStripButton();
            this.editPassword = new System.Windows.Forms.ToolStripButton();
            this.bandIDTextBox = new System.Windows.Forms.TextBox();
            this.band_NameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.memberIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.songIDTextBox = new System.Windows.Forms.TextBox();
            this.songIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager();
            this.memberIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.MemberIDTableAdapter();
            this.songIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter();
            this.paymentIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandIDLabel = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.SongIDLabel = new System.Windows.Forms.Label();
            band_NameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingNavigator)).BeginInit();
            this.bandIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // band_NameLabel
            // 
            band_NameLabel.AutoSize = true;
            band_NameLabel.Location = new System.Drawing.Point(12, 35);
            band_NameLabel.Name = "band_NameLabel";
            band_NameLabel.Size = new System.Drawing.Size(66, 13);
            band_NameLabel.TabIndex = 3;
            band_NameLabel.Text = "Band Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 61);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // bandIDBindingNavigator
            // 
            this.bandIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bandIDBindingNavigator.BindingSource = this.bandIDBindingSource;
            this.bandIDBindingNavigator.CountItem = null;
            this.bandIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bandIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bandIDBindingNavigatorSaveItem,
            this.editMember,
            this.editSong,
            this.editPayment,
            this.editPassword});
            this.bandIDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bandIDBindingNavigator.MoveFirstItem = null;
            this.bandIDBindingNavigator.MoveLastItem = null;
            this.bandIDBindingNavigator.MoveNextItem = null;
            this.bandIDBindingNavigator.MovePreviousItem = null;
            this.bandIDBindingNavigator.Name = "bandIDBindingNavigator";
            this.bandIDBindingNavigator.PositionItem = null;
            this.bandIDBindingNavigator.Size = new System.Drawing.Size(1092, 25);
            this.bandIDBindingNavigator.TabIndex = 0;
            this.bandIDBindingNavigator.Text = "bindingNavigator1";
            this.bandIDBindingNavigator.RefreshItems += new System.EventHandler(this.bandIDBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bandIDBindingSource
            // 
            this.bandIDBindingSource.DataMember = "BandID";
            this.bandIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // quartzDataDataSet
            // 
            this.quartzDataDataSet.DataSetName = "QuartzDataDataSet";
            this.quartzDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bandIDBindingNavigatorSaveItem
            // 
            this.bandIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bandIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bandIDBindingNavigatorSaveItem.Image")));
            this.bandIDBindingNavigatorSaveItem.Name = "bandIDBindingNavigatorSaveItem";
            this.bandIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bandIDBindingNavigatorSaveItem.Text = "Save Data";
            this.bandIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.bandIDBindingNavigatorSaveItem_Click);
            // 
            // editMember
            // 
            this.editMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editMember.Image = global::Quartz.Properties.Resources.stick_figure;
            this.editMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editMember.Name = "editMember";
            this.editMember.Size = new System.Drawing.Size(23, 22);
            this.editMember.Text = "EditMember";
            this.editMember.ToolTipText = "Edit Member Info";
            this.editMember.Visible = false;
            this.editMember.Click += new System.EventHandler(this.editMember_Click);
            // 
            // editSong
            // 
            this.editSong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editSong.Image = global::Quartz.Properties.Resources.music_note;
            this.editSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSong.Name = "editSong";
            this.editSong.Size = new System.Drawing.Size(23, 22);
            this.editSong.Text = "Song Info";
            this.editSong.ToolTipText = "Edit Song Info";
            this.editSong.Visible = false;
            this.editSong.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // editPayment
            // 
            this.editPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPayment.Image = global::Quartz.Properties.Resources.dollar_sign;
            this.editPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPayment.Name = "editPayment";
            this.editPayment.Size = new System.Drawing.Size(23, 22);
            this.editPayment.Text = "Edit Payment";
            this.editPayment.ToolTipText = "Edit Payment Info";
            this.editPayment.Visible = false;
            this.editPayment.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // editPassword
            // 
            this.editPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPassword.Image = global::Quartz.Properties.Resources.key_juliane_krug_01;
            this.editPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(23, 22);
            this.editPassword.Text = "Hide/Show Password";
            this.editPassword.ToolTipText = "Hide/Show Password";
            this.editPassword.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bandIDTextBox
            // 
            this.bandIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "BandID", true));
            this.bandIDTextBox.Enabled = false;
            this.bandIDTextBox.Location = new System.Drawing.Point(473, 58);
            this.bandIDTextBox.Name = "bandIDTextBox";
            this.bandIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bandIDTextBox.TabIndex = 2;
            this.bandIDTextBox.Visible = false;
            this.bandIDTextBox.WordWrap = false;
            // 
            // band_NameTextBox
            // 
            this.band_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "Band Name", true));
            this.band_NameTextBox.Location = new System.Drawing.Point(84, 32);
            this.band_NameTextBox.Name = "band_NameTextBox";
            this.band_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.band_NameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(84, 58);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // memberIDDataGridView
            // 
            this.memberIDDataGridView.AllowUserToAddRows = false;
            this.memberIDDataGridView.AllowUserToDeleteRows = false;
            this.memberIDDataGridView.AutoGenerateColumns = false;
            this.memberIDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.memberIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.memberIDDataGridView.DataSource = this.memberIDBindingSource;
            this.memberIDDataGridView.Location = new System.Drawing.Point(190, 84);
            this.memberIDDataGridView.Name = "memberIDDataGridView";
            this.memberIDDataGridView.ReadOnly = true;
            this.memberIDDataGridView.RowHeadersVisible = false;
            this.memberIDDataGridView.Size = new System.Drawing.Size(417, 309);
            this.memberIDDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn4.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn5.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 49;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 82;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 83;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 63;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "E-Mail";
            this.dataGridViewTextBoxColumn9.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 61;
            // 
            // memberIDBindingSource
            // 
            this.memberIDBindingSource.DataMember = "MemberID";
            this.memberIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "MemberID", true));
            this.memberIDTextBox.Enabled = false;
            this.memberIDTextBox.Location = new System.Drawing.Point(473, 32);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberIDTextBox.TabIndex = 10;
            this.memberIDTextBox.Visible = false;
            // 
            // songIDTextBox
            // 
            this.songIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songIDBindingSource, "SongID", true));
            this.songIDTextBox.Enabled = false;
            this.songIDTextBox.Location = new System.Drawing.Point(665, 32);
            this.songIDTextBox.Name = "songIDTextBox";
            this.songIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.songIDTextBox.TabIndex = 14;
            this.songIDTextBox.Visible = false;
            // 
            // songIDBindingSource
            // 
            this.songIDBindingSource.DataMember = "SongID";
            this.songIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // songIDDataGridView
            // 
            this.songIDDataGridView.AllowUserToAddRows = false;
            this.songIDDataGridView.AllowUserToDeleteRows = false;
            this.songIDDataGridView.AutoGenerateColumns = false;
            this.songIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn14});
            this.songIDDataGridView.DataSource = this.songIDBindingSource;
            this.songIDDataGridView.Location = new System.Drawing.Point(613, 84);
            this.songIDDataGridView.Name = "songIDDataGridView";
            this.songIDDataGridView.ReadOnly = true;
            this.songIDDataGridView.RowHeadersVisible = false;
            this.songIDDataGridView.Size = new System.Drawing.Size(459, 309);
            this.songIDDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SongID";
            this.dataGridViewTextBoxColumn10.HeaderText = "SongID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn11.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Song Price";
            this.dataGridViewTextBoxColumn13.HeaderText = "Song Price";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Mastered";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Mastered";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Mastered Price";
            this.dataGridViewTextBoxColumn14.HeaderText = "Mastered Price";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // bandIDDataGridView
            // 
            this.bandIDDataGridView.AllowUserToAddRows = false;
            this.bandIDDataGridView.AllowUserToDeleteRows = false;
            this.bandIDDataGridView.AutoGenerateColumns = false;
            this.bandIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandIDDataGridView.ColumnHeadersVisible = false;
            this.bandIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bandIDDataGridView.DataSource = this.bandIDBindingSource;
            this.bandIDDataGridView.Location = new System.Drawing.Point(15, 84);
            this.bandIDDataGridView.Name = "bandIDDataGridView";
            this.bandIDDataGridView.ReadOnly = true;
            this.bandIDDataGridView.RowHeadersVisible = false;
            this.bandIDDataGridView.Size = new System.Drawing.Size(169, 309);
            this.bandIDDataGridView.TabIndex = 15;
            this.bandIDDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bandIDDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Band Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Band Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // bandIDTableAdapter
            // 
            this.bandIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BandIDTableAdapter = this.bandIDTableAdapter;
            this.tableAdapterManager.MemberIDTableAdapter = this.memberIDTableAdapter;
            this.tableAdapterManager.PaymentIDTableAdapter = null;
            this.tableAdapterManager.SongIDTableAdapter = this.songIDTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberIDTableAdapter
            // 
            this.memberIDTableAdapter.ClearBeforeFill = true;
            // 
            // songIDTableAdapter
            // 
            this.songIDTableAdapter.ClearBeforeFill = true;
            // 
            // paymentIDBindingSource
            // 
            this.paymentIDBindingSource.DataMember = "PaymentID";
            this.paymentIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // bandIDLabel
            // 
            this.bandIDLabel.AutoSize = true;
            this.bandIDLabel.Location = new System.Drawing.Point(405, 61);
            this.bandIDLabel.Name = "bandIDLabel";
            this.bandIDLabel.Size = new System.Drawing.Size(49, 13);
            this.bandIDLabel.TabIndex = 16;
            this.bandIDLabel.Text = "Band ID:";
            this.bandIDLabel.Visible = false;
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Location = new System.Drawing.Point(405, 35);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(62, 13);
            this.MemberIDLabel.TabIndex = 17;
            this.MemberIDLabel.Text = "Member ID:";
            this.MemberIDLabel.Visible = false;
            // 
            // SongIDLabel
            // 
            this.SongIDLabel.AutoSize = true;
            this.SongIDLabel.Location = new System.Drawing.Point(610, 35);
            this.SongIDLabel.Name = "SongIDLabel";
            this.SongIDLabel.Size = new System.Drawing.Size(49, 13);
            this.SongIDLabel.TabIndex = 18;
            this.SongIDLabel.Text = "Song ID:";
            this.SongIDLabel.Visible = false;
            // 
            // BandInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 413);
            this.Controls.Add(this.SongIDLabel);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.bandIDLabel);
            this.Controls.Add(this.bandIDDataGridView);
            this.Controls.Add(this.songIDDataGridView);
            this.Controls.Add(this.songIDTextBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDDataGridView);
            this.Controls.Add(this.bandIDTextBox);
            this.Controls.Add(band_NameLabel);
            this.Controls.Add(this.band_NameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.bandIDBindingNavigator);
            this.Name = "BandInfo";
            this.Text = "Band Info";
            this.Load += new System.EventHandler(this.BandInfo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BandInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingNavigator)).EndInit();
            this.bandIDBindingNavigator.ResumeLayout(false);
            this.bandIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuartzDataDataSet quartzDataDataSet;
        private System.Windows.Forms.BindingSource bandIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter bandIDTableAdapter;
        private Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bandIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bandIDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bandIDTextBox;
        private System.Windows.Forms.TextBox band_NameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private Quartz.QuartzDataDataSetTableAdapters.MemberIDTableAdapter memberIDTableAdapter;
        private System.Windows.Forms.BindingSource memberIDBindingSource;
        private System.Windows.Forms.DataGridView memberIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.BindingSource paymentIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter songIDTableAdapter;
        private System.Windows.Forms.BindingSource songIDBindingSource;
        private System.Windows.Forms.TextBox songIDTextBox;
        private System.Windows.Forms.DataGridView songIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ToolStripButton editMember;
        private System.Windows.Forms.ToolStripButton editSong;
        private System.Windows.Forms.ToolStripButton editPayment;
        private System.Windows.Forms.DataGridView bandIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label bandIDLabel;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label SongIDLabel;
        private System.Windows.Forms.ToolStripButton editPassword;
    }
}