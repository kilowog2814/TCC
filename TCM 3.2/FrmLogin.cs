using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TCM
{
    public partial class FrmLogin : Form
    {
        FormLogin_BLL bll;
        FrmPrincipal principal;

        public FrmLogin()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            bll = new FormLogin_BLL();

            try
            {
                if (bll.loginBLL(txtUsuario.Text, txtSenha.Text))
                {
                    FrmSplashScreen splash = new FrmSplashScreen();
                    splash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou senha incorreto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
