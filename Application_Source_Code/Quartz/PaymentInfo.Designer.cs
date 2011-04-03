namespace Quartz
{
    partial class PaymentInfo
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
            System.Windows.Forms.Label payment_DateLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label methodLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentInfo));
            this.paymentIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.paymentIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentIDTextBox = new System.Windows.Forms.TextBox();
            this.bandIDTextBox = new System.Windows.Forms.TextBox();
            this.payment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.methodTextBox = new System.Windows.Forms.TextBox();
            this.paymentIDDataGridView = new System.Windows.Forms.DataGridView();
            this.band_NameTextBox = new System.Windows.Forms.TextBox();
            this.paymentIDLabel = new System.Windows.Forms.Label();
            this.bandIDLabel = new System.Windows.Forms.Label();
            this.songIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartzDataDataSet = new Quartz.QuartzDataDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.PaymentIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager();
            this.bandIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter();
            this.songIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter();
            payment_DateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            methodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingNavigator)).BeginInit();
            this.paymentIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_DateLabel
            // 
            payment_DateLabel.AutoSize = true;
            payment_DateLabel.Location = new System.Drawing.Point(12, 38);
            payment_DateLabel.Name = "payment_DateLabel";
            payment_DateLabel.Size = new System.Drawing.Size(77, 13);
            payment_DateLabel.TabIndex = 5;
            payment_DateLabel.Text = "Payment Date:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(12, 63);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            // 
            // methodLabel
            // 
            methodLabel.AutoSize = true;
            methodLabel.Location = new System.Drawing.Point(12, 89);
            methodLabel.Name = "methodLabel";
            methodLabel.Size = new System.Drawing.Size(46, 13);
            methodLabel.TabIndex = 9;
            methodLabel.Text = "Method:";
            // 
            // paymentIDBindingNavigator
            // 
            this.paymentIDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentIDBindingNavigator.BindingSource = this.paymentIDBindingSource;
            this.paymentIDBindingNavigator.CountItem = null;
            this.paymentIDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.paymentIDBindingNavigatorSaveItem});
            this.paymentIDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentIDBindingNavigator.MoveFirstItem = null;
            this.paymentIDBindingNavigator.MoveLastItem = null;
            this.paymentIDBindingNavigator.MoveNextItem = null;
            this.paymentIDBindingNavigator.MovePreviousItem = null;
            this.paymentIDBindingNavigator.Name = "paymentIDBindingNavigator";
            this.paymentIDBindingNavigator.PositionItem = null;
            this.paymentIDBindingNavigator.Size = new System.Drawing.Size(311, 25);
            this.paymentIDBindingNavigator.TabIndex = 0;
            this.paymentIDBindingNavigator.Text = "bindingNavigator1";
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
            // paymentIDBindingNavigatorSaveItem
            // 
            this.paymentIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentIDBindingNavigatorSaveItem.Image")));
            this.paymentIDBindingNavigatorSaveItem.Name = "paymentIDBindingNavigatorSaveItem";
            this.paymentIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentIDBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentIDBindingNavigatorSaveItem_Click);
            // 
            // paymentIDTextBox
            // 
            this.paymentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentIDBindingSource, "PaymentID", true));
            this.paymentIDTextBox.Enabled = false;
            this.paymentIDTextBox.Location = new System.Drawing.Point(84, 5);
            this.paymentIDTextBox.Name = "paymentIDTextBox";
            this.paymentIDTextBox.Size = new System.Drawing.Size(51, 20);
            this.paymentIDTextBox.TabIndex = 2;
            this.paymentIDTextBox.Visible = false;
            this.paymentIDTextBox.WordWrap = false;
            // 
            // bandIDTextBox
            // 
            this.bandIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentIDBindingSource, "BandID", true));
            this.bandIDTextBox.Enabled = false;
            this.bandIDTextBox.Location = new System.Drawing.Point(244, 5);
            this.bandIDTextBox.Name = "bandIDTextBox";
            this.bandIDTextBox.Size = new System.Drawing.Size(51, 20);
            this.bandIDTextBox.TabIndex = 4;
            this.bandIDTextBox.Visible = false;
            this.bandIDTextBox.WordWrap = false;
            // 
            // payment_DateDateTimePicker
            // 
            this.payment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentIDBindingSource, "Payment Date", true));
            this.payment_DateDateTimePicker.Location = new System.Drawing.Point(95, 34);
            this.payment_DateDateTimePicker.Name = "payment_DateDateTimePicker";
            this.payment_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.payment_DateDateTimePicker.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentIDBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(95, 60);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountTextBox.TabIndex = 8;
            // 
            // methodTextBox
            // 
            this.methodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentIDBindingSource, "Method", true));
            this.methodTextBox.Location = new System.Drawing.Point(95, 86);
            this.methodTextBox.Name = "methodTextBox";
            this.methodTextBox.Size = new System.Drawing.Size(200, 20);
            this.methodTextBox.TabIndex = 10;
            // 
            // paymentIDDataGridView
            // 
            this.paymentIDDataGridView.AllowUserToAddRows = false;
            this.paymentIDDataGridView.AllowUserToDeleteRows = false;
            this.paymentIDDataGridView.AutoGenerateColumns = false;
            this.paymentIDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.paymentIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.paymentIDDataGridView.DataSource = this.paymentIDBindingSource;
            this.paymentIDDataGridView.Location = new System.Drawing.Point(15, 112);
            this.paymentIDDataGridView.Name = "paymentIDDataGridView";
            this.paymentIDDataGridView.RowHeadersVisible = false;
            this.paymentIDDataGridView.Size = new System.Drawing.Size(280, 277);
            this.paymentIDDataGridView.TabIndex = 11;
            // 
            // band_NameTextBox
            // 
            this.band_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandIDBindingSource, "Band Name", true));
            this.band_NameTextBox.Enabled = false;
            this.band_NameTextBox.Location = new System.Drawing.Point(84, 5);
            this.band_NameTextBox.Name = "band_NameTextBox";
            this.band_NameTextBox.Size = new System.Drawing.Size(211, 20);
            this.band_NameTextBox.TabIndex = 15;
            this.band_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paymentIDLabel
            // 
            this.paymentIDLabel.AutoSize = true;
            this.paymentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIDLabel.Location = new System.Drawing.Point(82, 25);
            this.paymentIDLabel.Name = "paymentIDLabel";
            this.paymentIDLabel.Size = new System.Drawing.Size(47, 9);
            this.paymentIDLabel.TabIndex = 16;
            this.paymentIDLabel.Text = "Payment ID:";
            this.paymentIDLabel.Visible = false;
            // 
            // bandIDLabel
            // 
            this.bandIDLabel.AutoSize = true;
            this.bandIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandIDLabel.Location = new System.Drawing.Point(242, 25);
            this.bandIDLabel.Name = "bandIDLabel";
            this.bandIDLabel.Size = new System.Drawing.Size(34, 9);
            this.bandIDLabel.TabIndex = 17;
            this.bandIDLabel.Text = "Band ID:";
            this.bandIDLabel.Visible = false;
            // 
            // songIDDataGridView
            // 
            this.songIDDataGridView.AllowUserToAddRows = false;
            this.songIDDataGridView.AllowUserToDeleteRows = false;
            this.songIDDataGridView.AutoGenerateColumns = false;
            this.songIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn10});
            this.songIDDataGridView.DataSource = this.songIDBindingSource;
            this.songIDDataGridView.Location = new System.Drawing.Point(15, 25);
            this.songIDDataGridView.Name = "songIDDataGridView";
            this.songIDDataGridView.ReadOnly = true;
            this.songIDDataGridView.Size = new System.Drawing.Size(10, 10);
            this.songIDDataGridView.TabIndex = 17;
            this.songIDDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SongID";
            this.dataGridViewTextBoxColumn6.HeaderText = "SongID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn7.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Song Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Song Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Mastered";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Mastered";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mastered Price";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mastered Price";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // songIDBindingSource
            // 
            this.songIDBindingSource.DataMember = "SongID";
            this.songIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // quartzDataDataSet
            // 
            this.quartzDataDataSet.DataSetName = "QuartzDataDataSet";
            this.quartzDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaymentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 49;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Payment Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Payment Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 68;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Method";
            this.dataGridViewTextBoxColumn5.HeaderText = "Method";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 68;
            // 
            // paymentIDBindingSource
            // 
            this.paymentIDBindingSource.DataMember = "PaymentID";
            this.paymentIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // bandIDBindingSource
            // 
            this.bandIDBindingSource.DataMember = "BandID";
            this.bandIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // paymentIDTableAdapter
            // 
            this.paymentIDTableAdapter.ClearBeforeFill = true;
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
            // songIDTableAdapter
            // 
            this.songIDTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 409);
            this.Controls.Add(this.songIDDataGridView);
            this.Controls.Add(this.bandIDLabel);
            this.Controls.Add(this.paymentIDLabel);
            this.Controls.Add(this.paymentIDDataGridView);
            this.Controls.Add(this.paymentIDTextBox);
            this.Controls.Add(this.bandIDTextBox);
            this.Controls.Add(payment_DateLabel);
            this.Controls.Add(this.payment_DateDateTimePicker);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(methodLabel);
            this.Controls.Add(this.methodTextBox);
            this.Controls.Add(this.band_NameTextBox);
            this.Controls.Add(this.paymentIDBindingNavigator);
            this.Name = "PaymentInfo";
            this.Text = "PaymentInfo";
            this.Load += new System.EventHandler(this.PaymentInfo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingNavigator)).EndInit();
            this.paymentIDBindingNavigator.ResumeLayout(false);
            this.paymentIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuartzDataDataSet quartzDataDataSet;
        private System.Windows.Forms.BindingSource paymentIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.PaymentIDTableAdapter paymentIDTableAdapter;
        private Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton paymentIDBindingNavigatorSaveItem;
        private Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter bandIDTableAdapter;
        private System.Windows.Forms.TextBox paymentIDTextBox;
        private System.Windows.Forms.TextBox bandIDTextBox;
        private System.Windows.Forms.DateTimePicker payment_DateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox methodTextBox;
        private System.Windows.Forms.DataGridView paymentIDDataGridView;
        private System.Windows.Forms.BindingSource bandIDBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox band_NameTextBox;
        private System.Windows.Forms.Label paymentIDLabel;
        private System.Windows.Forms.Label bandIDLabel;
        private Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter songIDTableAdapter;
        private System.Windows.Forms.BindingSource songIDBindingSource;
        private System.Windows.Forms.DataGridView songIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}