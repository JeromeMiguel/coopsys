using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calypso.DataAccess;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Vml.Office;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace coopsys
{
    public partial class frmBackupSql : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        public string query, path;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        public frmBackupSql(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;
            txtDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + 
                @"\Database Backup " + System.DateTime.Now.ToString("D") + ".sql";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Database Backup " + System.DateTime.Now.ToString("D") + ".sql";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = saveFileDialog1.FileName;
            }
        }

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDir.Text))
            {
                btnBrowse.Enabled = false;
                btnStartBackup.Enabled = false;
                path = txtDir.Text;
                bgWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(this, "Please select a valid folder path.", "Folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\setup.txt");

            string constring = "server=" + lines[0] +"; " +
                "user=" + lines[3] +";" +
                "pwd=" + lines[4] +";" +
                "database=" + lines[1] +";";
            bgWorker.ReportProgress(20, "Connecting to server.");
            Thread.Sleep(500);
            FileInfo fileInfo = new FileInfo(saveFileDialog1.FileName);

            MySqlCommand cmd = new MySqlCommand();
            bgWorker.ReportProgress(40, "Generating databae tables.");
            Thread.Sleep(500);

            MySqlBackup mb = new MySqlBackup(cmd);
            bgWorker.ReportProgress(60, "Inserting backup records.");
            Thread.Sleep(500);

            cmd.Connection = conn;
            conn.Open();
            bgWorker.ReportProgress(80, "Creating SQL file for export.");
            Thread.Sleep(500);

            mb.ExportToFile(path);
            conn.Close();
            Thread.Sleep(1500);
            bgWorker.ReportProgress(100, "Export complete.");
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            lblProgress.Text = string.Format("Progress: {0}%", e.ProgressPercentage);
            lblStatus.Text = string.Format("Status: {0}", e.UserState);
            progress.Update();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Backup created successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblProgress.Text = "Progress:";
            lblStatus.Text = "Status:";
            btnBrowse.Enabled = true;
            btnStartBackup.Enabled = true;
            this.Close();
        }
    }
}
