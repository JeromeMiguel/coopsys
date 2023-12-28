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
using calypso;

namespace coopsys
{
    public partial class frmPayment : MetroFramework.Forms.MetroForm
    {
        frmLoan formLoan;
        frmDueForPayment dueForPayment;
        MySqlConnection conn;
        DataTable totalShare = new DataTable();
        DataCollection dc = new DataCollection();
        int loanid, memberid, cboLoansIndex;
        double balance, penalty;
        string duedate;
        bool fromDuePayment;

        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(frmLoan _formLoan, MySqlConnection _conn, int _loanid, int _memberid, 
            double _balance, double _penalty, string _duedate, int _cboLoansIndex)
        {
            InitializeComponent();
            formLoan = _formLoan;
            conn = _conn;
            loanid = _loanid;
            memberid = _memberid;
            balance = _balance;
            penalty = _penalty;
            duedate = _duedate;
            cboLoansIndex = _cboLoansIndex;
        }

        public frmPayment(frmDueForPayment _dueForPayment, MySqlConnection _conn, int _loanid, int _memberid,
            double _balance, double _penalty, string _duedate, bool _fromDuePayment)
        {
            InitializeComponent();
            dueForPayment = _dueForPayment;
            dueForPayment = _dueForPayment;
            conn = _conn;
            loanid = _loanid;
            memberid = _memberid;
            balance = _balance;
            penalty = _penalty;
            duedate = _duedate;
            fromDuePayment = _fromDuePayment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            balance = balance - (double.Parse(txtPaymentAmount.Text));
            dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `balance` = " + balance + " WHERE(`loanID` = " + loanid + " and `memberid` = " + memberid + ");", conn);

            int day = txtDate.Value.Day;
            int month = txtDate.Value.Month;
            int year = txtDate.Value.Year;

            if(!chkCheck.Checked)
            {
                dc.fnExecuteQuery("INSERT INTO `coop`.`payment` (`payday`, `paymonth`, `payyear`, `payamount`, `loanid`) " +
                    "VALUES (" + day + ", " + month + ", " + year + ", " + double.Parse(txtPaymentAmount.Text) + ", " + loanid + ");\r\n", conn);
                dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `balance` = " + balance + " WHERE (`loanID` = "+loanid+");\r\n", conn);
            }
            else
            {
                dc.fnExecuteQuery("INSERT INTO `coop`.`payment` (`payday`, `paymonth`, `payyear`, `payamount`, `checkno`, `loanid`) " +
                    "VALUES (" + day + ", " + month + ", " + year + ", " + double.Parse(txtPaymentAmount.Text) + ", '" + txtCheckNo.Text + "', " + loanid + ");\r\n", conn);
                dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `balance` = " + balance + " WHERE (`loanID` = " + loanid + ");\r\n", conn);

            }
            MessageBox.Show(this, "The following tasks were executed successfully:\n" +
                "1. Payment on loan.\n" +
                "2. Update on running balance.\n" +
                "Click OK to continue.", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(fromDuePayment)
            {
                dueForPayment.LoadDueList();
            }
            else
            {
                formLoan.LoadLoanList(cboLoansIndex);
            }
            this.Dispose();
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                txtCheckNo.Enabled = true;
                txtCheckNo.WaterMark = "Enter check number";
            }
            else
            {
                txtCheckNo.Enabled = false;
                txtCheckNo.WaterMark = "";
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblBalance.Text = balance.ToString();
            lblPenalty.Text = penalty.ToString();
            lblDueDate.Text = duedate;
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
