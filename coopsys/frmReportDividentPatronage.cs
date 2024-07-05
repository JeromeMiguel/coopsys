using calypso.DataAccess;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmReportDividentPatronage : MetroFramework.Forms.MetroForm
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        public double  dividentPercentage;
        public string query, path, defaultDividentPercentage;
        bool retry = true;
        public string year;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        public frmReportDividentPatronage(MySqlConnection _conn)
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
            saveFileDialog1.FileName = "Divident " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
        }

        private void frmReportDividentPatronage_Load(object sender, EventArgs e)
        {
            //Set default dividend percentage and format to remove trailing zeroes
            defaultDividentPercentage = decimal.Parse(dc.fnReturnStringValue("SELECT rep_dividend_rate AS 'divRate' FROM coop.defaults;", "divRate", conn)).ToString("G29");
            txtDivident.Text = defaultDividentPercentage;
            btnExportExcel.Enabled = false;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            query = "select NAMES, " +
                "format(sum(january),2) as 'JAN', " +
                "format(sum(january+february),2) as 'FEB'," +
                "format(sum(january+february+march),2) as 'MAR', " +
                "format(sum(january+february+march+april),2) as 'APR'," +
                "format(sum(january+february+march+april+may),2) as 'MAY', " +
                "format(sum(january+february+march+april+may+june),2) as 'JUN'," +
                "format(sum(january+february+march+april+may+june+july),2) as 'JUL', " +
                "format(sum(january+february+march+april+may+june+july+august),2) as 'AUG'," +
                "format(sum(january+february+march+april+may+june+july+august+september),2) as 'SEP', " +
                "format(sum(january+february+march+april+may+june+july+august+september+october),2) as 'OCT'," +
                "format(sum(january+february+march+april+may+june+july+august+september+october+november),2) as 'NOV', " +
                "format(sum(january+february+march+april+may+june+july+august+september+october+november+december),2) as 'DEC'" +
                "from(select m.memberid, upper(concat(lastname, ', ', firstname)) as 'NAMES'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=1 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'January'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=2 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'February'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=3 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'March'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=4 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'April'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=5 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'May'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=6 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'June'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=7 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'July'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=8 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'August'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=9 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'September'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=10 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'October'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=11 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'November'," +
                "(select ifnull(sum(interestAmount),0) from loan inner join member on loan.memberid = member.memberid where (loanmonth=12 and loanyear=" + int.Parse(cboYear.Text) + ") and member.memberID=m.memberID) as 'December'" +
                "from loan inner join member m on loan.memberid = m.memberid where memstatus=0 group by memberid order by lastname asc) t group by memberID;";

            DataSet ds = new DataSet();
            ds = dc.fnExcelExport(query, conn);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables[0];
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }

            grdReportDividentPatronage.DataSource = dt;
            grdReportDividentPatronage.Columns[13].Visible = false;

            if (grdReportDividentPatronage.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdReportDividentPatronage.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void txtDivident_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdReportDividentPatronage.DataSource = "";
            txtDivident.Text = defaultDividentPercentage;
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Divident " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                year = cboYear.Text;
                this.Enabled = false;
                dividentPercentage = double.Parse(txtDivident.Text.ToString());
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
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

            wSheet.Cell("A4").Value = "Dividend Patronage";
            wSheet.Range("A4:B4").Row(1).Merge();
            wSheet.Range("A4:B4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A5").Value = year;
            wSheet.Range("A5:B5").Row(1).Merge();
            wSheet.Range("A5:B5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q" };
            bgWorker.ReportProgress(10, "Creating excel worksheet.");
            Thread.Sleep(500);

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                if (c < dt.Columns.Count)
                {
                    string col = Letters[c + 1] + (7);
                    wSheet.Cell(col).Value = grdReportDividentPatronage.Columns[c].HeaderText.ToString();
                    wSheet.Cell(col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    bgWorker.ReportProgress(20, "Generating column headers.");
                }
            }
            Thread.Sleep(500);

            wSheet.Cells("O6").Value = "Interest on Loan Collected from";
            wSheet.Cells("O7").Value = "the Members for the Whole Year";
            wSheet.Cells("P7").Value = "Rate";
            wSheet.Cells("Q7").Value = "Patronage";
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
                        wSheet.Cells(loadRow1).Value = int.Parse(grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString());
                    }

                    else if (c == 0)
                    {
                        loadRow2 = Letters[c + 1] + (r + 10);
                        wSheet.Cells(loadRow2).Value = grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString().ToUpper();
                    }
                    else
                    {
                        loadRow3 = Letters[c + 1] + (r + 10);
                        decimal capitalSharValue = decimal.Parse(grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cells(loadRow3).Value = capitalSharValue;
                        wSheet.Cell(loadRow3).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
                    }
                    bgWorker.ReportProgress(40, "Adding row values.");
                }
                Thread.Sleep(500);

                //Formulas
                var cellWithFormulaA1 = wSheet.Cells("O" + (r + 10));
                cellWithFormulaA1.FormulaA1 = "SUM(C" + (r + 10) + ":N" + (r + 10) + ")";
                wSheet.Cell("O" + (r + 10)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
                wSheet.Cells("P" + (r + 10)).Value = dividentPercentage;

                var cellWithFormulaA2 = wSheet.Cells("Q" + (r + 10));
                cellWithFormulaA2.FormulaA1 = dividentPercentage + "*O" + (r + 10);
                wSheet.Cell("Q" + (r + 10)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
                
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
                else if (t == 15)
                {
                    wSheet.Cells(Letters[t] + (dt.Rows.Count + 11)).Value = "";
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
            wSheet.Range("A1:A"+(dt.Rows.Count + 11)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;

            wSheet.SheetView.Freeze(8, 2);
            bgWorker.ReportProgress(100, "Export complete.");
            Thread.Sleep(500);

            wBook.SaveAs(saveFileDialog1.FileName);

            #region Previous export code
            //DataSet ds = new DataSet();
            //ds = dc.fnExcelExport(query, conn);
            //WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0];
            //dt.Columns.Add("RowNo");
            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    dt.Rows[r]["RowNo"] = r + 1;
            //}

            //WorkSheet workSheet = wb.CreateWorkSheet("members");

            ////Freeze Pane
            //workSheet.CreateFreezePane(2, 8);
            //workSheet.Merge("A1:B1");
            //workSheet["A1"].Value = "CO-OP DEVELOPERS COOPERATIVE";
            //workSheet["A1"].Style.Font.Height = 10;

            //workSheet.Merge("A2:B2");
            //workSheet["A2"].Value = "Tuguegarao City";
            //workSheet["A2"].Style.Font.Height = 10;

            //workSheet.Merge("A4:B4");
            //workSheet["A4"].Value = "Dividend Patronage";
            //workSheet["A4"].Style.Font.Height = 10;

            //workSheet.Merge("A5:B5");
            //workSheet["A5"].Value = year;
            //workSheet["A5"].Style.Font.Height = 10;

            //string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q" };

            ////Column Titles
            //for (int c = 0; c < dt.Columns.Count; c++)
            //{
            //    if (c < dt.Columns.Count)
            //    {
            //        string col = Letters[c + 1] + (7);
            //        workSheet[col].Value = grdReportDividentPatronage.Columns[c].HeaderText.ToString();
            //    }


            //}
            //workSheet["O6"].Value = "Interest on Loan Collected from";
            //workSheet["O7"].Value = "the Members for the Whole Year";
            //workSheet["P7"].Value = "Rate";
            //workSheet["Q7"].Value = "Patronage";
            //workSheet["A6:V7"].Style.Font.Bold = true;
            //workSheet["A6:V7"].Style.Font.Italic = true;
            //workSheet["A6:V7"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A6:V7"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;

            ////All Rows Except Total
            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    int percentage = (int)((float)(r + 1) / dt.Rows.Count) * 100;
            //    //(No., Member Name, and Months)
            //    for (int c = 0; c < dt.Columns.Count; c++)
            //    {
            //        if (c == 13)
            //        {
            //            workSheet[Letters[0] + (r + 10)].Value = int.Parse(grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString());
            //        }

            //        else if (c == 0)
            //        {
            //            workSheet[Letters[c + 1] + (r + 10)].Value = grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString().ToUpper();
            //        }
            //        else
            //        {
            //            decimal capitalSharValue = decimal.Parse(grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString());
            //            workSheet[Letters[c + 1] + (r + 10)].Value = capitalSharValue;
            //        }
            //    }

            //    //Formulas
            //    workSheet["O" + (r + 10)].Formula = "=SUM(C" + (r + 10) + ":N" + (r + 10) + ")";
            //    workSheet["P" + (r + 10)].Formula = "=" + dividentPercentage;
            //    workSheet["Q" + (r + 10)].Formula = "=" + dividentPercentage + "*O" + (r + 10);

            //    bgWorker.ReportProgress(percentage);
            //}

            ////Total Row
            //for (int t = 1; t < Letters.Length; t++)
            //{
            //    if (t == 1)
            //    {
            //        workSheet[Letters[t] + (dt.Rows.Count + 11)].Value = "Total";
            //    }
            //    else if (t == 15)
            //    {
            //        workSheet[Letters[t] + (dt.Rows.Count + 11)].Value = "";
            //    }
            //    else
            //    {
            //        workSheet[Letters[t] + (dt.Rows.Count + 11)].Formula = "=SUM(" + Letters[t] + "10:" + Letters[t] + (dt.Rows.Count + 9 + ")");
            //    }
            //}


            ////Accounting Format
            //var range = workSheet[Letters[2] + "2:" + Letters[14] + (dt.Rows.Count + 11)];
            //range.FormatString = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";
            //workSheet[Letters[16] + "2:" + Letters[16] + (dt.Rows.Count + 11)].FormatString = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";
            //workSheet[Letters[15] + (dt.Rows.Count + 11)].FormatString = "d";

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

            //path = saveFileDialog1.FileName;
            //wb.SaveAs(path); 
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

        private void grdReportDividentPatronage_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdReportDividentPatronage.Rows)
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
    }
}
