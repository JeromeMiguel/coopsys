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
using calypso.DataAccess;
using Google.Protobuf.WellKnownTypes;
using MetroFramework.Controls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace coopsys
{
    public partial class frmSetPenalty : MetroFramework.Forms.MetroForm
    {
        frmLoan formLoan;
        MySqlConnection conn;
        DataCollection dc = new DataCollection();
        private int memberID, loanid, cboLoansIndex;
        private double penaltyAmt;

        public frmSetPenalty()
        {
            InitializeComponent();
        }

        public frmSetPenalty(frmLoan _formLoan, MySqlConnection _conn, int _loanid, int _memberid, double _penaltyAmt, int _cboLoansIndex)
        {
            InitializeComponent();
            formLoan = _formLoan;
            conn = _conn;
            memberID = _memberid;
            loanid = _loanid;
            penaltyAmt = _penaltyAmt;
            cboLoansIndex = _cboLoansIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //loan penalty status = 0 default
            //loan penalty status = 1 (cancelled)
            double inputPenaltyAmt = double.Parse(txtPenalty.Text);

            if (int.Parse(dc.fnReturnStringValue("select count(loanid) as Res from penalty where loanid = " + loanid + "", "Res", conn)) > 0)
            {
                if(int.Parse(dc.fnReturnStringValue("select penaltystatus from penalty where loanid = " + loanid + "", "penaltystatus", conn)) == 0)
                {
                    dc.fnExecuteQuery("UPDATE `coop`.`penalty` SET `penaltyamount` = " + inputPenaltyAmt + " WHERE (`loanid` = " + loanid + ");", conn);
                }
            }
            else
            {
                dc.fnExecuteQuery("INSERT INTO `coop`.`penalty`(`penaltyamount`,`penaltystatus`,`penaltydateadded`,`loanid`)" +
                "VALUES(" + txtPenalty.Text + ",0,'" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "'," + loanid + ");", conn);
            }
           
            MessageBox.Show(this, "Penalty value saved to loan record.\nClick OK to exit the window.", "Penalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formLoan.LoadLoanList(cboLoansIndex, memberID);
            this.Dispose();
        }

        private void frmPenalty_Load(object sender, EventArgs e)
        {
            txtPenalty.Text = penaltyAmt == 0 ? 
               double.Parse(dc.fnReturnStringValue("SELECT loan_penalty AS 'loanPenalty' FROM coop.defaults;", "loanPenalty", conn)).ToString("G29") : penaltyAmt.ToString();
        }

        private void txtPenalty_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
