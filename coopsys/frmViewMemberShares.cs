using System;
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
        private int memberID, capitalShareID, remarks, memberType;
        private double capitalShareAmount;
        private string date, orNum;

        public frmViewMemberShares()
        {
            InitializeComponent();
        }

        public frmViewMemberShares(MySqlConnection _conn, int _memberID, int _memberType, string _fname, string _mname, string _lname)
        {
            InitializeComponent();
            conn = _conn;
            memberID = _memberID;
            memberType = _memberType;

            lblmemname.Text = "" + _lname + "," + " " + _fname + " " + _mname.Substring(0, 1)+".";
            lblMemType.Text = memberType == 1 ? "Associate Member" : "Regular Member";

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
            grdShares.DataSource = dc.fnDataViewCollection("use coop;\r\nselect csID, format(csamount,2) as 'AMOUNT', " +
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
                    "END, '/', if(day<10,concat(0,day),day), '/', year) as 'DATE', if(unclaimed=1, 'Unclaimed','') as 'REMARKS', " +
                    "cs_or_num as 'OR No.' " +
                "from capitalshare " +
                "where memberID=" + memberID + " order by year desc, month desc, day desc;", conn);

            try
            {
                dt = dc.fnDataTableCollection("select distinct year from capitalshare;", conn);
                totalShare = dc.fnDataTableCollection("select format(sum(csamount),2) as 'total' " +
                "from capitalshare where memberID=" + memberID + " and year=" + cboYear.Text + ";");
                lblTotalSharesYear.Text = "Total share as of " + cboYear.Text + ": ";
                lblTotalShares.Text = "₱ " + (totalShare.Rows[0][0].ToString() == "" ? "0.00" : totalShare.Rows[0][0].ToString());
                cboYear.DataSource = dt;
                cboYear.DisplayMember = "year";
                if (cboYear.Items.Count > 0)
                {
                    cboYear.SelectedIndex = 0;
                }
            }
            catch { }
            grdShares.Columns[0].Visible = false;
            foreach (DataGridViewRow row in grdShares.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmViewMemberShares_Load(object sender, EventArgs e)
        {
            LoadCapitalShares();
            if (cboYear.Items.Count != 0)
            {
                btnFilter.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void grdShares_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    grdShares.Rows[e.RowIndex].Selected = true;
                    contextMenuStripDataRow.Show(MousePosition.X, MousePosition.Y);
                }
                catch { }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            grdShares.DataSource = null;
            grdShares.DataSource = dc.fnDataViewCollection("use coop;\r\nselect csID, format(csamount,2) as 'AMOUNT'," +
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
                    "END, '/', if(day<10,concat(0,day),day), '/', year) as 'DATE', if(unclaimed=1, 'Unclaimed','') as 'REMARKS', " +
                    "cs_or_num as 'OR No.' " +
                "from capitalshare " +
                "where memberID=" + memberID + " and month=" + (cboMonth.SelectedIndex + 1) + " and year=" + Int32.Parse(cboYear.Text) + " " +
                "order by year desc, month desc, day desc;", conn);

            try
            {
                dt = dc.fnDataTableCollection("select distinct year from capitalshare;", conn);
                totalShare = dc.fnDataTableCollection("select format(sum(csamount),2) as 'total' " +
                "from capitalshare where memberID=" + memberID + " and year=" + cboYear.Text + ";");
                lblTotalSharesYear.Text = "Total share as of " + cboYear.Text + ": ₱" + totalShare.Rows[0][0].ToString();
                cboYear.DataSource = dt;
                cboYear.DisplayMember = "year";
                if (cboYear.Items.Count > 0)
                {
                    cboYear.SelectedIndex = 0;
                }
            }
            catch { }
            grdShares.Columns[0].Visible = false;

            foreach (DataGridViewRow row in grdShares.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

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
            remarks =int.Parse(grdShares.SelectedCells[3].Value.ToString() == "Unclaimed" ? "1":"0");
            orNum = grdShares.SelectedCells[4].Value.ToString();
            frmAddCapitalShare editCapitalShare = new frmAddCapitalShare(this, conn, memberID, capitalShareID, capitalShareAmount, false, date, remarks, orNum);
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

        private void grdShares_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdShares.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmViewMemberShares_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
