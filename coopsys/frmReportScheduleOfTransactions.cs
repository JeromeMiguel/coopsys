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

namespace coopsys
{
    public partial class frmReportScheduleOfTransactions : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        public frmReportScheduleOfTransactions(MySqlConnection _conn)
        {
            InitializeComponent();

            conn = _conn;
        }
    }
}
