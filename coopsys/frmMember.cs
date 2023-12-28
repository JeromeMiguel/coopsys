using System;
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
using MySql.Data.MySqlClient;

namespace coopsys
{
    public partial class frmMember : MetroFramework.Forms.MetroForm
    {
        frmMain formMain;
        Database db = new Database();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        private bool register;
        private int age, sex, memfee, memtype, memstatus, memberID, cboMemTypeMain;
        private string bday, busname, busplateno;

        public frmMember(frmMain _formMain, MySqlConnection _conn, bool _register, int _cboMemTypeMain)
        {
            InitializeComponent();
            cboMemTypeMain = _cboMemTypeMain;
            cboMemType.SelectedIndex = _cboMemTypeMain;
            formMain = _formMain;
            conn = _conn;
            register = _register;
        }

        public frmMember(frmMain _formMain, MySqlConnection _conn, bool _register, int _memberID, string _fname, string _mname, string _lname,
            string _bday, int _age, int _sex, int _memfee, int _memtype, string _busname, string _busplateno,
            string _address, string _tin, string _cpnum, string _stalladdress, int _cboMemTypeMain)
        {
            InitializeComponent();
            cboMemTypeMain = _cboMemTypeMain;
            formMain = _formMain;
            conn = _conn;
            register = _register;
            
            memberID = _memberID;
            txtFname.Text = _fname;
            txtMname.Text = _mname;
            txtLname.Text = _lname;
            txtBday.Value = DateTime.Parse(_bday);
            txtAge.Value = _age;
            cboSex.SelectedIndex = _sex;
            cboMemType.SelectedIndex = _memtype;
            memfee = _memfee;
            if (memfee == 1) { chkFee.Checked = true; }
            else { chkFee.Checked = false; };
            txtBusName.Text = _busname;
            txtBusPlateNo.Text = _busplateno;
            txtAddress.Text = _address;
            txtTIN.Text = _tin;
            txtCpNum.Text = _cpnum;
            txtStallAddress.Text = _stalladdress;
        }

        private void RegisterMember()
        {
            //CHECK AGE VALUE
            if (Int32.Parse(txtAge.Value.ToString()) < 17)
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
                memstatus = 1; //1 = active; 0 = inactive

                dc.fnExecuteQuery("INSERT INTO `coop`.`member` (`firstname`, `middlename`, `lastname`, `sex`, " +
                    "`birthday`, `age`, `memfee`, `memtype`, `memstatus`, `busname`, `busplateno`, `address`, `tin`, `cpnum`, `stalladdress`) " +
                    "VALUES ('" + txtFname.Text + "', '" + txtMname.Text + "', '" + txtLname.Text + "', " + sex + ", " +
                    "'" + txtBday.Value.ToString("MM.dd.yyyy") + "', " + txtAge.Value + ", " + memfee + ", " + memtype + ", " + memstatus + "," +
                    "'" + txtBusName.Text + "', '" + txtBusPlateNo.Text + "', '"+txtAddress.Text+"', '"+txtTIN.Text+"', '"+txtCpNum.Text+"', '"+txtStallAddress.Text+"')", conn);

                DialogResult dialog = MessageBox.Show(this, "Member has been successfully added.\nAdd another member?",
                    "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog.Equals(DialogResult.Yes))
                {
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    txtBusName.Clear();
                    txtBusPlateNo.Clear();
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
            if (Int32.Parse(txtAge.Value.ToString()) < 17)
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
                memstatus = 1; //1 = active; 0 = inactive

                dc.fnExecuteQuery("UPDATE `coop`.`member` SET `firstname` = '" + txtFname.Text + "', `middlename` = '" + txtMname.Text + "', " +
                    "`lastname` = '" + txtLname.Text + "', `sex` = " + sex + ", `birthday` = '" + txtBday.Value.ToString("MM.dd.yyyy") + "', " +
                    "`age` = " + txtAge.Value + ", `memfee` = " + memfee + ", `memtype` = " + memtype + ", `memstatus` = " + memstatus + ", " +
                    "`busname` = '" + txtBusName.Text + "', `busplateno` = '" + txtBusPlateNo.Text + "', `address` = '"+txtAddress.Text+"', " +
                    "`tin` = '"+txtTIN.Text+"', `cpnum` = '"+txtCpNum.Text+"', `stalladdress` = '"+txtStallAddress.Text+"' " +
                    "WHERE (`memberID` = " + memberID + ")", conn);

                MessageBox.Show(this, "Member information saved successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
        }

        private void txtBday_ValueChanged(object sender, EventArgs e)
        {
            if (register)
            {
                int dateNow = DateTime.Now.Year;
                int dateBirth = txtBday.Value.Year;
                txtAge.Value = dateNow - dateBirth;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtMname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) || string.IsNullOrWhiteSpace(cboSex.Text))
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
            else if(register)
            {
                RegisterMember();
                if (cboMemTypeMain == 0)
                {
                    formMain.SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, \"Associate\", \"Regular\") as 'MEMBER TYPE', " +
                        "birthday, age, sex, memfee, memtype, memstatus, busname, busplateno, address, tin, cpnum, stalladdress from coop.member");
                }
                else if (cboMemTypeMain == 1)
                {
                    formMain.SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, \"Associate\", \"Regular\") as 'MEMBER TYPE', " +
                        "birthday, age, sex, memfee, memtype, memstatus, busname, busplateno, address, tin, cpnum, stalladdress from coop.member " +
                        "where memtype = 1;");
                }
                else if (cboMemTypeMain == 2)
                {
                    formMain.SearchResult("select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                        "if(memtype=0, \"Associate\", \"Regular\") as 'MEMBER TYPE', " +
                        "birthday, age, sex, memfee, memtype, memstatus, busname, busplateno, address, tin, cpnum, stalladdress from coop.member " +
                        "where memtype = 0;");
                }
            }
            else if(!register)
            {
                UpdateMember();
            }
        }

        private void cboMemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMemType.SelectedIndex == 1)
            {
                txtBusName.Enabled = true;
                txtBusPlateNo.Enabled = true;
                txtStallAddress.Enabled = true;
                txtStallAddress.Clear();
                txtBusName.Clear();
                txtBusPlateNo.Clear();
            }
            else
            {
                txtBusName.Enabled = false;
                txtBusName.Text = "N/A";

                txtBusPlateNo.Enabled = false;
                txtBusPlateNo.Text = "N/A";

                txtStallAddress.Enabled = false;
                txtStallAddress.Text = "N/A";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }  
    }
}
