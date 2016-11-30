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
    public partial class FrmAlteraPreco : Form
    {
        FormAlterarPreco_BLL bll;

        public FrmAlteraPreco()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bll = new FormAlterarPreco_BLL();

            String novo = mkPrecoNovo.Text.Replace(",", "").Trim().Replace(".", "").Replace("R$", "");
            String descricao = txtDescricao.Text;
            String codigo = txtPesquisa.Text.Trim().Replace(",", "").Replace(".", "");

            try
            {

                if (codigo.Equals(""))
                {
                    MessageBox.Show("Digite um codigo de quarto/serviço!");
                }
                else
                {
                    try
                    {
                        if (rbQuarto.Checked)
                        {
                            if (!bll.atualizarDadosQuarto(novo, descricao, codigo))
                            {
                                MessageBox.Show("Erro ao atualizar quarto!");
                            }
                        }

                        if (rbServico.Checked)
                        {
                            if (!bll.atualizarServico(novo, descricao, codigo))
                            {
                                MessageBox.Show("Erro ao atualizar serviço!");
                            }
                        }

                        MessageBox.Show("Dados atualizaos com sucesso!");
                        txtPesquisa.Text = "";
                        txtDescricao.Text = "";
                        mkDataAlteracao.Text = "";
                    }
                    catch (Exception erro) 
                    {
                        MessageBox.Show("Erro: " + erro);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        

        private void FrmAlteraPreco_Load(object sender, EventArgs e)
        {
            lblTipoDeAtualizacao.Text = "Codigo do Quarto:";
            lblPreco.Text = "Preço Atual";
            //mkDataAlteracao.Text = DateTime.Now.ToShortDateString();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoDeAtualizacao.Text = "Codigo do Serviço:";
            lblPreco.Text = "Diaria Atual";
            ver(false);
        }

        private void ver(bool var)
        {
            
            
            lblDiaNova.Visible = var;
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoDeAtualizacao.Text = "Codigo do Quarto:";
            lblPreco.Text = "Preço Atual";

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            bll = new FormAlterarPreco_BLL();
            String codigo = txtPesquisa.Text.Trim().Replace(",", "").Replace(".", "");

            if (rbQuarto.Checked)
            {
                try
                {
                    bll.pesquisarQuarto(codigo, "quarto");
                    mkPrecoAtual.Text = bll.getPreco() + "0";
                    txtDescricao.Text = bll.getDescricao();
                    mkDataAlteracao.Text = bll.getDataAtualizacao();
                }
                catch (Exception erro) 
                {
                    MessageBox.Show("Erro: " + erro);
                }

            }
            else if (rbServico.Checked)
            {
                try
                {
                    bll.pesquisarQuarto(codigo, "servico");
                    mkPrecoAtual.Text = bll.getPreco();
                    txtDescricao.Text = bll.getDescricao();
                    mkDataAlteracao.Text = bll.getDataAtualizacao();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro);
                }
            }
            else 
            {
                MessageBox.Show("Selecione o que deseja alterar!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        
    }
}

