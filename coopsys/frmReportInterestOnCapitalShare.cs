using calypso.DataAccess;
using ClosedXML.Excel;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace coopsys
{
    public partial class frmReportInterestOnCapitalShare : MetroFramework.Forms.MetroForm
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        string query, defaultInterest;
        bool retry = true;
        public int year;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        public frmReportInterestOnCapitalShare(MySqlConnection _conn)
        {
            conn = _conn;
            InitializeComponent();
            dt = dc.fnDataTableCollection("select distinct year from capitalshare order by year desc;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "year";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }
            saveFileDialog1.FileName = "Interest on Share Capital " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
        }

        private void frmReportInterestOnCapitalShare_Load(object sender, EventArgs e)
        {
            //Set Default Interest Rate and format to remove trailing zeroes
            try
            {
                defaultInterest = decimal.Parse(dc.fnReturnStringValue("SELECT rep_interest_capital_share AS 'interestCS' FROM coop.defaults;", "interestCS", conn)).ToString("G29");

                btnExportExcel.Enabled = false;
                txtRate.Text = defaultInterest;
                foreach (DataGridViewRow row in grdReportInterestOnShareCapital.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
            }
            catch
            {
                btnGenerateReport.Enabled = false;
                btnReset.Enabled = false;
                btnExportExcel.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdReportInterestOnShareCapital.DataSource = null;
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
            txtRate.Text = defaultInterest;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            //using (ProgressLoader progress = new ProgressLoader(LoadData))
            //{
            //    progress.ShowDialog(this);
            //}

            year = int.Parse(cboYear.Text);
            query = "select NAMES, TOTAL, " +
                "format(sum(total+january),2) as 'JAN', " +
                "format(sum(total+january+february),2) as 'FEB'," +
                "format(sum(total+january+february+march),2) as 'MAR', " +
                "format(sum(total+january+february+march+april),2) as 'APR'," +
                "format(sum(total+january+february+march+april+may),2) as 'MAY', " +
                "format(sum(total+january+february+march+april+may+june),2) as 'JUN'," +
                "format(sum(total+january+february+march+april+may+june+july),2) as 'JUL', " +
                "format(sum(total+january+february+march+april+may+june+july+august),2) as 'AUG'," +
                "format(sum(total+january+february+march+april+may+june+july+august+september),2) as 'SEP', " +
                "format(sum(total+january+february+march+april+may+june+july+august+september+october),2) as 'OCT'," +
                "format(sum(total+january+february+march+april+may+june+july+august+september+october+november),2) as 'NOV', " +
                "format(sum(total+january+february+march+april+may+june+july+august+september+october+november+december),2) as 'DEC'" +
                "from " +
                "(select m.memberid, concat(lastname, ', ', firstname) as 'NAMES', " +
                "(select format(ifnull(sum(csamount),0),2) from capitalshare inner join member on capitalshare.memberid = member.memberid where year<" + year + " and member.memberID=m.memberID) as 'TOTAL'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=1 and year=" + year + ") and member.memberID=m.memberID) as 'January'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=2 and year=" + year + ") and member.memberID=m.memberID) as 'February'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=3 and year=" + year + ") and member.memberID=m.memberID) as 'March'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=4 and year=" + year + ") and member.memberID=m.memberID) as 'April'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=5 and year=" + year + ") and member.memberID=m.memberID) as 'May'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=6 and year=" + year + ") and member.memberID=m.memberID) as 'June'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=7 and year=" + year + ") and member.memberID=m.memberID) as 'July'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=8 and year=" + year + ") and member.memberID=m.memberID) as 'August'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=9 and year=" + year + ") and member.memberID=m.memberID) as 'September'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=10 and year=" + year + ") and member.memberID=m.memberID) as 'October'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=11 and year=" + year + ") and member.memberID=m.memberID) as 'November'," +
                "(select ifnull(sum(csamount),0) from capitalshare inner join member on capitalshare.memberid = member.memberid where (month=12 and year=" + year + ") and member.memberID=m.memberID) as 'December'" +
                "from capitalshare inner join member m on capitalshare.memberid = m.memberid where memstatus=0 group by m.memberID order by lastname asc) t group by memberID;";
            dt = dc.fnDataTableCollection(query, conn);
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }
            grdReportInterestOnShareCapital.DataSource = dt;
            grdReportInterestOnShareCapital.Columns[14].Visible = false;

            if (grdReportInterestOnShareCapital.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdReportInterestOnShareCapital.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Interest on Share Capital " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                year = int.Parse(cboYear.Text);
                this.Enabled = false;
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as MetroTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void grdReportInterestOnShareCapital_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdReportInterestOnShareCapital.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex >= 0)
            {
                btnGenerateReport.Enabled = true;
            }
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

            wSheet.Cell("A4").Value = "Interest on Share Capital";
            wSheet.Range("A4:B4").Row(1).Merge();
            wSheet.Range("A4:B4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A5").Value = year;
            wSheet.Range("A5:B5").Row(1).Merge();
            wSheet.Range("A5:B5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            bgWorker.ReportProgress(10, "Creating worksheet.");
            Thread.Sleep(500);

            //Column Titles
            for (int c = 0; c < dt.Columns.Count; c++)
            {
                if (c + 1 < dt.Columns.Count)
                {
                    string col = Letters[c + 1] + (7);
                    wSheet.Cell(col).Value = grdReportInterestOnShareCapital.Columns[c].HeaderText.ToString();
                }
                else
                {
                    wSheet.Cell(Letters[0] + (7)).Value = "";
                }
            }

            wSheet.Cell("P7").Value = "Increase on Share Capital";
            wSheet.Cell("Q7").Value = "TOTAL DEPOSIT MONTHS";
            wSheet.Cell("R7").Value = "AVE. SHARE MONTHS";
            wSheet.Cell("S7").Value = "Rate";
            wSheet.Cell("T7").Value = "Amt of Int. on S/C Due";
            wSheet.Cell("V7").Value = "Signature";
            bgWorker.ReportProgress(20, "Generating columns.");
            Thread.Sleep(500);

            wSheet.Range("A6:V7").Style.Font.Bold = true;
            wSheet.Range("A6:V7").Style.Font.Italic = true;
            wSheet.Range("A6:V7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Range("A6:V7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            bgWorker.ReportProgress(30, "Applying column styles.");
            Thread.Sleep(500);

            //All Rows Except Total
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                //(No., Member Name, and Months)
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 14)
                    {
                        wSheet.Cell(Letters[0] + (r + 10)).Value = int.Parse(grdReportInterestOnShareCapital.Rows[r].Cells[c].Value.ToString());
                    }

                    else if (c == 0)
                    {
                        wSheet.Cell(Letters[c + 1] + (r + 10)).Value = grdReportInterestOnShareCapital.Rows[r].Cells[c].Value.ToString().ToUpper();
                    }
                    else
                    {
                        decimal capitalSharValue = decimal.Parse(grdReportInterestOnShareCapital.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cell(Letters[c + 1] + (r + 10)).Value = capitalSharValue;
                    }
                    bgWorker.ReportProgress(40, "Adding row values.");
                }
                Thread.Sleep(500);

                //Formulas
                var cellWithFormulaA1 = wSheet.Cells("P" + (r + 10));
                cellWithFormulaA1.FormulaA1 = "=O" + (r + 10) + "-C" + (r + 10);

                var cellWithFormulaA2 = wSheet.Cells("Q" + (r + 10));
                cellWithFormulaA2.FormulaA1 = "=SUM(D" + (r + 10) + ":O" + (r + 10) + ")";

                var cellWithFormulaA3 = wSheet.Cells("R" + (r + 10));
                cellWithFormulaA3.FormulaA1 = "=+Q" + (r + 10) + "/12";

                var cellWithFormulaA4 = wSheet.Cells("S" + (r + 10));
                cellWithFormulaA4.FormulaA1 = "=" + double.Parse(txtRate.Text.ToString());

                var cellWithFormulaA5 = wSheet.Cells("T" + (r + 10));
                cellWithFormulaA5.FormulaA1 = "=+S" + (r + 10) + "*R" + (r + 10);
                bgWorker.ReportProgress(60, "Calculating formulas.");
            }
            Thread.Sleep(500);

            //Total Row
            for (int t = 1; t < Letters.Length - 1; t++)
            {
                if (t == 1)
                {
                    wSheet.Cell(Letters[t] + (dt.Rows.Count + 11)).Value = "Total";
                }
                else if (t == 18)
                {
                    wSheet.Cell(Letters[t] + (dt.Rows.Count + 11)).Value = "";
                }
                else
                {
                    var cellWithFormulaA5 = wSheet.Cells(Letters[t] + (dt.Rows.Count + 11));
                    cellWithFormulaA5.FormulaA1 = "=SUM(" + Letters[t] + "10:" + Letters[t] + (dt.Rows.Count + 9) + ")";
                }
            }
            bgWorker.ReportProgress(80, "Calculating row summations.");
            Thread.Sleep(500);

            //Accounting Format
            wSheet.Range(Letters[2] + "2:" + Letters[17] + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
            wSheet.Range(Letters[19] + "2:" + Letters[19] + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
            wSheet.Range(Letters[18] + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "d";

            //Columns style
            wSheet.Range("A1:A"+ (dt.Rows.Count + 11)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            for (int a = 1; a <= 19; a++)
            {
                wSheet.Column(a).AdjustToContents();
                bgWorker.ReportProgress(90, "Adjusting column width.");
            }
            Thread.Sleep(500);

            wSheet.Column("A").Width = 20;
            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;

            wSheet.SheetView.Freeze(8, 2);

            wBook.SaveAs(saveFileDialog1.FileName);
            bgWorker.ReportProgress(100, "Export complete.");
            Thread.Sleep(500);

            #region Previous Code
            //DataSet ds = new DataSet();
            //ds = dc.fnExcelExport(query, conn);
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0];
            //dt.Columns.Add("RowNo");
            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    dt.Rows[r]["RowNo"] = r + 1;
            //}

            //WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
            //WorkSheet workSheet = wb.CreateWorkSheet(cboYear.Text);


            ////Freeze Pane
            //workSheet.CreateFreezePane(3, 8);
            //workSheet.Merge("A1:B1");
            //workSheet["A1"].Value = "CO-OP DEVELOPERS COOPERATIVE";
            //workSheet["A1"].Style.Font.Height = 10;

            //workSheet.Merge("A2:B2");
            //workSheet["A2"].Value = "Tuguegarao City";
            //workSheet["A2"].Style.Font.Height = 10;

            //workSheet.Merge("A4:B4");
            //workSheet["A4"].Value = "Interest on Share Capital";
            //workSheet["A4"].Style.Font.Height = 10;

            //workSheet.Merge("A5:B5");
            //workSheet["A5"].Value = cboYear.Text;
            //workSheet["A5"].Style.Font.Height = 10;

            //string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U" };

            ////Column Titles
            //for (int c = 0; c < dt.Columns.Count; c++)
            //{
            //    if (c + 1 < dt.Columns.Count)
            //    {
            //        string col = Letters[c + 1] + (7);
            //        workSheet[col].Value = grdReportInterestOnShareCapital.Columns[c].HeaderText.ToString();
            //    }
            //    else
            //    {
            //        workSheet[Letters[0] + (7)].Value = "";
            //    }

            //}
            //workSheet["P7"].Value = "Increase on Share Capital";
            //workSheet["Q7"].Value = "TOTAL DEPOSIT MONTHS";
            //workSheet["R7"].Value = "AVE. SHARE MONTHS";
            //workSheet["S7"].Value = "Rate";
            //workSheet["T7"].Value = "Amt of Int. on S/C Due";
            //workSheet["V7"].Value = "Signature";
            //workSheet["A6:V7"].Style.Font.Bold = true;
            //workSheet["A6:V7"].Style.Font.Italic = true;
            //workSheet["A6:V7"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A6:V7"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

            ////All Rows Except Total
            //for (int r = 0; r < dt.Rows.Count; r++)
            //{

            //    //(No., Member Name, and Months)
            //    for (int c = 0; c < dt.Columns.Count; c++)
            //    {

            //        if (c == 14)
            //        {
            //            workSheet[Letters[0] + (r + 10)].Value = int.Parse(grdReportInterestOnShareCapital.Rows[r].Cells[c].Value.ToString());
            //        }

            //        else if (c == 0)
            //        {
            //            workSheet[Letters[c + 1] + (r + 10)].Value = grdReportInterestOnShareCapital.Rows[r].Cells[c].Value.ToString().ToUpper();
            //        }
            //        else
            //        {
            //            decimal capitalSharValue = decimal.Parse(grdReportInterestOnShareCapital.Rows[r].Cells[c].Value.ToString());
            //            workSheet[Letters[c + 1] + (r + 10)].Value = capitalSharValue;
            //        }
            //    }

            //    //Formulas
            //    workSheet["P" + (r + 10)].Formula = "=O" + (r + 10) + "-C" + (r + 10);
            //    workSheet["Q" + (r + 10)].Formula = "=SUM(D" + (r + 10) + ":O" + (r + 10) + ")";
            //    workSheet["R" + (r + 10)].Formula = "=+Q" + (r + 10) + "/12";
            //    workSheet["S" + (r + 10)].Formula = "=" + double.Parse(txtRate.Text.ToString());
            //    workSheet["T" + (r + 10)].Formula = "=+S" + (r + 10) + "*R" + (r + 10);
            //}

            ////Total Row
            //for (int t = 1; t < Letters.Length - 1; t++)
            //{
            //    if (t == 1)
            //    {
            //        workSheet[Letters[t] + (dt.Rows.Count + 11)].Value = "Total";
            //    }
            //    else if (t == 18)
            //    {
            //        workSheet[Letters[t] + (dt.Rows.Count + 11)].Value = "";
            //    }
            //    else
            //    {
            //        workSheet[Letters[t] + (dt.Rows.Count + 11)].Value = "=SUM(" + Letters[t] + "10:" + Letters[t] + (dt.Rows.Count + 9) + ")";
            //    }
            //}

            ////Accounting Format
            //var range = workSheet[Letters[2] + "2:" + Letters[17] + (dt.Rows.Count + 11)];
            //range.FormatString = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";
            //workSheet[Letters[19] + "2:" + Letters[19] + (dt.Rows.Count + 11)].FormatString = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";
            //workSheet[Letters[18] + (dt.Rows.Count + 11)].FormatString = "d";

            ////Columns style
            //workSheet["A:A"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            //workSheet["B" + (dt.Rows.Count + 11) + ":T" + (dt.Rows.Count + 11)].Style.Font.Bold = true;
            //workSheet.AutoSizeColumn(0, true);
            //workSheet.AutoSizeColumn(1, false);
            //workSheet.AutoSizeColumn(2, false);
            //workSheet.AutoSizeColumn(3, false);
            //workSheet.AutoSizeColumn(4, false);
            //workSheet.AutoSizeColumn(5, false);
            //workSheet.AutoSizeColumn(6, false);
            //workSheet.AutoSizeColumn(7, false);
            //workSheet.AutoSizeColumn(8, false);
            //workSheet.AutoSizeColumn(9, false);
            //workSheet.AutoSizeColumn(10, false);
            //workSheet.AutoSizeColumn(11, false);
            //workSheet.AutoSizeColumn(12, false);
            //workSheet.AutoSizeColumn(13, false);
            //workSheet.AutoSizeColumn(14, false);
            //workSheet.AutoSizeColumn(15, false);
            //workSheet.AutoSizeColumn(16, false);
            //workSheet.AutoSizeColumn(17, false);
            //workSheet.AutoSizeColumn(18, false);
            //workSheet.AutoSizeColumn(19, false);

            //path = saveFileDialog1.FileName;
            //wb.SaveAs(path);
            //MessageBox.Show("Excel Workbook Created Successfully At\n " + path, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //path = "";
            //retry = false; 
            #endregion
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
