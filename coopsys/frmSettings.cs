using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using calypso;
using calypso.DataAccess;

namespace coopsys
{
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
        DataCollection dc = new DataCollection();
        MySqlConnection conn;

        public frmSettings(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackupSql sql = new frmBackupSql(conn);
            sql.ShowDialog();
        }
    }
}
