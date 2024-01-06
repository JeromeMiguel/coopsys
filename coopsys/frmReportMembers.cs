using calypso.DataAccess;
using calypso;
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
using System.Collections;
using IronXL;

namespace coopsys
{
    public partial class frmReportMembers : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        DataCollection dc = new DataCollection();
        DataGridTableStyle tableStyle = new DataGridTableStyle();
        MySqlConnection conn;
        public string getMembersQuery = "select lastname as 'Surname', firstname as 'First Name', middlename as 'Middle Name', " +
         "birthday as 'Birthday', DATE_FORMAT(FROM_DAYS(DATEDIFF(NOW(),birthday)), '%Y') \r\n + 0 AS Age from coop.member where memstatus=1;";

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
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            bool retry = true;

            while (retry)

            {
                string path;
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {


                        DataSet ds = new DataSet();
                        ds = dc.fnExcelExport(getMembersQuery, conn);
                        WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];

                        WorkSheet workSheet = wb.CreateWorkSheet("members");



                        string[] Letters = { "A", "B", "C", "D", "E", "F" };

                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            string col = Letters[c] + (1);
                            workSheet[col].Value = grdReportMembers.Columns[c].HeaderText.ToString();
                            workSheet[col].Style.Font.Bold = true;
                            workSheet[col].Style.Font.Italic = true;

                        }

                        for (int r = 0; r < dt.Rows.Count; r++)
                        {
                            for (int c = 0; c < dt.Columns.Count; c++)
                            {
                                if (c == 3)
                                {
                                    DateTime birthdayValue = DateTime.Parse(grdReportMembers.Rows[r].Cells[c].Value.ToString());
                                    workSheet[Letters[c] + (r + 2)].Value = birthdayValue;
                                    var range = workSheet["D2:" + Letters[c] + (dt.Rows.Count + 1)];
                                    range.FormatString = "MM/dd/yyyy";

                                }

                                if (c == 4)
                                {
                                    int ageValue = int.Parse(grdReportMembers.Rows[r].Cells[c].Value.ToString());
                                    workSheet[Letters[c] + (r + 2)].Value = ageValue;
                                    var range = workSheet["E2:" + Letters[c] + (dt.Rows.Count + 1)];
                                }

                                else
                                {
                                    workSheet[Letters[c] + (r + 2)].Value = grdReportMembers.Rows[r].Cells[c].Value.ToString();
                                }
                            }
                        }

                        path = saveFileDialog1.FileName;
                        wb.SaveAs(path);
                        MessageBox.Show("Excel Workbook Created Successfully At\n " + path, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        path = "";
                        retry = false;
                    }


                }
                catch (Exception error)
                {
                    DialogResult dialogResult = MessageBox.Show(error.Message+ " \n\nPlease Close the Excel File Before Saving" , "Export Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        path = "";
                    }
                   else  { retry = false; }
                }
            }
        }
    }
}
