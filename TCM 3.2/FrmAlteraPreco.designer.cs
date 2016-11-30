namespace TCM
{
    partial class FrmAlteraPreco
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlteraPreco));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.pQuartos = new System.Windows.Forms.Panel();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTipoDeAtualizacao = new System.Windows.Forms.Label();
            this.mkDataAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrecoNovo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mkPrecoNovo = new System.Windows.Forms.MaskedTextBox();
            this.lblDiaNova = new System.Windows.Forms.Label();
            this.mkPrecoAtual = new System.Windows.Forms.MaskedTextBox();
            this.rbQuarto = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pQuartos.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::TCM.Properties.Resources.btnCancelar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(309, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 76);
            this.button2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button2, "Cancelar");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::TCM.Properties.Resources.btnConfirmar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(180, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 76);
            this.button3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button3, "Confirmar");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbServico
            // 
            this.rbServico.AutoSize = true;
            this.rbServico.BackColor = System.Drawing.Color.Transparent;
            this.rbServico.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbServico.Location = new System.Drawing.Point(159, 12);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(111, 28);
            this.rbServico.TabIndex = 19;
            this.rbServico.TabStop = true;
            this.rbServico.Text = "Serviços";
            this.rbServico.UseVisualStyleBackColor = false;
            this.rbServico.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pQuartos
            // 
            this.pQuartos.BackColor = System.Drawing.Color.Transparent;
            this.pQuartos.Controls.Add(this.lblPreco);
            this.pQuartos.Controls.Add(this.lblTipoDeAtualizacao);
            this.pQuartos.Controls.Add(this.mkDataAlteracao);
            this.pQuartos.Controls.Add(this.label2);
            this.pQuartos.Controls.Add(this.txtPesquisa);
            this.pQuartos.Controls.Add(this.button1);
            this.pQuartos.Controls.Add(this.lblPrecoNovo);
            this.pQuartos.Controls.Add(this.txtDescricao);
            this.pQuartos.Controls.Add(this.label7);
            this.pQuartos.Controls.Add(this.mkPrecoNovo);
            this.pQuartos.Controls.Add(this.lblDiaNova);
            this.pQuartos.Controls.Add(this.mkPrecoAtual);
            this.pQuartos.Location = new System.Drawing.Point(18, 56);
            this.pQuartos.Name = "pQuartos";
            this.pQuartos.Size = new System.Drawing.Size(401, 347);
            this.pQuartos.TabIndex = 33;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(22, 63);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(16, 20);
            this.lblPreco.TabIndex = 46;
            this.lblPreco.Text = "?";
            this.lblPreco.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblTipoDeAtualizacao
            // 
            this.lblTipoDeAtualizacao.AutoSize = true;
            this.lblTipoDeAtualizacao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeAtualizacao.Location = new System.Drawing.Point(17, 16);
            this.lblTipoDeAtualizacao.Name = "lblTipoDeAtualizacao";
            this.lblTipoDeAtualizacao.Size = new System.Drawing.Size(20, 23);
            this.lblTipoDeAtualizacao.TabIndex = 45;
            this.lblTipoDeAtualizacao.Text = "?";
            this.lblTipoDeAtualizacao.Click += new System.EventHandler(this.label3_Click);
            // 
            // mkDataAlteracao
            // 
            this.mkDataAlteracao.Enabled = false;
            this.mkDataAlteracao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkDataAlteracao.Location = new System.Drawing.Point(175, 135);
            this.mkDataAlteracao.Mask = "00/00/0000";
            this.mkDataAlteracao.Name = "mkDataAlteracao";
            this.mkDataAlteracao.Size = new System.Drawing.Size(192, 26);
            this.mkDataAlteracao.TabIndex = 44;
            this.mkDataAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ultima  Alteração:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(162, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(130, 20);
            this.txtPesquisa.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(298, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 26);
            this.button1.TabIndex = 38;
            this.toolTip1.SetToolTip(this.button1, "Pesquisar Serviço");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblPrecoNovo
            // 
            this.lblPrecoNovo.AutoSize = true;
            this.lblPrecoNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoNovo.Location = new System.Drawing.Point(207, 63);
            this.lblPrecoNovo.Name = "lblPrecoNovo";
            this.lblPrecoNovo.Size = new System.Drawing.Size(94, 18);
            this.lblPrecoNovo.TabIndex = 37;
            this.lblPrecoNovo.Text = "Novo Preço:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(26, 194);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(341, 128);
            this.txtDescricao.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Descrição:";
            // 
            // mkPrecoNovo
            // 
            this.mkPrecoNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPrecoNovo.Location = new System.Drawing.Point(210, 86);
            this.mkPrecoNovo.Mask = "$000,00";
            this.mkPrecoNovo.Name = "mkPrecoNovo";
            this.mkPrecoNovo.Size = new System.Drawing.Size(148, 26);
            this.mkPrecoNovo.TabIndex = 24;
            // 
            // lblDiaNova
            // 
            this.lblDiaNova.AutoSize = true;
            this.lblDiaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNova.Location = new System.Drawing.Point(206, 63);
            this.lblDiaNova.Name = "lblDiaNova";
            this.lblDiaNova.Size = new System.Drawing.Size(90, 20);
            this.lblDiaNova.TabIndex = 23;
            this.lblDiaNova.Text = "Nova Diaria";
            // 
            // mkPrecoAtual
            // 
            this.mkPrecoAtual.Enabled = false;
            this.mkPrecoAtual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPrecoAtual.Location = new System.Drawing.Point(26, 86);
            this.mkPrecoAtual.Mask = "$000.00";
            this.mkPrecoAtual.Name = "mkPrecoAtual";
            this.mkPrecoAtual.Size = new System.Drawing.Size(156, 26);
            this.mkPrecoAtual.TabIndex = 22;
            // 
            // rbQuarto
            // 
            this.rbQuarto.AutoSize = true;
            this.rbQuarto.BackColor = System.Drawing.Color.Transparent;
            this.rbQuarto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuarto.Location = new System.Drawing.Point(12, 12);
            this.rbQuarto.Name = "rbQuarto";
            this.rbQuarto.Size = new System.Drawing.Size(103, 28);
            this.rbQuarto.TabIndex = 30;
            this.rbQuarto.TabStop = true;
            this.rbQuarto.Text = "Quartos";
            this.rbQuarto.UseVisualStyleBackColor = false;
            this.rbQuarto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FrmAlteraPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 536);
            this.Controls.Add(this.rbQuarto);
            this.Controls.Add(this.pQuartos);
            this.Controls.Add(this.rbServico);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAlteraPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Preços";
            this.Load += new System.EventHandler(this.FrmAlteraPreco_Load);
            this.pQuartos.ResumeLayout(false);
            this.pQuartos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbServico;
        private System.Windows.Forms.Panel pQuartos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mkPrecoNovo;
        private System.Windows.Forms.Label lblDiaNova;
        private System.Windows.Forms.MaskedTextBox mkPrecoAtual;
        private System.Windows.Forms.RadioButton rbQuarto;
        private System.Windows.Forms.Label lblPrecoNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox mkDataAlteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoDeAtualizacao;
        private System.Windows.Forms.Label lblPreco;
    }
}

