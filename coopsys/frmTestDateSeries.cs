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
    public partial class frmTestDateSeries : Form
    {
        public frmTestDateSeries()
        {
            InitializeComponent();
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            DateTime paydates;
            dt.Columns.Add("Payment Dates");
            if(cboPaymentMethod.SelectedIndex == 0)
            {
                for (var a = 1; a <= int.Parse(txtDays.Text); a++)
                {
                    paydates = txtStartDate.Value.AddDays(a);
                    dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));
                }
            }
            else if(cboPaymentMethod.SelectedIndex == 1)
            {
                int totalweeks = int.Parse(txtDays.Text)%7;
                for (var a = 7; a <= int.Parse(txtDays.Text); a += 7)
                {
                    paydates = txtStartDate.Value.AddDays(a);
                    dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));

                    if (a == int.Parse(txtDays.Text) - totalweeks && totalweeks != 0)
                    {
                        paydates = txtStartDate.Value.AddDays(a+totalweeks);
                        dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));
                    }
                }
            }
            else if(cboPaymentMethod.SelectedIndex == 2)
            {
                int totalmonth = int.Parse(txtDays.Text) % 30;
                for (var a = 30; a <= int.Parse(txtDays.Text); a += 30)
                {
                    paydates = txtStartDate.Value.AddDays(a);
                    dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));

                    if (a == int.Parse(txtDays.Text) - totalmonth && totalmonth != 0)
                    {
                        paydates = txtStartDate.Value.AddDays(a + totalmonth);
                        dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));
                    }
                }
            }
            else if(cboPaymentMethod.SelectedIndex == 3)
            {
                int totalyear = int.Parse(txtDays.Text) % 365;
                for (var a = 365; a <= int.Parse(txtDays.Text); a += 365)
                {
                    paydates = txtStartDate.Value.AddDays(a);
                    dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));

                    if (a == int.Parse(txtDays.Text) - totalyear && totalyear != 0)
                    {
                        paydates = txtStartDate.Value.AddDays(a + totalyear);
                        dt.Rows.Add(paydates.ToString("MM/dd/yyyy"));
                    }
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void btnGetEnd_Click(object sender, EventArgs e)
        {
            DateTime datetime = txtStartDate.Value.AddDays(double.Parse(txtDays.Text));
            txtEndDate.Value = datetime;
        }
    }
}
