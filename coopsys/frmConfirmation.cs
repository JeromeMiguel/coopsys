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
    public partial class frmConfirmation : MetroFramework.Forms.MetroForm
    {
        frmCutoffActions form;
        public frmConfirmation(frmCutoffActions _form)
        {
            InitializeComponent();
            form = _form;
            lblWarning.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text.ToLower().Trim();
           
            form.passedConfirmation = text == "confirm";
            lblWarning.Visible = text != "confirm";

            if (text == "confirm") { Close(); }
        }
    }
}
