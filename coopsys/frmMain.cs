using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data;
using MySql.Data.MySqlClient;
using calypso;
using calypso.DataAccess;
using IronXL;
using System.IO;

namespace coopsys
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();   
        DataCollection dc = new DataCollection();
        DataGridTableStyle tableStyle = new DataGridTableStyle();
        MySqlConnection conn;
        DateTime date, time;
        private int memberID, age, sex, memfee, memtype, memstatus;
        private string fname, mname, lname, bday, busname, busplateno, address, tin, cpnum, stalladdress;

        public frmMain()
        {
            InitializeComponent();
            db._serverAddress = "10.0.0.39";
            db._databaseName = "coop";
            db._serverPort = "3500";
            db._serverUID = "JeromeMiguel";
            db._serverPWD = "@migzcastle";
            conn = db.InitializeConnection();
        }

        private void SearchMemberLoadGrid()
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                if (cboMemType.SelectedIndex == 0)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                        "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                        "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                        "bus_barangay, bus_municipality_city from coop.member;");
                }
                else if (cboMemType.SelectedIndex == 1)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                          "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                          "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                          "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                          "bus_barangay, bus_municipality_city from coop.member where memtype=0;");
                }
                else if (cboMemType.SelectedIndex == 2)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                        "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                        "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                        "bus_barangay, bus_municipality_city from coop.member where memtype=1;");
                }
            }
            else
            {
                if (cboMemType.SelectedIndex == 0)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                        "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                        "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                        "bus_barangay, bus_municipality_city from coop.member where lastname like '%" + txtSearch.Text + "%'");
                }
                else if (cboMemType.SelectedIndex == 1)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                        "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                        "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                        "bus_barangay, bus_municipality_city from coop.member where lastname like '%" + txtSearch.Text + "%'" +
                        "and memtype = 0;");
                }
                else if (cboMemType.SelectedIndex == 2)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                        "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                        "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                        "bus_barangay, bus_municipality_city from coop.member where lastname like '%" + txtSearch.Text + "%'" +
                        "and memtype = 1;");
                }
                grdMembers.ClearSelection();
            }
        }

        private void OpenLoanForm()
        {
            if (!(grdMembers.SelectedRows.Count == 0))
            {
                memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
                fname = grdMembers.SelectedCells[1].Value.ToString();
                mname = grdMembers.SelectedCells[2].Value.ToString();
                lname = grdMembers.SelectedCells[3].Value.ToString();
                age = int.Parse(grdMembers.SelectedCells[6].Value.ToString());
                frmLoan loan = new frmLoan(conn, memberID, fname, mname, lname, age);
                loan.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Please select one record from the list.", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Logout()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnDue_Click(object sender, EventArgs e)
        {
            frmDueForPayment dueForPayment = new frmDueForPayment(conn);
            dueForPayment.ShowDialog();
        }


  

        private void tsmiReportsMembers_Click(object sender, EventArgs e)
        {
            frmReportMembers reportMembers = new frmReportMembers(conn);
            reportMembers.ShowDialog();
        }

        private void tsmiReportsDividentPatronage_Click(object sender, EventArgs e)
        {
            frmReportDividentPatronage reportMembers = new frmReportDividentPatronage(conn);
            reportMembers.ShowDialog();
        }

        private void grdMembers_DataSourceChanged(object sender, EventArgs e)
        {
            if(grdMembers.Rows.Count > 0)
            {
                grdMembers.Rows[0].Selected = true;
                btnEdit.Enabled = true;    
                btnLoan.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = true;
                btnLoan.Enabled = true;
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            OpenLoanForm();
        }

        private void grdMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenLoanForm();
        }

        private void grdMembers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                grdMembers.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataRow.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void viewSharesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
            fname = grdMembers.SelectedCells[1].Value.ToString();
            mname = grdMembers.SelectedCells[2].Value.ToString();
            lname = grdMembers.SelectedCells[3].Value.ToString();
            memtype = Int32.Parse(grdMembers.SelectedCells[9].Value.ToString());
            frmViewMemberShares ViewMemberShares = new frmViewMemberShares(conn, memberID, memtype, fname, mname, lname);
            ViewMemberShares.ShowDialog();
        }

        public void SearchResult(string query)
        {
            grdMembers.DataSource = dc.fnDataTableCollection(query, conn);
            grdMembers.Columns[0].Visible = false;//memberID
            grdMembers.Columns[2].Visible = false;//mname
            grdMembers.Columns[5].Visible = false;//position
            grdMembers.Columns[6].Visible = false;//sex
            grdMembers.Columns[7].Visible = false;//birthday
            grdMembers.Columns[8].Visible = false;//cpnum
            grdMembers.Columns[9].Visible = false;//tin
            grdMembers.Columns[10].Visible = false;//houseno
            grdMembers.Columns[11].Visible = false;//street
            grdMembers.Columns[12].Visible = false;//barangay
            grdMembers.Columns[13].Visible = false;//municipality_city
            grdMembers.Columns[14].Visible = false;//memfee
            grdMembers.Columns[15].Visible = false;//memtype
            grdMembers.Columns[16].Visible = false;//memstatus
            grdMembers.Columns[17].Visible = false;//busname
            grdMembers.Columns[18].Visible = false;//busplateno
            grdMembers.Columns[19].Visible = false;//bus_bldgno
            grdMembers.Columns[20].Visible = false;//bus_street
            grdMembers.Columns[21].Visible = false;//bus_barangay
            grdMembers.Columns[22].Visible = false;//bus_municipality_city

            grdMembers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblTotalResult.Text = "Total Records: " + grdMembers.Rows.Count.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //string query = "select loan.loanID, member.memberID, " +
            //    "concat(loanmonth,'/', loanday, '/', loanyear) as 'LOAN DATE', " +
            //    "concat(firstname, lastname) as NAME, " +
            //    "loan.loanamount as 'LOAN AMOUNT', " +
            //    "loan.balance as 'BALANCE', " +
            //    "loan.loanpenalty as 'PENALTY', " +
            //    "loan.duedate as 'DUE DATE' " +
            //    "from member inner join loan " +
            //    "on member.memberID = loan.memberID " +
            //    "where loan.balance > 0 or loan.loanpenalty > 0;";

            SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       "if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE', " +
                       "position, sex, birthday,  cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee, memtype, memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city from coop.member;");

            //btnDue.Text = "("+dc.fnDataTableCollection(query, conn).Rows.Count.ToString()+") Due for Payment";
            cboMemType.SelectedIndex = 0;
            grdMembers.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!(grdMembers.SelectedCells.Count == 0))
            {
                memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
                fname = grdMembers.SelectedCells[1].Value.ToString();
                mname = grdMembers.SelectedCells[2].Value.ToString();
                lname = grdMembers.SelectedCells[3].Value.ToString();
                //position = grdMembers.SelectedCells[5].Value.ToString();
                sex = Int32.Parse(grdMembers.SelectedCells[6].Value.ToString());
                bday = grdMembers.SelectedCells[5].Value.ToString();
                cpnum = grdMembers.SelectedCells[6].Value.ToString();
                sex = Int32.Parse(grdMembers.SelectedCells[7].Value.ToString());
                memfee = Int32.Parse(grdMembers.SelectedCells[8].Value.ToString());
                memtype = Int32.Parse(grdMembers.SelectedCells[9].Value.ToString());
                busname = grdMembers.SelectedCells[11].Value.ToString();
                busplateno = grdMembers.SelectedCells[12].Value.ToString();
                address = grdMembers.SelectedCells[13].Value.ToString();
                tin = grdMembers.SelectedCells[14].Value.ToString();
                cpnum = grdMembers.SelectedCells[15].Value.ToString();
                stalladdress = grdMembers.SelectedCells[16].Value.ToString();

                frmMember member = new frmMember(this, conn, false, memberID, fname, mname, lname, bday, age,
                    sex, memfee, memtype, busname, busplateno, address, tin, cpnum, stalladdress, cboMemType.SelectedIndex);
                member.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Please select one record from the list.", "Notice", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearchMem_Click(object sender, EventArgs e)
        {
            SearchMemberLoadGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchMemberLoadGrid();
        }

        private void cboMemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchMemberLoadGrid();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmMember member = new frmMember(this, conn, true, 1);
            member.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lblTime.Text = time.ToLongTimeString();

            date = DateTime.Today;
            lblDate.Text = date.ToLongDateString();
        }
    }
}
