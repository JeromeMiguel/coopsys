﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using calypso;
using calypso.DataAccess;
using MySql.Data.MySqlClient;

namespace coopsys
{
    public partial class frmViewMemberShares : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataTable dt = new DataTable();
        DataTable totalShare = new DataTable();
        DataCollection dc = new DataCollection();
        private int memberID, capitalShareID;
        private double capitalShareAmount;
        private string date;

        public frmViewMemberShares()
        {
            InitializeComponent();
        }

        public frmViewMemberShares(MySqlConnection _conn, int _memberID, int _memberType, string _fname, string _mname, string _lname)
        {
            InitializeComponent();
            conn = _conn;
            memberID = _memberID;
            if (_memberType == 1)
            {
                lblmemname.Text = "" + _lname + ", " + " " + _fname + " " + _mname.Substring(0, 1) + ".\nAssociate Member";

            }
            else
            {
                lblmemname.Text = "" + _lname + ", " + " " + _fname + " " + _mname.Substring(0, 1) + ".\nRegular Member";

            }

            grdShares.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt = dc.fnDataTableCollection("select distinct year from capitalshare;", conn);
            
            cboYear.DataSource = dt;
            cboYear.DisplayMember = "year";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }
            cboMonth.SelectedIndex = 0;
        }

        public void LoadCapitalShares()
        {
            grdShares.DataSource = dc.fnDataViewCollection("use coop;\r\nselect csID, csamount as 'AMOUNT', " +
                "concat(CASE month " +
                    "WHEN 1 then '01' " +
                    "WHEN 2 then '02' " +
                    "WHEN 3 then '03' " +
                    "WHEN 4 then '04' " +
                    "WHEN 5 then '05' " +
                    "WHEN 6 then '06' " +
                    "WHEN 7 then '07' " +
                    "WHEN 8 then '08' " +
                    "WHEN 9 then '09' " +
                    "WHEN 10 then '10' " +
                    "WHEN 11 then '11' " +
                    "ELSE '12' " +
                    "END, '/', day, '/', year) as 'DATE' "+
                "from capitalshare " +
                "where memberID=" + memberID + ";", conn);

            try
            {
                dt = dc.fnDataTableCollection("select distinct year from capitalshare;", conn);
                totalShare = dc.fnDataTableCollection("select cast(sum(csamount) as UNSIGNED) as 'total' " +
                "from capitalshare where memberID=" + memberID + " and year=" + cboYear.Text + ";");
                lbltotalshares.Text = "Total share as of " + cboYear.Text + ": ₱" + totalShare.Rows[0][0].ToString();
                cboYear.DataSource = dt;
                cboYear.DisplayMember = "year";
                if (cboYear.Items.Count > 0)
                {
                    cboYear.SelectedIndex = 0;
                }
            }
            catch { }
            grdShares.Columns[0].Visible = false;
        }

        private void frmViewMemberShares_Load(object sender, EventArgs e)
        {
                LoadCapitalShares();
        }

        private void grdShares_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                grdShares.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataRow.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            grdShares.DataSource = null;
            grdShares.DataSource = dc.fnDataViewCollection("use coop;\r\nselect csID, csamount as 'AMOUNT'," +
                "concat(CASE month " +
                    "WHEN 1 then '01' " +
                    "WHEN 2 then '02' " +
                    "WHEN 3 then '03' " +
                    "WHEN 4 then '04' " +
                    "WHEN 5 then '05' " +
                    "WHEN 6 then '06' " +
                    "WHEN 7 then '07' " +
                    "WHEN 8 then '08' " +
                    "WHEN 9 then '09' " +
                    "WHEN 10 then '10' " +
                    "WHEN 11 then '11' " +
                    "ELSE '12' " +
                    "END, '/', day, '/', year) as 'DATE' " +
                "from capitalshare " +
                "where memberID=" + memberID + " and month=" + (cboMonth.SelectedIndex + 1) + " and year=" + Int32.Parse(cboYear.Text) + ";", conn);

            try
            {
                dt = dc.fnDataTableCollection("select distinct year from capitalshare;", conn);
                totalShare = dc.fnDataTableCollection("select cast(sum(csamount) as UNSIGNED) as 'total' " +
                "from capitalshare where memberID=" + memberID + " and year=" + cboYear.Text + ";");
                lbltotalshares.Text = "Total share as of " + cboYear.Text + ": ₱" + totalShare.Rows[0][0].ToString();
                cboYear.DataSource = dt;
                cboYear.DisplayMember = "year";
                if (cboYear.Items.Count > 0)
                {
                    cboYear.SelectedIndex = 0;
                }
            }
            catch { }
            grdShares.Columns[0].Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCapitalShares();
        }

        private void btnAddShare_Click(object sender, EventArgs e)
        {
            frmAddCapitalShare addCapitalShare = new frmAddCapitalShare(this, conn, memberID, true);
            addCapitalShare.ShowDialog();
        }

        private void editCapitalShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capitalShareID = Int32.Parse(grdShares.SelectedCells[0].Value.ToString());
            capitalShareAmount = double.Parse(grdShares.SelectedCells[1].Value.ToString());
            date = grdShares.SelectedCells[2].Value.ToString();
            frmAddCapitalShare editCapitalShare = new frmAddCapitalShare(this, conn, memberID, capitalShareID, capitalShareAmount, false, date);
            editCapitalShare.ShowDialog();
        }

        private void deleteCapitalShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capitalShareID = Int32.Parse(grdShares.SelectedCells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show(this, "Delete selected capital share record?\nThis process is irreversible.", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                dc.fnExecuteQuery("delete from capitalshare where csID=" + capitalShareID + "", conn);
                LoadCapitalShares();
            }
        }

        private void frmViewMemberShares_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
