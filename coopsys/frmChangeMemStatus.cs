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
using System.Threading;

namespace coopsys
{
    public partial class frmChangeMemStatus : MetroFramework.Forms.MetroForm
    {
        frmMain main;
        Database db = new Database();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        private int _newMemberStatus, memberid;

        //active = 0, inactive = 1, withdraw = 2
        public frmChangeMemStatus(MySqlConnection _conn, frmMain _frmMain, int _memberid, int _memStatus)
        {
            InitializeComponent();
             conn = db.InitializeConnection();
            memberid = _memberid;
            main = _frmMain;
            if (_memStatus == 0)
            {
                rbtnActive.Checked = true;
                rbtnInactive.Checked = false;
                rbtnWithdraw.Checked = false;
            }
            else if( _memStatus == 1)
            {
                rbtnActive.Checked = false;
                rbtnInactive.Checked = true;
                rbtnWithdraw.Checked = false;
            }
            else if(_memStatus == 2)
            {
                rbtnActive.Checked = false;
                rbtnInactive.Checked = false;
                rbtnWithdraw.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string queryUpdateMemberStatus = "UPDATE `coop`.`member` SET memstatus = " + _newMemberStatus + " " +
                "where memberid = " + memberid + "";
            dc.fnExecuteQuery(queryUpdateMemberStatus, conn);

            string queryUpdateShareCapitalofWithdawnMember = "update `coop`.`capitalshare` SET csamount = 0 " +
                "where memberid = " + memberid + "";
            
            if (rbtnWithdraw.Checked)
            {
                if(dc.fnCount("select ifnull((select csamount from capitalshare where memberid="+memberid+"),0) ", conn) > 0)
                {
                    dc.fnExecuteQuery(queryUpdateShareCapitalofWithdawnMember, conn);
                }
            }

            string queryUpdateMain = "select memberID, firstname as 'FIRST NAME', middlename as 'MIDDLE NAME', lastname as 'LAST NAME', " +
                       " sex, birthday, position, cpnum, tin, houseno, street, barangay, municipality_city, " +
                       "memfee,if(memtype=0, 'Associate', 'Regular') as 'MEMBER TYPE',  memstatus, busname, busplateno, bus_bldgno, bus_street, " +
                       "bus_barangay, bus_municipality_city, memtype, account_number from coop.member where memstatus = 0";
            main.SearchResult(queryUpdateMain);
            main.cboMemStat.SelectedIndex = 0;
            DialogResult dr = MessageBox.Show(this, "Member status changed.", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void rbtnActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnActive.Checked)
            {
                _newMemberStatus = 0;
            }
        }

        private void rbtnInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInactive.Checked)
            {
                _newMemberStatus = 1;
            }
        }

        private void rbtnWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnWithdraw.Checked)
            {
                _newMemberStatus = 2;
            }
        }
    }
}
