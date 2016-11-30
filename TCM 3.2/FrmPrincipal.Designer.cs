namespace TCM
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCheckOut = new System.Windows.Forms.DataGridView();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlterarPrecos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.atualiza = new System.Windows.Forms.Timer(this.components);
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnGerencia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReserva
            // 
            this.btnReserva.BackgroundImage = global::TCM.Properties.Resources.btnReserva;
            this.btnReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.Location = new System.Drawing.Point(49, 429);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(140, 144);
            this.btnReserva.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnReserva, "Reserva");
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackgroundImage = global::TCM.Properties.Resources.btnCheckout;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(49, 279);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(140, 144);
            this.btnCheckOut.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCheckOut, "Check-out");
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check-out";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvCheckOut);
            this.panel1.Location = new System.Drawing.Point(527, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 230);
            this.panel1.TabIndex = 6;
            // 
            // dgvCheckOut
            // 
            this.dgvCheckOut.AllowUserToAddRows = false;
            this.dgvCheckOut.AllowUserToDeleteRows = false;
            this.dgvCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckOut.Location = new System.Drawing.Point(15, 15);
            this.dgvCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCheckOut.MultiSelect = false;
            this.dgvCheckOut.Name = "dgvCheckOut";
            this.dgvCheckOut.ReadOnly = true;
            this.dgvCheckOut.RowHeadersVisible = false;
            this.dgvCheckOut.RowTemplate.Height = 24;
            this.dgvCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckOut.Size = new System.Drawing.Size(400, 200);
            this.dgvCheckOut.TabIndex = 25;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblFuncionario.Location = new System.Drawing.Point(627, 78);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(302, 32);
            this.lblFuncionario.TabIndex = 7;
            this.lblFuncionario.Text = "Nome do Funcionario";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckIn.BackgroundImage = global::TCM.Properties.Resources.btnCheckin;
            this.btnCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(49, 129);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(140, 144);
            this.btnCheckIn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCheckIn, "Check-in");
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(468, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bem-vindo,";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnAlterarPrecos
            // 
            this.btnAlterarPrecos.BackgroundImage = global::TCM.Properties.Resources.btnAlterarPreco;
            this.btnAlterarPrecos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarPrecos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPrecos.Location = new System.Drawing.Point(220, 280);
            this.btnAlterarPrecos.Name = "btnAlterarPrecos";
            this.btnAlterarPrecos.Size = new System.Drawing.Size(140, 144);
            this.btnAlterarPrecos.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnAlterarPrecos, "Alterar Preços");
            this.btnAlterarPrecos.UseVisualStyleBackColor = true;
            this.btnAlterarPrecos.Click += new System.EventHandler(this.btnAlterarPreco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Check-in";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvCheckIn);
            this.panel2.Location = new System.Drawing.Point(531, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 230);
            this.panel2.TabIndex = 12;
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AllowUserToAddRows = false;
            this.dgvCheckIn.AllowUserToDeleteRows = false;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Location = new System.Drawing.Point(15, 14);
            this.dgvCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCheckIn.MultiSelect = false;
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowHeadersVisible = false;
            this.dgvCheckIn.RowTemplate.Height = 24;
            this.dgvCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIn.Size = new System.Drawing.Size(400, 200);
            this.dgvCheckIn.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsHora,
            this.stsData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 756);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1024, 24);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsHora
            // 
            this.stsHora.BackColor = System.Drawing.Color.Transparent;
            this.stsHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsHora.Name = "stsHora";
            this.stsHora.Size = new System.Drawing.Size(122, 19);
            this.stsHora.Text = "toolStripStatusLabel1";
            // 
            // stsData
            // 
            this.stsData.BackColor = System.Drawing.Color.Transparent;
            this.stsData.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsData.Name = "stsData";
            this.stsData.Size = new System.Drawing.Size(122, 19);
            this.stsData.Text = "toolStripStatusLabel2";
            // 
            // atualiza
            // 
            this.atualiza.Enabled = true;
            this.atualiza.Interval = 600000;
            this.atualiza.Tick += new System.EventHandler(this.atualiza_Tick);
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Interval = 1000;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackgroundImage = global::TCM.Properties.Resources.btnGraficos;
            this.btnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraficos.Location = new System.Drawing.Point(220, 430);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(140, 144);
            this.btnGraficos.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnGraficos, "Grafico");
            this.btnGraficos.UseVisualStyleBackColor = true;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = global::TCM.Properties.Resources.btnRelatorios;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRelatorio.Location = new System.Drawing.Point(220, 580);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(140, 144);
            this.btnRelatorio.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnRelatorio, "Relatorio de Funcionarios");
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnGerencia
            // 
            this.btnGerencia.BackgroundImage = global::TCM.Properties.Resources.btnMostrarMais;
            this.btnGerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerencia.Location = new System.Drawing.Point(49, 580);
            this.btnGerencia.Name = "btnGerencia";
            this.btnGerencia.Size = new System.Drawing.Size(140, 144);
            this.btnGerencia.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnGerencia, "Gerencia");
            this.btnGerencia.UseVisualStyleBackColor = true;
            this.btnGerencia.Click += new System.EventHandler(this.btnGerencia_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 780);
            this.Controls.Add(this.btnGerencia);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnGraficos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAlterarPrecos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnAlterarPrecos;
        private System.Windows.Forms.DataGridView dgvCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsHora;
        private System.Windows.Forms.ToolStripStatusLabel stsData;
        private System.Windows.Forms.Timer atualiza;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnGerencia;
    }
}