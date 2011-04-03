namespace Quartz
{
    partial class MemberInfo
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label e_MailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInfo));
            this.memberIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.memberIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartzDataDataSet = new Quartz.QuartzDataDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.memberIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.bandIDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.band_NameTextBox = new System.Windows.Forms.TextBox();
            this.bandIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.MemberIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager();
            this.bandIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter();
            this.BandIDLabel = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDBindingNavigator)).BeginInit();
            this.memberIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(12, 34);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 5;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(186, 34);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 7;
            last_NameLabel.Text = "Last Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(360, 34);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(513, 34);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(39, 13);
            e_MailLabel.TabIndex = 11;
            e_MailLabel.Text = "E-Mail:";
            // 
            // memberIDBindingNavigator
            // 
            this.memberIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberIDBindingNavigator.BindingSource = this.memberIDBindingSource;
            this.memberIDBindingNavigator.CountItem = null;
            this.memberIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.memberIDBindingNavigatorSaveItem});
            this.memberIDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memberIDBindingNavigator.MoveFirstItem = null;
            this.memberIDBindingNavigator.MoveLastItem = null;
            this.memberIDBindingNavigator.MoveNextItem = null;
            this.memberIDBindingNavigator.MovePreviousItem = null;
            this.memberIDBindingNavigator.Name = "memberIDBindingNavigator";
            this.memberIDBindingNavigator.PositionItem = null;
            this.memberIDBindingNavigator.Size = new System.Drawing.Size(678, 25);
            this.memberIDBindingNavigator.TabIndex = 0;
            this.memberIDBindingNavigator.Text = "bindingNavigator1";
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
            // memberIDBindingSource
            // 
            this.memberIDBindingSource.DataMember = "MemberID";
            this.memberIDBindingSource.DataSource = this.quartzDataDataSet;
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
            // 
            // memberIDBindingNavigatorSaveItem
            // 
            this.memberIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memberIDBindingNavigatorSaveItem.Image")));
            this.memberIDBindingNavigatorSaveItem.Name = "memberIDBindingNavigatorSaveItem";
            this.memberIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.memberIDBindingNavigatorSaveItem.Text = "Save Data";
            this.memberIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.memberIDBindingNavigatorSaveItem_Click);
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "MemberID", true));
            this.memberIDTextBox.Enabled = false;
            this.memberIDTextBox.Location = new System.Drawing.Point(558, 6);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberIDTextBox.TabIndex = 2;
            this.memberIDTextBox.Visible = false;
            this.memberIDTextBox.WordWrap = false;
            // 
            // bandIDTextBox
            // 
            this.bandIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "BandID", true));
            this.bandIDTextBox.Enabled = false;
            this.bandIDTextBox.Location = new System.Drawing.Point(145, 5);
            this.bandIDTextBox.Name = "bandIDTextBox";
            this.bandIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bandIDTextBox.TabIndex = 4;
            this.bandIDTextBox.Visible = false;
            this.bandIDTextBox.WordWrap = false;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(80, 31);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 6;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(254, 31);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(407, 31);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberIDBindingSource, "E-Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(558, 31);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_MailTextBox.TabIndex = 12;
            // 
            // band_NameTextBox
            // 
            this.band_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "Band Name", true));
            this.band_NameTextBox.Enabled = false;
            this.band_NameTextBox.Location = new System.Drawing.Point(80, 5);
            this.band_NameTextBox.Name = "band_NameTextBox";
            this.band_NameTextBox.Size = new System.Drawing.Size(578, 20);
            this.band_NameTextBox.TabIndex = 16;
            this.band_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // bandIDBindingSource
            // 
            this.bandIDBindingSource.DataMember = "BandID";
            this.bandIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // memberIDDataGridView
            // 
            this.memberIDDataGridView.AllowUserToAddRows = false;
            this.memberIDDataGridView.AutoGenerateColumns = false;
            this.memberIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.memberIDDataGridView.DataSource = this.memberIDBindingSource;
            this.memberIDDataGridView.Location = new System.Drawing.Point(15, 57);
            this.memberIDDataGridView.Name = "memberIDDataGridView";
            this.memberIDDataGridView.RowHeadersVisible = false;
            this.memberIDDataGridView.Size = new System.Drawing.Size(643, 299);
            this.memberIDDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "E-Mail";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // memberIDTableAdapter
            // 
            this.memberIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BandIDTableAdapter = this.bandIDTableAdapter;
            this.tableAdapterManager.MemberIDTableAdapter = this.memberIDTableAdapter;
            this.tableAdapterManager.PaymentIDTableAdapter = null;
            this.tableAdapterManager.SchedualIDTableAdapter = null;
            this.tableAdapterManager.SongIDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bandIDTableAdapter
            // 
            this.bandIDTableAdapter.ClearBeforeFill = true;
            // 
            // BandIDLabel
            // 
            this.BandIDLabel.AutoSize = true;
            this.BandIDLabel.Location = new System.Drawing.Point(90, 8);
            this.BandIDLabel.Name = "BandIDLabel";
            this.BandIDLabel.Size = new System.Drawing.Size(49, 13);
            this.BandIDLabel.TabIndex = 17;
            this.BandIDLabel.Text = "Band ID:";
            this.BandIDLabel.Visible = false;
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Location = new System.Drawing.Point(490, 8);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(62, 13);
            this.MemberIDLabel.TabIndex = 18;
            this.MemberIDLabel.Text = "Member ID:";
            this.MemberIDLabel.Visible = false;
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 376);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.BandIDLabel);
            this.Controls.Add(this.memberIDDataGridView);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.bandIDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(e_MailLabel);
            this.Controls.Add(this.e_MailTextBox);
            this.Controls.Add(this.band_NameTextBox);
            this.Controls.Add(this.memberIDBindingNavigator);
            this.Name = "MemberInfo";
            this.Text = "Member Info";
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberIDBindingNavigator)).EndInit();
            this.memberIDBindingNavigator.ResumeLayout(false);
            this.memberIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIDDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuartzDataDataSet quartzDataDataSet;
        private System.Windows.Forms.BindingSource memberIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.MemberIDTableAdapter memberIDTableAdapter;
        private Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memberIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton memberIDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox bandIDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter bandIDTableAdapter;
        private System.Windows.Forms.BindingSource bandIDBindingSource;
        private System.Windows.Forms.TextBox band_NameTextBox;
        private System.Windows.Forms.DataGridView memberIDDataGridView;
        private System.Windows.Forms.Label BandIDLabel;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}