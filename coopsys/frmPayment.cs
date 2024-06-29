using calypso.DataAccess;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmPayment : MetroFramework.Forms.MetroForm
    {
        frmLoan formLoan;
        frmDueForPayment dueForPayment;
        MySqlConnection conn;
        DataTable totalShare = new DataTable();
        DataCollection dc = new DataCollection();
        int loanid, memberID, cboLoansIndex;
        double balance, penalty;
        string duedate;
        bool fromDuePayment;

        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(frmLoan _formLoan, MySqlConnection _conn, int _loanid, int _memberID,
            double _balance, double _penalty, string _duedate, int _cboLoansIndex)
        {
            InitializeComponent();
            formLoan = _formLoan;
            conn = _conn;
            loanid = _loanid;
            memberID = _memberID;
            balance = _balance;
            penalty = _penalty;
            duedate = _duedate;
            cboLoansIndex = _cboLoansIndex;
        }

        public frmPayment(frmDueForPayment _dueForPayment, MySqlConnection _conn, int _loanid, int _memberID,
            double _balance, double _penalty, string _duedate, bool _fromDuePayment)
        {
            InitializeComponent();
            dueForPayment = _dueForPayment;
            dueForPayment = _dueForPayment;
            conn = _conn;
            loanid = _loanid;
            memberID = _memberID;
            balance = _balance;
            penalty = _penalty;
            duedate = _duedate;
            fromDuePayment = _fromDuePayment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int day = txtDate.Value.Day;
            int month = txtDate.Value.Month;
            int year = txtDate.Value.Year;

            if (!string.IsNullOrEmpty(txtPaymentAmount.Text))
            {
                if (balance < double.Parse(txtPaymentAmount.Text))
                {
                    MessageBox.Show(this, "Payment should not exceed the loan unpaid balance.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!chkCheck.Checked)
                    {
                        balance = balance - (double.Parse(txtPaymentAmount.Text));
                        dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `balance` = " + balance + " WHERE(`loanID` = " + loanid + " and `memberid` = " + memberID + ");", conn);

                        dc.fnExecuteQuery("INSERT INTO `coop`.`payment` (`payday`, `paymonth`, `payyear`, `payamount`, `runningbalance`,`loanid`) " +
                            "VALUES (" + day + ", " + month + ", " + year + ", " + double.Parse(txtPaymentAmount.Text) + ", " + balance + "," + loanid + ");\r\n", conn);
                        VerificationMsg();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtCheckNo.Text))
                        {
                            balance = balance - (double.Parse(txtPaymentAmount.Text));
                            dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `balance` = " + balance + " WHERE(`loanID` = " + loanid + " and `memberid` = " + memberID + ");", conn);

                            dc.fnExecuteQuery("INSERT INTO `coop`.`payment` (`payday`, `paymonth`, `payyear`, `payamount`,`runningbalance`, `checkno`, `loanid`) " +
                            "VALUES (" + day + ", " + month + ", " + year + ", " + double.Parse(txtPaymentAmount.Text) + ", " + balance + ", '" + txtCheckNo.Text + "', " + loanid + ");\r\n", conn);
                            VerificationMsg();
                        }
                        else
                        {
                            MessageBox.Show(this, "Check number is required.", "Check Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Please enter loan payment amount.", "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VerificationMsg()
        {
            DialogResult dr = MessageBox.Show(this, "The following tasks were executed successfully:\n" +
                        "1. Payment on loan.\n" +
                        "2. Update on running balance.\n" +
                        "Click Yes to exit, No to continue editing.", "Success",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DialogResult.Yes == dr)
            {
                this.Dispose();
            }
            else
            {
                clearAll();
            }

            if (fromDuePayment)
            {
                dueForPayment.LoadDueList();
            }
            else
            {
                formLoan.LoadLoanList(cboLoansIndex, memberID);
            }
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                txtCheckNo.Enabled = true;
                txtCheckNo.BackColor = Color.White;
                txtCheckNo.WaterMark = "Enter check number";
            }
            else
            {
                txtCheckNo.BackColor = Color.Gainsboro;
                txtCheckNo.Enabled = false;
                txtCheckNo.WaterMark = "";
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblBalance.Text = balance.ToString("N2");
            lblPenalty.Text = penalty.ToString("N2");
            lblDueDate.Text = duedate;

            if (penalty == 0)
            {
                txtPenaltyPayment.BackColor = Color.Gainsboro;
                txtPenaltyPayment.Enabled = false;
                btnCancelPenalty.Enabled = false;
                btnPayPenalty.Enabled = false;
            }
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void txtPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as MetroTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void clearAll()
        {
            if (!string.IsNullOrWhiteSpace(txtPaymentAmount.Text)) { lblBalance.Text = (double.Parse(lblBalance.Text) - double.Parse(txtPaymentAmount.Text)).ToString("N2"); }
            if (!string.IsNullOrWhiteSpace(txtPenaltyPayment.Text)) { lblPenalty.Text = (double.Parse(lblPenalty.Text) - double.Parse(txtPenaltyPayment.Text)).ToString("N2"); }
            txtCheckNo.Clear();
            txtPenaltyPayment.Clear();
            txtPaymentAmount.Clear();
            chkCheck.Checked = false;
        }

        private void btnPayPenalty_Click(object sender, EventArgs e)
        {
            double inputPenaltyAmt = double.Parse(txtPenaltyPayment.Text);

            if (inputPenaltyAmt <= penalty)
            {
                dc.fnExecuteQuery("UPDATE `coop`.`penalty` SET `penaltyamount` = " + (penalty - inputPenaltyAmt) + " WHERE (`loanid` = " + loanid + ");", conn);
                if(fromDuePayment)
                {
                    dueForPayment.LoadDueList();
                }
                else
                {
                    formLoan.LoadLoanList(cboLoansIndex, memberID);
                }
                DialogResult dr = MessageBox.Show("The following tasks were executed successfully:\n" +
                    "1. Penalty amount successfully updated." +
                    "\nClick Yes to exit, No to continue editing.", "Success",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult.Yes == dr)
                {
                    this.Dispose();
                }
                else
                {
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Input amount exceeds current penalty.\nPlease try again.", "Penalty Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelPenalty_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to cancel the penalty?\nThis will set the penalty amoount to zero.",
                "Cancel Penalty", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult.Yes == dr)
            {
                dc.fnExecuteQuery("UPDATE `coop`.`penalty` SET `penaltyamount` = 0, penaltystatus = 1 WHERE (`loanid` = " + loanid + ");", conn);
                dueForPayment.LoadDueList();

                DialogResult dr2 = MessageBox.Show("The following tasks were executed successfully:\n" +
                    "1. Penalty amount successfully updated." +
                    "\nClick Yes to exit, No to continue editing.", "Success",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == dr2)
                {
                    this.Dispose();
                }
                else
                {
                    clearAll();
                }
            }
        }
    }
}
