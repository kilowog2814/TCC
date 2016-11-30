namespace TCM
{
    partial class FrmReserva2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserva2));
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mkRg = new System.Windows.Forms.MaskedTextBox();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mkFone = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mkCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSuite = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtCod_Quarto = new System.Windows.Forms.TextBox();
            this.cbLuxo = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.dTPCheck_out = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.mkCartao = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpCheck_in = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbJogos = new System.Windows.Forms.CheckBox();
            this.cbAlmoco = new System.Windows.Forms.CheckBox();
            this.cbCafe = new System.Windows.Forms.CheckBox();
            this.cbSauna = new System.Windows.Forms.CheckBox();
            this.cbJantar = new System.Windows.Forms.CheckBox();
            this.cbPiscina = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(500, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 16);
            this.button2.TabIndex = 81;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = global::TCM.Properties.Resources.btnCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(844, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 76);
            this.btnCancelar.TabIndex = 74;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.White;
            this.btnAvancar.BackgroundImage = global::TCM.Properties.Resources.btnConfirmar;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.Location = new System.Drawing.Point(687, 328);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(92, 76);
            this.btnAvancar.TabIndex = 73;
            this.toolTip1.SetToolTip(this.btnAvancar, "Confirmar");
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(317, 58);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(31, 26);
            this.btnPesquisa.TabIndex = 96;
            this.toolTip1.SetToolTip(this.btnPesquisa, "Pesquisar");
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mkCep);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.mkRg);
            this.groupBox1.Controls.Add(this.dataNascimento);
            this.groupBox1.Controls.Add(this.mkFone);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mkCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 233);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // mkCep
            // 
            this.mkCep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCep.Location = new System.Drawing.Point(352, 149);
            this.mkCep.Mask = "00000-000";
            this.mkCep.Name = "mkCep";
            this.mkCep.Size = new System.Drawing.Size(167, 26);
            this.mkCep.TabIndex = 69;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(398, 183);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(121, 26);
            this.txtCidade.TabIndex = 68;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(338, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 18);
            this.label17.TabIndex = 67;
            this.label17.Text = "Cidade:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(304, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 18);
            this.label16.TabIndex = 66;
            this.label16.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 60;
            this.label12.Text = "RG:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 65;
            this.label15.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 18);
            this.label13.TabIndex = 62;
            this.label13.Text = "D. Nascimento:";
            // 
            // mkRg
            // 
            this.mkRg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkRg.Location = new System.Drawing.Point(66, 86);
            this.mkRg.Mask = "00.000.000-0";
            this.mkRg.Name = "mkRg";
            this.mkRg.Size = new System.Drawing.Size(177, 26);
            this.mkRg.TabIndex = 61;
            // 
            // dataNascimento
            // 
            this.dataNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(126, 150);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(172, 26);
            this.dataNascimento.TabIndex = 63;
            // 
            // mkFone
            // 
            this.mkFone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkFone.Location = new System.Drawing.Point(84, 118);
            this.mkFone.Mask = "(00) 0000-0000";
            this.mkFone.Name = "mkFone";
            this.mkFone.Size = new System.Drawing.Size(140, 26);
            this.mkFone.TabIndex = 59;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(91, 183);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(243, 26);
            this.txtEndereco.TabIndex = 64;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(299, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 26);
            this.txtEmail.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Telefone:";
            // 
            // mkCPF
            // 
            this.mkCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCPF.Location = new System.Drawing.Point(300, 87);
            this.mkCPF.Mask = "000.000.000-00";
            this.mkCPF.Name = "mkCPF";
            this.mkCPF.Size = new System.Drawing.Size(218, 26);
            this.mkCPF.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(66, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(452, 26);
            this.txtNome.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnPesquisa);
            this.groupBox2.Controls.Add(this.cbSuite);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtQuant);
            this.groupBox2.Controls.Add(this.txtCod_Quarto);
            this.groupBox2.Controls.Add(this.cbLuxo);
            this.groupBox2.Controls.Add(this.cbNormal);
            this.groupBox2.Controls.Add(this.dTPCheck_out);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.mkCartao);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dtpCheck_in);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(556, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 233);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Reserva";
            // 
            // cbSuite
            // 
            this.cbSuite.AutoSize = true;
            this.cbSuite.Enabled = false;
            this.cbSuite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuite.Location = new System.Drawing.Point(194, 100);
            this.cbSuite.Name = "cbSuite";
            this.cbSuite.Size = new System.Drawing.Size(63, 22);
            this.cbSuite.TabIndex = 99;
            this.cbSuite.Text = "Suite";
            this.cbSuite.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 18);
            this.label21.TabIndex = 94;
            this.label21.Text = "Cód. do Quarto:";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(291, 138);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(57, 21);
            this.txtQuant.TabIndex = 92;
            // 
            // txtCod_Quarto
            // 
            this.txtCod_Quarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_Quarto.Location = new System.Drawing.Point(131, 58);
            this.txtCod_Quarto.Multiline = true;
            this.txtCod_Quarto.Name = "txtCod_Quarto";
            this.txtCod_Quarto.Size = new System.Drawing.Size(165, 26);
            this.txtCod_Quarto.TabIndex = 93;
            // 
            // cbLuxo
            // 
            this.cbLuxo.AutoSize = true;
            this.cbLuxo.Enabled = false;
            this.cbLuxo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLuxo.Location = new System.Drawing.Point(288, 100);
            this.cbLuxo.Name = "cbLuxo";
            this.cbLuxo.Size = new System.Drawing.Size(60, 22);
            this.cbLuxo.TabIndex = 98;
            this.cbLuxo.Text = "Luxo";
            this.cbLuxo.UseVisualStyleBackColor = true;
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.Enabled = false;
            this.cbNormal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNormal.Location = new System.Drawing.Point(86, 100);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(77, 22);
            this.cbNormal.TabIndex = 97;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = true;
            // 
            // dTPCheck_out
            // 
            this.dTPCheck_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPCheck_out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPCheck_out.Location = new System.Drawing.Point(86, 202);
            this.dTPCheck_out.Name = "dTPCheck_out";
            this.dTPCheck_out.Size = new System.Drawing.Size(262, 21);
            this.dTPCheck_out.TabIndex = 88;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(230, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 18);
            this.label19.TabIndex = 91;
            this.label19.Text = "Quant.";
            // 
            // mkCartao
            // 
            this.mkCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCartao.Location = new System.Drawing.Point(86, 137);
            this.mkCartao.Mask = "9999 9999 9999 9999";
            this.mkCartao.Name = "mkCartao";
            this.mkCartao.Size = new System.Drawing.Size(135, 21);
            this.mkCartao.TabIndex = 90;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 18);
            this.label20.TabIndex = 95;
            this.label20.Text = "Diária:";
            // 
            // dtpCheck_in
            // 
            this.dtpCheck_in.Checked = false;
            this.dtpCheck_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpCheck_in.Enabled = false;
            this.dtpCheck_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheck_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheck_in.Location = new System.Drawing.Point(86, 170);
            this.dtpCheck_in.Name = "dtpCheck_in";
            this.dtpCheck_in.Size = new System.Drawing.Size(262, 21);
            this.dtpCheck_in.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 18);
            this.label18.TabIndex = 89;
            this.label18.Text = "Cartão:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 86;
            this.label6.Text = "Check-in:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 87;
            this.label14.Text = "Check-out:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbJogos);
            this.groupBox3.Controls.Add(this.cbAlmoco);
            this.groupBox3.Controls.Add(this.cbCafe);
            this.groupBox3.Controls.Add(this.cbSauna);
            this.groupBox3.Controls.Add(this.cbJantar);
            this.groupBox3.Controls.Add(this.cbPiscina);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 179);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Serviços";
            // 
            // cbJogos
            // 
            this.cbJogos.AutoSize = true;
            this.cbJogos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJogos.Location = new System.Drawing.Point(334, 104);
            this.cbJogos.Name = "cbJogos";
            this.cbJogos.Size = new System.Drawing.Size(163, 28);
            this.cbJogos.TabIndex = 88;
            this.cbJogos.Text = "Sala de Jogos";
            this.cbJogos.UseVisualStyleBackColor = true;
            // 
            // cbAlmoco
            // 
            this.cbAlmoco.AutoSize = true;
            this.cbAlmoco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlmoco.Location = new System.Drawing.Point(206, 40);
            this.cbAlmoco.Name = "cbAlmoco";
            this.cbAlmoco.Size = new System.Drawing.Size(97, 28);
            this.cbAlmoco.TabIndex = 87;
            this.cbAlmoco.Text = "Almoço";
            this.cbAlmoco.UseVisualStyleBackColor = true;
            // 
            // cbCafe
            // 
            this.cbCafe.AutoSize = true;
            this.cbCafe.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCafe.Location = new System.Drawing.Point(25, 40);
            this.cbCafe.Name = "cbCafe";
            this.cbCafe.Size = new System.Drawing.Size(172, 28);
            this.cbCafe.TabIndex = 85;
            this.cbCafe.Text = "Café da Manhã";
            this.cbCafe.UseVisualStyleBackColor = true;
            // 
            // cbSauna
            // 
            this.cbSauna.AutoSize = true;
            this.cbSauna.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSauna.Location = new System.Drawing.Point(206, 104);
            this.cbSauna.Name = "cbSauna";
            this.cbSauna.Size = new System.Drawing.Size(89, 28);
            this.cbSauna.TabIndex = 83;
            this.cbSauna.Text = "Sauna";
            this.cbSauna.UseVisualStyleBackColor = true;
            // 
            // cbJantar
            // 
            this.cbJantar.AutoSize = true;
            this.cbJantar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJantar.Location = new System.Drawing.Point(334, 40);
            this.cbJantar.Name = "cbJantar";
            this.cbJantar.Size = new System.Drawing.Size(88, 28);
            this.cbJantar.TabIndex = 86;
            this.cbJantar.Text = "Jantar";
            this.cbJantar.UseVisualStyleBackColor = true;
            // 
            // cbPiscina
            // 
            this.cbPiscina.AutoSize = true;
            this.cbPiscina.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPiscina.Location = new System.Drawing.Point(25, 104);
            this.cbPiscina.Name = "cbPiscina";
            this.cbPiscina.Size = new System.Drawing.Size(98, 28);
            this.cbPiscina.TabIndex = 84;
            this.cbPiscina.Text = "Piscina";
            this.cbPiscina.UseVisualStyleBackColor = true;
            // 
            // FrmReserva2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 459);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAvancar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmReserva2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.FrmReserva2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mkCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mkRg;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.MaskedTextBox mkFone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.CheckBox cbSuite;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtCod_Quarto;
        private System.Windows.Forms.CheckBox cbLuxo;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.DateTimePicker dTPCheck_out;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mkCartao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpCheck_in;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbJogos;
        private System.Windows.Forms.CheckBox cbAlmoco;
        private System.Windows.Forms.CheckBox cbCafe;
        private System.Windows.Forms.CheckBox cbSauna;
        private System.Windows.Forms.CheckBox cbJantar;
        private System.Windows.Forms.CheckBox cbPiscina;
    }
}