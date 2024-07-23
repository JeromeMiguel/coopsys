using calypso.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmCutoffActions : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        public bool passedConfirmation = false;
        DataCollection dc = new DataCollection();
        //for updating interest
        DataTable dtDistinctID, dtGetPrevTrans;
        double interestRate = 0.5, interestAmount, balance_after;
        int dateDiffValue;

        public frmCutoffActions(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;

            // TODO: Replace userID later after login integration
            string latestCutoffDate = dc.fnReturnStringValue("SELECT cut_date_last FROM coop.defaults WHERE userID=1;", "cut_date_last", conn);
            string date = latestCutoffDate == "" ? "" : DateTime.Parse(latestCutoffDate).ToString("yyyy-MM-dd");
            if (date == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                finishedConfirmation();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Clicking Ok will add interest to all members with savings account. THIS ACTION CANNOT BE REVERSED", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                frmConfirmation form = new frmConfirmation(this);
                form.ShowDialog();

                if (passedConfirmation)
                {
                    // Add Interest Logic
                    updateInterest();

                    // Update latest cutoff date
                    // TODO: Replace userID later after login integration
                    dc.fnExecuteQuery("UPDATE `coop`.`defaults` SET `cut_date_last` = NOW() WHERE (`id` = '1');", conn);
                    MessageBox.Show("Cutoff Date Confirmed. Interest Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    finishedConfirmation();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Close();
            frmSettings form = new frmSettings(conn);
            form.ShowDialog();
           
        }

        private void finishedConfirmation()
        {
            lblConfirmationStatus.Text = "• Finished";
            lblConfirmationStatus.ForeColor = Color.LimeGreen;
            btnConfirm.Enabled = false;
            btnConfirm.BackColor = Color.LightGray;
        }

        private void updateInterest ()
        {
            dtDistinctID = dc.fnDataTableCollection("SELECT distinct(savingsID) FROM coop.transactions");

            for (int a = 0; a < dtDistinctID.Rows.Count; a++)
            {
                dtGetPrevTrans = dc.fnDataTableCollection("select * from transactions where " +
                "savingsID = " + dtDistinctID.Rows[a][0].ToString() + " order by date desc limit 2;");

                if (dtGetPrevTrans.Rows.Count >= 2 && (dtGetPrevTrans.Rows[0][5].ToString() != dtGetPrevTrans.Rows[1][5].ToString()))
                {
                    var date1 = DateTime.Parse(dtGetPrevTrans.Rows[0][5].ToString());//date of latest transaction
                    var date2 = DateTime.Parse(dtGetPrevTrans.Rows[1][5].ToString());//date of previous transaction
                    var dateDiff = date1 - date2;//compute the days between date1 and date2
                    dateDiffValue = int.Parse(dateDiff.Days.ToString());

                    interestAmount = (double.Parse(dtGetPrevTrans.Rows[0][4].ToString()) * interestRate * dateDiffValue) / 360;
                }
                else if (dtGetPrevTrans.Rows.Count >= 2 && (dtGetPrevTrans.Rows[0][5].ToString() == dtGetPrevTrans.Rows[1][5].ToString()))
                {
                    var date1 = DateTime.Parse(dtGetPrevTrans.Rows[0][5].ToString());
                    var dateDiff = DateTime.Now - date1;
                    dateDiffValue = int.Parse(dateDiff.Days.ToString());

                    interestAmount = (double.Parse(dtGetPrevTrans.Rows[0][4].ToString()) * interestRate * dateDiffValue) / 360;
                }
                else if (dtGetPrevTrans.Rows.Count == 1)
                {
                    var date1 = DateTime.Parse(dtGetPrevTrans.Rows[0][5].ToString());
                    var dateDiff = DateTime.Now - date1;
                    dateDiffValue = int.Parse(dateDiff.Days.ToString());

                    interestAmount = (double.Parse(dtGetPrevTrans.Rows[0][4].ToString()) * interestRate * dateDiffValue) / 360;
                }

                balance_after = double.Parse(dtGetPrevTrans.Rows[0][4].ToString()) + interestAmount;
                dc.fnExecuteQuery("Update savings set current_balance = " +
                    "((select current_balance where savingsID = " + dtDistinctID.Rows[a][0].ToString() + ") + " + interestAmount.ToString() + ") " +
                    "where savingsID = " + dtDistinctID.Rows[a][0].ToString() + ";", conn);

                dc.fnExecuteQuery("insert into transactions(type, amount, balance_before, balance_after, date, savingsID) " +
                    "values(2, "+Math.Round(interestAmount,2)+","+ Math.Round(decimal.Parse(dtGetPrevTrans.Rows[0][4].ToString()),2) + ","+Math.Round(balance_after,2) +",NOW(),"+ dtDistinctID.Rows[a][0].ToString() + ")", conn);
            }
        }
    }
}
