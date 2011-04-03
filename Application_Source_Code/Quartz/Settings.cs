/*  Quartz -Settings
 *  By Scott Smereka
 *  Copyright January, 2010
 *  
 *  Description: 1) Make changes to the default settings in quartz.
 *                  *All changes are saved to quartz_settings text file.
 *                    -Start with windows
 *                    -Show in taskbar
 *                    -Show notification icon
 *                    -Backup or delete clients removed from database
 *                       *Change directory backup files moved to
 *                       *Both publish and client folder backup options
 *                    -Change visual theme
 *                    -Change Default directories (publish, client, backup)
 *                    -Return to default settings
 *                
 *               2) Add/Edit admins to program.  Admins, if enabled, can access
 *                  privileged data, and make changes to database.
 *                  
 *               3) Add/Remove programs from Toolbar
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* Added Definitions */
using System.IO;     //Added for file writing functionality

namespace Quartz
{
    public partial class Settings : Form
    {
        /* Semi-Global Variables */
        bool debugMode = false;     //Debug Mode on/off
        bool changeOccured = false; //If a change in settings has occured
        bool clientBkp = false;     //Delete or backup "deleted" clients
        bool startWindows = false;  //Start quartz with windows
        bool showTaskbar = false;   //Show quartz in taskbar
        bool showNotifIcon = true;  //Show Notification Icon
        string themeName = "";      //Selected Theme Name

        /* Default Directories */
        string deClientDir = "";     //Client directory
        string dePublishDir = "";    //Publish directory
        string deBackupDir = "";     //Backup directory
        string deBkpClientDir = "";  //Deleted client backup directory
        string deBkpPublishDir = ""; //Deleted publish backup directory
        string main_dir = "";        //Main program directory

        /* Forms */
        private MainForm parentFrm;

        public Settings(bool debug, string mainDir, MainForm pFrm)
        {//Pre: mainDir != null
        //Post: Changes debugMode and sets the main directory
        //      Sets parentFrm
            InitializeComponent();
            debugMode = debug;
            main_dir = mainDir;
            parentFrm = pFrm;
            if (debugMode)
            {
                changeDebug(debugMode);
            }
        }

        public Settings()
        {
            InitializeComponent();
        }

        public void changeDebug(bool debugMode)
        {//Pre:
        //Post: Toggle Debug features,
        //      1. Sets the admin ID visible
            adminIDLabel.Visible = debugMode;
            adminIDTextBox.Visible = debugMode;
        }

        public void loadDefault()
        {//Pre:
        //Post: All items in settings set to default values
        //      Changes applied and change listbox cleared
            clientBackupsCb.Checked = true;              //Bkup Clients removed
            startWithWindowsCb.Checked = true;           //Start with windows
            showInTaskbarCb.Checked = false;             //Dont show in taskbar
            showNotifIconCb.Checked = true;              //Show notification icon
            clientBackupLoc.Text = "Client.old";         //Removed client bkup folder
            publishBackupLoc.Text = "Publish.old";       //Removed publish bkup folder
            ClientDirTxt.Text = "C:\\Quartz\\Clients";   //Client default directory
            PublishDirTxt.Text = "C:\\Quartz\\Publish";  //Publish default directory
            BackupDirTxt.Text = "C:\\Quartz\\Backup";    //Backup default directory
            progDefLb.Items.Clear();                     //Clear all items in change box
            themeSelect.Text = "Default";                //Load Default Theme
            applyChanges();                              //Apply changes
        }
        
        private void showChgDefault()
        {//Pre:
        //Post: Lists all properties that are not default
            progDefLb.Items.Clear(); //Clear any old items
            if(!startWithWindowsCb.Checked)
                progDefLb.Items.Add("Start with windows: True");
            if (showInTaskbarCb.Checked)
                progDefLb.Items.Add("Show in taskbar: False");
            if (!showNotifIconCb.Checked)
                progDefLb.Items.Add("Show notification icon: True");
            if (!clientBackupsCb.Checked)
                progDefLb.Items.Add("Backup removed clients: True");
            if (deClientDir != "C:\\Quartz\\Clients")
                progDefLb.Items.Add("Client folder: C:\\Quartz\\Clients");
            if (dePublishDir != "C:\\Quartz\\Publish")
                progDefLb.Items.Add("Public folder: C:\\Quartz\\Public");
            if (deBackupDir != "C:\\Quartz\\Backup")
                progDefLb.Items.Add("Backup folder: C:\\Quartz\\Backup");
            if (deBkpClientDir != "Client.old")
                progDefLb.Items.Add("Client backup folder name: Client.old");
            if (deBkpPublishDir != "Publish.old")
                progDefLb.Items.Add("Publish backup folder name: Publish.old");
            if (themeName != "Default")
                progDefLb.Items.Add("Theme will change: Default");
        }

        private void adminIDBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {//Pre:
        //Post: (Auto generated) Saves/Validates Admin Database entries
            this.Validate();
            this.adminIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet1);
        }

        private void Settings_Load(object sender, EventArgs e)
        {//Pre:
        //Post: Reads/Loads settings
        //      Updates changes listbox
            // TODO: This line of code loads data into the 'quartzDataDataSet1.AdminID' table. You can move, or remove it, as needed.
            this.adminIDTableAdapter.Fill(this.quartzDataDataSet1.AdminID);
            loadSettings();
            showChgDefault();  //Update changes listbox
            //Check settings worked
        }

        private void ClientBkBrowse_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Shows Dialog and displays directory path selected
            BackupLocation.ShowDialog();
            ClientDirTxt.Text = BackupLocation.SelectedPath.ToString();
        }

        private void PublishBkBrowse_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Shows Dialog and displays directory path selected
            BackupLocation.ShowDialog();
            PublishDirTxt.Text = BackupLocation.SelectedPath.ToString();
        }

        private void BackupBkBtn_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Shows Dialog and displays directory path selected
            BackupLocation.ShowDialog();
            BackupDirTxt.Text = BackupLocation.SelectedPath.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Closes Settings form
            Close();
        }

        public void loadSettings()
        {//Pre:
        //Post: Loads settings from file, or if file DNE, loads defaults
        //      Also fills theme combo box
            if(System.IO.File.Exists(main_dir + "/quartz_settings"))
            {
                TextReader tr = new StreamReader(main_dir + "/quartz_settings");
                while(tr.ReadLine() != "")
                {
                }
                ClientDirTxt.Text         = deClientDir     = tr.ReadLine();
                PublishDirTxt.Text        = dePublishDir    = tr.ReadLine();
                BackupDirTxt.Text         = deBackupDir     = tr.ReadLine();
                clientBackupLoc.Text      = deBkpClientDir  = tr.ReadLine();
                publishBackupLoc.Text     = deBkpPublishDir = tr.ReadLine();
                themeSelect.Text          = themeName       = tr.ReadLine();

                if (tr.ReadLine() == "True")
                    clientBackupsCb.Checked = clientBkp = true;
                else
                    clientBackupsCb.Checked = clientBkp = false;
                if(tr.ReadLine() == "True")
                    startWithWindowsCb.Checked = startWindows = true;
                else
                    startWithWindowsCb.Checked = startWindows = false;
                if(tr.ReadLine() == "True")
                    showInTaskbarCb.Checked = showTaskbar = true;
                else
                    showInTaskbarCb.Checked = showTaskbar = false;
                if (tr.ReadLine() == "True")
                    showNotifIconCb.Checked = showNotifIcon = true;
                else
                    showNotifIconCb.Checked = showNotifIcon = false;
                tr.Close();
                tr.Dispose();
            }
            else
            {
                loadDefault();
            }
            populateThemes();  //Add themes to theme combo box
            enableBkupLoc(clientBackupsCb.Checked);   //Enable/Disable backupLoc

        }

        private void populateThemes()
        {//Pre:
        //Post: Adds all themes found in Theme directory & subdirectories
        //      to the theme combo box.
            List<string> dirs = FileHelper.GetFilesRecursive(main_dir + "/Themes");
            foreach (string p in dirs)
            {
                themeSelect.Items.Add(FileHelper.GetFileName(p));
            }
        }

        private void saveSettings()
        {//Pre:
        //Post: Overwrites existing file, or creates new text file
        //      with current settings.
            if (System.IO.File.Exists(main_dir + "/quartz_settings"))
            {
                try
                {
                    File.Delete(main_dir + "/quartz_settings");
                }
                catch
                {
                    MessageBox.Show("Could not save settings, File: " + main_dir + "/quartz_settings may be in use.");
                }
            }
            TextWriter tw = new StreamWriter(main_dir + "/quartz_settings");
            tw.WriteLine("Quartz Settings");
            tw.WriteLine("---------------");
            tw.WriteLine("Caution:  Do not modify this file, undesired outcomes may result!");
            tw.WriteLine("");
            tw.WriteLine(deClientDir);
            tw.WriteLine(dePublishDir);
            tw.WriteLine(deBackupDir);
            tw.WriteLine(deBkpClientDir);
            tw.WriteLine(deBkpPublishDir);
            tw.WriteLine(themeName);
            tw.WriteLine(clientBkp);
            tw.WriteLine(startWindows);
            tw.WriteLine(showTaskbar);
            tw.WriteLine(showNotifIcon);
            tw.Close();
            tw.Dispose();
        }

        private void applyChanges()
        {//Pre:
        //Post: Saves current form
        //      Sets boolean to allow for written changes on close
            clientBkp = clientBackupsCb.Checked;
            startWindows = startWithWindowsCb.Checked;
            showTaskbar = showInTaskbarCb.Checked;
            showNotifIcon = showNotifIconCb.Checked;
            deBkpClientDir = clientBackupLoc.Text;
            deBkpPublishDir = publishBackupLoc.Text;
            deClientDir = ClientDirTxt.Text;
            dePublishDir = PublishDirTxt.Text;
            deBackupDir = BackupDirTxt.Text;
            themeName = themeSelect.Text;
            changeOccured = true;  //Handels precondition for FormClosing
            showChgDefault();   //Show new changes in default
            if (themeName != "Default")            //If theme not default, load theme
                parentFrm.setTheme(parentFrm.loadTheme(main_dir + "/Themes/" + themeName + "/" + themeName + ".thm"));  //Apply new theme
            else
                parentFrm.loadThemeDefault(parentFrm);
        }

        private void applyGen_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Saves current form
        //      Sets boolean to allow for written changes on close 
            applyChanges();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {//Pre: changeOccured initaly set to false
         //     applyChanges has been called.
        //Post: Calls to write settings to file if a change occured
            if (changeOccured)
            {
                saveSettings();
            }
        }

        private void loadDefaultsBtn_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Deletes settings folder, if it exists
        //      Loads defaults via "loadDefault()"
            if (System.IO.File.Exists(main_dir + "/quartz_settings"))
            {
                try
                {
                    File.Delete(main_dir + "/quartz_settings");
                }
                catch
                {
                    MessageBox.Show("Could not delete file " +
                                     main_dir + "\\quartz_settings\n" +
                                     "File may be in use");
                }
            }
            loadDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBackupLoc.Text = "Client.old";
        }

        private void defPublishBtn_Click(object sender, EventArgs e)
        {
            publishBackupLoc.Text = "Publish.old";
        }

        private void enableBkupLoc(bool option)
        {//Pre:
        //Post: Enables/Disables Backup Locations
            clientBackupLoc.Enabled = option;
            publishBackupLoc.Enabled = option;
            defClientBtn.Enabled = option;
            defPublishBtn.Enabled = option;
        }

        private void clientBackupsCb_CheckedChanged(object sender, EventArgs e)
        {//Pre:
        //Post: Enables or disables backup locations, if checked or unchecked
            enableBkupLoc(clientBackupsCb.Checked);
        }
    }

    static class FileHelper
    {
        public static List<string> GetFilesRecursive(string b)
        {//Pre: Passed a directory that exists and not in use.
        //Post: Return list of files found in dir & subdirectories of 
        //      dir "b" with the file name .thm
            List<string> result = new List<string>();
            Stack<string> stack = new Stack<string>();  //Stack of directories

            stack.Push(b);  //Push directory
            while (stack.Count > 0)  //While more directories
            {
                string dir = stack.Pop();  //Get top directory
                try
                {
                    result.AddRange(Directory.GetFiles(dir, "*.thm*")); //Add all files to result
                    foreach (string dn in Directory.GetDirectories(dir)) //Add all other directories found
                    {
                        stack.Push(dn);
                    }
                }
                catch  //Couldnt open a directory
                {
                    MessageBox.Show("Themes were not properly loaded.\nCould not access a directory " + dir);
                }
            }
            return result;
        }

        public static string GetFileName(string a)
        {//Pre: given full file path "a"
        //Post: Returns filename - .thm
            string b = System.IO.Path.GetFileName(a);
            return b.Substring(0,b.Length-4);
        }
    }
}
