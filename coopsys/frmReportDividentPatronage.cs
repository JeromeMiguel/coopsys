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
using IronXL;

namespace coopsys
{
    public partial class frmReportDividentPatronage : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        public decimal defaultDividentPercentage = 10;
        public string query;

        public frmReportDividentPatronage(MySqlConnection _conn)
        {
            conn = _conn;
            InitializeComponent();

            dt = dc.fnDataTableCollection("select distinct year from capitalshare;", conn);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "year";
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
            }
       
        }

        private void frmReportDividentPatronage_Load(object sender, EventArgs e)
        {
            txtDivident.Text=defaultDividentPercentage.ToString();
            btnExportExcel.Enabled=false;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtDivident.Text) <=100 && int.Parse(txtDivident.Text)>=0) {
                decimal dividentPercentage = Decimal.Parse(txtDivident.Text);
                query = "SELECT CONCAT(lastname,\", \", firstname, \" \", middlename) AS \"Name\", SUM(csamount) AS \"Total Capital Share (" + cboYear.Text + ")\", SUM(csamount)*" + dividentPercentage / 100 + " AS \"Dividend " + dividentPercentage + "%\"  " +
                    "FROM member LEFT JOIN capitalshare ON member.memberID = capitalshare.memberID WHERE year = "+int.Parse(cboYear.Text) + " GROUP BY member.memberID ORDER BY lastname ASC;";

                DataSet ds = new DataSet();
                ds = dc.fnExcelExport(query, conn);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                btnExportExcel.Enabled = true;
                grdReportDividentPatronage.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please Enter A Value from 0-100", "Divident Percentage Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void txtDivident_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdReportDividentPatronage.DataSource = "";
            txtDivident.Text = defaultDividentPercentage.ToString();
            btnExportExcel.Enabled = false;
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
                        ds = dc.fnExcelExport(query, conn);
                        WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];

                        WorkSheet workSheet = wb.CreateWorkSheet("members");



                        string[] Letters = { "A", "B", "C", "D", "E", "F" };

                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            string col = Letters[c] + (1);
                            workSheet[col].Value = grdReportDividentPatronage.Columns[c].HeaderText.ToString();
                            workSheet[col].Style.Font.Bold = true;
                            workSheet[col].Style.Font.Italic = true;
                            if (c == 2)
                            {
                                workSheet[col].Style.BackgroundColor = "#C6E0B4";
                            }

                        }

                        for (int r = 0; r < dt.Rows.Count; r++)
                        {
                            for (int c = 0; c < dt.Columns.Count; c++)
                            {
                                if (c == 1 || c == 2)
                                {
                                    Console.WriteLine(c);
                                    decimal ageValue = decimal.Parse(grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString());
                                    workSheet[Letters[c] + (r + 2)].Value = ageValue;
                                    var range = workSheet[Letters[c] + "2:" + Letters[c] + (dt.Rows.Count + 1)];
                                    range.FormatString = "_(\"₱\"* #,##0_);_(\"₱\"* (#,##0);_(\"₱\"* \"-\"_);_(@_)";
                                    if (c == 2)
                                    {
                                        range.Style.BackgroundColor = "#C6E0B4";
                                    }
                                }
                                else
                                {
                                    workSheet[Letters[c] + (r + 2)].Value = grdReportDividentPatronage.Rows[r].Cells[c].Value.ToString();
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
                    DialogResult dialogResult = MessageBox.Show(error.Message + " \n\nPlease Close the Excel File Before Saving", "Export Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        path = "";
                    }
                    else { retry = false; }
                }
            }
        }
    }
}
