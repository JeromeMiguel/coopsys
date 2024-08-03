using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using calypso.DataAccess;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;

namespace coopsys
{

    public partial class frmReportOnScheduleOfSales : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        public string query, year, path;
        bool retry = true;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        public frmReportOnScheduleOfSales(MySqlConnection _conn)
        {
            InitializeComponent();

            conn = _conn;
            dt = dc.fnDataTableCollection("select distinct loanyear from loan order by loanyear desc;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "loanyear";
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
                btnReset.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdReportSales.DataSource = "";
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            query = "select concat(firstname, ' ',lastname) as 'MEMBER NAME', (loanadditionalfee1+loanadditionalfee2) as 'FEE' " +
                "from member m\r\ninner join loan l on m.memberID = l.memberID\r\nwhere loanAdditionalFeeRemarks like '%sale%' " +
                "and loanyear = " + cboYear.Text + ";";

            dt = dc.fnDataTableCollection(query);
            dt.Columns.Add("RowNo");
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dt.Rows[r]["RowNo"] = r + 1;
            }

            grdReportSales.DataSource = dt;
            grdReportSales.Columns[2].Visible = false;

            if (grdReportSales.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdReportSales.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Schedule Of Sales " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                year = cboYear.Text;
                this.Enabled = false;
                year = cboYear.Text;
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
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

            wSheet.Cell("A4").Value = "Schedule of Sales";
            wSheet.Range("A4:D4").Row(1).Merge();
            wSheet.Range("A4:D4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wSheet.Cell("A5").Value = "As of December 31, " + year + "";
            wSheet.Range("A5:D5").Row(1).Merge();
            wSheet.Range("A5:D5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            bgWorker.ReportProgress(20, "Creating worksheet.");
            Thread.Sleep(500);

            string[] Letters = { "A", "B", "C", "D" };

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                if (c + 1 < dt.Columns.Count)
                {
                    string col = Letters[c + 1] + (7);
                    wSheet.Cell(col).Value = grdReportSales.Columns[c].HeaderText.ToString();
                    wSheet.Cell(col).Style.Font.Bold = true;
                    wSheet.Cell(col).Style.Font.Italic = true;
                }
                else
                {
                    wSheet.Cell(Letters[0] + (7)).Value = "";
                }
                bgWorker.ReportProgress(40, "Generating columns");
            }
            Thread.Sleep(500);

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                int percentage = (int)((float)(r + 1) / dt.Rows.Count) * 100;
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 2)
                    {
                        wSheet.Cell(Letters[0] + (r + 10)).Value = int.Parse(grdReportSales.Rows[r].Cells[c].Value.ToString());
                    }

                    else if (c == 1)
                    {
                        decimal loanValue = decimal.Parse(grdReportSales.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cell(Letters[c + 1] + (r + 10)).Value = loanValue;
                    }
                    else
                    {
                        wSheet.Cell(Letters[c + 1] + (r + 10)).Value = grdReportSales.Rows[r].Cells[c].Value.ToString().ToUpper();
                    }
                }
                bgWorker.ReportProgress(75, "Adding row values.");
            }
            Thread.Sleep(500);

            //Columns Format
            wSheet.Range("A1:A" + (dt.Rows.Count + 10)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            wSheet.Cells("C2:C" + (dt.Rows.Count + 11)).Style.NumberFormat.Format = "_(\"₱\"* #,###.00_);_(\"₱\"* (#,###.00);_(\"₱\"* \"-\"_);_(@_)";
            //AutoSize Columns
            wSheet.Rows().AdjustToContents();
            wSheet.Columns().AdjustToContents();
            wSheet.Columns("A,C").Width = 20;
            bgWorker.ReportProgress(90, "Applying cell styles.");

            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;
            wBook.SaveAs(saveFileDialog1.FileName);
            bgWorker.ReportProgress(100, "Export complete.");
            Thread.Sleep(500);

            #region ORIGINAL EXPORT
            //WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
            //WorkSheet workSheet = wb.CreateWorkSheet(cboYear.Text);

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
            //workSheet["A4"].Value = "Schedule of Past Due Loans";
            //workSheet["A4"].Style.Font.Bold = true;
            //workSheet["A4"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A4"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A4"].Style.Font.Height = 11;

            //workSheet.Merge("A5:D5");
            //workSheet["A5"].Value = "As of December 31, " + year + "";
            //workSheet["A5"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A5"].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A4"].Style.Font.Height = 11;

            //string[] Letters = { "A", "B", "C", "D" };

            //for (int c = 0; c < dt.Columns.Count; c++)
            //{
            //    if (c + 1 < dt.Columns.Count)
            //    {
            //        string col = Letters[c + 1] + (7);
            //        workSheet[col].Value = grdReportSales.Columns[c].HeaderText.ToString();
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

            //            workSheet[Letters[0] + (r + 10)].Value = int.Parse(grdReportSales.Rows[r].Cells[c].Value.ToString());
            //        }

            //        else if (c == 1)
            //        {

            //            decimal loanValue = decimal.Parse(grdReportSales.Rows[r].Cells[c].Value.ToString());
            //            workSheet[Letters[c + 1] + (r + 10)].Value = loanValue;
            //        }
            //        else
            //        {

            //            workSheet[Letters[c + 1] + (r + 10)].Value = grdReportSales.Rows[r].Cells[c].Value.ToString().ToUpper();
            //        }
            //    }
            //}



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

        private void frmReportOnScheduleOfSales_Load(object sender, EventArgs e)
        {
            btnExportExcel.Enabled = false; 
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
