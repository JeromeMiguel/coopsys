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
using calypso.DataAccess;
using MetroFramework.Controls;

namespace coopsys
{

    public partial class frmViewSavings : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection conn;
        private int memberID;
        private string fname, mname, lname, accountNum, savingsID, currentBalance, createdAt;
        DataTable dtAcc = new DataTable(), dt = new DataTable();
        DataCollection dc = new DataCollection();

        public frmViewSavings(MySqlConnection _conn, int _memberID, string _fname, string _mname, string _lname)
        {
            InitializeComponent();
        
            conn = _conn;
            fname = _fname;
            mname = _mname;
            lname = _lname;
            memberID = _memberID;
            
            //Get Savings Account Info
            dtAcc = dc.fnDataTableCollection("SELECT savingsID, current_balance, created_at, account_number FROM coop.savings " +
                "INNER JOIN coop.member ON coop.member.memberID = coop.savings.memberID WHERE coop.savings.memberID = "+memberID+";", conn);
           

            savingsID = dtAcc.Rows[0][0].ToString();
            currentBalance = decimal.Parse(dtAcc.Rows[0][1].ToString()).ToString("#,##0.00");
            createdAt = DateTime.Parse(dtAcc.Rows[0][2].ToString()).ToString("MM/dd/yyyy");
            accountNum = dtAcc.Rows[0][3].ToString();

            txtAccount.Text = accountNum;
            txtName.Text = "" + fname + " " + mname + " " + lname + "";
            txtDate.Text = createdAt;
            lblBalance.Text = "₱ "+currentBalance+"";

            //Get Transaction History
            dt = dc.fnDataTableCollection("", conn);
        }
    }
}
