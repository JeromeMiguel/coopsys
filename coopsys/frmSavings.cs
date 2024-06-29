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
using calypso;
using calypso.DataAccess;
using MetroFramework.Controls;

namespace coopsys
{
    public partial class frmSavings : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataCollection dc = new DataCollection();
        private string fname, mname, lname, accountNum;
        private int memberID;

        public frmSavings(MySqlConnection _conn, int _memberID, string _fname, string _mname, string _lname)
        {
            InitializeComponent();
            conn = _conn;
            fname = _fname;
            mname= _mname;
            lname= _lname;
            memberID = _memberID;
            accountNum = dc.fnReturnStringValue("SELECT LAST_INSERT_ID() as 'ID';", "ID", conn);


            txtAccount.Text = accountNum;
            txtName.Text = ""+fname+" "+mname+" "+lname+"";
            txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dc.fnExecuteQuery("INSERT INTO `coop`.`savings` (`created_at`, `memberID`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + memberID + ");", conn);

            MessageBox.Show(this, "Savings Account for \"+fname+\" \"+mname+\" \"+lname+\" has been created successfully",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();

            
        }
    }
}
