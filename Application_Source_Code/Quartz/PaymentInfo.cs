/*  Quartz -PaymentInfo
 *  By Scott Smereka
 *  Copyright January, 2010
 *  
 *  Description: Maintains(edits, adds, deletes) payment information to and from
 *               database ("QuartzData")
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* Added Definitions: */

namespace Quartz
{
    public partial class PaymentInfo : Form
    {
        /* Semi-Global Variables */
        int bandIdNum = -1;     //Stores selected BandID
        bool debugMode = false; //Enables/Disables debug features
        private MainForm parentFrm;

        public PaymentInfo(int bandID, bool debug, MainForm pFrm)
        {//Pre: passed BandID > 0 and debug settings
        //Post: bandIdNum and debugMode are set
            InitializeComponent();
            bandIdNum = bandID;
            debugMode = debug;
            parentFrm = pFrm;
            if (debugMode)    //Check or change debug mode
            {
                changeDebug(debugMode);
            }
        }

        public PaymentInfo()
        {//Pre:
        //Post:
            InitializeComponent();
        }

        public void changeDebug(bool debugMode)
        {//Pre:
        //Post: Hides/Shows debug content
            paymentIDLabel.Visible = debugMode;
            paymentIDTextBox.Visible = debugMode;
            bandIDLabel.Visible = debugMode;
            bandIDTextBox.Visible = debugMode;
        }

        private void paymentIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: saves data to database (auto generated)
            this.Validate();
            this.paymentIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);
        }

        private void PaymentInfo_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'quartzDataDataSet.SongID' table. You can move, or remove it, as needed.
            this.songIDTableAdapter.FillByBandID(this.quartzDataDataSet.SongID, bandIdNum);
//Pre:
        //Post: Fills data feilds based on selected band (bandIdNum)
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.FillBy(this.quartzDataDataSet.BandID, bandIdNum);
            // TODO: This line of code loads data into the 'quartzDataDataSet.PaymentID' table. You can move, or remove it, as needed.
            this.paymentIDTableAdapter.FillBy(this.quartzDataDataSet.PaymentID, bandIdNum);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Fills in BandID column with current BandID (bandIdNum)
            paymentIDTextBox.Text = bandIdNum.ToString(); //Only edits current BandID
            paymentIDDataGridView.Rows[paymentIDDataGridView.Rows.Count - 1].Cells["dataGridViewTextBoxColumn2"].Value = bandIdNum;
        }

        private void updateBalance(int bandIdNum)
        {
            Decimal newBalance = 0;
            //For each song in Database
            for (int x = 0; x < songIDDataGridView.Rows.Count; x++)
            {
                newBalance += Convert.ToDecimal(songIDDataGridView.Rows[x].Cells["dataGridViewTextBoxColumn9"].Value);
                if(Convert.ToBoolean(songIDDataGridView.Rows[x].Cells["dataGridViewCheckBoxColumn1"].Value))
                    newBalance += Convert.ToDecimal(songIDDataGridView.Rows[x].Cells["dataGridViewTextBoxColumn10"].Value);
            }
            for (int y = 0; y < paymentIDDataGridView.Rows.Count; y++)
            {
                newBalance -= Convert.ToDecimal(paymentIDDataGridView.Rows[y].Cells["dataGridViewTextBoxColumn4"].Value);
            }
            //Update Balance in bandID
            this.bandIDTableAdapter.UpdateBalance(newBalance,bandIdNum);
        }

        private void PaymentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateBalance(bandIdNum);
            parentFrm.loadBandList();
        }

    }
}
