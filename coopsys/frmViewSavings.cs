﻿using MySql.Data.MySqlClient;
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

    public partial class frmViewSavings : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection conn;
        private int memberID;

        public frmViewSavings(MySqlConnection _conn, int _memberID)
        {
            InitializeComponent();

            conn = _conn;
            memberID = _memberID;
        }
    }
}