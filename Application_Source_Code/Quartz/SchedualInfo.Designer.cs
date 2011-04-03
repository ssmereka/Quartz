namespace Quartz
{
    partial class SchedualInfo
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label start_TimeLabel;
            System.Windows.Forms.Label end_TimeLabel;
            System.Windows.Forms.Label noteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedualInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.schedualIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.schedualIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartzDataDataSet = new Quartz.QuartzDataDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.schedualIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.schedualIDTextBox = new System.Windows.Forms.TextBox();
            this.bandIDTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.schedualIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.band_NameTextBox = new System.Windows.Forms.TextBox();
            this.bandIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedualIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.SchedualIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager();
            this.bandIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter();
            this.bandIdLbl = new System.Windows.Forms.Label();
            this.schedualIdLbl = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            start_TimeLabel = new System.Windows.Forms.Label();
            end_TimeLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schedualIDBindingNavigator)).BeginInit();
            this.schedualIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedualIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedualIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 36);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Date:";
            // 
            // start_TimeLabel
            // 
            start_TimeLabel.AutoSize = true;
            start_TimeLabel.Location = new System.Drawing.Point(169, 36);
            start_TimeLabel.Name = "start_TimeLabel";
            start_TimeLabel.Size = new System.Drawing.Size(58, 13);
            start_TimeLabel.TabIndex = 9;
            start_TimeLabel.Text = "Start Time:";
            // 
            // end_TimeLabel
            // 
            end_TimeLabel.AutoSize = true;
            end_TimeLabel.Location = new System.Drawing.Point(169, 62);
            end_TimeLabel.Name = "end_TimeLabel";
            end_TimeLabel.Size = new System.Drawing.Size(55, 13);
            end_TimeLabel.TabIndex = 11;
            end_TimeLabel.Text = "End Time:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(12, 85);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(33, 13);
            noteLabel.TabIndex = 13;
            noteLabel.Text = "Note:";
            // 
            // schedualIDBindingNavigator
            // 
            this.schedualIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.schedualIDBindingNavigator.BindingSource = this.schedualIDBindingSource;
            this.schedualIDBindingNavigator.CountItem = null;
            this.schedualIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.schedualIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.schedualIDBindingNavigatorSaveItem});
            this.schedualIDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.schedualIDBindingNavigator.MoveFirstItem = null;
            this.schedualIDBindingNavigator.MoveLastItem = null;
            this.schedualIDBindingNavigator.MoveNextItem = null;
            this.schedualIDBindingNavigator.MovePreviousItem = null;
            this.schedualIDBindingNavigator.Name = "schedualIDBindingNavigator";
            this.schedualIDBindingNavigator.PositionItem = null;
            this.schedualIDBindingNavigator.Size = new System.Drawing.Size(340, 25);
            this.schedualIDBindingNavigator.TabIndex = 0;
            this.schedualIDBindingNavigator.Text = "bindingNavigator1";
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
            // schedualIDBindingSource
            // 
            this.schedualIDBindingSource.DataMember = "SchedualID";
            this.schedualIDBindingSource.DataSource = this.quartzDataDataSet;
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
            // schedualIDBindingNavigatorSaveItem
            // 
            this.schedualIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.schedualIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("schedualIDBindingNavigatorSaveItem.Image")));
            this.schedualIDBindingNavigatorSaveItem.Name = "schedualIDBindingNavigatorSaveItem";
            this.schedualIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.schedualIDBindingNavigatorSaveItem.Text = "Save Data";
            this.schedualIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.schedualIDBindingNavigatorSaveItem_Click);
            // 
            // schedualIDTextBox
            // 
            this.schedualIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedualIDBindingSource, "SchedualID", true));
            this.schedualIDTextBox.Location = new System.Drawing.Point(84, 59);
            this.schedualIDTextBox.Name = "schedualIDTextBox";
            this.schedualIDTextBox.Size = new System.Drawing.Size(61, 20);
            this.schedualIDTextBox.TabIndex = 2;
            this.schedualIDTextBox.Visible = false;
            // 
            // bandIDTextBox
            // 
            this.bandIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedualIDBindingSource, "BandID", true));
            this.bandIDTextBox.Location = new System.Drawing.Point(270, 3);
            this.bandIDTextBox.Name = "bandIDTextBox";
            this.bandIDTextBox.Size = new System.Drawing.Size(53, 20);
            this.bandIDTextBox.TabIndex = 4;
            this.bandIDTextBox.Visible = false;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schedualIDBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(51, 33);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(94, 20);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // start_TimeDateTimePicker
            // 
            this.start_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schedualIDBindingSource, "Start Time", true));
            this.start_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start_TimeDateTimePicker.Location = new System.Drawing.Point(233, 33);
            this.start_TimeDateTimePicker.Name = "start_TimeDateTimePicker";
            this.start_TimeDateTimePicker.ShowUpDown = true;
            this.start_TimeDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.start_TimeDateTimePicker.TabIndex = 10;
            // 
            // end_TimeDateTimePicker
            // 
            this.end_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schedualIDBindingSource, "End Time", true));
            this.end_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end_TimeDateTimePicker.Location = new System.Drawing.Point(233, 59);
            this.end_TimeDateTimePicker.Name = "end_TimeDateTimePicker";
            this.end_TimeDateTimePicker.ShowUpDown = true;
            this.end_TimeDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.end_TimeDateTimePicker.TabIndex = 12;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedualIDBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(51, 82);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(272, 55);
            this.noteTextBox.TabIndex = 14;
            // 
            // schedualIDDataGridView
            // 
            this.schedualIDDataGridView.AllowUserToAddRows = false;
            this.schedualIDDataGridView.AllowUserToDeleteRows = false;
            this.schedualIDDataGridView.AutoGenerateColumns = false;
            this.schedualIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedualIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.schedualIDDataGridView.DataSource = this.schedualIDBindingSource;
            this.schedualIDDataGridView.Location = new System.Drawing.Point(15, 143);
            this.schedualIDDataGridView.Name = "schedualIDDataGridView";
            this.schedualIDDataGridView.RowHeadersVisible = false;
            this.schedualIDDataGridView.Size = new System.Drawing.Size(308, 220);
            this.schedualIDDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SchedualID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SchedualID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn3.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Band Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Band Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Start Time";
            dataGridViewCellStyle2.Format = "t";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "End Time";
            dataGridViewCellStyle3.Format = "t";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "End Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn8.HeaderText = "Note";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // band_NameTextBox
            // 
            this.band_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "Band Name", true));
            this.band_NameTextBox.Enabled = false;
            this.band_NameTextBox.Location = new System.Drawing.Point(84, 3);
            this.band_NameTextBox.Name = "band_NameTextBox";
            this.band_NameTextBox.Size = new System.Drawing.Size(239, 20);
            this.band_NameTextBox.TabIndex = 19;
            this.band_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bandIDBindingSource
            // 
            this.bandIDBindingSource.DataMember = "BandID";
            this.bandIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // schedualIDTableAdapter
            // 
            this.schedualIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BandIDTableAdapter = this.bandIDTableAdapter;
            this.tableAdapterManager.MemberIDTableAdapter = null;
            this.tableAdapterManager.PaymentIDTableAdapter = null;
            this.tableAdapterManager.SchedualIDTableAdapter = this.schedualIDTableAdapter;
            this.tableAdapterManager.SongIDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bandIDTableAdapter
            // 
            this.bandIDTableAdapter.ClearBeforeFill = true;
            // 
            // bandIdLbl
            // 
            this.bandIdLbl.AutoSize = true;
            this.bandIdLbl.Location = new System.Drawing.Point(215, 6);
            this.bandIdLbl.Name = "bandIdLbl";
            this.bandIdLbl.Size = new System.Drawing.Size(49, 13);
            this.bandIdLbl.TabIndex = 22;
            this.bandIdLbl.Text = "Band ID:";
            this.bandIdLbl.Visible = false;
            // 
            // schedualIdLbl
            // 
            this.schedualIdLbl.AutoSize = true;
            this.schedualIdLbl.Location = new System.Drawing.Point(12, 62);
            this.schedualIdLbl.Name = "schedualIdLbl";
            this.schedualIdLbl.Size = new System.Drawing.Size(69, 13);
            this.schedualIdLbl.TabIndex = 23;
            this.schedualIdLbl.Text = "Schedual ID:";
            this.schedualIdLbl.Visible = false;
            // 
            // SchedualInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 377);
            this.Controls.Add(this.schedualIdLbl);
            this.Controls.Add(this.bandIdLbl);
            this.Controls.Add(this.schedualIDDataGridView);
            this.Controls.Add(this.schedualIDTextBox);
            this.Controls.Add(this.bandIDTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(start_TimeLabel);
            this.Controls.Add(this.start_TimeDateTimePicker);
            this.Controls.Add(end_TimeLabel);
            this.Controls.Add(this.end_TimeDateTimePicker);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.band_NameTextBox);
            this.Controls.Add(this.schedualIDBindingNavigator);
            this.Name = "SchedualInfo";
            this.Text = "SchedualInfo";
            this.Load += new System.EventHandler(this.SchedualInfo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedualInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.schedualIDBindingNavigator)).EndInit();
            this.schedualIDBindingNavigator.ResumeLayout(false);
            this.schedualIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedualIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedualIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private QuartzDataDataSet quartzDataDataSet;
        private System.Windows.Forms.BindingSource schedualIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.SchedualIDTableAdapter schedualIDTableAdapter;
        private Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator schedualIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton schedualIDBindingNavigatorSaveItem;
        private Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter bandIDTableAdapter;
        private System.Windows.Forms.TextBox schedualIDTextBox;
        private System.Windows.Forms.TextBox bandIDTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker start_TimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_TimeDateTimePicker;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DataGridView schedualIDDataGridView;
        private System.Windows.Forms.BindingSource bandIDBindingSource;
        private System.Windows.Forms.TextBox band_NameTextBox;
        private System.Windows.Forms.Label bandIdLbl;
        private System.Windows.Forms.Label schedualIdLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;


    }
}