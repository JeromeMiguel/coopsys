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
            string query = "select loan.loanID, member.memberID, " +
                "concat(loanmonth,'/', loanday, '/', loanyear) as 'LOAN DATE', " +
                "concat(firstname, ' ', lastname) as NAME, " +
                "loan.loanamount as 'LOAN AMOUNT', " +
                "loan.balance as 'BALANCE', " +
                "loan.loanpenalty as 'PENALTY', " +
                "loan.duedate as 'DUE DATE' " +
                "from member inner join loan " +
                "on member.memberID = loan.memberID " +
                "where loan.balance > 0 or loan.loanpenalty > 0;";
            grdMembers.DataSource = dc.fnDataTableCollection(query, conn);

            grdMembers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (grdMembers.Rows.Count > 0)
            {
                grdMembers.Columns[0].Visible = false;
                grdMembers.Columns[1].Visible = false;
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
                balance = double.Parse(grdMembers.SelectedCells[5].Value.ToString());
                penalty = double.Parse(grdMembers.SelectedCells[6].Value.ToString());
                duedate = grdMembers.SelectedCells[7].Value.ToString();
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
