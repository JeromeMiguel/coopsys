using calypso.DataAccess;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmReportOnScheduleOfShareCapital : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        public string query, path, year;
        bool retry = true;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        public frmReportOnScheduleOfShareCapital(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;

            dt = dc.fnDataTableCollection("select distinct year from capitalshare order by year desc;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "year";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }
            else
            {
                btnGenerateReport.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void frmReportOnScheduleOfShareCapital_Load(object sender, EventArgs e)
        {
            btnExportExcel.Enabled = false;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            query = "select concat(lastname, ', ', firstname,  ' ', middlename) as 'NAMES', " +
               "format(sum(csamount),2) as 'AMOUNT' from capitalshare " +
               "inner join member on capitalshare.memberid = member.memberid where year=" + cboYear.Text + " " +
               "group by member.memberID order by lastname asc;";

            dt = dc.fnDataTableCollection(query);
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }

            grdReportShareCapital.DataSource = dt;
            grdReportShareCapital.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdReportShareCapital.Columns[2].Visible = false;

            lblTotal.Text = "₱" + dc.fnReturnStringValue("SELECT FORMAT(SUM(csamount),2) as 'TOTAL SUM' " +
                "from capitalshare where year = " + cboYear.Text + ";", "TOTAL SUM", conn);
            if (grdReportShareCapital.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdReportShareCapital.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "₱0.00";
            grdReportShareCapital.DataSource = "";
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            year = cboYear.Text;
            saveFileDialog1.FileName = "SchedShareCapital " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                this.Enabled = false;
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
        }

        private void grdReportShareCapital_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdReportShareCapital.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dc.fnExcelExport(query, conn);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
                bgWorker.ReportProgress(5);
            }

            var wBook = new XLWorkbook(); //create workbook
            var wSheet = wBook.Worksheets.Add("data"); //add worksheet

            wSheet.SheetView.Freeze(4, 8);
            wSheet.Range("A1:D1").Row(1).Merge();
            wSheet.Cell("A1").Value = "METRO TUGUEGARAO MULTI-PURPOSE COOPERATIVE";
            wSheet.Cell("A1").Style.Font.Bold = true;
            wSheet.Range("A1:D1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Cell("A1").Style.Font.FontSize = 14;

            wSheet.Range("A2:D2").Row(1).Merge();
            wSheet.Cell("A2").Value = "Tuguegarao City  Commercial Center,  Tuguegarao City, Cagayan";
            wSheet.Range("A2:D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Cell("A2").Style.Font.FontSize = 11;

            wSheet.Range("A4:D4").Row(1).Merge();
            wSheet.Cell("A4").Value = "SCHEDULE OF SHARE CAPITAL";
            wSheet.Cell("A4").Style.Font.Bold = true;
            wSheet.Range("A4:D4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Cell("A4").Style.Font.FontSize = 11;

            wSheet.Range("A5:D5").Row(1).Merge();
            wSheet.Cell("A5").Value = "For Year " + year + "";
            wSheet.Range("A5:D5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Cell("A5").Style.Font.FontSize = 11;

            string[] Letters = { "A", "B", "C", "D" };
            bgWorker.ReportProgress(30, "Creating excel worksheet.");
            Thread.Sleep(500);

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                if (c + 1 < dt.Columns.Count)
                {
                    string col = Letters[c + 1] + (7);
                    wSheet.Cell(col).Value = grdReportShareCapital.Columns[c].HeaderText.ToString();
                    wSheet.Cell(col).Style.Font.Bold = true;
                    wSheet.Cell(col).Style.Font.Italic = true;
                }
                else
                {
                    wSheet.Cell(Letters[0] + (7)).Value = "";
                }
                bgWorker.ReportProgress(50, "Generating columns.");
            }
            Thread.Sleep(500);

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 2)
                    {
                        wSheet.Cell(Letters[0] + (r + 10)).Value = int.Parse(grdReportShareCapital.Rows[r].Cells[c].Value.ToString());
                    }

                    else if (c == 1)
                    {

                        decimal capitalSharValue = decimal.Parse(grdReportShareCapital.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cells(Letters[c + 1] + (r + 10)).Value = capitalSharValue;
                        wSheet.Cell(Letters[c + 1] + (r + 10)).Style.NumberFormat.Format = "₱ #,###.00";
                    }
                    else
                    {
                        wSheet.Cell(Letters[c + 1] + (r + 10)).Value = grdReportShareCapital.Rows[r].Cells[c].Value.ToString().ToUpper();
                    }
                }
                bgWorker.ReportProgress(85, "Adding row values.");
            }
            Thread.Sleep(500);

            wSheet.Cell(Letters[1] + (dt.Rows.Count + 11)).Value = "Total";
            wSheet.Cell(Letters[2] + (dt.Rows.Count + 11)).Value = decimal.Parse(dc.fnReturnStringValue("SELECT FORMAT(SUM(csamount),2) as 'TOTAL SUM' " +
                "from capitalshare where year = " + year + ";", "TOTAL SUM", conn));
            wSheet.Cell(Letters[2] + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";

            for (int a = 1; a <= 3; a++)
            {
                wSheet.Column(a).AdjustToContents();
            }

            wSheet.Column("A").Width = 15;
            wSheet.Column("C").Width = 15;
            wSheet.Range("A1:A"+(dt.Rows.Count + 10)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;
            Thread.Sleep(500);
            wBook.SaveAs(saveFileDialog1.FileName);
            bgWorker.ReportProgress(100, "Export complete.");

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
            //WorkSheet workSheet = wb.CreateWorkSheet(year);

            ////Freeze Pane
            //workSheet.CreateFreezePane(4, 8);
            //workSheet.Merge("A1:D1");
            //workSheet["A1"].Value = "METRO TUGUEGARAO MULTI-PURPOSE COOPERATIVE";
            //workSheet["A1"].Style.Font.Bold = true;
            //workSheet["A1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A1"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A1"].Style.Font.Height = 14;

            //workSheet.Merge("A2:D2");
            //workSheet["A2"].Value = "Tuguegarao City  Commercial Center,  Tuguegarao City, Cagayan";
            //workSheet["A2"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A2"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A2"].Style.Font.Height = 11;

            //workSheet.Merge("A4:D4");
            //workSheet["A4"].Value = "SCHEDULE OF SHARE CAPITAL";
            //workSheet["A4"].Style.Font.Bold = true;
            //workSheet["A4"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A4"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A4"].Style.Font.Height = 11;

            //workSheet.Merge("A5:D5");
            //workSheet["A5"].Value = "For Year " + year + "";
            //workSheet["A5"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A5"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A4"].Style.Font.Height = 11;

            //string[] Letters = { "A", "B", "C", "D" };

            //for (int c = 0; c < dt.Columns.Count; c++)
            //{
            //    if (c + 1 < dt.Columns.Count)
            //    {
            //        string col = Letters[c + 1] + (7);
            //        workSheet[col].Value = grdReportShareCapital.Columns[c].HeaderText.ToString();
            //        workSheet[col].Style.Font.Bold = true;
            //        workSheet[col].Style.Font.Italic = true;
            //    }
            //    else
            //    {
            //        workSheet[Letters[0] + (7)].Value = "";
            //    }
            //}

            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    for (int c = 0; c < dt.Columns.Count; c++)
            //    {
            //        if (c == 2)
            //        {
            //            workSheet[Letters[0] + (r + 10)].Value = int.Parse(grdReportShareCapital.Rows[r].Cells[c].Value.ToString());
            //        }

            //        else if (c == 1)
            //        {

            //            decimal capitalSharValue = decimal.Parse(grdReportShareCapital.Rows[r].Cells[c].Value.ToString());
            //            workSheet[Letters[c + 1] + (r + 10)].Value = capitalSharValue;
            //        }
            //        else
            //        {
            //            workSheet[Letters[c + 1] + (r + 10)].Value = grdReportShareCapital.Rows[r].Cells[c].Value.ToString().ToUpper();
            //        }
            //    }
            //}

            //workSheet[Letters[1] + (dt.Rows.Count + 11)].Value = "Total";
            //workSheet[Letters[2] + (dt.Rows.Count + 11)].Value = decimal.Parse(dc.fnReturnStringValue("SELECT FORMAT(SUM(csamount),2) as 'TOTAL SUM' " +
            //    "from capitalshare where year = " + year + ";", "TOTAL SUM", conn));

            //var range = workSheet[Letters[2] + "2:" + Letters[2] + (dt.Rows.Count + 11)];
            //range.FormatString = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";

            ////Columns style
            //workSheet["A:A"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
            //workSheet.AutoSizeColumn(0, true);
            //workSheet.AutoSizeColumn(1, false);
            //workSheet.AutoSizeColumn(2, false);

            //path = saveFileDialog1.FileName;
            //wb.SaveAs(path);
            #endregion
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboYear.SelectedIndex >= 0)
            {
                btnGenerateReport.Enabled = true;
            }
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
