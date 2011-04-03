/*  Quartz -SongInfo
 *  By Scott Smereka
 *  Copyright January, 2010
 *  
 *  Description: Maintains(edits, adds, deletes) song information to and from
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
    public partial class SongInfo : Form
    {
        /* Semi-Global Variables */
        int bandIdNum = -1;      //Stores selected BandID
        bool debugMode = false;  //Enables/Disables debug features
        private MainForm parentFrm;

        public SongInfo(int bandID, bool debug, MainForm pFrm)
        {//Pre: passed BandID > 0 and debug settings
        //Post: bandIdNum and debugMode are set
            InitializeComponent();
            bandIdNum = bandID;
            debugMode = debug;
            parentFrm = pFrm;
            if (debugMode)  //Check or change debug mode
            {
                changeDebug(debugMode);
            }
        }

        public SongInfo()
        {//Pre:
        //Post:
            InitializeComponent();
        }

        public void changeDebug(bool debugMode)
        {//Pre: 
        //Post: Hides/Shows debug content
            SongIDLabel.Visible = debugMode;
            songIDTextBox.Visible = debugMode;
            bandIDTextBox.Visible = debugMode;
            BandIDLabel.Visible = debugMode;
        }
        private void SongInfo_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'quartzDataDataSet.PaymentID' table. You can move, or remove it, as needed.
            this.paymentIDTableAdapter.Fill(this.quartzDataDataSet.PaymentID);
//Pre: bandIdNum > 0
        //Post: Fills data using current BandID (aka bandIdNum)
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.FillBy(this.quartzDataDataSet.BandID, bandIdNum);
            // TODO: This line of code loads data into the 'quartzDataDataSet.SongID' table. You can move, or remove it, as needed.
            this.songIDTableAdapter.FillBy(this.quartzDataDataSet.SongID, bandIdNum);

        }

        private void songIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: saves data to database (auto generated)
            this.Validate();
            this.songIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Fills in BandID column with current BandID (bandIdNum)
            songIDDataGridView.Rows[songIDDataGridView.Rows.Count - 1].Cells["dataGridViewTextBoxColumn2"].Value = bandIdNum;  //Only edits current BandID
        }

        private void updateBalance(int bandIdNum)
        {
            Decimal newBalance = 0;
            //For each song in Database
            for (int x = 0; x < songIDDataGridView.Rows.Count; x++)
            {
                newBalance += Convert.ToDecimal(songIDDataGridView.Rows[x].Cells["dataGridViewTextBoxColumn4"].Value);
                if (Convert.ToBoolean(songIDDataGridView.Rows[x].Cells["dataGridViewCheckBoxColumn1"].Value))
                    newBalance += Convert.ToDecimal(songIDDataGridView.Rows[x].Cells["dataGridViewTextBoxColumn5"].Value);
            }
            for (int y = 0; y < paymentIDDataGridView.Rows.Count; y++)
            {
                newBalance -= Convert.ToDecimal(paymentIDDataGridView.Rows[y].Cells["dataGridViewTextBoxColumn13"].Value);
            }
            //Update Balance in bandID
            this.bandIDTableAdapter.UpdateBalance(newBalance, bandIdNum);
        }

        private void SongInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateBalance(bandIdNum);
            parentFrm.loadBandList();
        }
    }
}
