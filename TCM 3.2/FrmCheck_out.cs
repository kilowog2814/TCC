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
    public partial class FrmCheck_out : Form
    {
        private FormCheck_out_BLL bll;
        private FormConsulta_BLL bllConsulta;


        public FrmCheck_out()
        {
            InitializeComponent();
        }

        private void edicao(bool vl) 
        {
            mkCartao.Enabled = vl;
            mkValorPago.Enabled = vl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FrmCheck_out_Load(object sender, EventArgs e)
        {
            pParce.Visible = false;
            edicao(false);
            cmbPagamento.Items.Add("");
            cmbPagamento.Items.Add("Dinheiro");
            cmbPagamento.Items.Add("Cartão");
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String codReserva = txtCodigoReserva.Text;
            bll = new FormCheck_out_BLL();
            try
            {
                //if (txtCodigoReserva.Text.Equals("") || (txtCodigoReserva.Text.Length < 6) || (txtCodigoReserva.Text.Length < 6))
                //{
                  //  MessageBox.Show("Digite o codigo da Reserva!");
                    edicao(false);
                //}
                else
                {
                    bll.setCodReserva(codReserva);
                    bll.pesquisarCliente(codReserva);
                    bll.pesquisarReserva(codReserva);
                    if (bll.getStatus().Equals("C") || (bll.getStatus().Equals("W")) || (bll.getStatus().Equals("E")) || (bll.getStatus().Equals("R")) || (bll.getStatus().Equals("N")) || (bll.getStatus().Equals("V")))
                    {
                        MessageBox.Show("Esta reserva não pode ser finalizada!");
                    }
                    else
                    {
                        txtQuarto.Text = bll.getCodQuarto();
                        txtDiaria.Text = "R$ " + bll.pesquisarQuarto(codReserva).ToString() + ",00";
                        txtNome.Text = bll.getNomeCliente();
                        mkCpf.Text = bll.getCPFCliente();
                        dpChegada.Text = bll.getDataEntrada();
                        txtQuanti.Text = bll.getQuantidade();
                        mkRG.Text = bll.getRG();
                        mkTelefone.Text = bll.getTelefone();
                        txtEmail.Text = bll.getEmail();
                        bll.calcularServico(codReserva);
                        lblValorServico.Text = "R$" + bll.getTotalServico();
                        bll = new FormCheck_out_BLL();
                        String total = bll.calcularTotalEstadia(codReserva);
                        lblEstadia.Text = "R$ " + total;

                        bllConsulta = new FormConsulta_BLL();
                        String servicos = bllConsulta.pesquisarServico(bll.getCodReserva());
                        if (servicos == null)
                        {

                        }
                        else
                        {
                            String[] temp = servicos.Split(',');

                            for (int i = 0; i < temp.Length; i++)
                            {
                                if (temp[i].Equals("cafe"))
                                {
                                    cbCafe.Checked = true;
                                }

                                if (temp[i].Equals("almoco"))
                                {
                                    cbAlmoco.Checked = true;
                                }

                                if (temp[i].Equals("jantar"))
                                {
                                    cbJantar.Checked = true;
                                }

                                if (temp[i].Equals("piscina"))
                                {
                                    cbPiscina.Checked = true;
                                }

                                if (temp[i].Equals("sauna"))
                                {
                                    cbSauna.Checked = true;
                                }

                                if (temp[i].Equals("jogos"))
                                {
                                    cbJogos.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        

        private void lblTroco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mkValorPago.Enabled == true)
                {
                    decimal total = decimal.Parse(lblEstadia.Text.Replace("R", "").Replace("$", "").Replace(".", "").Trim());
                    decimal pago = decimal.Parse(mkValorPago.Text.Replace("R", "").Replace("$", "").Replace(".", "").Trim());
                    if (pago > total) 
                    {
                        decimal troco = (total - pago);
                        lblTroco.Text = String.Format("R$ " + "{0:N}",troco).Replace("-","");        
                    }
                }
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
            

            
        }

        private void mktCartao_Leave(object sender, EventArgs e)
        {
            Valida valida = new Valida();
            if (!valida.IsCartao(mkCartao.Text))
            {
                MessageBox.Show("Cartão Inválido!");
            }

        }

        private void lblValorTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal valor = decimal.Parse(lblEstadia.Text.Replace("R", "").Replace("$", "").Replace(".", "").Trim());
                rb1x.Text = String.Format("R$ " + "{0:N}", valor);
                rb2x.Text = String.Format("R$ " + "{0:N}", (valor / 2));
                rb3x.Text = String.Format("R$ " + "{0:N}", (valor / 3));
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            bll = new FormCheck_out_BLL();
            if ((mkCartao.Text.Equals("")) || (mkValorPago.Text.Equals("")))
            {

            }
            else 
            {
                if (bll.finalizarReserva(txtCodigoReserva.Text))
                {
                    MessageBox.Show("Reserva finalizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao finalizar reserva!");
                }
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigoReserva.Text = "100038";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPagamento.SelectedIndex == 1)
                {

                    mkValorPago.Enabled = true;
                    mkCartao.Enabled = false;
                    pParce.Visible = false;
                }
                if (cmbPagamento.SelectedIndex == 2)
                {
                    mkCartao.Enabled = true;
                    pParce.Visible = true;

                    mkValorPago.Enabled = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        }

      
    }


