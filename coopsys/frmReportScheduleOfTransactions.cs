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
    public partial class frmReportScheduleOfTransactions : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        public string query;

        public frmReportScheduleOfTransactions(MySqlConnection _conn)
        {
            InitializeComponent();

            conn = _conn;
            dt = dc.fnDataTableCollection("SELECT DISTINCT YEAR(`date`) as 'Year' FROM coop.transactions ORDER BY YEAR(`date`) DESC;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "Year";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int selectedType = cboType.Text == "Deposit" ? 2 : 1;
            query = "select NAMES," +
                "format(sum(january),2) as 'JAN'," +
                "format(sum(january+february),2) as 'FEB'," +
                "format(sum(january+february+march),2) as 'MAR'," +
                "format(sum(january+february+march+april),2) as 'APR'," +
                "format(sum(january+february+march+april+may),2) as 'MAY'," +
                "format(sum(january+february+march+april+may+june),2) as 'JUN'," +
                "format(sum(january+february+march+april+may+june+july),2) as 'JUL'," +
                "format(sum(january+february+march+april+may+june+july+august),2) as 'AUG'," +
                "format(sum(january+february+march+april+may+june+july+august+september),2) as 'SEP'," +
                "format(sum(january+february+march+april+may+june+july+august+september+october),2) as 'OCT'," +
                "format(sum(january+february+march+april+may+june+july+august+september+october+november),2) as 'NOV'," +
                "format(sum(january+february+march+april+may+june+july+august+september+october+november+december),2) as 'DEC'" +
                "from (select m.memberid, concat(lastname, ', ', firstname) as 'NAMES'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=1 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'January'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=2 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'February'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=3 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'March'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=4 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'April'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=5 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'May'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=6 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'June'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=7 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'July'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=8 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'August'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=9 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'September'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=10 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'October'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=11 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'November'," +
                "(select ifnull(sum(amount),0) from transactions t inner join savings s on s.savingsID = t.savingsID inner join member on member.memberID = s.memberID where (month(t.date)=12 and year(t.date)="+cboYear.Text+") and member.memberID=m.memberID and type = "+selectedType+") as 'December'" +
                "from savings inner join member m on savings.memberid = m.memberid where memstatus=0 group by m.memberID order by lastname asc) t group by memberID;";

            dt = dc.fnDataTableCollection(query);
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }

            grdReportTrans.DataSource = dt;
            grdReportTrans.Columns[13].Visible = false;

            if (grdReportTrans.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdReportTrans.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdReportTrans.DataSource = "";
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void frmReportScheduleOfTransactions_Load(object sender, EventArgs e)
        {
            btnExportExcel.Enabled = false;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex >= 0 && cboType.SelectedIndex >= 0)
            {
                btnGenerateReport.Enabled = true;
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex >= 0 && cboType.SelectedIndex >= 0)
            {
                btnGenerateReport.Enabled = true;
            }
        }
    }
}
