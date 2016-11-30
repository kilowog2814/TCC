using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TCM
{
    public partial class FrmCheck_in : Form
    {

        private FormCheckIn_BLL bll;
        private Valida valida;
        private FormLogin_BLL formLogin_BLL;

        public FrmCheck_in()
        {
            InitializeComponent();
        }

        private void edicao(bool val)//esconde label, mostra text box e ativa checkBox e vice versa
        {
            txtNome.Enabled = val;
            txtEmail.Enabled = val;
            mktCPF.Enabled = val;
            mktCEP.Enabled = val;
            mktNascimento.Enabled = val;
            mktTelefone.Enabled = val;
            txtQuarto.Enabled = val;
            cbQtde.Enabled = val;
            dtmChegada.Enabled = val;
            dtmSaida.Enabled = val;
            cbxCafe.Enabled = val;
            cbxAlmoco.Enabled = val;
            cbxJantar.Enabled = val;
            cbxJogos.Enabled = val;
            cbxPiscina.Enabled = val;
            cbxSauna.Enabled = val;


        }

        private void FrmCheck_in_Load(object sender, EventArgs e)
        {
            edicao(false);
            cbQtde.Items.Add("");
            cbQtde.Items.Add("1");
            cbQtde.Items.Add("2");
            cbQtde.Items.Add("3");
            cbQtde.Items.Add("4");
            btnConfirmarAlterar.FlatStyle = FlatStyle.Flat;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanho = txtCodReserva.Text.Length;
                bll = new FormCheckIn_BLL();
                bll.pesquisaBll(txtCodReserva.Text);
                String status = bll.getStatus();
                //if (txtCodReserva.Text.Equals("") || (txtCodReserva.Text.Length < 6) || (txtCodReserva.Text.Length > 6) || (status.Equals("C")) || (status.Equals("W")) || (status.Equals("E")) || (status.Equals("R")) || (status.Equals("N")) || (status.Equals("V")))
                //{
                  //  MessageBox.Show("Digite o codigo da Reserva!");

                //}
                else
                {
                    bll = new FormCheckIn_BLL();
                    String servicos = bll.pesquisaBll(txtCodReserva.Text);
                    String[] temp = servicos.Split(',');
					if (servicos != null) 
                    {
                        String[]temp = servicos.Split(',');
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i].Equals("cafe"))
                            {
                                cbxCafe.Checked = true;
                            }

                            if (temp[i].Equals("almoco"))
                            {
                                cbxAlmoco.Checked = true;
                            }

                            if (temp[i].Equals("jantar"))
                            {
                                cbxJantar.Checked = true;
                            }

                            if (temp[i].Equals("piscina"))
                            {
                                cbxPiscina.Checked = true;
                            }

                            if (temp[i].Equals("sauna"))
                            {
                                cbxSauna.Checked = true;
                            }

                            if (temp[i].Equals("jogos"))
                            {
                                cbxJogos.Checked = true;
                            }

                        }
                    } 
                    txtNome.Text = bll.getNomeCliente();
                    txtEmail.Text = bll.getEmailCliente();
                    txtQuarto.Text = "0" + bll.getCodQuarto();
                    mktCEP.Text = bll.getCepCliente();
                    mktCPF.Text = bll.getCpfCliente();
                    dtmChegada.Text = bll.getDataEntradaCliente().Split(' ')[0];
                    mktNascimento.Text = bll.getDataNascimento();
                    dtmSaida.Text = bll.getDataSaidaCliente().Split(' ')[0];
                    mktTelefone.Text = bll.getTelefone();
                    cbQtde.SelectedIndex = int.Parse(bll.getQuantidade());
                }
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        

        private void btnConfirmar_Click(object sender, EventArgs e)
        { 
            bll = new FormCheckIn_BLL();
            formLogin_BLL = new FormLogin_BLL();
            try
            {
                if (txtCodReserva.Text.Equals("") || (txtCodReserva.Text.Length < 6) || (txtCodReserva.Text.Length < 6))
                {
                    MessageBox.Show("Digite o codigo da Reserva!");
                    edicao(false);
                }
                else
                {
                    bll.confirmarCheckIn(formLogin_BLL.getCodFuncionario(), txtCodReserva.Text);
                    MessageBox.Show("Check-in realizado com sucesso!");
                    this.Close();
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodReserva.Text.Equals("") || (txtCodReserva.Text.Length < 6) || (txtCodReserva.Text.Length < 6))
            {
                MessageBox.Show("Digite o codigo da Reserva!");
                edicao(false);
            }
            else 
            {
                edicao(true);
            }
           // txtNome.Text = lblNome.Text;
           // mktCPF.Text = lblCPF.Text;
           // mktNascimento.Text = lblNascimento.Text;
           // mktCEP.Text = lblCEP.Text;
           // txtEmail.Text = lblEmail.Text;
           // mktTelefone.Text = lblTelefone.Text;
           //// txtQuarto.Text = lblQuarto.Text;
           //// dtmChegada.Text = lblChegada.Text;
           // dtmSaida.Text = lblSaida.Text;
           // mktCartao.Text = lblCartao.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)//esconde text box, mostra labels
        {
            edicao(false);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarAlterar_Click(object sender, EventArgs e)
        {
            valida = new Valida();
            formLogin_BLL = new FormLogin_BLL();
            bll = new FormCheckIn_BLL();
            string servicos = "";

            try
            {
                if (txtCodReserva.Text.Equals("") || (txtCodReserva.Text.Length < 6) || (txtCodReserva.Text.Length < 6))
                {
                    MessageBox.Show("Digite o codigo da Reserva!");
                    edicao(false);
                }
                else
                {
                    if (valida.IsCpf(mktCPF.Text))
                    {
                        if (cbxCafe.Checked)
                            servicos += "100001,";
                        if (cbxAlmoco.Checked)
                            servicos += "100002,";
                        if (cbxJantar.Checked)
                            servicos += "100003,";
                        if (cbxPiscina.Checked)
                            servicos += "100004,";
                        if (cbxSauna.Checked)
                            servicos += "100005,";
                        if (cbxJogos.Checked)
                            servicos += "100006,";

                        string info = txtCodReserva.Text + ";" + formLogin_BLL.getCodFuncionario() + ";" + txtQuarto.Text.Trim() + ";" + cbQtde.Text + ";" + dtmChegada.Text + ";" + dtmSaida.Text + ";" + txtNome.Text.Trim() + ";" + mktCPF.Text.Trim().Trim().Replace(",", "").Replace("-", "") + ";" + mktNascimento.Text + ";" + mktCEP.Text.Replace("-", "") + ";" + txtEmail.Text.Trim() + ";" + mktTelefone.Text.Trim().Replace("(", "").Replace(")", "").Replace(" ", "") + ";";

                        if (bll.confirmarAlterandoBLL(info, dtmChegada.Text, servicos))
                        {
                            MessageBox.Show("Alteração realizada com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro na operação!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF incorreto!");
                        mktCPF.Focus();
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void mktCartao_Leave(object sender, EventArgs e)
        {
            //valida = new Valida();
            //try
            //{
            //    if (valida.IsCartao(mktCartao.Text))
            //    {
            //        if (mktCartao.Text.StartsWith("3"))
            //        {
            //            pbxBandeira.Image = TCM.Properties.Resources.Diners_logo;
            //        }
            //        if (mktCartao.Text.StartsWith("4"))
            //        {
            //            pbxBandeira.Image = TCM.Properties.Resources.Visa_logo;
            //        }
            //        if (mktCartao.Text.StartsWith("5"))
            //        {
            //            pbxBandeira.Image = TCM.Properties.Resources.MasterCard_logo;
            //        }
            //        if (mktCartao.Text.StartsWith("6"))
            //        {
            //            pbxBandeira.Image = TCM.Properties.Resources.Discover_logo;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Número de cartão não aceito!");

            //    }
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Erro: " + erro);
            //}
        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            try
            {
                bll = new FormCheckIn_BLL();
                if (bll.realizarNoShowBll(txtCodReserva.Text))
                {
                    MessageBox.Show("No Show realizado com sucesso!");
                }
                else
                    MessageBox.Show("Falha na operação!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void btnCancelaReserva_Click(object sender, EventArgs e)
        {
            try
            {
                bll = new FormCheckIn_BLL();
                if (bll.cancelarReservaBll(txtCodReserva.Text))
                    MessageBox.Show("Cancelamento realizado com sucesso!");
                else
                    MessageBox.Show("Falha no cancelamento!");
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro: " + erro);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtCodReserva.Text = "100038";
        }
    }
}
