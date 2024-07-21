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
    public partial class frmEditCutoffDate : MetroFramework.Forms.MetroForm
    {
        frmSettings Form;
        string DateNo;
        public frmEditCutoffDate(frmSettings _form, string _dateNo, string _dateVal)
        {
            InitializeComponent();
            Form = _form;
            DateNo = _dateNo;

            lblDay.Text = "Cutoff Day "+DateNo+"";
            try
            {
                txtDay.Value = DateTime.Parse(_dateVal);
            }
            catch { }
            
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            if (DateNo == "1")
            {
                Form.date1 = txtDay.Value.ToString("MM/dd/yyyy");
            }
            else if (DateNo == "2")
            {
                Form.date2 = txtDay.Value.ToString("MM/dd/yyyy");
            }
            else if (DateNo == "3")
            {
                Form.date3 = txtDay.Value.ToString("MM/dd/yyyy");
            }
            else if (DateNo == "4") 
            { 
                Form.date4 = txtDay.Value.ToString("MM/dd/yyyy"); 
            }

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
