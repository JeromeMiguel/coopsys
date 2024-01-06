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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace coopsys
{
    public partial class frmPenalty : MetroFramework.Forms.MetroForm
    {
        frmLoan formLoan;
        MySqlConnection conn;
        DataCollection dc = new DataCollection();
        private int memberID, loanid, cboLoansIndex;
        private double penaltyAmt;

        public frmPenalty()
        {
            InitializeComponent();
        }

        public frmPenalty(frmLoan _formLoan, MySqlConnection _conn, int _loanid, int _memberid, double _penaltyAmt, int _cboLoansIndex)
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
            //loan penalty status = 1 (unpaid)
            //loan penalty status = 2 (paid)
            dc.fnExecuteQuery("insert into penalty(loanpenaltyamount, loanpenaltystatus, loanpenaltydateadded) " +
                "values(" + double.Parse(txtPenalty.Text) + ", 1, " + DateTime.Now.ToString("MM/dd/yyyy") + ");", conn);
            MessageBox.Show(this, "Penalty value saved to loan record.\nClick OK to exit the window.", "Penalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formLoan.LoadLoanList(cboLoansIndex);
            this.Dispose();
        }

        private void frmPenalty_Load(object sender, EventArgs e)
        {
            txtPenalty.Text = penaltyAmt.ToString();
        }

        private void txtPenalty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
