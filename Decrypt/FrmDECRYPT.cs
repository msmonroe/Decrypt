using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decrypt
{
    public partial class FrmDECRYPT : Form
    {
        private const string ENDEROT = @"0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_abcdefghijklmnopqrstuvwxyz";
        private const string ERROR = "Error";

        public FrmDECRYPT()
        {

            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile(@"Roboto\Roboto-Regular.ttf");
            
            lblDECRYPT.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            
            txtBxDECRYPT.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);

            lblDECRYPT.Text = "";
        }

        public string decrypto(string d)
        {
            try
            {
                string o = "";

                if (false == string.IsNullOrEmpty(d))
                {
                    string s = d.Trim();
                    int l = s.Length;

                    for (int i = 0; i < l; i++)
                    {
                        int x = ENDEROT.IndexOf(s.Substring(i, 1)) - i;

                        if (x < 0)
                        {
                            x = i;
                        }

                        o += ENDEROT.Substring(x, 1);
                    }
                }

                return o;
            }
            catch
            {
                return ERROR;
            }
        }

        private void btnDECRYPT_Click(object sender, EventArgs e)
        {
            lblDECRYPT.Text = decrypto(txtBxDECRYPT.Text);
        }
    }
}
