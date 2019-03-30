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
    public partial class frmLogContrast : Form
    {
        public frmLogContrast()
        {
            InitializeComponent();
        }

        private void btnLogContrast_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hsbLogContrast_ValueChanged(object sender, EventArgs e)
        {
            tbLogContrast.Text = hsbLogContrast.Value.ToString();
        }

        private void tbLogContrast_TextChanged(object sender, EventArgs e)
        {
            if ((tbLogContrast.Text == "") || (tbLogContrast.Text == "-"))
            {
                hsbLogContrast.Value = 0;
                hsbLogContrast.Text = "0";
            }
            else if ((Convert.ToInt16(tbLogContrast.Text) <= 105) && (Convert.ToInt16(tbLogContrast.Text) >= 0))
            {
                hsbLogContrast.Value = Convert.ToInt16(tbLogContrast.Text);
            }
            else
            {
                MessageBox.Show("Input nilai error");
                tbLogContrast.Text = "0";
            }
        }

        private void frmLogContrast_Load(object sender, EventArgs e)
        {
            tbLogContrast.Text = hsbLogContrast.Value.ToString();
        }
    }
}
