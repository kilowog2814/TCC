using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarregar.Value < 100)
            {
                timer1.Enabled = true;
                pbCarregar.Value = pbCarregar.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                FrmPrincipal form = new FrmPrincipal();
                form.Show();
                this.Visible = false;

            }
        }
    }
}
