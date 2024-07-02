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
        clsDefaults defaults = new clsDefaults();
        MySqlConnection conn;

        DateTime date, time;
        private int memberID, sex, memfee, memtype, memstatus;
        private string fname, mname, lname, bday, position, busname, busplateno, address, tin, cpnum, stalladdress, 
            houseno, street, barangay, municipality_city, bus_bldgno, bus_street, bus_barangay, bus_municipality_city, account_number;

        public frmMain(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;

            string cert_total = "0", member_total = "0";

            cert_total = dc.fnReturnStringValue("select count(cert_id) as R from certificate", "R", conn);
            member_total = dc.fnReturnStringValue("select count(memberid) as R from member", "R", conn);
            defaults.certificateTotal = int.Parse(cert_total);
            defaults.totalMember = int.Parse(member_total);

            int defaultYear = int.Parse(dc.fnReturnStringValue("select year from defaults", "year", conn));
            int systemYear = int.Parse(lblDate.Text = DateTime.Now.ToString("yyyy"));

            if (int.Parse(dc.fnReturnStringValue("select exists (select * from defaults) as R", "R", conn)) == 1)
            {
                if (systemYear > defaultYear)
                {
                    dc.fnExecuteQuery("update defaults set `year` = " + systemYear + "," +
                    "`cert_count`=" + cert_total + "," +
                    "`member_count`=" + member_total + "", conn);
                }
                else
                {
                    dc.fnExecuteQuery("update defaults set" +
                    "`cert_count`=" + cert_total + "," +
                    "`member_count`=" + member_total + "", conn);
                }
            }
            else
            {
                dc.fnExecuteQuery("INSERT INTO `coop`.`defaults`" +
                    "(`year`,`cert_count`,`member_count`)" +
                    "VALUES(" + System.DateTime.Today.Year + "," +
                    ""+cert_total+"," +
                    ""+member_total+");", conn);
            }
            defaults.year = int.Parse(dc.fnReturnStringValue("select year from defaults", "year", conn));
        }

        private void SearchMemberLoadGrid(int _memStatVal)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                //control statement without search key
                if (cboMemType.SelectedIndex == 0)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where memstatus = "+_memStatVal+";");
                }
                else if (cboMemType.SelectedIndex == 1)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where memtype=0 and memstatus = " + _memStatVal+";");
                }
                else if (cboMemType.SelectedIndex == 2)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where memtype=1 and memstatus = " + _memStatVal+";");
                }

                setRowHeadNumber();
            }
            else
            {
                //control statement with search key
                if (cboMemType.SelectedIndex == 0)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where lastname like '%" + txtSearch.Text + "%' and memstatus = "+_memStatVal+" ");
                }
                else if (cboMemType.SelectedIndex == 1)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where lastname like '%" + txtSearch.Text + "%' and memstatus = "+_memStatVal+" " +
                        "and memtype = 0;");
                }
                else if (cboMemType.SelectedIndex == 2)
                {
                    SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where lastname like '%" + txtSearch.Text + "%' and memstatus = "+_memStatVal+" " +
                        "and memtype = 1;");
                }

                setRowHeadNumber();
                grdMembers.ClearSelection();
            }
        }

        private void tsmiScheduleOfCapitalShare_Click(object sender, EventArgs e)
        {
            frmReportOnScheduleOfShareCapital scheduleOfShareCapital = new frmReportOnScheduleOfShareCapital(conn);
            scheduleOfShareCapital.ShowDialog();
        }

        private void tsmiScheduleOfLoanReleases_Click(object sender, EventArgs e)
        {
            frmReportLoanReleases scheduleOfLoanRelease = new frmReportLoanReleases(conn); 
            scheduleOfLoanRelease.ShowDialog();
        }

        private void tsmInterestOnCapitalShare_Click(object sender, EventArgs e)
        {
            frmReportInterestOnCapitalShare interestOnCapitalShare = new frmReportInterestOnCapitalShare(conn);
            interestOnCapitalShare.ShowDialog();
        }

        private void grdMembers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnFormLoad();
        }

        private void scheduleOfPastDueLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportPastDueLoan dueLoan = new frmReportPastDueLoan(conn); 
            dueLoan.ShowDialog();
        }

        private void scheduleOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportOnScheduleOfSales schedule = new frmReportOnScheduleOfSales(conn);
            schedule.ShowDialog();
        }

        private void sqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupSql sql = new frmBackupSql(conn);
            sql.ShowDialog();
        }

        private void finalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinalReport report = new frmFinalReport(conn);
            report.ShowDialog();
        }

        private void tipTools_Popup(object sender, PopupEventArgs e)
        {

        }

        private void savingsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
            fname = grdMembers.SelectedCells[1].Value.ToString();
            mname = grdMembers.SelectedCells[2].Value.ToString();
            lname = grdMembers.SelectedCells[3].Value.ToString();

            string savingsAccExists=dc.fnReturnStringValue("SELECT IF( EXISTS( SELECT savingsID FROM coop.savings WHERE `memberID` =  "+memberID+" ), 1, 0) AS \"AccountExists\";", "AccountExists", conn);

            if (savingsAccExists == "0")
            {
                DialogResult savingsDialog = MessageBox.Show(this, "This User has no registered Savings Account\nDo you want to create a Savings Account?",
                     "Account Does Not Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (savingsDialog == DialogResult.Yes)
                {
                    frmSavings form = new frmSavings(conn, memberID, fname, mname, lname);
                    form.ShowDialog();
                }
            }
            else
            {

                frmViewSavings form = new frmViewSavings(conn, memberID, fname, mname, lname);
                form.ShowDialog();
            }
        }

        private void printCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
            fname = grdMembers.SelectedCells[1].Value.ToString();
            mname = grdMembers.SelectedCells[2].Value.ToString();
            lname = grdMembers.SelectedCells[3].Value.ToString();

            frmPrintDialog print = new frmPrintDialog(conn, fname, mname, lname, memberID);
            print.ShowDialog();
        }

        public void OnFormLoad()
        {
            string query = "SELECT COUNT(loan.loanID) " +
                "from loan inner join member on member.memberid = loan.memberid " +
                "left join penalty on loan.loanid = penalty.loanid " +
                "where ((balance > 0 or penaltyamount > 0) or penaltystatus = 0) and memstatus = 0;";

            btnDue.Text = "(" + dc.fnDataTableCollection(query, conn).Rows[0][0].ToString() + ") Due for Payment";
            cboMemType.SelectedIndex = 0;
            cboMemStat.SelectedIndex = 0;
            grdMembers.ClearSelection();

            setRowHeadNumber();
        }

        private void OpenLoanForm()
        {
            if (!(grdMembers.SelectedRows.Count == 0))
            {
                memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
                fname = grdMembers.SelectedCells[1].Value.ToString();
                mname = grdMembers.SelectedCells[2].Value.ToString();
                lname = grdMembers.SelectedCells[3].Value.ToString();
                frmLoan loan = new frmLoan(this, conn, memberID, fname, mname, lname);
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
            frmDueForPayment dueForPayment = new frmDueForPayment(this, conn);
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
                try
                {
                    grdMembers.Rows[e.RowIndex].Selected = true;
                    contextMenuStripDataRow.Show(MousePosition.X, MousePosition.Y);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex);
                }

               
            }
        }

        private void viewSharesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString()); 
            fname = grdMembers.SelectedCells[1].Value.ToString();
            mname = grdMembers.SelectedCells[2].Value.ToString();
            lname = grdMembers.SelectedCells[3].Value.ToString();
            memtype = Int32.Parse(grdMembers.SelectedCells[22].Value.ToString());
            frmViewMemberShares ViewMemberShares = new frmViewMemberShares(conn, memberID, memtype, fname, mname, lname);
            ViewMemberShares.ShowDialog();
        }

        public void SearchResult(string query)
        {
            grdMembers.DataSource = dc.fnDataTableCollection(query, conn);
            grdMembers.Columns[0].Visible = false;//memberID
            grdMembers.Columns[2].Visible = true;//mname
            grdMembers.Columns[4].Visible = false;//sex
            grdMembers.Columns[5].Visible = false;//birthday
            grdMembers.Columns[6].Visible = false;//position
            grdMembers.Columns[7].Visible = false;//cpnum
            grdMembers.Columns[8].Visible = false;//tin
            grdMembers.Columns[9].Visible = false;//houseno
            grdMembers.Columns[10].Visible = false;//street
            grdMembers.Columns[11].Visible = false;//barangay
            grdMembers.Columns[12].Visible = false;//bmunicipality_city
            grdMembers.Columns[13].Visible = false;//memfee

            grdMembers.Columns[15].Visible = false;//memstatus
            grdMembers.Columns[16].Visible = false;//busname
            grdMembers.Columns[17].Visible = false;//busplateno
            grdMembers.Columns[18].Visible = false;//bus_bldgno
            grdMembers.Columns[19].Visible = false;//bus_street
            grdMembers.Columns[20].Visible = false;//bus_barangay
            grdMembers.Columns[21].Visible = false;//bus_municipality_city
            grdMembers.Columns[22].Visible = false;//memtype
            grdMembers.Columns[23].Visible = false;//account_number

            grdMembers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblTotalResult.Text = "Total Records: " + grdMembers.Rows.Count.ToString();
            setRowHeadNumber();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OnFormLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!(grdMembers.SelectedCells.Count == 0))
            {
                memberID = Int32.Parse(grdMembers.SelectedCells[0].Value.ToString());
                fname = grdMembers.SelectedCells[1].Value.ToString();
                mname = grdMembers.SelectedCells[2].Value.ToString();
                lname = grdMembers.SelectedCells[3].Value.ToString();
                sex = Int32.Parse(grdMembers.SelectedCells[4].Value.ToString());
                bday = grdMembers.SelectedCells[5].Value.ToString();
                position = grdMembers.SelectedCells[6].Value.ToString();  
                cpnum = grdMembers.SelectedCells[7].Value.ToString();
                tin = grdMembers.SelectedCells[8].Value.ToString();
                houseno = grdMembers.SelectedCells[9].Value.ToString();
                street = grdMembers.SelectedCells[10].Value.ToString();
                barangay = grdMembers.SelectedCells[11].Value.ToString();
                municipality_city = grdMembers.SelectedCells[12].Value.ToString();
                memfee = Int32.Parse(grdMembers.SelectedCells[13].Value.ToString());
                memtype = Int32.Parse(grdMembers.SelectedCells[22].Value.ToString());
                memstatus = Int32.Parse(grdMembers.SelectedCells[15].Value.ToString()); 
                busname = grdMembers.SelectedCells[16].Value.ToString();
                busplateno = grdMembers.SelectedCells[17].Value.ToString();
                bus_bldgno = grdMembers.SelectedCells[18].Value.ToString();
                bus_street = grdMembers.SelectedCells[19].Value.ToString();
                bus_barangay = grdMembers.SelectedCells[20].Value.ToString();
                bus_municipality_city = grdMembers.SelectedCells[21].Value.ToString();
                account_number = grdMembers.SelectedCells[23].Value.ToString();

                frmMember member = new frmMember(this, conn, false, memberID, fname, mname, lname, sex, bday, position,
                    cpnum, tin, houseno, street, barangay, municipality_city, memfee, memtype, memstatus, busname, busplateno, 
                    bus_bldgno, bus_street, bus_barangay, bus_municipality_city, account_number, cboMemType.SelectedIndex);
                member.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Please select one record from the list.", "Notice", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeMemStatus changeStat = new frmChangeMemStatus(conn, this, Int32.Parse(grdMembers.SelectedCells[0].Value.ToString()), Int32.Parse(grdMembers.SelectedCells[15].Value.ToString()));
            changeStat.ShowDialog();
        }

        private void btnSearchMem_Click(object sender, EventArgs e)
        {
            SearchMemberLoadGrid(cboMemStat.SelectedIndex);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchMemberLoadGrid(cboMemStat.SelectedIndex);
        }

        private void cboMemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchMemberLoadGrid(cboMemStat.SelectedIndex);
        }

        private void cboMemStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchMemberLoadGrid(cboMemStat.SelectedIndex);
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

        private void setRowHeadNumber()
        {
            foreach (DataGridViewRow row in grdMembers.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
    }
}
