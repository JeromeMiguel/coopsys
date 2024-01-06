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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace coopsys
{
    public partial class frmLoan : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataTable dt = new DataTable();
        DataTable totalShare = new DataTable();
        DataCollection dc = new DataCollection();
        frmMain main;
        frmCheckNo checkno;
        private int memberID, day, month, year, loanID, age;
        private double penaltyAmt, balance;
        private string duedate;

        private double amount, interestAmount, terms, interestTerms, serviceFee, insurance, loanableAmount, totaldeduction;

        public frmLoan()
        {
            InitializeComponent();
        }

        public frmLoan(frmMain _main, MySqlConnection _conn, int _memberid, string _fname, string _mname, string _lname, int _age)
        {
            InitializeComponent();
            main = _main;
            lblmemname.Text = _lname + ", " + _fname + " " + _mname;
            conn = _conn;
            age = _age;
            memberID = _memberid;
            cboLoans.SelectedIndex = 1;
            LoadLoanList(cboLoans.SelectedIndex);
        }

        private void ComputeLoanableAmount()
        {
            if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtFee.Text) && !string.IsNullOrEmpty(txtTerm.Text) && !string.IsNullOrEmpty(txtInsurance.Text))
            {
                amount = double.Parse(txtAmount.Text);
                interestAmount = double.Parse(txtAmount.Text) * .01;
                terms = double.Parse(txtTerm.Text) / 30;
                interestTerms = interestAmount * terms;
                serviceFee = double.Parse(txtFee.Text);
                insurance = double.Parse(txtInsurance.Text);
                totaldeduction = interestTerms + serviceFee + insurance + double.Parse(txtCapitalShare.Text);

                if (!string.IsNullOrWhiteSpace(txtAmount.Text) && 
                    !string.IsNullOrWhiteSpace(txtFee.Text) && 
                    !string.IsNullOrWhiteSpace(txtTerm.Text) && 
                    !string.IsNullOrWhiteSpace(txtInsurance.Text))
                {
                    if(string.IsNullOrWhiteSpace(txtCapitalShare.Text))
                    {
                        loanableAmount = amount - (interestTerms + serviceFee + insurance);
                    }
                    else
                    {
                        loanableAmount = amount - totaldeduction;
                    }
                    txtLoanable.Text = Math.Round(loanableAmount, 2).ToString();
                }
            }
            else
            {
                txtLoanable.Clear();
            }
        }

        public void LoadLoanList(int loanstatus)
        {
            if(loanstatus == 0)
            {
                grdLoans.DataSource = dc.fnDataTableCollection("select loanID, " +
                "\r\nconcat(loanmonth, " +
                "'/', loanday,  '/', loanyear) as 'DATE', " +
                "loanamount as 'AMOUNT', balance as 'BALANCE', duedate as 'DUE', " +
                "loanpenaltyamount as 'PENALTY' " +
                "from loan left join penalty on loan.loanpenalty=penalty.loanpenalty " +
                "where memberid= " + memberID + ";", conn);
            }
            else if(loanstatus == 1)
            {
                grdLoans.DataSource = dc.fnDataTableCollection("select loanID, " +
                "\r\nconcat(loanmonth, " +
                "'/', loanday,  '/', loanyear) as 'DATE', " +
                "loanamount as 'AMOUNT', balance as 'BALANCE', duedate as 'DUE', " +
                "loanpenaltyamount as 'PENALTY' " +
                "from loan left join penalty on loan.loanpenalty=penalty.loanpenalty " +
                "where memberid= " + memberID + " and balance > 0;", conn);
            }
            else if(loanstatus == 2)
            {
                grdLoans.DataSource = dc.fnDataTableCollection("select loanID, " +
                "\r\nconcat(loanmonth, " +
                "'/', loanday,  '/', loanyear) as 'DATE', " +
                "loanamount as 'AMOUNT', balance as 'BALANCE', duedate as 'DUE', " +
                "loanpenaltyamount as 'PENALTY' " +
                "from loan left join penalty on loan.loanpenalty=penalty.loanpenalty " +
                "where memberid= " + memberID + " and balance = 0;", conn);
            }

            grdLoans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdLoans.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoans.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdLoans.Columns[0].Visible = false;
        }

        #region Textbox KeyPress Events
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCapitalShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void grdLoans_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                grdLoans.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataRow.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void cboLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoanList(cboLoans.SelectedIndex);
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
                if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtFee.Text) && !string.IsNullOrEmpty(txtTerm.Text))
                {
                    DateTime datetime = txtDate.Value.AddDays(double.Parse(txtTerm.Text));
                    if(string.IsNullOrWhiteSpace(txtCapitalShare.Text))
                    {
                        //dc.fnExecuteQuery("INSERT INTO `coop`.`loan` " +
                        //"(`loanday`, `loanmonth`, `loanyear`, `loanfee`, `loanterm`, `loanamount`, `loaninterest`, `loancomputed`, `duedate`, `balance`, `memberid`) " +
                        //"VALUES (" + txtDate.Value.Day + ", " + txtDate.Value.Month + ", " + txtDate.Value.Year + ", " + double.Parse(txtFee.Text) + ", " + double.Parse(txtTerm.Text) + ", " +
                        //double.Parse(txtAmount.Text) + ", " + (double.Parse(txtAmount.Text) * .01) + ", " + Math.Round(double.Parse(txtLoanable.Text), 2) + ", '" + datetime.ToString("MM/dd/yyyy") + "', " + double.Parse(txtLoanable.Text) + ", " + memberID + ");", conn);

                        //dc.fnExecuteQuery("INSERT INTO `coop`.`loan` (``loanday`,`loanmonth`,`loanyear`,`loanfee`,`loanterm`,`loanamount`,`loaninterest`,`loancomputed`,`totaldeduction`,`duedate`,`balance`,`memberid`,`checkno`)" +
                        //    "VALUES("+txtDate.Value.Day+","+txtDate.Value.Month+","+txtDate.Value.Year+","+serviceFee+","+terms+","+amount+","+interestTerms+","+loanableAmount+","+totaldeduction+ ",'"+datetime.ToString("MM/dd/yyyy")+"',"+loanableAmount+","+memberID+",<{checkno: }>);");

                        string query = "INSERT INTO `coop`.`loan` (``loanday`,`loanmonth`,`loanyear`,`loanfee`,`loanterm`,`loanamount`,`loaninterest`,`loancomputed`,`totaldeduction`,`duedate`,`balance`,`memberid`,`checkno`)" +
                            "VALUES(" + txtDate.Value.Day + "," + txtDate.Value.Month + "," + txtDate.Value.Year + "," + serviceFee + "," + terms + "," + amount + "," + interestTerms + "," + loanableAmount + "," + totaldeduction + ",'" + datetime.ToString("MM/dd/yyyy") + "'," + loanableAmount + "," + memberID + ",";

                        grdLoans.DataSource = null;
                        txtLoanable.Clear();
                        txtAmount.Clear();
                        txtTerm.Clear();
                        txtFee.Clear();
                        txtInsurance.Clear();
                        txtCapitalShare.Clear();
                        checkno = new frmCheckNo(this, query, conn);
                    }
                    else
                    {
                        dc.fnExecuteQuery("INSERT INTO `coop`.`loan` " +
                        "(`loanday`, `loanmonth`, `loanyear`, `loanfee`, `loanterm`, `loanamount`, `loaninterest`,`loancomputed`, `duedate`, `balance`, `memberid`) " +
                        "VALUES (" + txtDate.Value.Day + ", " + txtDate.Value.Month + ", " + txtDate.Value.Year + ", " + double.Parse(txtFee.Text) + ", " + double.Parse(txtTerm.Text) + ", " +
                        double.Parse(txtAmount.Text) + ", " + (double.Parse(txtAmount.Text) * .01) + ", " + Math.Round(double.Parse(txtLoanable.Text), 2) + ", '" + datetime.ToString("MM/dd/yyyy") + "', " + double.Parse(txtLoanable.Text) + ", " + memberID + ");", conn);

                        dc.fnExecuteQuery("INSERT INTO `coop`.`capitalshare` (`csamount`, `day`, `month`, `year`, `memberID`) " +
                        "VALUES (" + double.Parse(txtCapitalShare.Text) + ", " + Int32.Parse(txtDate.Value.Day.ToString()) + ", " +
                        "" + Int32.Parse(txtDate.Value.Month.ToString()) + ", " + Int32.Parse(txtDate.Value.Year.ToString()) + ", " +
                        "" + memberID + ");", conn);

                        grdLoans.DataSource = null;
                        txtLoanable.Clear();
                        txtAmount.Clear();
                        txtTerm.Clear();
                        txtFee.Clear();
                        txtInsurance.Clear();
                        txtCapitalShare.Clear();
                        MessageBox.Show(this, "Record saved successfully.\nClick OK to proceed.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLoanList(1);
                    }
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
            penaltyAmt = double.Parse(grdLoans.SelectedCells[5].Value.ToString());
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
        }

        private void deleteLoanRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show(this, "Delete selected loan record?\nThis process is irreversible.", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dc.fnExecuteQuery("delete from loan where loanID=" + loanID + "", conn);
                LoadLoanList(1);
            }
        }

        private void setPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            penaltyAmt = double.Parse(grdLoans.SelectedCells[5].Value.ToString());
            frmPenalty penalty = new frmPenalty(this, conn, loanID, memberID, penaltyAmt, cboLoans.SelectedIndex);
            penalty.ShowDialog();
        }

        private void removePenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanID = Int32.Parse(grdLoans.SelectedCells[0].Value.ToString());
            dc.fnExecuteQuery("UPDATE `coop`.`loan` SET `loanpenalty` = NULL WHERE(`loanID` = " + loanID + " and `memberid` = " + memberID + ");", conn);
            MessageBox.Show(this, "Penalty for this loan was successfully removed.\nClick OK to continue.", "Penalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLoanList(1);
        }
    }
}
