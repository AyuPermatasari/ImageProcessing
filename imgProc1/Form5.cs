using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgProc1
{
    public partial class frmGamma : Form
    {
        public frmGamma()
        {
            InitializeComponent();
        }

        private void hscGamma_ValueChanged(object sender, EventArgs e)
        {
            tbGamma.Text = Convert.ToString(hscGamma.Value * 0.01);
        }

        private void tbGamma_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGammaOk_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmGamma_Load(object sender, EventArgs e)
        {
            if ((tbGamma.Text == "") || (tbGamma.Text == "-"))
            {
                hscGamma.Value = 0;
                hscGamma.Text = "0";
            }
            else if ((Convert.ToInt16(tbGamma.Text) <= 8) && (Convert.ToInt16(tbGamma.Text) >= 0))
            {
                hscGamma.Value = Convert.ToInt16(tbGamma.Text);
            }
            else
            {
                MessageBox.Show("Input nilai error");
                tbGamma.Text = "0";
            }
            
        }
    }
}
