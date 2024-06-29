using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using calypso;
using calypso.DataAccess;
using IronXL;
using IronXL.Styles;
using System.Windows.Forms.VisualStyles;
using System.Collections;

namespace coopsys
{
    public partial class frmPatronage : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        private string query;
        private int year;

        public frmPatronage(MySqlConnection _conn)
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            year = int.Parse(cboYear.Text);
            query = "select concat(lastname, ', ', firstname) as 'NAME', format(((sum(interestAmount)*.7)*.3),2) as 'PATRONAGE AMOUNT' from member m " +
                "inner join loan l on m.memberid = l.memberid where loanyear=" + year + " group by m.memberID order by lastname asc; ";
            dt = dc.fnDataTableCollection(query, conn);
            grdPatronageFunds.DataSource = dt;

            if (grdPatronageFunds.Rows.Count > 0)
            {
                btnExportExcel.Enabled = true;
            }

            foreach (DataGridViewRow row in grdPatronageFunds.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
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
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];
                       
                        WorkBook wb = WorkBook.Create(ExcelFileFormat.XLSX);
                        WorkSheet workSheet = wb.CreateWorkSheet(cboYear.Text);

                        string[] Letters = { "A", "B" };
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            string col = Letters[c] + (1);
                            workSheet[col].Value = grdPatronageFunds.Columns[c].HeaderText.ToString();
                            workSheet[col].Style.Font.Bold = true;
                            workSheet[col].Style.Font.Italic = true;
                        }

                        for (int r = 0; r < dt.Rows.Count; r++)
                        {
                            for (int c = 0; c < dt.Columns.Count; c++)
                            {
                                if (c == 1)
                                {
                                    decimal loanValue = decimal.Parse(grdPatronageFunds.Rows[r].Cells[c].Value.ToString());
                                    workSheet[Letters[c] + (r + 2)].Value = loanValue;
                                }
                                else
                                {
                                    workSheet[Letters[c] + (r + 2)].Value = grdPatronageFunds.Rows[r].Cells[c].Value.ToString().ToUpper();
                                }
                            }
                        }
                        var range = workSheet[Letters[1] + "2:" + Letters[1] + (dt.Rows.Count +2)];
                        range.FormatString = "_(\"₱\"* #,##0.00_);_(\"₱\"* (#,##0.00);_(\"₱\"* \"-\"_);_(@_)";

                        //Columns style
                        workSheet.AutoSizeColumn(0, true);
                        workSheet.AutoSizeColumn(1, false);

                        path = saveFileDialog1.FileName;
                        wb.SaveAs(path);
                        MessageBox.Show("Excel Workbook Created Successfully At\n " + path, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        path = "";
                        retry = false;
                    }
                    else
                    {
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdPatronageFunds.DataSource = null;
            btnExportExcel.Enabled = false;
            cboYear.SelectedIndex = 0;
        }

        private void grdPatronageFunds_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdPatronageFunds.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        
    }
}
