using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using calypso;
using calypso.DataAccess;
using System.Collections;
using IronXL;
using IronSoftware.Drawing.Extensions;
using IronSoftware.Shared;
using IronXL.Formatting;
using System.IO;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestExcel
{
    public partial class FrmTestExcel : Form
    {
        Database db = new Database();
        DataCollection dc = new DataCollection();
        DataGridTableStyle tableStyle = new DataGridTableStyle();
        MySqlConnection conn;
        public string query = "select lastname as 'Surname', firstname as 'First Name', middlename as 'Middle Name', " +
          "birthday as 'Birthday', DATE_FORMAT(FROM_DAYS(DATEDIFF(NOW(),birthday)), '%Y') \r\n + 0 AS Age from coop.member where memstatus=1;";

        public FrmTestExcel()
        {
            InitializeComponent();
           
            db._serverAddress = "localhost";
            db._databaseName = "coop";
            db._serverPort = "3306";
            db._serverUID = "root";
            db._serverPWD = "root_passv.1.1";
            conn = db.InitializeConnection();

        }

        private void FrmTestExcel_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dc.fnExcelExport(query, conn);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            grdMembers.DataSource = dt;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path;
                DataSet ds = new DataSet();
                ds = dc.fnExcelExport(query, conn);
                WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                WorkSheet workSheet = wb.CreateWorkSheet("members");



                string[] Letters = { "A", "B", "C", "D", "E", "F" };

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    string col = Letters[c] + (1);
                    workSheet[col].Value = grdMembers.Columns[c].HeaderText.ToString();
                    workSheet[col].Style.Font.Bold = true;
                    workSheet[col].Style.Font.Italic = true;

                }

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        if (c == 3)
                        {
                            DateTime birthdayValue = DateTime.Parse(grdMembers.Rows[r].Cells[c].Value.ToString());
                            workSheet[Letters[c] + (r + 2)].Value = birthdayValue;
                            var range = workSheet["D2:"+Letters[c] + (dt.Rows.Count+1)];
                            range.FormatString = "MM/dd/yyyy";

                        }

                        if (c == 4)
                        {
                            int ageValue = int.Parse(grdMembers.Rows[r].Cells[c].Value.ToString());
                            workSheet[Letters[c] + (r + 2)].Value = ageValue;
                            var range = workSheet["E2:" + Letters[c] + (dt.Rows.Count + 1)];
                            range.FormatString = "D";

                        }

                        else
                        {
                            workSheet[Letters[c] + (r + 2)].Value = grdMembers.Rows[r].Cells[c].Value.ToString();
                        }
                    }
                }

                path = saveFileDialog1.FileName;
                wb.SaveAs(path);
                path = "";
            }


         


        }
    }
}
