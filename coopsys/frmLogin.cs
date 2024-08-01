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
using calypso.Security;
using MySql.Data.MySqlClient;
using System.IO;

namespace coopsys
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        DataCollection dc = new DataCollection();
        MySqlConnection conn;
        string userID;

        public frmLogin()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines(@"C:\setup.txt");
            db._serverAddress = lines[0];
            db._databaseName = lines[1];
            db._serverPort = lines[2];
            db._serverUID = lines[3];
            db._serverPWD = lines[4];
            conn = db.InitializeConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            conn.Close();
            fnLogin();
            //frmMain main = new frmMain(conn, );
            //main.Show();
            //this.Hide();
            //try
            //{
            //    conn.Open();
            //    conn.Close();
            //    frmMain main = new frmMain(conn);
            //    main.Show();
            //    this.Hide();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(this, "Unable to connect to the database.\nPlease contact your administrator.", "Cannot Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fnLogin()
        {
            string query = "select * from useraccounts where username = '" + txtUname.Text + "' and password = '" + txtPassword.Text + "'";
            if(dc.fnCheckRecord(query, conn))
            {
                userID = dc.fnReturnStringValue(query, "id", conn);
                frmMain main = new frmMain(conn, userID);
                main.Show();
                this.Hide();
            }
            else
            {
                DialogResult dr = MessageBox.Show(this, "Username or password is incorrect.\nTry again?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(DialogResult.Yes == dr)
                {
                    txtUname.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
