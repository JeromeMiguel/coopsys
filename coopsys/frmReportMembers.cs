using calypso;
using calypso.DataAccess;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmReportMembers : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        DataCollection dc = new DataCollection();
        DataGridTableStyle tableStyle = new DataGridTableStyle();
        MySqlConnection conn;

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        string elapsedTime;

        public string path;
        bool retry = true;
        public string getMembersQuery = "select lastname as 'Surname', firstname as 'First Name', middlename as 'Middle Name', " +
            "if(sex=0,'Female','Male' ) as 'Gender', DATE_FORMAT(birthday, '%m/%d/%Y') as 'Birthday', DATE_FORMAT(FROM_DAYS(DATEDIFF(NOW(), birthday)), '%Y') + 0 AS Age, " +
            "barangay as 'Address (Barangay)' from coop.member where memstatus = 0;";

        public frmReportMembers(MySqlConnection _conn)
        {
            conn = _conn;
            InitializeComponent();
        }

        private void frmReportMembers_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dc.fnExcelExport(getMembersQuery, conn);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            grdReportMembers.DataSource = dt;

            if (grdReportMembers.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in grdReportMembers.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                saveFileDialog1.FileName = "Members " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            }
            else
            {
                btnExportExcel.Enabled = false;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Members " + System.DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.Visible = true;
                this.Enabled = false;
                stopwatch.Start();
                bgWorker.RunWorkerAsync();
            }
            else { retry = false; }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dc.fnExcelExport(getMembersQuery, conn);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            var wBook = new XLWorkbook(); //create workbook
            var wSheet = wBook.Worksheets.Add("data"); //add worksheet

            string[] Letters = { "A", "B", "C", "D", "E", "F", "G" };

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                string col = Letters[c] + (1);
                wSheet.Cell(col).Value = grdReportMembers.Columns[c].HeaderText.ToString();
                wSheet.Cell(col).Style.Font.Bold = true;
                bgWorker.ReportProgress(30, "Generating columns.");
            }
            Thread.Sleep(500);

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 4)
                    {
                        DateTime birthdayValue = DateTime.Parse(grdReportMembers.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cell(Letters[c] + (r + 2)).Value = birthdayValue;
                        var range = wSheet.Range("E2:" + Letters[c] + (dt.Rows.Count + 1));
                        range.Style.NumberFormat.NumberFormatId = (int)XLPredefinedFormat.Number.Text;
                    }

                    if (c == 5)
                    {
                        int ageValue = int.Parse(grdReportMembers.Rows[r].Cells[c].Value.ToString());
                        wSheet.Cell(Letters[c] + (r + 2)).Value = ageValue;
                        var range = wSheet.Range("F2:" + Letters[c] + (dt.Rows.Count + 1));
                    }

                    else
                    {
                        wSheet.Cell(Letters[c] + (r + 2)).Value = grdReportMembers.Rows[r].Cells[c].Value.ToString();
                    }
                    bgWorker.ReportProgress(50, "Adding row values.");
                }
            }
            Thread.Sleep(500);

            //Summary
            wSheet.Range("A" + (dt.Rows.Count + 4) + ":G" + (dt.Rows.Count + 4)).Merge();
            wSheet.Cell("A" + (dt.Rows.Count + 4)).Value = "SUMMARY";
            wSheet.Cell("A" + (dt.Rows.Count + 4)).Style.Font.Bold = true;

            //Summary - Age
            wSheet.Cell("B" + (dt.Rows.Count + 6)).Value = "Age";
            wSheet.Cell("B" + (dt.Rows.Count + 6)).Style.Font.Bold = true;

            wSheet.Cell("B" + (dt.Rows.Count + 7)).Value = "18-35";
            var cellWithFormula1 = wSheet.Cell("C" + (dt.Rows.Count + 7));
            cellWithFormula1.FormulaA1 = "COUNTIFS(F2:F" + (dt.Rows.Count + 1) + ",\">=18\",F2:F" + (dt.Rows.Count + 1) + ",\"<=35\")";
            
            wSheet.Cell("B" + (dt.Rows.Count + 8)).Value = "36-59";
            var cellWithFormula2 = wSheet.Cell("C" + (dt.Rows.Count + 8));
            cellWithFormula2.FormulaA1 = "COUNTIFS(F2:F" + (dt.Rows.Count + 1) + ",\">=36\",F2:F" + (dt.Rows.Count + 1) + ",\"<=59\")";
            
            wSheet.Cell("B" + (dt.Rows.Count + 9)).Value = "60 Above";
            var cellWithFormula3 = wSheet.Cell("C" + (dt.Rows.Count + 9));
            cellWithFormula3.FormulaA1 = "COUNTIF(F2:F" + (dt.Rows.Count + 1) + ",\">=60\")";
            bgWorker.ReportProgress(60, "Calculating cell formulas.");
            Thread.Sleep(500);

            //Summary - Gender
            wSheet.Cell("B" + (dt.Rows.Count + 11)).Value = "Gender";
            wSheet.Cell("B" + (dt.Rows.Count + 11)).Style.Font.Bold = true;

            wSheet.Cell("B" + (dt.Rows.Count + 12)).Value = "Female";
            var cellWithFormula4 = wSheet.Cell("C" + (dt.Rows.Count + 12));
            cellWithFormula4.FormulaA1 = "COUNTIF(D2:D" + (dt.Rows.Count + 1) + ",\"Female\")";

            wSheet.Cell("B" + (dt.Rows.Count + 13)).Value = "Male";
            var cellWithFormula5 = wSheet.Cell("C" + (dt.Rows.Count + 13));
            cellWithFormula5.FormulaA1 = "COUNTIF(D2:D" + (dt.Rows.Count + 1) + ",\"Male\")";

            //Summary - Barangay
            wSheet.Cell("E" + (dt.Rows.Count + 6)).Value = "Barangay";
            wSheet.Cell("E" + (dt.Rows.Count + 6)).Style.Font.Bold = true;
            bgWorker.ReportProgress(70, "Calculating cell formulas.");
            Thread.Sleep(500);

            string[] barangays = { "Annafunan East", "Annafunan West", "Atulayan Norte", "Atulayan Sur", "Bagay", "Buntun",
                            "Caggay", "Capatan", "Carig Norte", "Carig Sur", "Caritan Centro", "Caritan Norte", "Caritan Sur",
                            "Cataggaman Nuevo", "Cataggaman Pardo", "Cataggaman Viejo", "Centro 01 (Bagumbayan)", "Centro 02",
                            "Centro 03", "Centro 04", "Centro 05 (Bagumbayan)", "Centro 06", "Centro 07", "Centro 08", "Centro 09 (Bagumbayan)",
                            "Centro 10 (Riverside)", "Centro 11 (Balzain East)", "Centro 12 (Balzain West)", "Dadda", "Gosi Norte",
                            "Gosi Sur", "Larion Alto", "Larion Bajo", "Leonarda", "Libag Norte", "Libag Sur", "Linao East", "Linao Norte",
                            "Linao West", "Namabbalan Norte", "Namabbalan Sur", "Pallua Norte", "Pallua Sur", "Pengue-Ruyu",
                            "San Gabriel", "Tagga", "Tanza", "Ugac Norte", "Ugac Sur"};

            for (int i = 0; i < barangays.Length; i++)
            {
                wSheet.Cell("E" + (dt.Rows.Count + 7 + i)).Value = barangays[i];
                var cellWithFormula6 = wSheet.Cells("F" + (dt.Rows.Count + 7 + i));
                cellWithFormula6.FormulaA1 = "COUNTIF(G2:G" + (dt.Rows.Count + 1) + ",\"" + barangays[i] + "\")";
                bgWorker.ReportProgress(90, "Calculating cell formulas.");
            }
            Thread.Sleep(500);

            for (int a = 1; a <= 7; a++)
            {
                wSheet.Column(a).AdjustToContents();
            }

            wSheet.Range("A1:A"+(dt.Rows.Count + 7)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            wBook.ReferenceStyle = XLReferenceStyle.A1;
            wBook.CalculateMode = XLCalculateMode.Auto;

            wBook.SaveAs(saveFileDialog1.FileName);
            bgWorker.ReportProgress(100, "Export complete.");
            Thread.Sleep(500);

            #region Previous Code
            //DataSet ds = new DataSet();
            //ds = dc.fnExcelExport(getMembersQuery, conn);
            //WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0];

            //WorkSheet workSheet = wb.CreateWorkSheet("members");

            //string[] Letters = { "A", "B", "C", "D", "E", "F", "G" };

            //for (int c = 0; c < dt.Columns.Count; c++)
            //{
            //    string col = Letters[c] + (1);
            //    workSheet[col].Value = grdReportMembers.Columns[c].HeaderText.ToString();
            //    workSheet[col].Style.Font.Bold = true;
            //    workSheet[col].Style.Font.Italic = true;
            //}

            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    for (int c = 0; c < dt.Columns.Count; c++)
            //    {
            //        int percentage = (int)((float)(r + 1) / dt.Rows.Count) * 100;
            //        if (c == 4)
            //        {
            //            DateTime birthdayValue = DateTime.Parse(grdReportMembers.Rows[r].Cells[c].Value.ToString());
            //            workSheet[Letters[c] + (r + 2)].Value = birthdayValue;
            //            var range = workSheet["E2:" + Letters[c] + (dt.Rows.Count + 1)];
            //            range.FormatString = "MM/dd/yyyy";

            //        }

            //        if (c == 5)
            //        {
            //            int ageValue = int.Parse(grdReportMembers.Rows[r].Cells[c].Value.ToString());
            //            workSheet[Letters[c] + (r + 2)].Value = ageValue;
            //            var range = workSheet["F2:" + Letters[c] + (dt.Rows.Count + 1)];
            //        }

            //        else
            //        {
            //            workSheet[Letters[c] + (r + 2)].Value = grdReportMembers.Rows[r].Cells[c].Value.ToString();
            //        }
            //        bgWorker.ReportProgress(percentage);
            //    }
            //}

            ////Summary
            //workSheet.Merge("A" + (dt.Rows.Count + 4) + ":G" + (dt.Rows.Count + 4));
            //workSheet["A" + (dt.Rows.Count + 4)].Value = "SUMMARY";
            //workSheet["A" + (dt.Rows.Count + 4)].Style.Font.Bold = true;

            //workSheet["A" + (dt.Rows.Count + 4)].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.CenterSelection;
            //workSheet["A" + (dt.Rows.Count + 4)].Style.VerticalAlignment = IronXL.Styles.VerticalAlignment.Center;
            //workSheet["A" + (dt.Rows.Count + 4)].Style.Font.Height = 14;

            ////Summary - Age
            //workSheet["B" + (dt.Rows.Count + 6)].Value = "Age";
            //workSheet["B" + (dt.Rows.Count + 6)].Style.Font.Bold = true;

            //workSheet["B" + (dt.Rows.Count + 7)].Value = "18-35";
            //workSheet["C" + (dt.Rows.Count + 7)].Formula = "=COUNTIFS(F2:F" + (dt.Rows.Count + 1) + ",\">=18\",F2:F" + (dt.Rows.Count + 1) + ",\"<=35\")";
            //workSheet["B" + (dt.Rows.Count + 8)].Value = "36-59";
            //workSheet["C" + (dt.Rows.Count + 8)].Formula = "=COUNTIFS(F2:F" + (dt.Rows.Count + 1) + ",\">=36\",F2:F" + (dt.Rows.Count + 1) + ",\"<=59\")";
            //workSheet["B" + (dt.Rows.Count + 9)].Value = "60 Above";
            //workSheet["C" + (dt.Rows.Count + 9)].Formula = "=COUNTIF(F2:F" + (dt.Rows.Count + 1) + ",\">=60\")";

            ////Summary - Gender
            //workSheet["B" + (dt.Rows.Count + 11)].Value = "Gender";
            //workSheet["B" + (dt.Rows.Count + 11)].Style.Font.Bold = true;

            //workSheet["B" + (dt.Rows.Count + 12)].Value = "Female";
            //workSheet["C" + (dt.Rows.Count + 12)].Formula = "=COUNTIF(D2:D" + (dt.Rows.Count + 1) + ",\"Female\")";
            //workSheet["B" + (dt.Rows.Count + 13)].Value = "Male";
            //workSheet["C" + (dt.Rows.Count + 13)].Formula = "=COUNTIF(D2:D" + (dt.Rows.Count + 1) + ",\"Male\")";

            ////Summary - Barangay
            //workSheet["E" + (dt.Rows.Count + 6)].Value = "Barangay";
            //workSheet["E" + (dt.Rows.Count + 6)].Style.Font.Bold = true;

            //string[] barangays = { "Annafunan East", "Annafunan West", "Atulayan Norte", "Atulayan Sur", "Bagay", "Buntun",
            //                "Caggay", "Capatan", "Carig Norte", "Carig Sur", "Caritan Centro", "Caritan Norte", "Caritan Sur",
            //                "Cataggaman Nuevo", "Cataggaman Pardo", "Cataggaman Viejo", "Centro 01 (Bagumbayan)", "Centro 02",
            //                "Centro 03", "Centro 04", "Centro 05 (Bagumbayan)", "Centro 06", "Centro 07", "Centro 08", "Centro 09 (Bagumbayan)",
            //                "Centro 10 (Riverside)", "Centro 11 (Balzain East)", "Centro 12 (Balzain West)", "Dadda", "Gosi Norte",
            //                "Gosi Sur", "Larion Alto", "Larion Bajo", "Leonarda", "Libag Norte", "Libag Sur", "Linao East", "Linao Norte",
            //                "Linao West", "Namabbalan Norte", "Namabbalan Sur", "Pallua Norte", "Pallua Sur", "Pengue-Ruyu",
            //                "San Gabriel", "Tagga", "Tanza", "Ugac Norte", "Ugac Sur"};

            //for (int i = 0; i < barangays.Length; i++)
            //{
            //    workSheet["E" + (dt.Rows.Count + 7 + i)].Value = barangays[i];
            //    workSheet["F" + (dt.Rows.Count + 7 + i)].Formula = "=COUNTIF(G2:G" + (dt.Rows.Count + 1) + ",\"" + barangays[i] + "\")";
            //}

            ////Columns style
            //workSheet.AutoSizeColumn(0, true);
            //workSheet.AutoSizeColumn(1, false);
            //workSheet.AutoSizeColumn(2, false);
            //workSheet.AutoSizeColumn(3, false);
            //workSheet.AutoSizeColumn(4, false);
            //workSheet.AutoSizeColumn(5, false);
            //workSheet.AutoSizeColumn(6, false);

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

        private void grdReportMembers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdReportMembers.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
    }
}
