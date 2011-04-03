namespace Quartz
{
    partial class BalanceInfo
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
            this.quartzDataDataSet = new Quartz.QuartzDataDataSet();
            this.bandIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter();
            this.tableAdapterManager = new Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager();
            this.bandIDDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.PaymentIDTableAdapter();
            this.paymentIDDataGridView = new System.Windows.Forms.DataGridView();
            this.songIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songIDTableAdapter = new Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter();
            this.songIDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quartzDataDataSet
            // 
            this.quartzDataDataSet.DataSetName = "QuartzDataDataSet";
            this.quartzDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandIDBindingSource
            // 
            this.bandIDBindingSource.DataMember = "BandID";
            this.bandIDBindingSource.DataSource = this.quartzDataDataSet;
            // 
            // bandIDTableAdapter
            // 
            this.bandIDTableAdapter.ClearBeforeFill = true;
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
            // bandIDDataGridView
            // 
            this.bandIDDataGridView.AllowUserToAddRows = false;
            this.bandIDDataGridView.AllowUserToDeleteRows = false;
            this.bandIDDataGridView.AutoGenerateColumns = false;
            this.bandIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bandIDDataGridView.DataSource = this.bandIDBindingSource;
            this.bandIDDataGridView.Location = new System.Drawing.Point(12, 37);
            this.bandIDDataGridView.Name = "bandIDDataGridView";
            this.bandIDDataGridView.ReadOnly = true;
            this.bandIDDataGridView.RowHeadersVisible = false;
            this.bandIDDataGridView.Size = new System.Drawing.Size(230, 295);
            this.bandIDDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.paymentIDDataGridView.DataSource = this.paymentIDBindingSource;
            this.paymentIDDataGridView.Location = new System.Drawing.Point(248, 37);
            this.paymentIDDataGridView.Name = "paymentIDDataGridView";
            this.paymentIDDataGridView.ReadOnly = true;
            this.paymentIDDataGridView.RowHeadersVisible = false;
            this.paymentIDDataGridView.Size = new System.Drawing.Size(310, 295);
            this.paymentIDDataGridView.TabIndex = 2;
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
            this.songIDDataGridView.Location = new System.Drawing.Point(564, 37);
            this.songIDDataGridView.Name = "songIDDataGridView";
            this.songIDDataGridView.ReadOnly = true;
            this.songIDDataGridView.RowHeadersVisible = false;
            this.songIDDataGridView.Size = new System.Drawing.Size(436, 295);
            this.songIDDataGridView.TabIndex = 3;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn4.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BandID";
            this.dataGridViewTextBoxColumn6.HeaderText = "BandID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Payment Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Payment Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Method";
            this.dataGridViewTextBoxColumn9.HeaderText = "Method";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripButton8,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Quartz.Properties.Resources.admin;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Quartz.Properties.Resources.show_info;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Quartz.Properties.Resources.music_note;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Quartz.Properties.Resources.DollarsignBlockcrop;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Quartz.Properties.Resources.dollar_sign;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Quartz.Properties.Resources.show_info;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Quartz.Properties.Resources.admin;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Quartz.Properties.Resources.music_note;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // BalanceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 349);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.songIDDataGridView);
            this.Controls.Add(this.paymentIDDataGridView);
            this.Controls.Add(this.bandIDDataGridView);
            this.Name = "BalanceInfo";
            this.Text = "BalanceInfo";
            this.Load += new System.EventHandler(this.BalanceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quartzDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songIDDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuartzDataDataSet quartzDataDataSet;
        private System.Windows.Forms.BindingSource bandIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.BandIDTableAdapter bandIDTableAdapter;
        private Quartz.QuartzDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bandIDDataGridView;
        private Quartz.QuartzDataDataSetTableAdapters.PaymentIDTableAdapter paymentIDTableAdapter;
        private System.Windows.Forms.BindingSource paymentIDBindingSource;
        private Quartz.QuartzDataDataSetTableAdapters.SongIDTableAdapter songIDTableAdapter;
        private System.Windows.Forms.DataGridView paymentIDDataGridView;
        private System.Windows.Forms.BindingSource songIDBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView songIDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
    }
}