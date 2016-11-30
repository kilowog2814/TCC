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
    public partial class FrmPrincipal : Form
    {
        FormLogin_BLL login;
        FormPrincipal_BLL principal;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            login = new FormLogin_BLL();
            visivel(false);

            try
            {
                String nivel = login.getNivelFuncionario();
                if (nivel.Equals("1"))
                {
                    btnGerencia.Visible = false;   
                }
                lblFuncionario.Text = login.getNomeFuncionario();
                stsData.Text = DateTime.Now.ToLongDateString();
                atualizarGrid();
                formataGrid();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void btnCheckIn_Click_1(object sender, EventArgs e)
        {
            FrmCheck_in formcheckin = new FrmCheck_in();
            formcheckin.ShowDialog();
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            FrmCheck_out formcheckout = new FrmCheck_out();
            formcheckout.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FrmReserva2 formreserva = new FrmReserva2();
            formreserva.ShowDialog();
        }

        private void btnAlterarPreco_Click(object sender, EventArgs e)
        {
            FrmAlteraPreco alt = new FrmAlteraPreco();
            alt.ShowDialog();



        }
        private void Hora_Tick(object sender, EventArgs e)
        {
            stsHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void formataGrid()
        {
            try
            {
                //Check in
                dgvCheckIn.AutoGenerateColumns = false;
                dgvCheckIn.RowsDefaultCellStyle.BackColor = Color.White;//alternar cores
                dgvCheckIn.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;//alternar cores
                dgvCheckIn.Columns[0].HeaderText = "Reserva";
                dgvCheckIn.Columns[1].HeaderText = "Quarto";
                dgvCheckIn.Columns[2].HeaderText = "Nome";
                dgvCheckIn.Columns[0].Width = 70;
                dgvCheckIn.Columns[1].Width = 70;
                dgvCheckIn.Columns[2].Width = 260;
                dgvCheckIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgvCheckIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCheckIn.MultiSelect = false;
                dgvCheckIn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvCheckIn.ReadOnly = true;
                dgvCheckIn.RowHeadersVisible = true;
                dgvCheckIn.RowHeadersVisible = false;



                //Check out
                dgvCheckOut.AutoGenerateColumns = false;
                dgvCheckOut.RowsDefaultCellStyle.BackColor = Color.White;//alternar cores
                dgvCheckOut.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;//alternar cores
                dgvCheckOut.Columns[0].HeaderText = "Reserva";
                dgvCheckOut.Columns[1].HeaderText = "Quarto";
                dgvCheckOut.Columns[2].HeaderText = "Nome";
                dgvCheckOut.Columns[0].Width = 70;
                dgvCheckOut.Columns[1].Width = 70;
                dgvCheckOut.Columns[2].Width = 260;
                dgvCheckOut.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgvCheckOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCheckOut.MultiSelect = false;
                dgvCheckOut.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvCheckOut.ReadOnly = true;
                dgvCheckOut.RowHeadersVisible = true;
                dgvCheckOut.RowHeadersVisible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void atualiza_Tick(object sender, EventArgs e)//atualiza grids a cada 10 minutos
        {
            atualizarGrid();
        }

        protected void atualizarGrid()
        {
            principal = new FormPrincipal_BLL();
            try
            {
                dgvCheckIn.DataSource = principal.getCheckIn();

                dgvCheckOut.DataSource = principal.getCheckOut();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            FrmGrafico gra = new FrmGrafico();
            gra.ShowDialog();
            
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            
            FrmRelatorio rel = new FrmRelatorio();
            rel.ShowDialog();
           
        }


        private void btnGerencia_Click(object sender, EventArgs e)
        {

            if (btnAlterarPrecos.Visible == false)
            {
                visivel(true);
            }
            else 
            {
                visivel(false);
            }
        }

        private void visivel(bool vc) 
        {
            btnGraficos.Visible = vc;
            btnRelatorio.Visible = vc;
            btnAlterarPrecos.Visible = vc;
        
        }


    }
}

