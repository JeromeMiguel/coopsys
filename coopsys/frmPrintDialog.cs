using calypso.DataAccess;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coopsys
{
    
    public partial class frmPrintDialog : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn;
        DataCollection dc = new DataCollection();
        clsDefaults defaults = new clsDefaults();
        string fname, mname, lname, shareCount, shareAmt, certNum, desktopPath;
        int memberID;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            DataTable dtDistinct;

            dtDistinct = dc.fnDataTableCollection("select distinct if(certificate.total_share_amount = " + double.Parse(shareAmt) + " and certificate.total_share_count = " + int.Parse(shareCount) + ", 'true', 'false' ) as 'Existing', cert_num " +
                "from certificate where memberid = 1 and certificate.total_share_amount = " + double.Parse(shareAmt) + " and certificate.total_share_count = " + int.Parse(shareCount) + "",conn);

            //if (dc.fnReturnStringValue("select distinct if (certificate.total_share_amount = " + double.Parse(shareAmt) + " and certificate.total_share_count = " + int.Parse(shareCount) + ", 'true', 'false' ) as 'Existing' from certificate where memberid = " + memberID + " ", "Existing", conn) != "true")
            try
            {
                if (dtDistinct.Rows[0][0].ToString() != "true")
                {
                    createWordFile();
                }

                else
                {
                    certNum = dtDistinct.Rows[0][1].ToString();
                    DialogResult result = MessageBox.Show("Certificate " + certNum + " already issued. Click OK to view the document", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if ((result == DialogResult.Yes))
                    {
                        string openPath = desktopPath + "\\" + fname + " " + lname + " Certificate - " + certNum + ".docx";
                        Process.Start(openPath);
                    }
                }
            }
            catch {
                createWordFile();
            }

        }

        public frmPrintDialog(MySqlConnection _conn, string _fname, string _mname, string _lname, int _memberID)
        {
            InitializeComponent();

            conn = _conn;
            fname = _fname;
            mname = _mname;
            lname = _lname;
            memberID = _memberID;

            shareCount = dc.fnReturnStringValue("select count(csID) as \"Total Share Count\" FROM coop.capitalshare WHERE memberID=" + memberID + ";", "Total Share Count", conn);
            shareAmt = dc.fnReturnStringValue("select format(sum(csamount),2) as \"Total Share Amount\" FROM coop.capitalshare WHERE memberID=" + memberID + ";", "Total Share Amount", conn);
            lblName.Text = ""+lname+", "+fname+" "+mname+"";
            lblShareCount.Text = shareCount;
            lblShareAmt.Text = "₱ " + shareAmt;
        }

        public void createWordFile ()
        {
            //Duplicate Master Word Document (Certificate)
            string savePath = desktopPath + "\\" + fname + " " + lname + " Certificate - " + string.Format("{0:000000}", defaults.certificateTotal + 1) + ".docx";
            System.IO.File.Copy(@"C:\MTMC-Cert.docx", savePath, true);

            //Replace Keywords in Document
            using (WordprocessingDocument doc = WordprocessingDocument.Open(savePath, true))
            {
                var document = doc.MainDocumentPart.Document;
                foreach (var text in document.Descendants<Text>())
                {
                    if (text.Text.Contains("NAME"))
                    {
                        text.Text = text.Text.Replace("NAME", "" + fname + " " + mname + " " + lname + "");
                    }

                    if (text.Text.Contains("CERTNUM"))
                    {
                        certNum = string.Format("{0:000000}", defaults.certificateTotal + 1);
                        text.Text = text.Text.Replace("CERTNUM", certNum);
                    }

                    if (text.Text.Contains("SHARENUM"))
                    {
                        certNum = string.Format("{0:000000}", defaults.certificateTotal + 1);
                        text.Text = text.Text.Replace("SHARENUM", shareCount);
                    }

                    if (text.Text.Contains("VALUE"))
                    {
                        certNum = string.Format("{0:000000}", defaults.certificateTotal + 1);
                        text.Text = text.Text.Replace("VALUE", shareAmt);
                    }

                    if (text.Text.Contains("DATE"))
                    {
                        certNum = string.Format("{0:000000}", defaults.certificateTotal + 1);
                        text.Text = text.Text.Replace("DATE", DateTime.Today.ToString("MMMM dd, yyyy"));
                    }

                }
            }
            MessageBox.Show("Certificate generated at: " + savePath + "", "Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(savePath);

            //Update certificate number (db and defaults)
            dc.fnExecuteQuery("INSERT INTO `coop`.`certificate` (`cert_num`, `issued_date`, `total_share_amount`, `total_share_count`, " +
                "`memberid`) VALUES ('" + certNum + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "', " + double.Parse(shareAmt) + ", " +
                "" + int.Parse(shareCount) + ", " + memberID + ");", conn);

            dc.fnExecuteQuery("UPDATE `coop`.`defaults` SET `cert_count` = " + int.Parse(certNum) + " WHERE (`id` = " + memberID + ");", conn);

            defaults.certificateTotal = int.Parse(certNum);
        }

    }
}
