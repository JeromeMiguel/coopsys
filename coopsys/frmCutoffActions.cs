using calypso.DataAccess;
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
    public partial class frmCutoffActions : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        public bool passedConfirmation = false;
        DataCollection dc = new DataCollection();

        public frmCutoffActions(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;

            // TODO: Replace userID later after login integration
            string latestCutoffDate = dc.fnReturnStringValue("SELECT cut_date_last FROM coop.defaults WHERE userID=1;", "cut_date_last", conn);
            string date = latestCutoffDate == "" ? "" : DateTime.Parse(latestCutoffDate).ToString("yyyy-MM-dd");
            if (date == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                finishedConfirmation();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Clicking Ok will add interest to all members with savings account. THIS ACTION CANNOT BE REVERSED", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                frmConfirmation form = new frmConfirmation(this);
                form.ShowDialog();

                if (passedConfirmation)
                {
                    //Add logic here

                    // Update latest cutoff date
                    // TODO: Replace userID later after login integration
                    dc.fnExecuteQuery("UPDATE `coop`.`defaults` SET `cut_date_last` = NOW() WHERE (`id` = '1');", conn);
                    MessageBox.Show("Cutoff Date Confirmed. Interest Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    finishedConfirmation();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Close();
            frmSettings form = new frmSettings(conn);
            form.ShowDialog();
           
        }

        private void finishedConfirmation()
        {
            lblConfirmationStatus.Text = "• Finished";
            lblConfirmationStatus.ForeColor = Color.LimeGreen;
            btnConfirm.Enabled = false;
            btnConfirm.BackColor = Color.LightGray;
        }
    }
}
