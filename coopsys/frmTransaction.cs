using calypso.DataAccess;
using MetroFramework.Controls;
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
    public partial class frmTransaction : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection conn;
        private int type, memberID;
        private string savingsID, accountNum, fname, mname, lname;
        private Form prevForm;

      
        private decimal balanceBefore, amount, balanceAfter;
        DataCollection dc = new DataCollection();


        public frmTransaction(MySqlConnection _conn, string _savingsID, int _type, decimal _balanceBefore, string _accountNum, 
            int _memberID, string _fname, string _mname, string _lname, frmViewSavings parentForm)
        {

            InitializeComponent();

            conn = _conn;
            type = _type;
            savingsID = _savingsID;
            accountNum = _accountNum;
            balanceBefore = _balanceBefore;
            memberID = _memberID;
            fname = _fname;
            mname = _mname;
            lname = _lname;

            lblAccountNum.Text = "Account Number: "+accountNum+"";
            lblBalance.Text = "₱ "+balanceBefore.ToString("#,##0.00")+"";

            btnTransaction.Enabled = false;
            lblWarning.Text =  "⚠️ Amount does not meet the minimum requirement" ;

            // type: 1 - debit (withdraw);  2 - credit (deposit)
            this.Text = type == 1 ? "Withdraw" : "Deposit";
            btnTransaction.Text =  type == 1 ? "Withdraw" : "Deposit";

            // Reload frmViewSavings on close
            this.FormClosing += delegate { parentForm.getAccInfo(); parentForm.getTransactions(); };
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            amount = decimal.Parse(txtAmount.Text);
            balanceAfter = type ==1 ? balanceBefore - amount : balanceBefore + amount;
            
            if (type == 1)
            {
                //For Withdraw 
                MessageBox.Show("Withdraw ₱ " + amount.ToString("#,##0.00") + " from " + fname + " " + mname + " " + lname + "'s Account?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                //For Deposit
                MessageBox.Show("Deposit ₱ " + amount.ToString("#,##0.00") + " to " + fname + " " + mname + " " + lname + "'s Account?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }


            //Insert Transaction record to Transaction Table
            dc.fnExecuteQuery("INSERT INTO `coop`.`transactions` (`type`, `amount`, `balance_before`, `balance_after`, `date`, `savingsID`) " +
                "VALUES ("+type+", "+amount+", "+balanceBefore+", "+balanceAfter+", NOW(), "+savingsID+");", conn);

            //Update current balance at Savings Table
            dc.fnExecuteQuery("UPDATE `coop`.`savings` SET `current_balance` = "+balanceAfter+" WHERE (`savingsID` = "+savingsID+");", conn);

            MessageBox.Show("Transaction Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtAmount.Text)) { amount = decimal.Parse(txtAmount.Text); } 
            else { amount = 0; }


            if ((amount > balanceBefore && type==1) || amount <= 0)
            {
                lblWarning.Text = amount <= 0 ? "⚠️ Amount does not meet the minimum requirement" : "⚠️ Amount exceeds the user's current balance";
                btnTransaction.Enabled = false;
            
            }  
            else
            {
                lblWarning.Text = "";
                btnTransaction.Enabled = true;
            }
        }

    }
}
