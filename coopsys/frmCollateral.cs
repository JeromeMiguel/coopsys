using calypso.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace coopsys
{
    public partial class frmCollateral : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataCollection dc = new DataCollection();
        DataTable dt = new DataTable();
        frmLoan frmLoan;
        bool IfView;
        int loanid;

        public frmCollateral(frmLoan _frmLoan)
        {
            InitializeComponent();
            frmLoan = _frmLoan;
            txtPropDesc.Text = frmLoan.propDesc;
            txtPropSurvey.Text = frmLoan.propSurvey;
            txtPropArea.Text = frmLoan.propArea;
            txtPropLoc.Text = frmLoan.propLoc;

            txtVehPlate.Text = frmLoan.vehPlate;
            txtVehEngine.Text = frmLoan.vehEngine;
            txtVehChassis.Text = frmLoan.vehChassis;
            txtVehMake.Text = frmLoan.vehMake;

            txtChqNum.Text = frmLoan.chqNum;

            if (frmLoan.chqAmt > 0)
            {
                txtChqAmt.Text = frmLoan.chqAmt.ToString();
            }
            txtBank.Text = frmLoan.bank;
        }

        public frmCollateral(frmLoan _frmLoan, bool _IfView, MySqlConnection _conn, int _loanid)
        {
            InitializeComponent();
            frmLoan = _frmLoan;
            conn = _conn;
            loanid = _loanid;
            IfView = _IfView;

            dt = dc.fnDataTableCollection("SELECT * FROM coop.collateral where loanid='" + _loanid + "';", conn);
            grdView.DataSource = dt;

            txtPropDesc.Text = grdView.Rows[0].Cells[1].Value?.ToString();
            txtPropSurvey.Text = grdView.Rows[0].Cells[2].Value?.ToString();
            txtPropArea.Text = grdView.Rows[0].Cells[3].Value?.ToString();
            txtPropLoc.Text = grdView.Rows[0].Cells[4].Value?.ToString();
            txtVehPlate.Text = grdView.Rows[0].Cells[5].Value?.ToString();
            txtVehEngine.Text = grdView.Rows[0].Cells[6].Value?.ToString();
            txtVehChassis.Text = grdView.Rows[0].Cells[7].Value?.ToString();
            txtVehMake.Text = grdView.Rows[0].Cells[8].Value?.ToString();
            txtChqNum.Text = grdView.Rows[0].Cells[9].Value?.ToString();
            txtChqAmt.Text = grdView.Rows[0].Cells[10].Value?.ToString();
            txtBank.Text = grdView.Rows[0].Cells[11].Value?.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IfView)
            {
                dc.fnExecuteQuery("UPDATE `coop`.`collateral` SET " +
                    "`propDesc` = '"+ txtPropDesc.Text + "', " +
                    "`propSurvey` = '"+ txtPropSurvey.Text + "', " +
                    "`propArea` = '"+ txtPropArea.Text + "', " +
                    "`propLoc` = '"+ txtPropLoc.Text + "', " +
                    "`vehPlate` = '"+ txtVehPlate.Text + "', " +
                    "`vehEngine` = '"+ txtVehEngine.Text + "', " +
                    "`vehChassis` = '"+txtVehChassis.Text+"', " +
                    "`vehMake` = '"+ txtVehMake.Text + "', " +
                    "`chqNum` = '"+ txtChqNum.Text + "', " +
                    "`chqAmt` = '"+ txtChqAmt.Text + "', " +
                    "`bank` = '"+txtBank.Text+"' " +
                    "WHERE `loanid` = " + loanid + ";", conn);
                MessageBox.Show(this, "Collateral information saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                frmLoan.propDesc = txtPropDesc.Text;
                frmLoan.propSurvey = txtPropSurvey.Text;
                frmLoan.propArea = txtPropArea.Text;
                frmLoan.propLoc = txtPropLoc.Text;

                frmLoan.vehPlate = txtVehPlate.Text;
                frmLoan.vehEngine = txtVehEngine.Text;
                frmLoan.vehChassis = txtVehChassis.Text;
                frmLoan.vehMake = txtVehMake.Text;

                frmLoan.chqNum = txtChqNum.Text;
                if (!string.IsNullOrWhiteSpace(txtChqAmt.Text))
                {
                    frmLoan.chqAmt = double.Parse(txtChqAmt.Text);
                }
                frmLoan.bank = txtBank.Text;

                if (!string.IsNullOrWhiteSpace(txtPropDesc.Text) || !string.IsNullOrWhiteSpace(txtPropSurvey.Text)
                    || !string.IsNullOrWhiteSpace(txtPropArea.Text) || !string.IsNullOrWhiteSpace(txtPropLoc.Text)
                    || !string.IsNullOrWhiteSpace(txtVehPlate.Text) || !string.IsNullOrWhiteSpace(txtVehEngine.Text)
                    || !string.IsNullOrWhiteSpace(txtVehChassis.Text) || !string.IsNullOrWhiteSpace(txtVehMake.Text)
                    || !string.IsNullOrWhiteSpace(txtChqNum.Text) || !string.IsNullOrWhiteSpace(txtChqAmt.Text)
                    || !string.IsNullOrWhiteSpace(txtBank.Text))
                {
                    frmLoan.IfCollateral = true;
                    MessageBox.Show(this, "Collateral information saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmLoan.IfCollateral = false;
                }
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
