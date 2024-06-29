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
    public partial class frmCheckNo : MetroFramework.Forms.MetroForm
    {
        frmLoan frmLoan;
        MySqlConnection conn;
        DataTable dt = new DataTable();
        DataTable totalShare = new DataTable();
        DataCollection dc = new DataCollection();
        string query;
        int loanIndex, memberID, day, month, year;
        double capitalShare;
        bool iscapShare, IfCollateral;

        //loan with capital share
        public frmCheckNo(frmLoan _loan, string _query, MySqlConnection _conn, int _loanIndex, int _memberID, double _capitalShare, 
            int _day, int _month, int _year, bool _IfCollateral, bool _iscapShare)
        {
            InitializeComponent();
            frmLoan = _loan;
            query = _query;
            conn = _conn;
            loanIndex = _loanIndex;
            memberID = _memberID;
            capitalShare = _capitalShare;
            iscapShare = _iscapShare;
            IfCollateral = _IfCollateral;
            day = _day;
            month = _month;
            year = _year;
        }

        //loan without capital share
        public frmCheckNo(frmLoan _loan, string _query, MySqlConnection _conn, int _loanIndex, int _memberID, bool _IfCollateral, bool _iscapShare)
        {
            InitializeComponent();
            frmLoan = _loan;
            query = _query;
            conn = _conn;
            loanIndex = _loanIndex;
            memberID = _memberID;
            iscapShare = _iscapShare;
            IfCollateral = _IfCollateral;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (iscapShare)
            {
                dc.fnExecuteQuery(query + "'" + txtCheckNo.Text + "')", conn);
                dc.fnExecuteQuery("INSERT INTO `coop`.`capitalshare`(`csamount`,`day`,`month`,`year`,`memberID`,`loanid`)" +
                    "VALUES(" + capitalShare + ", " + day + ", " + month + ", " + year + ", " + memberID + ", (select distinct last_insert_id() from loan));", conn);
                if(IfCollateral)
                {
                    dc.fnExecuteQuery("INSERT INTO `coop`.`collateral`(`propDesc`,`propSurvey`,`propArea`,`propLoc`,`vehPlate`,`vehEngine`,`vehChassis`,`vehMake`,`chqNum`,`chqAmt`,`loanid`)" +
                    "VALUES('" + frmLoan.propDesc + "'," +
                    "'" + frmLoan.propSurvey + "'," +
                    "'" + frmLoan.propArea + "'," +
                    "'" + frmLoan.propLoc + "'," +
                    "'" + frmLoan.vehPlate + "'," +
                    "'" + frmLoan.vehEngine + "'," +
                    "'" + frmLoan.vehChassis + "'," +
                    "'" + frmLoan.vehMake + "'," +
                    "'" + frmLoan.chqNum + "'," +
                    "" + frmLoan.chqAmt + ", (select max(loanid) from loan));", conn);
                }
                
                frmLoan.LoadLoanList(loanIndex, memberID);
                MessageBox.Show(this, "Record saved successfully. \n\nClick OK to continue.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                dc.fnExecuteQuery(query + "'" + txtCheckNo.Text + "')", conn);
                if (IfCollateral)
                {
                    dc.fnExecuteQuery("INSERT INTO `coop`.`collateral`(`propDesc`,`propSurvey`,`propArea`,`propLoc`,`vehPlate`,`vehEngine`,`vehChassis`,`vehMake`,`chqNum`,`chqAmt`,`loanid`)" +
                    "VALUES('" + frmLoan.propDesc + "'," +
                    "'" + frmLoan.propSurvey + "'," +
                    "'" + frmLoan.propArea + "'," +
                    "'" + frmLoan.propLoc + "'," +
                    "'" + frmLoan.vehPlate + "'," +
                    "'" + frmLoan.vehEngine + "'," +
                    "'" + frmLoan.vehChassis + "'," +
                    "'" + frmLoan.vehMake + "'," +
                    "'" + frmLoan.chqNum + "'," +
                    "" + frmLoan.chqAmt + ", (select max(loanid) from loan));", conn);
                }

                frmLoan.LoadLoanList(loanIndex, memberID);
                MessageBox.Show(this, "Record saved successfully. \n\nClick OK to continue.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void frmCheckNo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
