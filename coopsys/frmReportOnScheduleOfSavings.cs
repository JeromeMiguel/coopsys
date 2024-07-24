using calypso.DataAccess;
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
    public partial class frmReportOnScheduleOfSavings : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        public string query;

        public frmReportOnScheduleOfSavings(MySqlConnection _conn)
        {
            InitializeComponent();

            conn = _conn;
            dt = dc.fnDataTableCollection("SELECT DISTINCT YEAR(created_at) as 'Year' FROM coop.savings ORDER BY YEAR(created_at) DESC;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "Year";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex >= 0)
            {
                btnGenerateReport.Enabled = true;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            query = "select NAMES, " +
                "format(january,2) as 'JAN'," +
                "format(february,2) as 'FEB'," +
                "format(march,2) as 'MAR'," +
                "format(april,2) as 'APR'," +
                "format(may,2) as 'MAY'," +
                "format(june,2) as 'JUN'," +
                "format(july,2) as 'JUL'," +
                "format(august,2) as 'AUG'," +
                "format(september,2) as 'SEP'," +
                "format(october,2) as 'OCT'," +
                "format(november,2) as 'NOV'," +
                "format(december,2) as 'DEC'" +
                "from (select m.memberid, concat(lastname, ', ', firstname) as 'NAMES', " +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=1 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'January'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=2 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'February'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=3 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'March'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=4 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'April'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=5 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'May'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=6 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'June'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=7 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'July'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=8 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'August'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=9 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'September'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=10 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'October'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=11 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'November'," +
                "(select ifnull(balance_after,0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=12 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID order by date desc limit 1) as 'December'" +
                "from savings inner join member m on savings.memberid = m.memberid where memstatus=0 group by m.memberID order by lastname asc) t group by memberID;";

            dt = dc.fnDataTableCollection(query);
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }
             
            grdReportSavings.DataSource = dt;
            grdReportSavings.Columns[13].Visible = false;

            if (grdReportSavings.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdReportSavings.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdReportSavings.DataSource = "";
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
        }

        private void frmReportOnScheduleOfSavings_Load(object sender, EventArgs e)
        {
            btnExportExcel.Enabled = false;
        }
    }
}
