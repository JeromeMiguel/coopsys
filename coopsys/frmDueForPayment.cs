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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.ComponentModel.Composition.Primitives;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace coopsys
{
    public partial class frmDueForPayment : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        DataCollection dc = new DataCollection();
        DataGridTableStyle tableStyle = new DataGridTableStyle();
        MySqlConnection conn;
        frmMain main;
        private int loanID, memberID;
        private double balance, penalty;
        private string duedate;

        public frmDueForPayment(frmMain _main, MySqlConnection _conn)
        {
            main = _main;
            conn = _conn;
            InitializeComponent();
        }

        public void LoadDueList()
        {

            #region DataGrid Query
            string query = "select loan.loanid as 'LID', member.memberid as 'MID', " +
                    "concat(firstname, ' ', lastname) as 'NAME', format(loanamount,2) as 'LOAN AMOUNT', " +
                    "format(balance,2) as 'BALANCE', concat(if(loanmonth<10,concat(0,loanmonth),loanmonth),'/', if(loanday<10,concat(0,loanday),loanday), '/', loanyear) as 'LOAN DATE', " +
                    "duedate as 'MATURITY DATE', format(ifnull(penaltyamount, 0),2) as 'PENALTY AMOUNT' " +
                    "from loan inner join member on member.memberid = loan.memberid " +
                    "left join penalty on loan.loanid = penalty.loanid " +
                    "where ((balance > 0 or penaltyamount > 0) or penaltystatus = 0) and memstatus = 0 " +
                    "order by name asc;";
            #endregion
            grdMembers.DataSource = dc.fnDataTableCollection(query, conn);

            grdMembers.Columns[0].Visible = false;
            grdMembers.Columns[1].Visible = false;
            grdMembers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//name
            grdMembers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//loan amount
            grdMembers.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//balance
            grdMembers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//loan date
            grdMembers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//maturity date
            grdMembers.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//penalty amount

            if (grdMembers.Rows.Count > 0)
            {
                grdMembers.Columns[0].Visible = false;
                grdMembers.Columns[1].Visible = false;
            }

            foreach (DataGridViewRow row in grdMembers.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

        }

        private void frmDueForPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.OnFormLoad();
        }

        private void frmDueForPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void grdMembers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in grdMembers.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmDueForPayment_Load(object sender, EventArgs e)
        {
            LoadDueList();
        }

        private void grdMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(grdMembers.SelectedRows.Count == 0))
            {
                loanID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
                memberID = Int32.Parse(grdMembers.SelectedCells[1].Value.ToString());
                balance = double.Parse(grdMembers.SelectedCells[4].Value.ToString());
                penalty = double.Parse(grdMembers.SelectedCells[7].Value.ToString());
                duedate = grdMembers.SelectedCells[6].Value.ToString();
                frmPayment payment = new frmPayment(this, conn, loanID, memberID, balance, penalty, duedate, true);
                payment.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Please select one record from the list.", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
