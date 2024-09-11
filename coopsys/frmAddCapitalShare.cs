﻿using System;
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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace coopsys
{
    public partial class frmAddCapitalShare : MetroFramework.Forms.MetroForm
    {
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        frmViewMemberShares viewMemberShares;
        private int memberID, capitalShareID, remarks;
        private bool addShare, fromLoan;
        private string orNum;

        public frmAddCapitalShare()
        {
            InitializeComponent();
        }

        public frmAddCapitalShare(frmViewMemberShares _viewMemberShares, MySqlConnection _conn, int _memberID, bool _addShare)
        {
            InitializeComponent();
            viewMemberShares = _viewMemberShares;
            memberID = _memberID;
            conn = _conn;
            addShare = _addShare;
        }

        public frmAddCapitalShare(frmViewMemberShares _viewMemberShares, MySqlConnection _conn, int _memberID, int _capitalShareID, double _capitalShareAmount, bool _addShare, string _date, int _remarks, string _orNum)
        {
            InitializeComponent();
            viewMemberShares = _viewMemberShares;
            memberID = _memberID;
            capitalShareID = _capitalShareID;
            txtCapitalShare.Text = _capitalShareAmount.ToString();
            conn = _conn;
            addShare = _addShare;
            txtDate.Text = _date;
            chkUnclaimed.Checked = _remarks == 1;
            txtOrNum.Text = _orNum;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtCapitalShare.Text) || !string.IsNullOrWhiteSpace(txtOrNum.Text))
            {
                // Add Capital Share
                if (addShare)
                {
                    if (!string.IsNullOrWhiteSpace(txtOrNum.Text))
                    {
                        dc.fnExecuteQuery("INSERT INTO `coop`.`capitalshare` (`csamount`, `day`, `month`, `year`, `cs_or_num`, `memberID`, `unclaimed`) " +
                            "VALUES (" + double.Parse(txtCapitalShare.Text) + ", " + Int32.Parse(txtDate.Value.Day.ToString()) + ", " +
                            "" + Int32.Parse(txtDate.Value.Month.ToString()) + ", " + Int32.Parse(txtDate.Value.Year.ToString()) + ", " +
                            "'" + txtOrNum.Text + "', " + memberID + ", "+ chkUnclaimed.Checked + ");", conn);
                        MessageBox.Show(this, "Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewMemberShares.LoadCapitalShares();
                        this.Dispose();
                    }
                    else
                    {
                        tipRequired.Show("Please enter the OR number.", txtOrNum, 2000);
                    }
                }

                // Edit Capital Share
                else
                {
                    dc.fnExecuteQuery("UPDATE `coop`.`capitalshare` SET `csamount` = " + double.Parse(txtCapitalShare.Text) + ", " +
                     "`day` = " + Int32.Parse(txtDate.Value.Day.ToString()) + ", " +
                     "`month` = " + Int32.Parse(txtDate.Value.Month.ToString()) + ", " +
                     "`year` = " + Int32.Parse(txtDate.Value.Year.ToString()) + ", " +
                     "`cs_or_num` = '" + txtOrNum.Text + "', " +
                     "`unclaimed` = "+ chkUnclaimed.Checked +" " +
                     "WHERE (`csID` = " + capitalShareID + ");", conn);
                    MessageBox.Show(this, "Record udpated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewMemberShares.LoadCapitalShares();
                    this.Dispose();
                }
            }
            else
            {
                tipRequired.Show("Please enter the capital share amount.", txtCapitalShare, 2000);
            }

        }

        private void txtCapitalShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
