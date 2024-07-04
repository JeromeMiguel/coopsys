using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using calypso;
using calypso.DataAccess;
using MetroFramework.Controls;

namespace coopsys
{
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
        DataCollection dc = new DataCollection();
        MySqlConnection conn;

        public frmSettings(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackupSql sql = new frmBackupSql(conn);
            sql.ShowDialog();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            disabledForm();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Edit") 
            {
                btnAction.Text = "Save";
                enabledForm();
            }

            else
            {
                btnAction.Text = "Edit";
                disabledForm();
            }
        }

        private void disabledForm ()
        {
            txtDvidendRate.BackColor = SystemColors.ButtonFace;
            txtFinalPercentage1.BackColor = SystemColors.ButtonFace;
            txtFinalPercentage2.BackColor = SystemColors.ButtonFace;
            txtInterestCSRate.BackColor = SystemColors.ButtonFace;
            txtLoanPenalty.BackColor = SystemColors.ButtonFace;
            txtMemberLoanRate.BackColor = SystemColors.ButtonFace;
            txtSaveCertificates.BackColor = SystemColors.ButtonFace;
            txtSaveReports.BackColor = SystemColors.ButtonFace;

            lblPercent1.BackColor = SystemColors.ButtonFace;
            lblPercent2.BackColor = SystemColors.ButtonFace;
            lblPercent3.BackColor = SystemColors.ButtonFace;

            btnBrowseReports.Enabled = false;
            btnBrowseCertificates.Enabled = false;

            lblEditStatus.Text = string.Empty;

            txtDvidendRate.Enabled = false;
            txtFinalPercentage1.Enabled = false;
            txtFinalPercentage2.Enabled = false;
            txtInterestCSRate.Enabled = false;
            txtLoanPenalty.Enabled = false;
            txtMemberLoanRate.Enabled = false;
            txtSaveCertificates.Enabled = false;
            txtSaveReports.Enabled = false;
        }

        private void enabledForm ()
        {
            txtDvidendRate.BackColor = Color.FromArgb(255, 255, 255);
            txtFinalPercentage1.BackColor = Color.FromArgb(255, 255, 255);
            txtFinalPercentage2.BackColor = Color.FromArgb(255, 255, 255);
            txtInterestCSRate.BackColor = Color.FromArgb(255, 255, 255);
            txtLoanPenalty.BackColor = Color.FromArgb(255, 255, 255);
            txtMemberLoanRate.BackColor = Color.FromArgb(255, 255, 255);
            txtSaveCertificates.BackColor = Color.FromArgb(255, 255, 255);
            txtSaveReports.BackColor = Color.FromArgb(255, 255, 255);

            lblPercent1.BackColor = Color.FromArgb(255, 255, 255);
            lblPercent2.BackColor = Color.FromArgb(255, 255, 255);
            lblPercent3.BackColor = Color.FromArgb(255, 255, 255);

            btnBrowseReports.Enabled = true;
            btnBrowseCertificates.Enabled = true;

            lblEditStatus.Text = "( Editing )";

            txtDvidendRate.Enabled = true;
            txtFinalPercentage1.Enabled = true;
            txtFinalPercentage2.Enabled = true;
            txtInterestCSRate.Enabled = true;
            txtLoanPenalty.Enabled = true;
            txtMemberLoanRate.Enabled = true;
            txtSaveCertificates.Enabled = true;
            txtSaveReports.Enabled = true;
        }

        private void percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow whole number only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
