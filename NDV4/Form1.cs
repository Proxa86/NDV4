using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;

namespace NDV4
{
    public partial class Form1 : Form
    {
        public static bool CheckSharp { get; set; }
        public static bool CheckC { get; set; }
        public static bool CheckFortran { get; set; }
        public static bool CheckPascal { get; set; }
        public static bool CheckOptimQmake { get; set; }
        public static bool CheckExcel { get; set; }
        public static bool CheckFileTxt { get; set; }
        public static bool CheckClearResultBin { get; set; }
        public static string Inform { get; set; }
        public Form1()
        {
            
            InitializeComponent();

            

            listBoxReport.Items.Add("Все найденные файлы в бинарниках.");
            listBoxReport.Items.Add("Потенциально - избыточные файлы.");
            listBoxReport.Items.Add("Какие исходные файлы вошли в бинарник.");
            listBoxReport.SelectedIndex = 1;

            this.Text = "Есть ли жизнь на марсе?";
            this.bInsertMarker.Enabled = false;
            this.buttonExcel.Enabled = false;
            this.bStartAnalysis.Enabled = false;

            this.cbOptimQmake.Enabled = false;
            this.cbExcel.Enabled = false;
            this.cbFile.Enabled = false;
            this.cBClearResultBin.Checked = true;

            this.createStripMenuItem.Click += new EventHandler(this.createStripMenuItem_Click);

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            //backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            //backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            lInform.Text = "";
            Inform = lInform.Text;
        }



        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if(CheckExcel & !CheckFileTxt)
            {
                bStartAnalysis.Enabled = false;
                //LInformation = "Waiting ...";
                BuildReport buildReport = new BuildReport();
                buildReport.buildReportExcel(listBoxReport.SelectedIndex);
                //LInformation = "Building report - OK";
                bStartAnalysis.Enabled = true;
            }
            if(CheckFileTxt & !CheckExcel)
            {
                bStartAnalysis.Enabled = false;
                BuildReport buildReport = new BuildReport();
                buildReport.buildReportInFile(listBoxReport.SelectedIndex);
                bStartAnalysis.Enabled = true;
            }
            if(CheckExcel & CheckFileTxt)
            {
                bStartAnalysis.Enabled = false;
                BuildReport buildReport = new BuildReport();
                buildReport.buildReportExcel(listBoxReport.SelectedIndex);
                buildReport.buildReportInFile(listBoxReport.SelectedIndex);
                bStartAnalysis.Enabled = true;
            }
            
            
        }

        private void buttonInsertMarker_Click(object sender, EventArgs e)
        {

            //LInformation = "Waiting ...";
            OpenFolder openFolder = new OpenFolder();
            openFolder.insertMarkerInFile();
            lInform.Text = "Insert marker - OK";
        }

        private void createStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (CheckC || CheckSharp || CheckFortran || CheckPascal)
            {
                CreateNewProject createNewProject = new CreateNewProject(bInsertMarker);
                createNewProject.Owner = this;
                createNewProject.Show();
                this.cbOptimQmake.Enabled = true;
                
            }
            else
                MessageBox.Show("Please, choice language!");

        }

        private void openStripMenuItem_Click(object sender, EventArgs e)
        {
            //LInformation = "Open project!";
            OpenFile openFileDB = new OpenFile(bStartAnalysis, this);
            openFileDB.openFileDB();
            buttonExcel.Enabled = true;
            this.cbExcel.Enabled = true;
            this.cbFile.Enabled = true;
        }

        private void cBSharp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckSharp = true;
                CheckC = false;
                CheckFortran = false;
                CheckPascal = false;

                cBCpp.Enabled = false;
                cBFortran.Enabled = false;
                //cBPascal.Enabled = false;
            }
            else
            {
                cBCpp.Enabled = true;
                cBFortran.Enabled = true;
                //cBPascal.Enabled = true;
            }
                
        }

        private void cBCpp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckC = true;
                CheckSharp = false;
                CheckFortran = false;
                CheckPascal = false;

                cBSharp.Enabled = false;
                cBFortran.Enabled = false;
                //cBPascal.Enabled = false;
            }
            else
            {
                cBSharp.Enabled = true;
                cBFortran.Enabled = true;
                //cBPascal.Enabled = true;
            }
                
        }

        private void cBFatran_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckC = false;
                CheckSharp = false;
                CheckFortran = true;
                CheckPascal = false;

                cBSharp.Enabled = false;
                cBCpp.Enabled = false;
                //cBPascal.Enabled = false;
            }
            else
            {
                cBSharp.Enabled = true;
                cBCpp.Enabled = true;
                //cBPascal.Enabled = true;
            }
        }

        private void cBPascal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckC = false;
                CheckSharp = false;
                CheckFortran = false;
                CheckPascal = true;

                cBSharp.Enabled = false;
                cBCpp.Enabled = false;
                cBFortran.Enabled = false;
            }
            else
            {
                cBSharp.Enabled = true;
                cBCpp.Enabled = true;
                cBFortran.Enabled = true;
            }
        }

        private void bStartAnalysis_Click(object sender, EventArgs e)
        {
            //FindTmpMarker findTmpMarker = new FindTmpMarker(lCountBin);

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FindTmpMarker findTmpMarker = new FindTmpMarker(lInform);
            findTmpMarker.findTmpMarkerWithBin();
            backgroundWorker1.CancelAsync();
            lInform.Text = "Analysis and!";
        }
    

        private void cbOptimQmake_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckOptimQmake = true;
            }
        }

        private void cbExcel_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckExcel = true;
                //CheckFileTxt = false;
            }
            else CheckExcel = false;
        }

        private void cbFile_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckFileTxt = true;
                //CheckExcel = false;
            }
            else CheckFileTxt = false;
        }

        private void cBClearResultBin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                CheckClearResultBin = true;
                //CheckExcel = false;
            }
            else CheckClearResultBin = false;
        }

        
    }
}
