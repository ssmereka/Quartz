namespace Quartz
{
    partial class SongInfo
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label song_PriceLabel;
            System.Windows.Forms.Label mastered_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongInfo));
            this.quartzDataDataSet = new Quartz.QuartzDataDataSet();
            this.songIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager();
            this.bandIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter();
            this.songIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.songIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.songIDTextBox = new System.Windows.Forms.TextBox();
            this.bandIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.song_PriceTextBox = new System.Windows.Forms.TextBox();
            this.masteredCheckBox = new System.Windows.Forms.CheckBox();
            this.mastered_PriceTextBox = new System.Windows.Forms.TextBox();
            this.songIDDataGridView = new System.Windows.Forms.DataGridView();
            this.bandIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.band_NameTextBox = new System.Windows.Forms.TextBox();
            this.SongIDLabel = new System.Windows.Forms.Label();
            this.BandIDLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.PaymentIDTableAdapter();
            this.paymentIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            song_PriceLabel = new System.Windows.Forms.Label();
            mastered_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingNavigator)).BeginInit();
            this.songIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 36);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // song_PriceLabel
            // 
            song_PriceLabel.AutoSize = true;
            song_PriceLabel.Location = new System.Drawing.Point(278, 36);
            song_PriceLabel.Name = "song_PriceLabel";
            song_PriceLabel.Size = new System.Drawing.Size(62, 13);
            song_PriceLabel.TabIndex = 7;
            song_PriceLabel.Text = "Song Price:";
            // 
            // mastered_PriceLabel
            // 
            mastered_PriceLabel.AutoSize = true;
            mastered_PriceLabel.Location = new System.Drawing.Point(475, 36);
            mastered_PriceLabel.Name = "mastered_PriceLabel";
            mastered_PriceLabel.Size = new System.Drawing.Size(81, 13);
            mastered_PriceLabel.TabIndex = 11;
            mastered_PriceLabel.Text = "Mastered Price:";
            // 
            // quartzDataDataSet
            // 
            this.quartzDataDataSet.DataSetName = "QuartzDataDataSet";
            this.quartzDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songIDBindingSource
            // 
            this.songIDBindingSource.DataMember = "SongID";
            this.songIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // songIDTableAdapter
            // 
            this.songIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BandIDTableAdapter = this.bandIDTableAdapter;
            this.tableAdapterManager.MemberIDTableAdapter = null;
            this.tableAdapterManager.PaymentIDTableAdapter = this.paymentIDTableAdapter;
            this.tableAdapterManager.SchedualIDTableAdapter = null;
            this.tableAdapterManager.SongIDTableAdapter = this.songIDTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bandIDTableAdapter
            // 
            this.bandIDTableAdapter.ClearBeforeFill = true;
            // 
            // songIDBindingNavigator
            // 
            this.songIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.songIDBindingNavigator.BindingSource = this.songIDBindingSource;
            this.songIDBindingNavigator.CountItem = null;
            this.songIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.songIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.songIDBindingNavigatorSaveItem});
            this.songIDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.songIDBindingNavigator.MoveFirstItem = null;
            this.songIDBindingNavigator.MoveLastItem = null;
            this.songIDBindingNavigator.MoveNextItem = null;
            this.songIDBindingNavigator.MovePreviousItem = null;
            this.songIDBindingNavigator.Name = "songIDBindingNavigator";
            this.songIDBindingNavigator.PositionItem = null;
            this.songIDBindingNavigator.Size = new System.Drawing.Size(679, 25);
            this.songIDBindingNavigator.TabIndex = 0;
            this.songIDBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // songIDBindingNavigatorSaveItem
            // 
            this.songIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.songIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("songIDBindingNavigatorSaveItem.Image")));
            this.songIDBindingNavigatorSaveItem.Name = "songIDBindingNavigatorSaveItem";
            this.songIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.songIDBindingNavigatorSaveItem.Text = "Save Data";
            this.songIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.songIDBindingNavigatorSaveItem_Click);
            // 
            // songIDTextBox
            // 
            this.songIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songIDBindingSource, "SongID", true));
            this.songIDTextBox.Enabled = false;
            this.songIDTextBox.Location = new System.Drawing.Point(169, 6);
            this.songIDTextBox.Name = "songIDTextBox";
            this.songIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.songIDTextBox.TabIndex = 2;
            this.songIDTextBox.Visible = false;
            // 
            // bandIDTextBox
            // 
            this.bandIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songIDBindingSource, "BandID", true));
            this.bandIDTextBox.Enabled = false;
            this.bandIDTextBox.Location = new System.Drawing.Point(562, 5);
            this.bandIDTextBox.Name = "bandIDTextBox";
            this.bandIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.bandIDTextBox.TabIndex = 4;
            this.bandIDTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songIDBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(56, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(104, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // song_PriceTextBox
            // 
            this.song_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songIDBindingSource, "Song Price", true));
            this.song_PriceTextBox.Location = new System.Drawing.Point(346, 33);
            this.song_PriceTextBox.Name = "song_PriceTextBox";
            this.song_PriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.song_PriceTextBox.TabIndex = 8;
            // 
            // masteredCheckBox
            // 
            this.masteredCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.songIDBindingSource, "Mastered", true));
            this.masteredCheckBox.Location = new System.Drawing.Point(183, 31);
            this.masteredCheckBox.Name = "masteredCheckBox";
            this.masteredCheckBox.Size = new System.Drawing.Size(104, 24);
            this.masteredCheckBox.TabIndex = 10;
            this.masteredCheckBox.Text = "Mastered";
            this.masteredCheckBox.UseVisualStyleBackColor = true;
            // 
            // mastered_PriceTextBox
            // 
            this.mastered_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songIDBindingSource, "Mastered Price", true));
            this.mastered_PriceTextBox.Location = new System.Drawing.Point(562, 33);
            this.mastered_PriceTextBox.Name = "mastered_PriceTextBox";
            this.mastered_PriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.mastered_PriceTextBox.TabIndex = 12;
            // 
            // songIDDataGridView
            // 
            this.songIDDataGridView.AllowUserToAddRows = false;
            this.songIDDataGridView.AllowUserToDeleteRows = false;
            this.songIDDataGridView.AutoGenerateColumns = false;
            this.songIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.songIDDataGridView.DataSource = this.songIDBindingSource;
            this.songIDDataGridView.Location = new System.Drawing.Point(12, 61);
            this.songIDDataGridView.Name = "songIDDataGridView";
            this.songIDDataGridView.RowHeadersVisible = false;
            this.songIDDataGridView.Size = new System.Drawing.Size(654, 306);
            this.songIDDataGridView.TabIndex = 13;
            // 
            // bandIDBindingSource
            // 
            this.bandIDBindingSource.DataMember = "BandID";
            this.bandIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // band_NameTextBox
            // 
            this.band_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "Band Name", true));
            this.band_NameTextBox.Enabled = false;
            this.band_NameTextBox.Location = new System.Drawing.Point(86, 5);
            this.band_NameTextBox.Name = "band_NameTextBox";
            this.band_NameTextBox.Size = new System.Drawing.Size(580, 20);
            this.band_NameTextBox.TabIndex = 16;
            this.band_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SongIDLabel
            // 
            this.SongIDLabel.AutoSize = true;
            this.SongIDLabel.Location = new System.Drawing.Point(114, 8);
            this.SongIDLabel.Name = "SongIDLabel";
            this.SongIDLabel.Size = new System.Drawing.Size(49, 13);
            this.SongIDLabel.TabIndex = 17;
            this.SongIDLabel.Text = "Song ID:";
            this.SongIDLabel.Visible = false;
            // 
            // BandIDLabel
            // 
            this.BandIDLabel.AutoSize = true;
            this.BandIDLabel.Location = new System.Drawing.Point(507, 9);
            this.BandIDLabel.Name = "BandIDLabel";
            this.BandIDLabel.Size = new System.Drawing.Size(49, 13);
            this.BandIDLabel.TabIndex = 18;
            this.BandIDLabel.Text = "Band ID:";
            this.BandIDLabel.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mastered Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mastered Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Mastered";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Mastered";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Song Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Song Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SongID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SongID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // bandIDDataGridView
            // 
            this.bandIDDataGridView.AllowUserToAddRows = false;
            this.bandIDDataGridView.AllowUserToDeleteRows = false;
            this.bandIDDataGridView.AutoGenerateColumns = false;
            this.bandIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.bandIDDataGridView.DataSource = this.bandIDBindingSource;
            this.bandIDDataGridView.Location = new System.Drawing.Point(15, 23);
            this.bandIDDataGridView.Name = "bandIDDataGridView";
            this.bandIDDataGridView.Size = new System.Drawing.Size(10, 10);
            this.bandIDDataGridView.TabIndex = 18;
            this.bandIDDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn6.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Band Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Band Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn8.HeaderText = "Password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn9.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // paymentIDBindingSource
            // 
            this.paymentIDBindingSource.DataMember = "PaymentID";
            this.paymentIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // paymentIDTableAdapter
            // 
            this.paymentIDTableAdapter.ClearBeforeFill = true;
            // 
            // paymentIDDataGridView
            // 
            this.paymentIDDataGridView.AllowUserToAddRows = false;
            this.paymentIDDataGridView.AllowUserToDeleteRows = false;
            this.paymentIDDataGridView.AutoGenerateColumns = false;
            this.paymentIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.paymentIDDataGridView.DataSource = this.paymentIDBindingSource;
            this.paymentIDDataGridView.Location = new System.Drawing.Point(31, 23);
            this.paymentIDDataGridView.Name = "paymentIDDataGridView";
            this.paymentIDDataGridView.Size = new System.Drawing.Size(10, 10);
            this.paymentIDDataGridView.TabIndex = 18;
            this.paymentIDDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PaymentID";
            this.dataGridViewTextBoxColumn10.HeaderText = "PaymentID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn11.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Payment Date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Payment Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn13.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Method";
            this.dataGridViewTextBoxColumn14.HeaderText = "Method";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // SongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 379);
            this.Controls.Add(this.paymentIDDataGridView);
            this.Controls.Add(this.bandIDDataGridView);
            this.Controls.Add(this.BandIDLabel);
            this.Controls.Add(this.SongIDLabel);
            this.Controls.Add(this.songIDDataGridView);
            this.Controls.Add(this.songIDTextBox);
            this.Controls.Add(this.bandIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(song_PriceLabel);
            this.Controls.Add(this.song_PriceTextBox);
            this.Controls.Add(this.masteredCheckBox);
            this.Controls.Add(mastered_PriceLabel);
            this.Controls.Add(this.mastered_PriceTextBox);
            this.Controls.Add(this.band_NameTextBox);
            this.Controls.Add(this.songIDBindingNavigator);
            this.Name = "SongInfo";
            this.Text = "Song Info";
            this.Load += new System.EventHandler(this.SongInfo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingNavigator)).EndInit();
            this.songIDBindingNavigator.ResumeLayout(false);
            this.songIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuartzDataDataSet quartzDataDataSet;
        private System.Windows.Forms.BindingSource songIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter songIDTableAdapter;
        private Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator songIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton songIDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox songIDTextBox;
        private System.Windows.Forms.TextBox bandIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox song_PriceTextBox;
        private System.Windows.Forms.CheckBox masteredCheckBox;
        private System.Windows.Forms.TextBox mastered_PriceTextBox;
        private Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter bandIDTableAdapter;
        private System.Windows.Forms.DataGridView songIDDataGridView;
        private System.Windows.Forms.BindingSource bandIDBindingSource;
        private System.Windows.Forms.TextBox band_NameTextBox;
        private System.Windows.Forms.Label SongIDLabel;
        private System.Windows.Forms.Label BandIDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView bandIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Quartz.QuartzDataDataSetTableAdapters.PaymentIDTableAdapter paymentIDTableAdapter;
        private System.Windows.Forms.BindingSource paymentIDBindingSource;
        private System.Windows.Forms.DataGridView paymentIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}