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
using System.Collections;

namespace coopsys
{
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        DataTable dt = new DataTable();
        public string date1, date2, date3, date4;

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
            loadDefaultData();
            disabledForm();

            txtDay1.Enabled = false;
            txtDay2.Enabled = false;
            txtDay3.Enabled = false;
            txtDay4.Enabled = false;
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
                string day1, day2, day3, day4;

                day1 = txtDay1.Text == "" ? "NULL" : "'" + DateTime.Parse(txtDay1.Text).ToString("yyyy-MM-dd") + "'";
                day2 = txtDay2.Text == "" ? "NULL" : "'" + DateTime.Parse(txtDay2.Text).ToString("yyyy-MM-dd") + "'";
                day3 = txtDay3.Text == "" ? "NULL" : "'" + DateTime.Parse(txtDay3.Text).ToString("yyyy-MM-dd") + "'";
                day4 = txtDay4.Text == "" ? "NULL" : "'" + DateTime.Parse(txtDay4.Text).ToString("yyyy-MM-dd") + "'";

                // Update Database
                // TODO: replace id = 1 with userID after login integration
                dc.fnExecuteQuery("UPDATE `coop`.`defaults` SET `loan_member_rate` = "+txtMemberLoanRate.Text+", `loan_penalty` = "+txtLoanPenalty.Text+", " +
                    "`rep_dividend_rate` = "+txtDvidendRate.Text+", `rep_interest_capital_share` = "+txtInterestCSRate.Text+", `rep_final_1` = "+txtFinalPercentage1.Text+", " +
                    "`rep_final_2` = "+txtFinalPercentage2.Text+", `save_reports` = NULL, `save_certificates` = NULL, " + "`cut_date_1` = " +day1 +
                    ", `cut_date_2` = " + day2+ ", `cut_date_3` = " + day3 + ", `cut_date_4` = " + day4 +" WHERE (`id` = 1);", conn);

                loadDefaultData();

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


            lblPercent1.BackColor = SystemColors.ButtonFace;
            lblPercent2.BackColor = SystemColors.ButtonFace;
            lblPercent3.BackColor = SystemColors.ButtonFace;

            //btnBrowseReports.Enabled = false;
            //btnBrowseCertificates.Enabled = false;

            lblEditStatus.Text = string.Empty;

            txtDvidendRate.Enabled = false;
            txtFinalPercentage1.Enabled = false;
            txtFinalPercentage2.Enabled = false;
            txtInterestCSRate.Enabled = false;
            txtLoanPenalty.Enabled = false;
            txtMemberLoanRate.Enabled = false;
            btnEditDay1.Enabled = false;
            btnEditDay2.Enabled = false;
            btnEditDay3.Enabled = false;
            btnEditDay4.Enabled = false;
            //txtSaveCertificates.Enabled = false;
            //txtSaveReports.Enabled = false;



            btnReset.Visible = false;
            btnCancel.Visible = false;

        }

        private void enabledForm ()
        {
            txtDvidendRate.BackColor = Color.FromArgb(255, 255, 255);
            txtFinalPercentage1.BackColor = Color.FromArgb(255, 255, 255);
            txtFinalPercentage2.BackColor = Color.FromArgb(255, 255, 255);
            txtInterestCSRate.BackColor = Color.FromArgb(255, 255, 255);
            txtLoanPenalty.BackColor = Color.FromArgb(255, 255, 255);
            txtMemberLoanRate.BackColor = Color.FromArgb(255, 255, 255);
            //txtSaveCertificates.BackColor = Color.FromArgb(255, 255, 255);
            //txtSaveReports.BackColor = Color.FromArgb(255, 255, 255);

            lblPercent1.BackColor = Color.FromArgb(255, 255, 255);
            lblPercent2.BackColor = Color.FromArgb(255, 255, 255);
            lblPercent3.BackColor = Color.FromArgb(255, 255, 255);

            //btnBrowseReports.Enabled = true;
            //btnBrowseCertificates.Enabled = true;

            lblEditStatus.Text = "( Editing )";

            txtDvidendRate.Enabled = true;
            txtFinalPercentage1.Enabled = true;
            txtFinalPercentage2.Enabled = true;
            txtInterestCSRate.Enabled = true;
            txtLoanPenalty.Enabled = true;
            txtMemberLoanRate.Enabled = true;
            btnEditDay1.Enabled = true;
            btnEditDay2.Enabled = true;
            btnEditDay3.Enabled = true;
            btnEditDay4.Enabled = true;
            //txtSaveCertificates.Enabled = true;
            //txtSaveReports.Enabled = true;

            btnReset.Visible = true;
            btnCancel.Visible = true;

          
        }

        private void decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void loadDefaultData ()
        {
            dt = dc.fnDataTableCollection("SELECT * FROM coop.defaults;", conn);

            txtMemberLoanRate.Text = decimal.Parse(dt.Rows[0][4].ToString()).ToString("G29");
            txtLoanPenalty.Text = decimal.Parse(dt.Rows[0][5].ToString()).ToString("G29");
            txtDvidendRate.Text = decimal.Parse(dt.Rows[0][6].ToString()).ToString("G29");
            txtInterestCSRate.Text = decimal.Parse(dt.Rows[0][7].ToString()).ToString("G29");
            txtFinalPercentage1.Text = decimal.Parse(dt.Rows[0][8].ToString()).ToString("G29");
            txtFinalPercentage2.Text = decimal.Parse(dt.Rows[0][9].ToString()).ToString("G29");

            date1 = dt.Rows[0][10].ToString() == "" ? "" : DateTime.Parse(dt.Rows[0][10].ToString()).ToString("MM/dd/yyyy");
            date2 = dt.Rows[0][11].ToString() == "" ? "" : DateTime.Parse(dt.Rows[0][11].ToString()).ToString("MM/dd/yyyy");
            date3 = dt.Rows[0][12].ToString() == "" ? "" : DateTime.Parse(dt.Rows[0][12].ToString()).ToString("MM/dd/yyyy");
            date4 = dt.Rows[0][13].ToString() == "" ? "" : DateTime.Parse(dt.Rows[0][13].ToString()).ToString("MM/dd/yyyy");

            txtDay1.Text = date1;
            txtDay2.Text = date2;
            txtDay3.Text = date3;
            txtDay4.Text = date4;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAction.Text = "Edit";
            disabledForm();
            loadDefaultData();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
             loadDefaultData ();
        }

        private void btnEditDay1_Click(object sender, EventArgs e)
        {
            openDateEditor("1", date1);
        }

        private void btnEditDay2_Click(object sender, EventArgs e)
        {
            openDateEditor("2", date2);
        }

        private void btnEditDay3_Click(object sender, EventArgs e)
        {
            openDateEditor("3", date3);
        }

        private void btnEditDay4_Click(object sender, EventArgs e)
        {
            openDateEditor("4", date4);
        }

        private void openDateEditor (string dateNo, string dateVal)
        {
            frmEditCutoffDate form = new frmEditCutoffDate(this, dateNo, dateVal);
            form.ShowDialog();

            txtDay1.Text = date1;
            txtDay2.Text = date2;
            txtDay3.Text = date3;
            txtDay4.Text = date4;
        }
    }
}
