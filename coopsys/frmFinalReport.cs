using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data;
using MySql.Data.MySqlClient;
using calypso;
using calypso.DataAccess;
using IronXL;
using System.IO;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using System.Threading;
using DocumentFormat.OpenXml.Vml.Office;
using System.Diagnostics;

namespace coopsys
{
    public partial class frmFinalReport : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        Database db = new Database();
        DataCollection dc = new DataCollection();
        DataGridTableStyle tableStyle = new DataGridTableStyle();
        bool retry = true;
        public string year, percent1, percent2;

        System.Data.DataTable dtPatronage = new System.Data.DataTable();
        System.Data.DataTable dtDivident = new System.Data.DataTable();
        System.Data.DataTable dtMerge = new System.Data.DataTable();
        System.Data.DataTable dtAddNew = new System.Data.DataTable();

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        MySqlConnection conn;

        public frmFinalReport(MySqlConnection _conn)
        {
            conn = _conn;
            InitializeComponent();
            dt = dc.fnDataTableCollection("select distinct loanyear from loan order by loanyear desc;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "loanyear";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }
            saveFileDialog1.FileName = "Interest On Share Capital and Patronage Refund " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
        }

        public void LoadRecords()
        {
            #region Query
            dtPatronage = dc.fnDataTableCollection("select memberIDLoan, NAMES," +
                    "format(sum(january)+" +
                    "sum(january+february)+" +
                    "sum(january+february+march)+" +
                    "sum(january+february+march+april)+" +
                    "sum(january+february+march+april+may)+" +
                    "sum(january+february+march+april+may+june)+" +
                    "sum(january+february+march+april+may+june+july)+" +
                    "sum(january+february+march+april+may+june+july+august)+" +
                    "sum(january+february+march+april+may+june+july+august+september)+" +
                    "sum(january+february+march+april+may+june+july+august+september+october)+" +
                    "sum(january+february+march+april+may+june+july+august+september+october+november)+" +
                    "sum(january+february+march+april+may+june+july+august+september+october+november+december),2) as 'Patronage'" +
                    "from(select m.memberid as memberIDLoan, upper(concat(lastname, ', ', firstname)) as 'NAMES'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=1 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'January'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=2 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'February'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=3 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'March'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=4 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'April'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=5 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'May'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=6 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'June'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=7 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'July'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=8 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'August'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=9 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'September'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=10 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'October'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=11 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'November'," +
                    "(select ifnull(sum(interestAmount),0) from loan left join member on loan.memberid = member.memberid where (loanmonth=12 and loanyear = " + cboYear.Text + ") and member.memberID=m.memberID) as 'December'" +
                    "from loan left join member m on loan.memberid = m.memberid where memstatus=0 group by m.memberid order by lastname asc) t group by memberIDLoan;", conn);

            dtDivident = dc.fnDataTableCollection("select memberIDShareCap, NAMES," +
                "format(sum(total+january)+" +
                "sum(total+january+february)+" +
                "sum(total+january+february+march)+" +
                "sum(total+january+february+march+april)+" +
                "sum(total+january+february+march+april+may)+" +
                "sum(total+january+february+march+april+may+june)+" +
                "sum(total+january+february+march+april+may+june+july)+" +
                "sum(total+january+february+march+april+may+june+july+august)+" +
                "sum(total+january+february+march+april+may+june+july+august+september)+" +
                "sum(total+january+february+march+april+may+june+july+august+september+october)+" +
                "sum(total+january+february+march+april+may+june+july+august+september+october+november)+" +
                "sum(total+january+february+march+april+may+june+july+august+september+october+november+december),2) as 'Divident'" +
                "from (select m.memberid as memberIDShareCap, upper(concat(lastname, ', ', firstname)) as 'NAMES'," +
                "(select format(ifnull(sum(csamount),0),2) from capitalshare inner join member on capitalshare.memberid = member.memberid where year< " + cboYear.Text + " and member.memberID=m.memberID) as 'TOTAL'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=1 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'January'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=2 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'February'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=3 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'March'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=4 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'April'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=5 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'May'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=6 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'June'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=7 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'July'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=8 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'August'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=9 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'September'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=10 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'October'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=11 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'November'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=12 and year= " + cboYear.Text + ") and member.memberID=m.memberID) as 'December'" +
                "from capitalshare inner join member m on capitalshare.memberid = m.memberid where memstatus=0 group by m.memberID order by lastname asc) t group by memberIDShareCap;");

            #endregion

            dtMerge.Columns.Add("ID");
            dtMerge.Columns.Add("Name");
            dtMerge.Columns.Add("Dividend");
            dtMerge.Columns.Add("Patronage");
            dtMerge.Columns.Add("Percentage 1 (" + txtPercent1.Text + "%)");
            dtMerge.Columns.Add("Percentage 2 (" + txtPercent2.Text + "%)");

            dtAddNew.Columns.Add("ID");
            dtAddNew.Columns.Add("Name");
            dtAddNew.Columns.Add("Dividend");
            dtAddNew.Columns.Add("Patronage");

            //Add Dividend
            for (int a = 0; a < dtDivident.Rows.Count; a++)
            {
                dtMerge.Rows.Add(dtDivident.Rows[a][0], dtDivident.Rows[a][1], dtDivident.Rows[a][2], 0.00);
            }

            //Add Patronage
            var trueCount = 0;
            for (int a = 0; a < dtMerge.Rows.Count; a++)
            {
                foreach (DataRow dr in dtMerge.Rows)
                {
                    if (dr[0].ToString() == dtPatronage.Rows[a][0].ToString())
                    {
                        dr["Patronage"] = dtPatronage.Rows[a][2];
                        trueCount++;
                    }
                }

                if (trueCount == 0)
                {
                    dtAddNew.Rows.Add(dtPatronage.Rows[a][0], dtPatronage.Rows[a][1], dtPatronage.Rows[a][2], 0.00);
                }
                trueCount = 0;
            }

            dtMerge.Merge(dtAddNew);
            for (int a = 0; a < dtMerge.Rows.Count; a++)
            {
                dtMerge.Rows[a][4] = (object)(double.Parse(dtMerge.Rows[a][2].ToString()) * double.Parse(txtPercent1.Text)).ToString("#,##0.00");
                dtMerge.Rows[a][5] = (object)(double.Parse(dtMerge.Rows[a][3].ToString()) * double.Parse(txtPercent1.Text)).ToString("#,##0.00");
            }

            grdFinalReport.DataSource = dtMerge;

            grdFinalReport.Columns[0].Visible = false;
            foreach (DataGridViewRow row in grdFinalReport.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Interest On Share Capital and Patronage Refund " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                year = cboYear.Text;
                this.Enabled = false;
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = dtMerge;

            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }

            var wBook = new XLWorkbook(); //create workbook
            var wSheet = wBook.Worksheets.Add("data"); //add worksheet

            //Freeze Pane
            wSheet.SheetView.Freeze(8, 4);

            wSheet.Cell("A1").Value = "METRO TUGUEGARAO MULTI-PURPOSE COOPERATIVE";
            wSheet.Range("A1:D1").Row(1).Merge();
            wSheet.Range("A1:D1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Range("A1:D1").Style.Font.FontSize = 14;
            wSheet.Range("A1:D1").Style.Font.Bold = true;

            wSheet.Cell("A2").Value = "Tuguegarao City  Commercial Center,  Tuguegarao City, Cagayan";
            wSheet.Range("A2:D2").Row(1).Merge();
            wSheet.Range("A2:D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A4").Value = "Interest On Share Capital and Patronage Refund";
            wSheet.Range("A4:D4").Row(1).Merge();
            wSheet.Range("A4:D4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A5").Value = year;
            wSheet.Range("A5:D5").Row(1).Merge();
            wSheet.Range("A5:D5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            string[] Letters = { "A", "B", "C", "D", "E", "F", "G" };

            //Column Names
            for (int c = 1; c < dt.Columns.Count - 1; c++)
            {
                if (c < dt.Columns.Count)
                {
                    string col = Letters[c] + (7);
                    wSheet.Cell(col).Value = grdFinalReport.Columns[c].HeaderText.ToString();
                    wSheet.Cell(col).Style.Font.Bold = true;
                    wSheet.Cell(col).Style.Font.Italic = true;
                }
                else
                {
                    wSheet.Cell(Letters[0] + (7)).Value = "";
                }
                bgWorker.ReportProgress(50, "Generating column headers.");
            }
            //Thread.Sleep(500);

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 1; c < dt.Columns.Count; c++)
                {
                    if (c == 6)
                    {
                        wSheet.Cell(Letters[0] + (r + 10)).Value = int.Parse(dt.Rows[r][c].ToString());
                    }

                    else if (c == 1)
                    {
                        wSheet.Cell(Letters[c] + (r + 10)).Value = dt.Rows[r][c].ToString().ToUpper();
                    }
                    else
                    {
                        decimal loanValue = decimal.Parse(dt.Rows[r][c].ToString());
                        wSheet.Cell(Letters[c] + (r + 10)).Value = loanValue;
                    }
                }
                bgWorker.ReportProgress(75, "Adding row values.");
            }
            //Thread.Sleep(500);

            //Columns Format
            wSheet.Range("A1:A" + (dt.Rows.Count + 10)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Cells("C2:F" + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
            bgWorker.ReportProgress(90, "Formatting columns.");
            //AutoSize Columns
            wSheet.Rows().AdjustToContents();
            wSheet.Columns().AdjustToContents();
            wSheet.Columns("A,C,D,E,F").Width = 20;

            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;

            wBook.SaveAs(saveFileDialog1.FileName);
        }

        private void frmFinalReport_Load(object sender, EventArgs e)
        {
            // Set default values from defaults table
            percent1 = dc.fnReturnStringValue("SELECT rep_final_1 AS 'f1' FROM coop.defaults;", "f1", conn);
            percent2 = dc.fnReturnStringValue("SELECT rep_final_2 AS 'f2' FROM coop.defaults;", "f2", conn);

            txtPercent1.Text = percent1;
            txtPercent2.Text = percent2;
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
            MessageBox.Show("Excel file created successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
