using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calypso;
using calypso.DataAccess;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace coopsys
{
    public partial class frmLoan : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataCollection dc = new DataCollection();
        frmMain main;
        private int memberID, loanID;
        private double penaltyAmt, balance, addFee1, addFee2;
        private string duedate;

        #region Collateral Variables
        //Real Property Variables
        public string propDesc { get; set; }
        public string propSurvey { get; set; }
        public string propArea { get; set; }
        public string propLoc { get; set; }

        //Vehicles Variables
        public string vehPlate { get; set; }
        public string vehEngine { get; set; }
        public string vehChassis { get; set; }
        public string vehMake { get; set; }

        //Cheque Variables
        public string chqNum { get; set; }
        public double chqAmt { get; set; }
        public string bank { get; set; }

        //if there are collaterals
        public bool IfCollateral { get; set; }
        #endregion

        private double amount, interestAmount, interestRate, terms, interestTerms, serviceFee, insurance, loanableAmount, totaldeduction;

        public frmLoan()
        {
            InitializeComponent();
        }

        public frmLoan(frmMain _main, MySqlConnection _conn, int _memberID, string _fname, string _mname, string _lname)
        {
            InitializeComponent();
            main = _main;
            lblmemname.Text = _lname + ", " + _fname + " " + _mname;
            conn = _conn;
            memberID = _memberID;
            cboLoans.SelectedIndex = 1;
            LoadLoanList(cboLoans.SelectedIndex, memberID);

            lblLoanType.Text = "( " + cboLoans.Text + " )";
        }

        private void ComputeLoanableAmount()
        {
            if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtFee.Text) && !string.IsNullOrEmpty(txtTerm.Text) && !string.IsNullOrEmpty(txtInsurance.Text))
            {
                interestRate = double.Parse(txtInterest.Text)/100;
                amount = double.Parse(txtAmount.Text);
                terms = double.Parse(txtTerm.Text) / 30;
                interestAmount = double.Parse(txtAmount.Text) * interestRate;
                interestTerms = interestAmount * terms;
                serviceFee = double.Parse(txtFee.Text);
                insurance = double.Parse(txtInsurance.Text);
                addFee1 = double.Parse(string.IsNullOrWhiteSpace(txtAddFee1.Text) ? "0":txtAddFee1.Text);
                addFee2 = double.Parse(string.IsNullOrWhiteSpace(txtAddFee2.Text) ? "0":txtAddFee2.Text);


                // Compute Net Proceeds 
                // ( Checks if capital share is null)
                // ( Checks if savings is null) - SOON
                totaldeduction = interestTerms + serviceFee + insurance + (!string.IsNullOrEmpty(txtCapitalShare.Text) ? double.Parse(txtCapitalShare.Text) : 0) + addFee1 + addFee2;

                if (!string.IsNullOrWhiteSpace(txtAmount.Text) && 
                    !string.IsNullOrWhiteSpace(txtFee.Text) && 
                    !string.IsNullOrWhiteSpace(txtTerm.Text) && 
                    !string.IsNullOrWhiteSpace(txtInsurance.Text))
                {
                    //if(string.IsNullOrWhiteSpace(txtCapitalShare.Text))
                    //{
                    //    loanableAmount = amount - (interestTerms + serviceFee + insurance);
                    //}
                    //else
                    //{
                    //    loanableAmount = amount - totaldeduction;
                    //}
                    loanableAmount = amount - totaldeduction;
                    txtLoanable.Text = Math.Round(loanableAmount, 2).ToString("N2");
                }
            }
            else
            {
                txtLoanable.Clear();
            }
        }

        public void LoadLoanList(int loanstatus, int _memberID)
        {
            string query = "select loan.loanid as 'LID', concat(if(loanmonth<10,concat(0,loanmonth),loanmonth),'/', if(loanday<10,concat(0,loanday),loanday), '/', loanyear) as 'LOAN DATE', " +
                "format(loanamount,2) as 'AMOUNT', format(balance,2) as 'BALANCE', duedate as 'MATURITY DATE', format(interestAmount,2) as 'INTEREST', format(loanfee,2) as 'SERVICE FEE', " +
                "format(loaninsurance,2) as 'INSURANCE', ifnull(format(csamount,2), 0.00) as 'SHARE CAPITAL', ifnull(format(penaltyamount,2), 0.00) as 'PENALTY' " +
                "from coop.loan left join penalty on penalty.loanid = loan.loanid " +
                "left join capitalshare on loan.loanid=capitalshare.loanid " +
                "where loan.memberid = " + _memberID + "";

            if (loanstatus == 0)
            {
                grdLoans.DataSource = dc.fnDataTableCollection(query, conn);
            }
            else if (loanstatus == 1)
            {
                grdLoans.DataSource = dc.fnDataTableCollection(query + " and (balance > 0 or penaltyamount > 0)", conn);
            }
            else if (loanstatus == 2)
            {
                grdLoans.DataSource = dc.fnDataTableCollection(query + " and (balance = 0 or penaltyamount = 0)", conn);
            }

            grdLoans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdLoans.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdLoans.Columns[0].Visible = false;

            foreach (DataGridViewRow row in grdLoans.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmLoan_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdLoans.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            
            txtInterest.Text = decimal.Parse(dc.fnReturnStringValue("SELECT loan_member_rate AS 'loanRate' FROM coop.defaults;", "loanRate", conn)).ToString("G29");
            
            lblWarning.Visible = false;
        }

        #region Textbox KeyPress Events
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimalKeyPress(sender, e);
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimalKeyPress(sender, e);
        }

        private void txtTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimalKeyPress(sender, e);
        }

        private void txtCapitalShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimalKeyPress(sender, e);
        }


        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimalKeyPress(sender, e);
        }

        #endregion


        private void grdLoans_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdLoans.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void grdPayment_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdPayment.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void cboLoans_TextChanged(object sender, EventArgs e)
        {
            lblLoanType.Text = "( " + cboLoans.Text + " )";
        }

        private void viewEditCollateralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            frmCollateral collateral = new frmCollateral(this, true, conn, loanID);
            collateral.ShowDialog();
        }

        private void cboFillTable_CheckedChanged(object sender, EventArgs e)
        {
            if (cboFillTable.Checked == true)
            {
                grdLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdLoans.DataSource = null;
                grdPayment.DataSource = null;
                LoadLoanList(cboLoans.SelectedIndex, memberID);
            }
            else
            {
                grdLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                grdLoans.DataSource = null;
                grdPayment.DataSource = null;
                LoadLoanList(cboLoans.SelectedIndex, memberID);
            }
        }

        private void grdLoans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());

            string query = "SELECT paymentID, loanid, CONCAT(if(paymonth<10,concat(0,paymonth),paymonth),'/', if(payday<10,concat(0,payday),payday), '/', payyear) as \"PAYMENT DATE\", " +
                "format(payamount,2) as \"AMOUNT\", format(runningbalance,2) as \"RUNNING BALANCE\", checkno as \"CHECK NO.\" " +
                "from payment where loanid = '"+loanID+"' ORDER BY paymentid DESC";

            grdPayment.DataSource = dc.fnDataTableCollection(query, conn);

            grdPayment.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdPayment.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdPayment.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdPayment.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdPayment.Columns[0].Visible = false;
            grdPayment.Columns[1].Visible = false;

            foreach (DataGridViewRow row in grdPayment.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            amtCSTextChange();
        }

        private void grdLoans_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    grdLoans.Rows[e.RowIndex].Selected = true;
                    contextMenuStripDataRow.Show(MousePosition.X, MousePosition.Y);
                }
                catch { }
            }
        }

        private void txtCapitalShare_TextChanged(object sender, EventArgs e)
        {
            amtCSTextChange();
        }

        private void cboLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoanList(cboLoans.SelectedIndex, memberID);
            grdPayment.DataSource = null;
        }

        private void frmLoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.OnFormLoad();
        }

        private void frmLoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ComputeLoanableAmount();
            DialogResult dr = MessageBox.Show(this, "Please check the computed values before saving.\nClick Yes to save loan, click No to continue editing.", "Check Values", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txtAmount.Text) && !string.IsNullOrWhiteSpace(txtFee.Text) && !string.IsNullOrWhiteSpace(txtTerm.Text) && !string.IsNullOrWhiteSpace(txtInsurance.Text))
                {
                    if (string.IsNullOrWhiteSpace(txtAddFee1.Text)) addFee1 = 0;
                    else addFee1 = double.Parse(txtAddFee1.Text);
                    
                    if (string.IsNullOrWhiteSpace(txtAddFee2.Text)) addFee2 = 0;
                    else addFee2 = double.Parse(txtAddFee2.Text);

                    DateTime datetime = txtDate.Value.AddDays(double.Parse(txtTerm.Text));
                    string query = "INSERT INTO `coop`.`loan` (`loanday`,`loanmonth`,`loanyear`,`loanfee`,`loanterm`,`loanamount`,`loaninterest`,`loancomputed`," +
                        "`totaldeduction`,`duedate`,`balance`,`memberid`,`interestAmount`,`loaninsurance`,`loanAdditionalFee1`,`loanAdditionalFee2`,`loanAdditionalFeeRemarks`,`checkno`) " +
                            "VALUES(" + txtDate.Value.Day + "," +
                            "" + txtDate.Value.Month + "," +
                            "" + txtDate.Value.Year + "," +
                            "" + serviceFee + "," +
                            "" + terms + "," +
                            "" + amount + "," +
                            "" + interestTerms + "," +
                            "" + loanableAmount + "," +
                            "" + totaldeduction + "," +
                            "'" + datetime.ToString("MM/dd/yyyy") + "'," +
                            "" + loanableAmount + "," +
                            "" + memberID + "," +
                            "" + interestAmount + "," +
                            "" + insurance + "," +
                            "" + addFee1 + "," +
                            "" + addFee2 + "," +
                            "'" + txtRemarks.Text + "',";
                    if (!string.IsNullOrWhiteSpace(txtCapitalShare.Text))
                    {
                        frmCheckNo checkno = new frmCheckNo(this, query, conn, cboLoans.SelectedIndex, memberID, double.Parse(txtCapitalShare.Text),
                            txtDate.Value.Day, txtDate.Value.Month, txtDate.Value.Year, IfCollateral, true);
                        checkno.ShowDialog();
                    }
                    else
                    {
                        frmCheckNo checkno = new frmCheckNo(this, query, conn, cboLoans.SelectedIndex, memberID, IfCollateral, false);
                        checkno.ShowDialog();
                    }
                    foreach (DataGridViewRow row in grdLoans.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    }
                    txtLoanable.Clear();
                    txtAmount.Clear();
                    txtTerm.Clear();
                    txtFee.Clear();
                    txtInsurance.Clear();
                    txtCapitalShare.Clear();
                    txtAddFee1.Clear();
                    txtAddFee2.Clear();
                    txtRemarks.Clear();
                }
                else
                {
                    MessageBox.Show(this, "Please fill out all the fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void enterLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            penaltyAmt = double.Parse(grdLoans.SelectedCells[9].Value.ToString());
            balance = double.Parse(grdLoans.SelectedCells[3].Value.ToString());
            duedate = grdLoans.SelectedCells[4].Value.ToString();
            frmPayment payment = new frmPayment(this, conn, loanID, memberID, balance, penaltyAmt, duedate, cboLoans.SelectedIndex);
            payment.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLoanable.Clear();
            txtAmount.Clear();
            txtTerm.Clear();
            txtFee.Clear();
            txtInsurance.Clear();
            txtCapitalShare.Clear();

            lblWarning.Visible = false;
        }

        private void deleteLoanRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show(this, "Delete selected loan record?\nThis process is irreversible.", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dc.fnExecuteQuery("delete from loan where loanID=" + loanID + "", conn);
                LoadLoanList(1, memberID);
            }
        }

        private void setPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            if (!string.IsNullOrWhiteSpace(grdLoans.SelectedCells[9].Value.ToString()))
            {
                penaltyAmt = double.Parse(grdLoans.SelectedCells[9].Value.ToString());
            }
            else
            {
                penaltyAmt = 0;
            }
            frmSetPenalty penalty = new frmSetPenalty(this, conn, loanID, memberID, penaltyAmt, cboLoans.SelectedIndex);
            penalty.ShowDialog();
        }

        private void removePenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `loanpenalty` = NULL WHERE(`loanID` = " + loanID + " and `memberid` = " + memberID + ");", conn);
            MessageBox.Show(this, "Penalty for this loan was successfully removed.\nClick OK to continue.", "Penalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLoanList(1, memberID);
        }

        private void btnAddCollateral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCollateral collateral = new frmCollateral(this);
            collateral.ShowDialog();
        }

        private void decimalKeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as MetroTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void amtCSTextChange()
        {
            if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtCapitalShare.Text))
            {
                try
                {
                    decimal capitalShare = decimal.Parse(txtCapitalShare.Text.ToString());
                    decimal amt = decimal.Parse(txtAmount.Text.ToString());

                    lblWarning.Visible = capitalShare >= amt;
                    btnSave.Enabled = capitalShare < amt;
                }
                catch { }

            }
        }
    }
}
