using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calypso;
using calypso.DataAccess;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;

namespace coopsys
{
    public partial class frmMember : MetroFramework.Forms.MetroForm
    {
        frmMain formMain;
        Database db = new Database();
        DataCollection dc = new DataCollection();
        clsDefaults defaults = new clsDefaults();
        MySqlConnection conn;
        private bool register;
        private int age, sex, memfee, memtype, memstatus, memberID, cboMemTypeMain;
        private string bday, busname, busplateno, tin, account_number;

        private void txtCpNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtxtTin_Leave(object sender, EventArgs e)
        {
            Console.WriteLine(mtxtTin.Text);
            if(string.IsNullOrEmpty(mtxtTin.Text) || mtxtTin.Text == "   -   -   -")
            {
                mtxtTin.Font = new Font(mtxtTin.Font, FontStyle.Italic);
                mtxtTin.Mask = "";
                mtxtTin.Text = "TIN";
                mtxtTin.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txtHouseNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void mtxtTin_Click(object sender, EventArgs e)
        {
            if (mtxtTin.Text == "TIN")
            {
                mtxtTin.Clear();
            }
            mtxtTin.Font = new Font(mtxtTin.Font, FontStyle.Regular);
            mtxtTin.ForeColor = SystemColors.WindowText;
            mtxtTin.Mask = "000-000-000-000";
            mtxtTin.PromptChar = ' ';
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            if (tin != null)
            {
                mtxtTin.Font = new Font(mtxtTin.Font, FontStyle.Regular);
                mtxtTin.ForeColor = SystemColors.WindowText;
                mtxtTin.Mask = "000-000-000-000";
                mtxtTin.PromptChar = ' ';
            }
        }

        public DateTime today = DateTime.Today;

        public frmMember(frmMain _formMain, MySqlConnection _conn, bool _register, int _cboMemTypeMain)
        {
            InitializeComponent();
            cboMemTypeMain = _cboMemTypeMain;
            cboMemType.SelectedIndex = _cboMemTypeMain;
            formMain = _formMain;
            conn = _conn;
            register = _register;

            account_number = "MTM-" + defaults.year + "-" + string.Format("{0:000000}", defaults.totalMember + 1) + "";
            txtAccountNumber.Text = account_number;
        }

        public frmMember(frmMain _formMain, MySqlConnection _conn, bool _register, int _memberID, string _fname, string _mname, string _lname,
            int _sex, string _bday, string _position, string _cpnum, string _tin, string _houseno, string _street, string _barangay, 
            string _municipality_city, int _memfee, int _memtype, int _memstatus, string _busname, string _busplateno,
            string _bus_bldgno, string _bus_street, string _bus_barangay, string _bus_municipality_city, string _account_number, int _cboMemTypeMain)
        {
            InitializeComponent();
            cboMemTypeMain = _cboMemTypeMain;
            formMain = _formMain;
            conn = _conn;
            register = _register;
            
            tin = _tin;
            memberID = _memberID;
            txtFname.Text = _fname;
            txtMname.Text = _mname;
            txtLname.Text = _lname;
            txtBday.Value = DateTime.Parse(_bday);
            cboSex.SelectedIndex = _sex;
            cboMemType.SelectedIndex = _memtype;
            memfee = _memfee;
            if (memfee == 1) { chkFee.Checked = true; }
            else { chkFee.Checked = false; };
            txtBusName.Text = _busname;
            txtBusPlateNo.Text = _busplateno;
            mtxtTin.Text = _tin;
            txtCpNum.Text = _cpnum;
            txtHouseNo.Text = _houseno; 
            txtStreet.Text = _street;
            cboBarangay.Text = _barangay;
            txtMunicipalityCity.Text = _municipality_city;
            txtPosition.Text = _position;
            txtBusBldgNo.Text = _bus_bldgno;
            txtBusStreet.Text = _bus_street;
            txtBusBarangay.Text = _bus_barangay;
            txtBusMunicipalityCity.Text = _bus_municipality_city;
            txtAccountNumber.Text = _account_number;
        }

        private void RegisterMember()
        {
            age = today.Year - txtBday.Value.Year;
            //CHECK AGE VALUE
            if (age < 17)
            {
                MessageBox.Show(this, "Member does not meet the age requirement.", "Age Requirement",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //SAVE MEMBER INFORMATION
                sex = cboSex.SelectedIndex;

                if (chkFee.Checked) { memfee = 1; }
                else { memfee = 0; }

                memtype = cboMemType.SelectedIndex;
                memstatus = 0; //0 = active; 1 = inactive
                
                dc.fnExecuteQuery("INSERT INTO `coop`.`member` (`firstname`, `middlename`, `lastname`, `sex`, " +
                    "`birthday`, `position`, `cpnum`, `tin`, `houseno`, `street`, `barangay`, `municipality_city`, `memfee`, `memtype`, `memstatus`, `busname`, " +
                    "`busplateno`, `bus_bldgno`, `bus_street`, `bus_barangay`, `bus_municipality_city`, `account_number`) " +
                    "VALUES ('" + txtFname.Text + "', '" + txtMname.Text + "', '" + txtLname.Text + "', " + sex + ",'" + txtBday.Value.ToString("yyyy-MM-dd") + "'," +
                    " '"+txtPosition.Text+"', '" + txtCpNum.Text + "', '" + mtxtTin.Text + "', '" + txtHouseNo.Text + "', '" + txtStreet.Text + "', '" + cboBarangay.Text + "', " +
                    "'" + txtMunicipalityCity.Text + "', " + memfee + ", " + memtype + ", " + memstatus + ", '" + txtBusName.Text + "', '" + txtBusPlateNo.Text + "', " +
                    "'" + txtBusBldgNo.Text + "', '" + txtBusStreet.Text + "', '" + txtBusBarangay.Text + "', '" + txtBusMunicipalityCity.Text + "', '"+txtAccountNumber.Text+"');", conn);
                
                DialogResult dialog = MessageBox.Show(this, "Member has been successfully added.\nAdd another member?",
                    "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                defaults.totalMember = defaults.totalMember + 1;
                account_number = "MTM-" + defaults.year + "-" + string.Format("{0:000000}", defaults.totalMember + 1) + "";
                txtAccountNumber.Text = account_number;

                if (dialog.Equals(DialogResult.Yes))
                {
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    mtxtTin.Clear();
                    txtCpNum.Clear();
                    txtHouseNo.Clear();
                    txtStreet.Clear();
                    cboBarangay.SelectedIndex = 0;
                    txtBusMunicipalityCity.Clear();
                    txtBusName.Clear();
                    txtBusPlateNo.Clear();
                    txtPosition.Clear();
                    txtBusBldgNo.Clear();
                    txtBusStreet.Clear();
                    txtBusBarangay.Clear();
                    txtBusMunicipalityCity.Clear();
                    chkFee.Checked = false;
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void UpdateMember()
        {
            age = today.Year - txtBday.Value.Year;
            if (age < 17)
            {
                MessageBox.Show(this, "Member does not meet the age requirement.", "Age Requirement",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //UDPATE MEMBER INFORMATION
                sex = cboSex.SelectedIndex;

                if (chkFee.Checked) { memfee = 1; }
                else { memfee = 0; }

                memtype = cboMemType.SelectedIndex;
                memstatus = 0; //0 = active; 1 = inactive

                //dc.fnExecuteQuery("UPDATE `coop`.`member` SET `firstname` = '" + txtFname.Text + "', `middlename` = '" + txtMname.Text + "', " +
                //    "`lastname` = '" + txtLname.Text + "', `sex` = " + sex + ", `birthday` = '" + txtBday.Value.ToString("yyyy-MM-dd") + "', " +
                //    "`age` = " + txtAge.Value + ", `memfee` = " + memfee + ", `memtype` = " + memtype + ", `memstatus` = " + memstatus + ", " +
                //    "`busname` = '" + txtBusName.Text + "', `busplateno` = '" + txtBusPlateNo.Text + "', `address` = '"+txtAddress.Text+"', " +
                //    "`tin` = '"+txtTIN.Text+"', `cpnum` = '"+txtCpNum.Text+"', `stalladdress` = '"+txtStallAddress.Text+"' " +
                //    "WHERE (`memberID` = " + memberID + ")", conn);

                dc.fnExecuteQuery("UPDATE `coop`.`member` SET" + 
                    "`firstname` = '" + txtFname.Text + "', `middlename` = '" + txtMname.Text + "', `lastname` =  '" + txtLname.Text + "', `sex` =  " + sex + ", " +
                    "`birthday` = '" + txtBday.Value.ToString("yyyy-MM-dd") + "', `position` = '" + txtPosition.Text + "', `cpnum` =  '" + txtCpNum.Text + "'," +
                    " `tin` = '" + mtxtTin.Text + "', `houseno` =  '" + txtHouseNo.Text + "', `street` =  '" + txtStreet.Text + "', `barangay` =  '" + cboBarangay.Text + "', " +
                    " `municipality_city` = '" + txtMunicipalityCity.Text + "', `memfee` =  " + memfee + ", `memtype` =  " + memtype + ", " +
                    " `busname` =  '" + txtBusName.Text + "', `busplateno` =  '" + txtBusPlateNo.Text + "', `bus_bldgno` = '" + txtBusBldgNo.Text + "'," +
                    " `bus_street` =  '" + txtBusStreet.Text + "', `bus_barangay` = '" + txtBusBarangay.Text + "', `bus_municipality_city` = '" + txtBusMunicipalityCity.Text + "' " +
                    " WHERE (`memberID` = " + memberID + ");", conn);


                MessageBox.Show(this, "Member information saved successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where memstatus = 0";

            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtMname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) || string.IsNullOrWhiteSpace(cboSex.Text) || cboBarangay.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Member personal information is required. \nPlease fill out the fields.",
                    "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFname.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cboMemType.Text))
            {
                MessageBox.Show(this, "Please select the membership type.",
                    "Member Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMemType.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBusPlateNo.Text) || string.IsNullOrWhiteSpace(txtBusName.Text))
            {
                MessageBox.Show(this, "Business information is required for regular members.",
                    "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrWhiteSpace(txtBusName.Text) && (string.IsNullOrWhiteSpace(txtBusBldgNo.Text) || 
                string.IsNullOrWhiteSpace(txtBusStreet.Text) || string.IsNullOrWhiteSpace(txtBusBarangay.Text) ||
                string.IsNullOrWhiteSpace(txtBusMunicipalityCity.Text)))
            {
                MessageBox.Show(this, "Stall Address is required. \nPlease fill out the fields.",
                   "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBusBldgNo.Focus();
            }
            else if(register)
            {
                RegisterMember();
                formMain.SearchResult(query);
                dc.fnExecuteQuery("update defaults set member_count = (select count(memberid) from member)+1 where id=1;", conn);
            }
            else if(!register)
            {
                UpdateMember();
                formMain.SearchResult(query);
            }
        }

        private void cboMemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMemType.SelectedIndex == 1)
            {
                txtPosition.Enabled = true;
                txtBusName.Enabled = true;
                txtBusPlateNo.Enabled = true;
                txtBusBldgNo.Enabled = true;
                txtBusStreet.Enabled = true;  
                txtBusBarangay.Enabled = true;
                txtBusMunicipalityCity.Enabled = true;

                txtPosition.Clear();
                txtBusBldgNo.Clear();
                txtBusBarangay.Clear();
                txtBusStreet.Clear();
                txtBusMunicipalityCity.Clear();
                txtBusName.Clear();
                txtBusPlateNo.Clear();
            }
            else
            {
                txtPosition.Enabled = false;
                txtPosition.Text = "N/A";

                txtBusName.Enabled = false;
                txtBusName.Text = "N/A";

                txtBusPlateNo.Enabled = false;
                txtBusPlateNo.Text = "N/A";

                txtBusBldgNo.Enabled = false;
                txtBusBldgNo.Text = "N/A";

                txtBusStreet.Enabled = false;
                txtBusStreet.Text = "N/A";

                txtBusBarangay.Enabled = false;
                txtBusBarangay.Text = "N/A";

                txtBusMunicipalityCity.Enabled = false;
                txtBusMunicipalityCity.Text = "N/A";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }  
    }
}
