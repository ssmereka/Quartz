/*  Quartz
 *  By Scott Smereka
 *  Copyright January, 2010
 *  
 *  Description: 
 *    Database        - Holds/Manipulates SuppressPro Client-tell Data
 *                      *Band/Contact info
 *                      *Payroll
 *    Workstation     - Adds more functionality and tools to a workstation
 *                      *Display options
 *                      *Opens/stores client porfolio
 *                      *Various tools included with install
 *    Automates Tasks - Automates repetative tasks
 *                      *Updating client info in various other tools
 *                      *Keeps website and publish material updated
 *                      *Organizes workstation
 *                      *Keeps security files and statments up-to-date
*/


/* TODO:
 *        *See Outlook, Excel, Word functions
 *        *See bandID Data Gridview Click function
 *        *See openFolder quick menu button
 */

/* Auto-generated References */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* Added Definitions */
using System.IO;
using Microsoft.Win32;              //Added for registry edits
using System.Collections;           //Added for Arraylist

namespace Quartz
{
    public partial class MainForm : Form
    {

        /* Semi-Global Variables */
        bool debugMode = false;                     //Enables/Disables debug features
        int bandIdNum = -1;                         //Stores currently selected bandID
        string bandName = "";                       //Stores currently selected band Name
        string main_dir = "";                       //Stores quartz program directory
        string themeName = "Default";
        
        DateTime selectDateTime = DateTime.Today;   //Stores currently selected Date/Time
        Decimal selectMonth = DateTime.Today.Month;
        Decimal selectDay = DateTime.Today.Day;
        Decimal selectYear = DateTime.Today.Year;

        //ArrayList dateSched = new ArrayList();
        DateTime[] dateSched;

        bool clientBkp = true;
        bool startWindows = true;
        bool showTaskbar = false;
        bool showNotifyIcon = true;

        /* Registry Locations */
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        /* Default Directories */
        string deClientDir = "C:/Quartz/Clients";   //Stores Clients current default directory
        string dePublishDir = "C:/Quartz/Publish";  //Stores Publish current default directory
        string deBackupDir = "C:/Quartz/Backup";    //Stores Backup current default directory
        string deBkupClientDir = "/Clients.old";
        string deBkupPublishDir = "/Publish.old";

        public MainForm()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {//Pre:
        //Post: Fills band grid view with all bands (auto generated)

            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.Fill(this.quartzDataDataSet.BandID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.PaymentID' table. You can move, or remove it, as needed.
            this.paymentIDTableAdapter.Fill(this.quartzDataDataSet.PaymentID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.SongID' table. You can move, or remove it, as needed.
            this.songIDTableAdapter.Fill(this.quartzDataDataSet.SongID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.SchedualID' table. You can move, or remove it, as needed.
            this.schedualIDTableAdapter.Fill(this.quartzDataDataSet.SchedualID);

            main_dir = Path.GetDirectoryName(Application.ExecutablePath);  //Gets the program directory
            loadSettings();
            BoldDates();
        }

        private void loadThemeDefaultHelper(Control control)
        {
            control.BackColor = SystemColors.Control;//System.Drawing.Color.Black;//SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;
            if (control.HasChildren)
            {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls)
                {
                    loadThemeDefaultHelper(childControl);
                }
            }
        }

        public void loadThemeDefault(Control control)
        {
            loadThemeDefaultHelper(control);
            //Change MenuStrip
            menuStrip1.ForeColor = System.Drawing.Color.Black;
            fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            OptionsMenu.ForeColor = System.Drawing.Color.Black;
            toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            contentToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            //Remove toolstrip3
            toolStrip3.Visible = false;
            //Change Background
            this.BackgroundImage = null;
            //Change Gridview
            bandIDDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            schedualIDDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            //Change Textbox
            balanceTxt.BackColor = SystemColors.Window;
            balanceTxt.ForeColor = SystemColors.WindowText;
            noteTextBox.BackColor = SystemColors.Window;
            noteTextBox.ForeColor = SystemColors.WindowText;
            //Change Labels
            balanceLbl.BackColor = SystemColors.Control;
            balanceLbl.ForeColor = SystemColors.WindowText;

            themeToolStripMenuItem.Checked = false;  //Uncheck theme
        }

        public ArrayList loadTheme(String themeFile)
        {
            ArrayList themeSettings = new ArrayList();
            string buffer = "";
            if (System.IO.File.Exists(themeFile))
            {
                TextReader tr = new StreamReader(themeFile);
                buffer = tr.ReadLine();
                bool ignore = false;
                while (buffer != null)  //Not at end of file
                {
                    if (buffer != "")
                    {
                        switch (buffer.Substring(0, 1))
                        {
                            
                            case "/":
                            case "*":
                            case "+":
                            case "&":
                            case "$":
                            case "#": ignore = true;
                                break;
                        }
                        if (!ignore)
                        {
                            themeSettings.Add(buffer.Trim());
                        }
                    }
                    buffer = tr.ReadLine();
                    ignore = false;
                }
                return themeSettings;
            }
            else
            {
                MessageBox.Show("Theme settings could not be found in directory: " + themeFile);
            }
            return null;
        }

        private System.Drawing.Color setThemeHelper(String color)
        {
            switch (color)
            {
                case "Black":
                    return System.Drawing.Color.Black;
                case "White":
                    return System.Drawing.Color.White;
                case "NULL": 
                    return System.Drawing.Color.Empty;
            }
            return System.Drawing.Color.Empty;
        }

        public void setTheme(ArrayList themeSettings)
        {
            if (themeSettings != null)
            {

                //Theme Name
                //themeSettings[0]

                //Change Background
                if (themeSettings[1] != null)
                {
                    Bitmap image = (Bitmap)Image.FromFile(main_dir + "/" + themeSettings[1].ToString());
                    this.BackgroundImage = image;
                }
                else
                {
                    this.BackColor = setThemeHelper(themeSettings[2].ToString());
                }

                //Change Textbox
                balanceTxt.BackColor = setThemeHelper(themeSettings[3].ToString());
                balanceTxt.ForeColor = setThemeHelper(themeSettings[4].ToString());
                noteTextBox.BackColor = setThemeHelper(themeSettings[3].ToString());
                noteTextBox.ForeColor = setThemeHelper(themeSettings[4].ToString());

                //Change Labels
                balanceLbl.BackColor = setThemeHelper(themeSettings[5].ToString());
                balanceLbl.ForeColor = setThemeHelper(themeSettings[6].ToString());

                //Change Gridviews
                bandIDDataGridView.BackgroundColor = setThemeHelper(themeSettings[7].ToString());
                schedualIDDataGridView.BackgroundColor = setThemeHelper(themeSettings[7].ToString());

                //Change Toolstrip Menus
                if (themeSettings[8].ToString() == "False")
                    toolStrip3.Visible = false;
                else
                    toolStrip3.Visible = true;
                toolStrip2.BackColor = setThemeHelper(themeSettings[9].ToString());
                toolStrip2.ForeColor = setThemeHelper(themeSettings[10].ToString());
                toolStrip3.BackColor = setThemeHelper(themeSettings[9].ToString());
                toolStrip3.ForeColor = setThemeHelper(themeSettings[10].ToString());

                //Change Groupbox
                addInfoGb.BackColor = setThemeHelper(themeSettings[11].ToString());
                addInfoGb.ForeColor = setThemeHelper(themeSettings[12].ToString());

                //Change Menu
                menuStrip1.BackColor = setThemeHelper(themeSettings[13].ToString());
                menuStrip1.ForeColor = setThemeHelper(themeSettings[14].ToString());
                fileToolStripMenuItem.ForeColor = setThemeHelper(themeSettings[14].ToString());
                OptionsMenu.ForeColor = setThemeHelper(themeSettings[14].ToString());
                toolsToolStripMenuItem.ForeColor = setThemeHelper(themeSettings[14].ToString());
                contentToolStripMenuItem.ForeColor = setThemeHelper(themeSettings[14].ToString());
                helpToolStripMenuItem.ForeColor = setThemeHelper(themeSettings[14].ToString());

                //Footer Toolstrip Menu
                toolStrip1.BackColor = setThemeHelper(themeSettings[15].ToString());
            }
            else
            {
                MessageBox.Show("Theme settings could not be loaded.");
                loadThemeDefault(this);
            }
        }

        /* Tool Strip Menu */
        private void debugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Toggles debugMode checked,
        //      Toggles debugMode value
            if (debugMode == false)
            {
                debugMode = true;
                debugModeToolStripMenuItem.Checked = true;
            }
            else
            {
                debugMode = false;
                debugModeToolStripMenuItem.Checked = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Closes Quartz form
            Close();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Displays credits in messagebox
            string credits = "Quartz alpha(8.1)\n";
            credits +=       "Created By: Scott Smereka\n";
            credits +=       "Copyright January, 2010\n";
            credits +=       "www.suppresspro.com/quartz";
            MessageBox.Show(credits);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens settings form and passes debug info and program directory
            Settings form = new Settings(debugMode, main_dir, this);
            form.ShowDialog();
            //TODO:  load new settings into main form
            loadSettings();

        }

        private void loadSettings()
        {
            if (System.IO.File.Exists(main_dir + "/quartz_settings"))
            {
                TextReader tr = new StreamReader(main_dir + "/quartz_settings");
                while (tr.ReadLine() != "")
                {
                }
                deClientDir = tr.ReadLine();
                dePublishDir = tr.ReadLine();
                deBackupDir = tr.ReadLine();
                deBkupClientDir = tr.ReadLine();
                deBkupPublishDir = tr.ReadLine();
                themeName = tr.ReadLine();
                if (themeName != "Default")    //If theme is active, check theme
                    themeToolStripMenuItem.Checked = true;

                if (tr.ReadLine() == "True")  //Removed Client backup
                    clientBkp = true;
                else
                    clientBkp = false;
                if (tr.ReadLine() == "True")  //Start with windows
                    startWindows = true;
                else
                    startWindows = false;
                if (tr.ReadLine() == "True")  //Show in Taskbar
                    showTaskbar = true;
                else
                    showTaskbar = false;
                if (tr.ReadLine() == "True")  //Show Notification Icon
                    showNotifyIcon = true;
                else
                    showNotifyIcon = false;
                tr.Close();
                tr.Dispose();
            }
            /* Apply Changes */
            startWithWindows();                   //Set or Remove start with windows
            this.ShowInTaskbar = showTaskbar;     //Show/Hide in taskbar
            notifyIcon1.Visible = showNotifyIcon; //Show/Hide Notification Icon
            if(themeName != "Default")            //If theme not default, load theme
                setTheme(loadTheme(main_dir + "/Themes/" + themeName + "/" + themeName + ".thm"));  //Apply theme
        }

        private void startWithWindows()
        {//Pre:
        //Post: If startWindows = true, adds registry value to start
        //      Quartz with windows, if false, removes this edit (if it exists)
            if (rkApp.GetValue("Quartz") == null)  //If registry edit does not exist
            {
                if (startWindows == true)          //And it should, create it
                {
                    rkApp.SetValue("Quartz", Application.ExecutablePath.ToString());
                }
            }
            else if (startWindows == false) //If it exists, and it shouldnt, delete it
            {
                rkApp.DeleteValue("Quartz", false);
            }
        }

        private void bandInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens bandInfo form and passes debug info
            BandInfo form = new BandInfo(debugMode, this, deClientDir,
                                         dePublishDir, deBackupDir, deBkupClientDir,
                                         deBkupPublishDir);
            form.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens bandInfo form and passes debug info
            bandInfoToolStripMenuItem_Click(sender, e); //Reference tool strip menu item
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens new notepad
            System.Diagnostics.Process.Start(@"notepad.exe");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre: Excel must be installed
            //Post: Opens new excel document
            /* TODO:
             * Add if exists, 
             * Add if installed, 
             * Add option to install */
            System.Diagnostics.Process.Start(@"excel.exe");
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre: outlook must be installed
            //Post: Opens new outlook document
            /* TODO:
             * Add if exists, 
             * Add if installed, 
             * Add option to install */
            System.Diagnostics.Process.Start(@"outlook.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre: Word must be installed
            //Post: Opens new word document
            /* TODO:
             * Add if exists, 
             * Add if installed, 
             * Add option to install */
            System.Diagnostics.Process.Start(@"winword.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens new calculator
            System.Diagnostics.Process.Start(@"calc.exe");
        }

        private void schedualToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens SchedualInfo form and passes debug info, 
        //      currently selected bandID and date
            SchedualInfo form = new SchedualInfo(debugMode, bandIdNum, selectDateTime,this);
            //form.FormClosed += new FormClosedEventHandler(schedual_FormClosed);
            form.Show();

           //   this.schedualIDTableAdapter.Fill(this.quartzDataDataSet.SchedualID);
        }
     //   public void schedual_FormClosed()
      //  {
      //      MessageBox.Show("Schedual closed");
       // }
        private void clientFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre: Client default folder exisits
        //Post: Client folder is displayed or prompted if it does not exists
            if (System.IO.Directory.Exists(deClientDir))
            {
                System.Diagnostics.Process.Start(deClientDir);
            }
            else
            {
                MessageBox.Show("Folder " + deClientDir + " could not be found");
            }
        }

        private void publishToolStripMenuItem1_Click(object sender, EventArgs e)
        {//Pre: Publish default folder exists
        //Post: Publish folder is displayed or prompted if it does not exists
            if (System.IO.Directory.Exists(dePublishDir))
            {
                System.Diagnostics.Process.Start(dePublishDir);
            }
            else
            {
                MessageBox.Show("Folder " + dePublishDir + " could not be found");
            }
        }

        private void backupToolStripMenuItem2_Click(object sender, EventArgs e)
        {//Pre: Backup default folder exisits
        //Post: Backup folder is displayed or prompted if it does not exists
            if (System.IO.Directory.Exists(deBackupDir))
            {
                System.Diagnostics.Process.Start(deBackupDir);
            }
            else
            {
                MessageBox.Show("Folder " + deBackupDir + " could not be found");
            }
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre: Band has been selected
        //Post: Displays paymentInfo form
        //      Currently selected band and debug info passed
            PaymentInfo form = new PaymentInfo(bandIdNum, debugMode, this);
            form.ShowDialog();
        }

        /* Program Icons */
        private void notepadIcon_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens new notepad
            notepadToolStripMenuItem_Click(sender, e);  //Reference tool strip menu item
        }

        private void calcIcon_Click(object sender, EventArgs e)
        {//Pre:
        //Post: Opens new calculator
            calculatorToolStripMenuItem_Click(sender, e);  //Reference tool strip menu item
        }

        private void outlookIcon_Click(object sender, EventArgs e)
        {//Pre: Outlook must be installed
        //Post: Opens new outlook document
            outlookToolStripMenuItem_Click(sender, e); //Reference tool strip menu item
        }

        private void excelIcon_Click(object sender, EventArgs e)
        {//Pre: Excel must be installed
        //Post: Opens new excel document
            excelToolStripMenuItem_Click(sender, e); //Reference tool strip menu item
        }

        private void wordIcon_Click(object sender, EventArgs e)
        {//Pre: Word must be installed
        //Post: Opens new word document
            wordToolStripMenuItem_Click(sender, e); //Reference tool strip menu item
        }

        /* Quick Menu Buttons */
        public void loadBandList()
        {//Pre:
        //Post: Fills band ID Gridview with all bands sorted alphabeticaly
            this.bandIDTableAdapter.Fill(this.quartzDataDataSet.BandID);
            bandIDDataGridView.Sort(dataGridViewTextBoxColumn2, ListSortDirection.Ascending);
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {//Pre: A band has been selected in Data Gridview
            //Post: Opens selected band Client folder 
            //      if it doesnt exist prompts user file not found
            /* TODO: 
             *       If folder is in backup directory, ask to move to working directory
             *       */
            if (bandIdNum > 0) //If band selected is valid
            {
                if (System.IO.Directory.Exists(deClientDir + "/" + bandName)) //Check for folder in default client directory
                {
                    System.Diagnostics.Process.Start(deClientDir + "/" + bandName);
                }
                else if (System.IO.Directory.Exists(deBackupDir + "/Client.old/" + bandName)) //Check for folder in default backup directory
                {
                    System.Diagnostics.Process.Start(deBackupDir + "/" + bandName);
                }
                else    //Prompt: File not found
                {
                    string fileNotFound = "The file specified was not found. ";
                    fileNotFound += "The file could have been moved.  ";
                    fileNotFound += "A log of this event was created.";
                    prompt(fileNotFound);
                }

            }

        }

        private void schedualBtn_Click(object sender, EventArgs e)
        {//Pre: A band has been selected
        //Post: Opens SchedualInfo form and passes debug info, 
        //      currently selected bandID and date
            if (bandIdNum > 0)  //Check that a valid band has been selected
            {
                schedualToolStripMenuItem_Click(sender, e); //Reference tool strip menu item
            }
        }

        /* bandID Data Gridview */
        private void bandIDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Pre:
        //Post: sets band name and bandID to currently selected cell
        //      Shows options menu and quick menu button enabled
            /*TODO:
             * Check that when empty what bandIdNum and bandName are set too */
            OptionsMenu.Visible   = true; //Handles optionMenu    precondition
            openFolderBtn.Enabled = true; //Handles openFolderBtn precondition
            schedualBtn.Enabled   = true; //Handles schedualBtn   precondition
            emailBtn.Enabled      = true; //Handles emailBtn      precondition
            passwordBtn.Enabled   = true; //Handels passwordBtn   precondition
            bandIdNum = Convert.ToInt32(bandIDDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value); //bandIdNum = BandID of selected cell
            bandName = Convert.ToString(bandIDDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value); //bandName = band name of selected cell
            balanceTxt.Text ="$" + Convert.ToString(bandIDDataGridView.Rows[e.RowIndex].Cells["Balance"].Value);
            //Shows Band Schedualed Dates
            this.schedualIDTableAdapter.FillByBandID(this.quartzDataDataSet.SchedualID, bandIdNum);
        }

        /* Calendar Functions */
        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {//Pre:
        //Post: selected date is set
            selectMonth = calendar.SelectionStart.Month;
            selectDay = calendar.SelectionStart.Day;
            selectYear = calendar.SelectionStart.Year;
            this.schedualIDTableAdapter.FillByDate(this.quartzDataDataSet.SchedualID, selectMonth, selectDay, selectYear);
        }

        /* Other Functions */
        private void prompt(string message)
        {//Pre:
        //Post: MessageBox with passed string text is shown
            string caption = "Attention";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK
                                            , MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.OK:
                    break;
            }
        }

        public void BoldDates()
        {
            //Show All
            this.schedualIDTableAdapter.Fill(this.quartzDataDataSet.SchedualID);
            //Fill array
            dateSched = new DateTime[schedualIDDataGridView.Rows.Count];
            for (int x = 0; x < schedualIDDataGridView.Rows.Count; x++)
            {
                dateSched[x] = Convert.ToDateTime(schedualIDDataGridView.Rows[x].Cells["dataGridViewTextBoxColumn9"].Value);
            }
            //Bold Dates
            calendar.BoldedDates = dateSched;
        }

        private void bandInfoBtn_Click(object sender, EventArgs e)
        {
            bandInfoToolStripMenuItem_Click(sender, e);
        }

        private void schedualIDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Show note of band clicked or open schedule of band clicked

        }

        private void addInfoBtn_Click(object sender, EventArgs e)
        {
            additionalInfoToolStripMenuItem_Click(sender, e);
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            calendarToolStripMenuItem_Click(sender, e);
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            scheduledDatesToolStripMenuItem_Click(sender, e);
        }

        private void toolStrip3_MouseEnter(object sender, EventArgs e)
        {
            addInfoBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            calendarBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            scheduleBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void toolStrip3_MouseLeave(object sender, EventArgs e)
        {
            addInfoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            calendarBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            scheduleBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {//Pre: themeName is a valid theme. (I.E. it exists and is configured correctly)
        //Post: If unchecked Default theme is loaded
        //      If checked & Default theme not selected
        //      loads selected theme
            if (themeToolStripMenuItem.Checked)
            {
                if(themeName != "Default")
                    setTheme(loadTheme(main_dir + "/Themes/" + themeName + "/" + themeName + ".thm"));
                else
                {
                    MessageBox.Show("The default theme is already loaded.");
                    themeToolStripMenuItem.Checked = false;
                }
            }
            else
            {
                loadThemeDefault(this);
            }
        }

        private void additionalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addInfoGb.Visible == false)
            {
                addInfoGb.Visible = true;
                additionalInfoToolStripMenuItem.Checked = true;
            }
            else
            {
                addInfoGb.Visible = false;
                additionalInfoToolStripMenuItem.Checked = false;
            }
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calendar.Visible == false)
            {
                calendar.Visible = true;
                calendarToolStripMenuItem.Checked = true;
            }
            else
            {
                calendar.Visible = false;
                calendarToolStripMenuItem.Checked = false;
            }
        }

        private void scheduledDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (schedualIDDataGridView.Visible == false)
            {
                schedualIDDataGridView.Visible = true;
                noteTextBox.Visible = true;
                scheduledDatesToolStripMenuItem.Checked = true;
            }
            else
            {
                schedualIDDataGridView.Visible = false;
                noteTextBox.Visible = false;
                scheduledDatesToolStripMenuItem.Checked = false;
            }
        }

    }
}
