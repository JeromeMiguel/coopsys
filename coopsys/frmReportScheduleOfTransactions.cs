using calypso.DataAccess;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Vml.Office;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmReportScheduleOfTransactions : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        public string query, path, year, type;
        public bool retry, generated;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;

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
            if (cboType.Items.Count > 0) 
            { 
                cboType.SelectedIndex = 0; 
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            generated = true;
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
            year = cboYear.Text;
            saveFileDialog1.FileName = "Sched"+cboType.Text+" " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                this.Enabled = false;
                type = cboType.Text;
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
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

            btnExportExcel.Enabled=!generated;

        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dc.fnExcelExport(query, conn);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables[0];
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }

            var wBook = new XLWorkbook(); //create workbook
            var wSheet = wBook.Worksheets.Add("data"); //add worksheet

            wSheet.Cell("A1").Value = "CO-OP DEVELOPERS COOPERATIVE";
            wSheet.Range("A1:B1").Row(1).Merge();
            wSheet.Range("A1:B1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A2").Value = "Tuguegarao City";
            wSheet.Range("A2:B2").Row(1).Merge();
            wSheet.Range("A2:B2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A4").Value = "Schedule of "+ type + "";
            wSheet.Range("A4:B4").Row(1).Merge();
            wSheet.Range("A4:B4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A5").Value = year;
            wSheet.Range("A5:B5").Row(1).Merge();
            wSheet.Range("A5:B5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N" };
            bgWorker.ReportProgress(10, "Creating excel worksheet.");
            Thread.Sleep(500);

            for (int c = 0; c < dt.Columns.Count - 1; c++)
            {
                if (c < dt.Columns.Count)
                {
                    string col = Letters[c + 1] + (7);
                    wSheet.Cell(col).Value = grdReportTrans.Columns[c].HeaderText.ToString();
                    wSheet.Cell(col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    bgWorker.ReportProgress(20, "Generating column headers.");
                }
            }
            Thread.Sleep(500);

            bgWorker.ReportProgress(30, "Generating column headers.");
            Thread.Sleep(500);

            //All Rows Except Total
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                //(No., Member Name, and Months)
                string loadRow1 = Letters[0] + (r + 10);
                string loadRow2;
                string loadRow3;
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 13)
                    {
                        wSheet.Cells(loadRow1).Value = int.Parse(grdReportTrans.Rows[r].Cells[c].Value.ToString());
                    }

                    else if (c == 0)
                    {
                        loadRow2 = Letters[c + 1] + (r + 10);
                        wSheet.Cells(loadRow2).Value = grdReportTrans.Rows[r].Cells[c].Value.ToString().ToUpper();
                    }
                    else
                    {
                        loadRow3 = Letters[c + 1] + (r + 10);
                        decimal capitalSharValue = decimal.Parse(grdReportTrans.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cells(loadRow3).Value = capitalSharValue;
                        wSheet.Cell(loadRow3).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
                    }
                    bgWorker.ReportProgress(40, "Adding row values.");
                }
                Thread.Sleep(500);

                bgWorker.ReportProgress(60, "Calculating excel formulas.");
            }
            Thread.Sleep(500);

            //Total Row
            for (int t = 1; t < Letters.Length; t++)
            {
                if (t == 1)
                {
                    wSheet.Cells(Letters[t] + (dt.Rows.Count + 11)).Value = "Total";
                }
                else
                {
                    var cellWithFormulaA3 = wSheet.Cells(Letters[t] + (dt.Rows.Count + 11));
                    cellWithFormulaA3.FormulaA1 = "SUM(" + Letters[t] + "10:" + Letters[t] + (dt.Rows.Count + 9) + ")";
                    wSheet.Cell(Letters[t] + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
                }
                bgWorker.ReportProgress(80, "Calculating row summation.");
            }
            Thread.Sleep(500);

            //AutoSize Columns
            for (int a = 1; a <= 17; a++)
            {
                wSheet.Column(a).AdjustToContents();
            }
            wSheet.Column("A").Width = 20;
            wSheet.Range("A1:A" + (dt.Rows.Count + 11)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;

            wSheet.SheetView.Freeze(8, 2);
            bgWorker.ReportProgress(100, "Export complete.");
            Thread.Sleep(500);

            wBook.SaveAs(saveFileDialog1.FileName);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            lblWait.Text = string.Format("Exporting...{0}%", e.ProgressPercentage);
            ts = stopwatch.Elapsed;
            lblStatus.Text = "Status: " + e.UserState + "";
            progress.Update();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Excel file created successfully.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Enabled = true;
            retry = false;
            panel1.Visible = false;
            stopwatch.Stop();

            if (cboxOpenFile.Checked)
            {
                Process.Start(saveFileDialog1.FileName);
            }
        }
    }
}
