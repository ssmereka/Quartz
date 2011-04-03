/*  Quartz -BandInfo
 *  By Scott Smereka
 *  Copyright January, 2010
 *  
 *  Description: Maintains(edits, adds, deletes) band information to and from
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
using System.IO;           //Added for file and folder functions
using System.Collections;  //Added for ArrayList functionality

namespace Quartz
{
    public partial class BandInfo : Form
    {
        public enum Sync { MKCHANGE = 1, NOCHANGE = 0, PROMPT = 2 };
        public enum TFF { TRUE = 1, FALSE = 0, FAIL = 2 };
        /* Semi-Global Variables */
        bool debugMode = false;      //Enables/Disables debug features
        int bandIdNum = -1;          //Stores selected BandID  
        bool changeOccured = false;  //True if save/add is clicked
        bool notSaved = false;       //True if add clicked, false when save clicked
        bool promptResult = false;
        
        /* Arrays, Dictionaries, Lists */

        /* Index.html Lock Files */
        static string indexLock = "Files are posted but currently not available. This could be due to an outstanding balance. Please contact Admin@suppresspro.com for further information.";
        static string indexNoFiles = "No files are currently available for download. Please try again later";
        static string indexNoPermission = "URL navigation canceled.  You do not have permission to access this portion.";

        /* Default Directories */
        string deClientDir = "C:/Quartz/Clients";
        string dePublishDir = "C:/Quartz/Publish";
        string deBackupDir = "C:/Quartz/Backup";
        string deBkupClientDir = "/Client.old";
        string deBkupPublishDir = "/Publish.old";

        private MainForm parentFrm; 

        public BandInfo(bool debug, MainForm pfrm, 
                        string clientDir, string publishDir, 
                        string backupDir, string bkupClientDir,
                        string bkupPublishDir)
        {//Pre: 
        //Post: bandIdNum and debugMode are set
            InitializeComponent();
            debugMode = debug;
            parentFrm = pfrm;

            /* Set Default Directories */
            deClientDir = clientDir;    
            dePublishDir = publishDir;
            deBackupDir = backupDir;
            deBkupClientDir = bkupClientDir;
            deBkupPublishDir = bkupPublishDir;

            if (debugMode)   //Check or change debug mode
            {
                changeDebug(debugMode);
            }

        }

        public BandInfo()
        {
            InitializeComponent();
        }

        public void changeDebug(bool debugMode)
        {//Pre:
        //Post: Hides/Shows debug content
            bandIDLabel.Visible = debugMode;
            bandIDTextBox.Visible = debugMode;
            MemberIDLabel.Visible = debugMode;
            memberIDTextBox.Visible = debugMode;
            SongIDLabel.Visible = debugMode;
            songIDTextBox.Visible = debugMode;
        }

        private void bandIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: saves data to database (auto generated)
        //      sets changeOcured and not saved
            this.Validate();
            this.bandIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);
            //End Auto generated
            changeOccured = true;
            notSaved = false;
        }

        private void BandInfo_Load(object sender, EventArgs e)
        {//Pre:
        //Post: Fills data feilds from database (auto generated)
            // TODO: This line of code loads data into the 'quartzDataDataSet.SongID' table. You can move, or remove it, as needed.
            this.songIDTableAdapter.Fill(this.quartzDataDataSet.SongID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.MemberID' table. You can move, or remove it, as needed.
            this.memberIDTableAdapter.Fill(this.quartzDataDataSet.MemberID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.Fill(this.quartzDataDataSet.BandID);
            bandIDDataGridView.Sort(dataGridViewTextBoxColumn2, ListSortDirection.Ascending);  //Sort Data
           manageFolders(Sync.PROMPT);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Auto sets password to "changeme"
        //      sets notSaved and changeOccured
            if (passwordTextBox.Text == "")  //Handles NULL password PreCondition
            {
                passwordTextBox.Text = "changeme";
            }
            notSaved = true;
            changeOccured = true;
        }

        private void bandIDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Pre:
        //Post: Fills tables with selected BandID sub-information
        //      Makes editMember, editSong, editPayment Visible
            editMember.Visible = true;  //Handles editMember  PreCondition
            editSong.Visible = true;    //Handles editSong    PreCondition
            editPayment.Visible = true; //Handles editPayment PreCondition
            bandIdNum = Convert.ToInt32(bandIDDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value); //bandIdNum = BandID of selected cell
            this.memberIDTableAdapter.FillBy(this.quartzDataDataSet.MemberID, bandIdNum);  //Fills member Table based on Band selected
            this.songIDTableAdapter.FillBy(this.quartzDataDataSet.SongID, bandIdNum);      //Fills song table based on Band selected
        }

        private void editMember_Click(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Show MemberInfo Form,
        //      passes selected bandID (via bandIdNum) 
        //      passes debug Mode
            MemberInfo form = new MemberInfo(bandIdNum,debugMode);
            form.ShowDialog();

        }

        private void bandIDBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Show SongInfo Form,
        //      passes selected bandID (via bandIdNum)
        //      passes debug Mode
            SongInfo form = new SongInfo(bandIdNum, debugMode, parentFrm);
            form.ShowDialog();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {//Pre: bandIdNum > 0
        //Post: Show PaymentInfo Form,
        //      passes selected bandID (via bandIdNum)
        //      passes debug Mode
            PaymentInfo form = new PaymentInfo(bandIdNum, debugMode, parentFrm);
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Shows/Hides password
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Hides member, payment, and song buttons
            editMember.Visible = false;  //
            editPayment.Visible = false;
            editSong.Visible = false;
            notSaved = true;
        }

        private bool fileExist(string location, string folder )
        {//Pre:
        //Post: if file exists, return true, otherwise return false
            if (System.IO.Directory.Exists(location + "/" + folder))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void manageFolders(Sync option)
        {
            if (syncFolders(deClientDir, option, deBkupClientDir) != TFF.FAIL)
            {
                if (syncFolders(dePublishDir, Sync.MKCHANGE, deBkupPublishDir ) == TFF.FAIL)
                {
                   // MessageBox.Show("Failed: " + dePublishDir);
                }
            }
            else
            {
              //  MessageBox.Show("Failed: " + deClientDir);
            }
        }


        private TFF syncFolders(string directory, Sync option, string bkSubDir)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(directory);
            ArrayList dirList = new ArrayList();
            ArrayList dbList = new ArrayList();
            ArrayList buffer = new ArrayList();

            if (!dir.Exists)  //Create directory, if DNE
            {
                try
                {
                    dir.Create();
                }
                catch
                {
                    MessageBox.Show("Error creating folder " + dir.Name);
                    return TFF.FAIL;
                }
            }
            foreach (System.IO.DirectoryInfo y in dir.GetDirectories())  //Fill dirList with directories in "directory"
            {
                dirList.Add(y.Name);
            }
            for (int x = 0; x < bandIDDataGridView.RowCount; x++)  ////Fill DBList with bands in database
            {
                dbList.Add(Convert.ToString(bandIDDataGridView.Rows[x].Cells["dataGridViewTextBoxColumn2"].Value).Trim());
            }
            foreach (string a in dbList)  //Find any folders in dir that match files in database
            {
                foreach (string b in dirList)
                {
                    if (a == b)
                    {
                        buffer.Add(a);
                    }
                }
            }
            foreach (string c in buffer) //Remove any folders added to buffer
            {
                dbList.Remove(c);
                dirList.Remove(c);
            }
            if (option == Sync.MKCHANGE)
            {
                if (syncFoldersHelper(dbList, dirList, directory, bkSubDir))
                    return TFF.TRUE;
                else
                    return TFF.FAIL;
            }
            else if (option == Sync.PROMPT)
            {
                string temp = "Quartz Client folders have been changed ";
                temp += "outside of the program.  Would you like to allow quartz to ";
                temp += "overwrite these changes?";
                if (dbList.Count > 0 || dirList.Count > 0)
                {
                    promptResult = prompt(temp);
                    if (promptResult)
                    {
                        if (syncFoldersHelper(dbList, dirList, directory, bkSubDir))
                            return TFF.TRUE;
                        else
                            return TFF.FAIL;
                    }
                }
                else
                {
                    return TFF.FALSE;  //Nothing in folder
                }
            }
            else if (dbList.Count == 0 && dirList.Count == 0)
            {
                return TFF.TRUE;
            }
            else
            {
                return TFF.FALSE;
            }
            return TFF.FAIL;
        }

        private bool syncFoldersHelper(ArrayList dbList, ArrayList dirList, string directory, string bkSubDir)
        {
            if (!System.IO.Directory.Exists(deBackupDir + bkSubDir))      //If Backup Clients doesn't exist, create it
            {
                try
                {
                    System.IO.Directory.CreateDirectory(deBackupDir + bkSubDir);
                }
                catch
                {
                    MessageBox.Show("Could not create folder " + deBackupDir + bkSubDir);
                    return false;
                }
            }
            
            System.IO.DirectoryInfo bkDir = new System.IO.DirectoryInfo(deBackupDir + bkSubDir);
            ArrayList bkDirList = new ArrayList();
            bool duplicateFile = false;

            foreach (System.IO.DirectoryInfo x in bkDir.GetDirectories())  //Fill bkDir with directories in "deBackupDir"
            {
                bkDirList.Add(x.Name);
            }
            foreach (string a in dbList)
            {
                try
                {
                    foreach (string bk in bkDirList)
                    {
                        if(a == bk)
                        {
                            Directory.Move(deBackupDir + bkSubDir + "/" + a, directory + "/" + a);
                            break;
                        }
                    }
                    if (!System.IO.Directory.Exists(directory + "/" + a))
                    {
                        CreateFolder(directory, a);
                    }
                }
                catch
                {
                    MessageBox.Show("Could not create Folder " + a);
                }
            }

            GC.Collect();                    //Remove garbage
            GC.WaitForPendingFinalizers();   //wait till done removing garbage

            foreach (string b in dirList)    //Move files not in database to backup folder
            {
                try
                {
                    duplicateFile = moveHelper(deBackupDir + bkSubDir +"/" + b);        //Check that backup file doesnt already exist
                    Directory.Move(directory + "/" + b, deBackupDir + bkSubDir + "/" + b);  //Move File to backup folder
                    //OPTION:  Can also delete file  //  Directory.Delete(deClientDir + "/" + b);
                }
                catch   //Collect garbage and try again.
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    MessageBox.Show("Error: Quartz could not delete file.\nPress ok to try again.");
                    duplicateFile = moveHelper(deBackupDir + bkSubDir + "/" + b);        //Check that backup file doesnt already exist
                    Directory.Move(directory + "/" + b, deBackupDir + bkSubDir + "/" + b);
                }
            }
            return true;
            //Move folders in dirList
        }

        private bool prompt(string message)
        {
            string caption = "Attention";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    return true;
                    //break;
                case DialogResult.No:
                    return false;
                   // break;
            }
            return false;
        }

        private bool moveHelper(string folderName)
        {//Pre: main directory already exists
        //Post: If folder already exists, add a number to the end, return true
        //      otherwise return false
            if (!System.IO.Directory.Exists(folderName))  //If folder isnt already backedup return false
            {
                return false;
            }

            int x = 1;            
            while(System.IO.Directory.Exists(folderName + x.ToString()))  //Find a new name for previous backup
            {
                x++;
            }
            try
            {
                System.IO.Directory.Move(folderName, folderName + x.ToString()); //change old backup to new found name
            }
            catch
            {
                MessageBox.Show("Move " + folderName + " to " + folderName + x.ToString() + " failed");
            }
            return true;
        }
                    
        private void BandInfo_FormClosing(object sender, FormClosingEventArgs e)
        {//Pre:
        //Post: If changed occured syncs folders (adding or moves as necessary)

            //Handel edit

            if (changeOccured)
            {
                if (notSaved)
                {
                    MessageBox.Show("Changes were not saved");
                }
                else
                {
                    manageFolders(Sync.MKCHANGE); //Create/sync folders with the database
                }
                parentFrm.loadBandList();   //Reload/Refresh bandID Table Gridview
            }
        }
        
        public void CreateFolder(string activeDir, string subDirName)
        {//Pre: 
        //Post: Creates a folder and all directories leading too it.
            try
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(activeDir, subDirName));
            }
            catch
            {
                MessageBox.Show("An error occured creating a folder " + activeDir + subDirName);
            }
        }

        private void writeFile(string data, string filename, string location)
        {//Pre:
        //Post: writes data to a file in location specified
            if (System.IO.File.Exists(location + "/" + filename))
                File.Delete(location + "/" + filename);
            TextWriter tw = new StreamWriter(location + "/" + filename);
            tw.WriteLine(data);
            tw.Close();
            tw.Dispose();
        }

    }
}
