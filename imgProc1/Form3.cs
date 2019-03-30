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
    public partial class frmLogBrightness : Form
    {
        public frmLogBrightness()
        {
            InitializeComponent();
        }

        private void frmLogBrightness_Load(object sender, EventArgs e)
        {
            tbLogBrightness.Text = hsbLogBrightness.Value.ToString();
        }

        private void hsbLogBrightness_ValueChanged(object sender, EventArgs e)
        {
            tbLogBrightness.Text = hsbLogBrightness.Value.ToString();
        }

        private void tbLogBrightness_TextChanged(object sender, EventArgs e)
        {
            if ((tbLogBrightness.Text == "") || (tbLogBrightness.Text == "-"))
            {
                hsbLogBrightness.Value = 0;
                hsbLogBrightness.Text = "0";
            }
            else if ((Convert.ToInt16(tbLogBrightness.Text) <= 105) && (Convert.ToInt16(tbLogBrightness.Text) >= 0))
            {
                hsbLogBrightness.Value = Convert.ToInt16(tbLogBrightness.Text);
            }
            else
            {
                MessageBox.Show("Input nilai error");
                tbLogBrightness.Text = "0";
            }
        }

        private void btnLogBrightness_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
