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
    public partial class FrmReserva2 : Form
    {
        
        private Valida var;
        private FormReserva_BLL bll;

        public FrmReserva2()
        {
            InitializeComponent();

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            bll = new FormReserva_BLL();

            String nome = txtNome.Text;
            String email = txtEmail.Text;
            String cpf = mkCPF.Text.Replace(",", "").Replace("-", "").Trim();
            String rg = mkRg.Text.Replace(",", "").Replace("-", "").Trim();
            String quarto = txtCod_Quarto.Text;
            String cidade = txtCidade.Text;
            String cep = mkCep.Text.Replace("-", "").Trim();
            String ender = txtEndereco.Text;
            String fone = mkFone.Text.Replace("-", "").Replace("(", "").Trim().Replace(")", "").Replace("-", "");
            String nasci = dataNascimento.Text;
            String quanti = txtQuant.Text;
            String cartao = mkCartao.Text.Trim();
            String entrada = dtpCheck_in.Text;
            String saida = dTPCheck_out.Text;
            String estado = txtCidade.Text;

            String dadosCliente  = nome+","+cpf+","+rg+","+nasci+","+ender+","+cep+","+cidade+","+cidade+","+email+","+fone;
            String dadosReserva = quarto+","+quanti+","+entrada+","+saida+",";


            if (!bll.cadastrarCliente(dadosCliente)) 
            {
                MessageBox.Show("Erro ao cadastrar cliente");
            }

            if (!bll.cadastrarReserva(dadosReserva))
            {
                MessageBox.Show("Erro ao fazer a reserva");
            }

            String servico = null;


            if (cbCafe.Checked)
            {
                servico = servico + "cafe,";
            }
            if (cbAlmoco.Checked)
            {
                servico = servico + "almoco,";
            }
            if (cbJantar.Checked)
            {
                servico = servico + "jantar,";
            }
            if (cbSauna.Checked)
            {
                servico = servico + "sauna,";
            }
            if (cbPiscina.Checked)
            {
                servico = servico + "piscina,";
            }
            if (cbJogos.Checked)
            {
                servico = servico + "jogos,";
            }

            if ((bll.reservarServico(servico) != 1) && (bll.reservarServico(servico) != 3))
            {
                MessageBox.Show("Não foi possivel realizar a reserva dos serviços!");
            }
            else
            {
                MessageBox.Show("Reserva concluida com sucesso!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpCheck_in_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                String data1 = dtpCheck_in.ToString();
                var = new Valida();
                if (!var.validarData(data1))
                {
                    MessageBox.Show("Essa data não pode ser usada!");
                    this.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }
        private void mkCPF_Leave(object sender, EventArgs e)
        {

            var = new Valida();
            if (!var.IsCpf(mkCPF.Text))
            {
                MessageBox.Show("CPF Incorreto!");
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            var = new Valida();
            if (!var.validarEmail(txtEmail.Text) == true)
            {
                MessageBox.Show("Essa email é invalido!");
            }
            
        }
        private void mkRg_Leave(object sender, EventArgs e)
        {

            var = new Valida();
            if (var.validateRg(mkRg.Text) == true)
            {
                MessageBox.Show("Este Rg está incorreto, digite novamente!");
            }
            
        }

        private void mkCartao_Leave(object sender, EventArgs e)
        {

            var = new Valida();

            if (var.IsCartao(mkCartao.Text))
            {
                MessageBox.Show("Cartão valido");
            }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bll = new FormReserva_BLL();
            String servico = null;

            if (cbCafe.Checked) 
            {
                servico = servico + "cafe,";
            }
            if (cbAlmoco.Checked) 
            {
                servico = servico + "almoco,";
            }
            if (cbJantar.Checked) 
            {
                servico = servico + "jantar,";
            }
            if (cbSauna.Checked) 
            {
                servico = servico + "sauna,";
            }
            if (cbPiscina.Checked) 
            {
                servico = servico + "piscina,";
            }
            if (cbJogos.Checked) 
            {
                servico = servico + "jogos,";
            }
            
            if ((bll.reservarServico(servico) != 1) && (bll.reservarServico(servico) != 3))
            {
                MessageBox.Show("Não foi possivel realizar a reserva dos serviços!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Ana Oliveira";
            txtEmail.Text = "ana.oliveira@gmail.com";
            mkCPF.Text = "39749151844";
            mkRg.Text = "389002343";
            txtCod_Quarto.Text = "011101";
            txtCidade.Text = "São Paulo";
            mkFone.Text = "1129912394";
            dataNascimento.Text = "12/11/1998";
            txtQuant.Text = "4";
            mkCartao.Text = "4639515277365365";
            txtEndereco.Text = "Rua Albuquerque José";
            mkCep.Text = "12345670";

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            check(false);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            bll = new FormReserva_BLL();

            int quarto = bll.pesquisarQuarto(txtCod_Quarto.Text);

                if (quarto == 1)
                {
                    cbNormal.Checked = true;
                }
                else if (quarto == 2)
                {
                    cbSuite.Checked = true;
                }

                else if (quarto == 3)
                {
                    cbLuxo.Checked = true;
                }
                else 
                {
                    MessageBox.Show("Quarto não existe!");
                }
                
        }
        private void check(bool var) 
        {
            cbAlmoco.Checked = var;
            cbCafe.Checked = var;
            cbJogos.Checked = var;
            cbPiscina.Checked = var;
            cbJantar.Checked = var;
            cbSauna.Checked = var;
        }

        private void FrmReserva2_Load(object sender, EventArgs e)
        {

        }

        

        

    }
}

