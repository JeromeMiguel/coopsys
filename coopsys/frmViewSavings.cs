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
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Math;
using Microsoft.Office.Core;
using System.Security.Cryptography;

namespace coopsys
{

    public partial class frmViewSavings : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection conn;
        private int memberID;
        private decimal currentBalance;
        private string fname, mname, lname, accountNum, savingsID, currentBalanceText, createdAt;

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // type: 1 - debit (withdraw);  2 - credit (deposit)
            frmTransaction form = new frmTransaction(conn, savingsID, 1, currentBalance, accountNum, memberID, fname, mname, lname, this);
            form.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmTransaction form = new frmTransaction(conn, savingsID, 2, currentBalance, accountNum, memberID, fname, mname, lname, this);
            form.ShowDialog();
        }

        private void grdTransactions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setRowHeadNumber();
        }

        System.Data.DataTable dtAcc = new System.Data.DataTable(), dt = new System.Data.DataTable();
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
            getAccInfo();

            //Get Transaction History
            getTransactions();

        }

        public void getAccInfo()
        {
            dtAcc = dc.fnDataTableCollection("SELECT savingsID, current_balance, created_at, account_number FROM coop.savings " +
              "INNER JOIN coop.member ON coop.member.memberID = coop.savings.memberID WHERE coop.savings.memberID = " + memberID + ";", conn);


            savingsID = dtAcc.Rows[0][0].ToString();
            currentBalance = decimal.Parse(dtAcc.Rows[0][1].ToString());
            currentBalanceText = currentBalance.ToString("#,##0.00");
            createdAt = DateTime.Parse(dtAcc.Rows[0][2].ToString()).ToString("MM/dd/yyyy");
            accountNum = dtAcc.Rows[0][3].ToString();


            txtAccount.Text = accountNum;
            txtName.Text = "" + fname + " " + mname + " " + lname + "";
            txtDate.Text = createdAt;
            lblBalance.Text = "₱ " + currentBalanceText + "";
        }

        public void getTransactions()
        {
            dt = dc.fnDataTableCollection("SELECT transactionsID, " +
                "CASE WHEN type = 1 THEN 'Withdraw' WHEN type = 2 THEN 'Deposit' ELSE 'Interest' END AS 'Type',   date AS 'Date', " +
                "CASE WHEN type = 1 THEN FORMAT(amount, 2) END AS 'Amt Withdrawn', " +
                "CASE WHEN type = 2 THEN FORMAT(amount, 2) END AS 'Amt Deposit', " +
                "CASE WHEN type = 3 THEN FORMAT(amount, 2) END AS 'Amt Interest', " +
                "FORMAT(balance_after, 2) AS 'Balance' FROM coop.transactions " +
                "WHERE savingsID = " + savingsID + " order by transactionsID desc;", conn);
            grdTransactions.DataSource = dt;

            grdTransactions.Columns[0].Visible = false;
      
        }

        private void setRowHeadNumber()
        {
            foreach (DataGridViewRow row in grdTransactions.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
    }
}
