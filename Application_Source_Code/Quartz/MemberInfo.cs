/*  Quartz -MemberInfo
 *  By Scott Smereka
 *  Copyright January, 2010
 *  
 *  Description: Maintains(edits, adds, deletes) band member information to and from
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
    public partial class MemberInfo : Form
    {
        /* Semi-Global Variables */
        int bandIdNum = -1;    //Stores selected BandID
        bool debugMode = false;  //Enables/Disables debug features

        public MemberInfo()
        {
            InitializeComponent();
        }
        public MemberInfo(int bandID, bool debug)
        {//Pre: passed BandID > 0 and debug settings
        //Post: bandIdNum and debugMode are set 
            InitializeComponent();
            bandIdNum = bandID;
            debugMode = debug;
            if (debugMode)  //Check or change debug mode
            {
                changeDebug(debugMode);
            }
        }

        public void changeDebug(bool debugMode)
        {//Pre: 
        //Post: Hides/Shows debug content
            BandIDLabel.Visible = debugMode;
            bandIDTextBox.Visible = debugMode;
            MemberIDLabel.Visible = debugMode;
            memberIDTextBox.Visible = debugMode;
        }

        private void memberIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: saves member info to database (non-commented = auto generated)
            bandIDTextBox.Text = bandIdNum.ToString(); //Only edits current BandID
            this.Validate();
            this.memberIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);

        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Fills data using current BandID (aka bandIdNum)
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.FillBy(this.quartzDataDataSet.BandID, bandIdNum);
            // TODO: This line of code loads data into the 'quartzDataDataSet.MemberID' table. You can move, or remove it, as needed.
            this.memberIDTableAdapter.FillBy(this.quartzDataDataSet.MemberID, bandIdNum);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Fills in BandID column with current BandID (bandIdNum)
            memberIDTextBox.Text = bandIdNum.ToString(); //Only edits current BandID
            memberIDDataGridView.Rows[memberIDDataGridView.Rows.Count - 1].Cells["dataGridViewTextBoxColumn2"].Value = bandIdNum;
        }



        
    }
}
