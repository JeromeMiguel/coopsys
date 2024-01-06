using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calypso;
using calypso.DataAccess;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace coopsys
{
    public partial class frmCheckNo : MetroFramework.Forms.MetroForm
    {
        frmLoan loan;
        MySqlConnection conn;
        DataTable dt = new DataTable();
        DataTable totalShare = new DataTable();
        DataCollection dc = new DataCollection();
        string query;
        
        public frmCheckNo(frmLoan _loan, string _query, MySqlConnection _conn)
        {
            InitializeComponent();
            loan = _loan;
            query = _query;
            conn = _conn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dc.fnExecuteQuery(query+txtCheckNo.Text);
        }
    }
}
