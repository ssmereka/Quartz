using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quartz
{
    public partial class SchedualInfo : Form
    {
        bool debugMode = false;
        int bandIdNum = -1;
        DateTime selectDayTime = DateTime.Today;
        private MainForm parentFrm;

        public SchedualInfo(bool debug, int bandID, DateTime date, MainForm pFrm)
        {
            InitializeComponent();
            bandIdNum = bandID;
            debugMode = debug;
            selectDayTime = date;
            parentFrm = pFrm;

            if (debugMode)
            {
                changeDebug(debugMode);
            }

        }

        private void changeDebug(bool debugMode)
        {
            bandIDTextBox.Visible = debugMode;
            bandIdLbl.Visible = debugMode;
            schedualIDTextBox.Visible = debugMode;
            schedualIdLbl.Visible = debugMode;
        }

        public SchedualInfo()
        {
            InitializeComponent();
        }

        private void schedualIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schedualIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);
            bandIDTextBox.Text = bandIdNum.ToString(); //Only edits current BandID
        }

        private void SchedualInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
        //    this.bandIDTableAdapter.Fill(this.quartzDataDataSet.BandID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.SchedualID' table. You can move, or remove it, as needed.
          //  this.schedualIDTableAdapter.Fill(this.quartzDataDataSet.SchedualID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.FillBy(this.quartzDataDataSet.BandID, bandIdNum);
            // TODO: This line of code loads data into the 'quartzDataDataSet.SchedualID' table. You can move, or remove it, as needed.
            this.schedualIDTableAdapter.FillByBandID(this.quartzDataDataSet.SchedualID, bandIdNum);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bandIDTextBox.Text = bandIdNum.ToString(); //Only edits current BandID
            schedualIDDataGridView.Rows[schedualIDDataGridView.Rows.Count - 1].Cells["dataGridViewTextBoxColumn3"].Value = bandIdNum;
            schedualIDDataGridView.Rows[schedualIDDataGridView.Rows.Count - 1].Cells["dataGridViewTextBoxColumn4"].Value = band_NameTextBox.Text;
            dateDateTimePicker.Value = selectDayTime;
            start_TimeDateTimePicker.Value = selectDayTime;
            end_TimeDateTimePicker.Value = selectDayTime;
        }

        private void schedualIDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void date___TimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //end_Date___TimeDateTimePicker.Value = date___TimeDateTimePicker.Value;
        }

        private void schedualIDBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.schedualIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);

        }

        private void SchedualInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentFrm.BoldDates();
        }

    }
}
