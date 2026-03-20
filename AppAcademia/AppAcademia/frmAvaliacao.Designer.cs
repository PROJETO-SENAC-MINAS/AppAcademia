namespace AppAcademia
{
    partial class frmAvaliacao
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
            lblAvaliacao = new Label();
            lblDados = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblIdade = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            txtIdade = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            lblMedidas = new Label();
            txtQuadril = new TextBox();
            txtAbdomen = new TextBox();
            txtCintura = new TextBox();
            lblQuadril = new Label();
            lblAbdomen = new Label();
            lblCintura = new Label();
            lblPeitoral = new Label();
            txtPeitoral = new TextBox();
            lblBraco = new Label();
            lblCoxa = new Label();
            lblPanturrilha = new Label();
            txtBraco = new TextBox();
            txtCoxa = new TextBox();
            txtPanturrilha = new TextBox();
            cbObjetivo = new ComboBox();
            lblObjetivo = new Label();
            lblCPF = new Label();
            txtCPF = new TextBox();
            btnSalvar = new Button();
            lblTitulo = new PictureBox();
            imgLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // lblAvaliacao
            // 
            lblAvaliacao.AutoSize = true;
            lblAvaliacao.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvaliacao.Location = new Point(338, 181);
            lblAvaliacao.Name = "lblAvaliacao";
            lblAvaliacao.Size = new Size(152, 18);
            lblAvaliacao.TabIndex = 15;
            lblAvaliacao.Text = "Avaliação Fisica";
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDados.Location = new Point(106, 260);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(155, 23);
            lblDados.TabIndex = 16;
            lblDados.Text = "Dados Pessoais ";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtNome.Location = new Point(129, 302);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(80, 305);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome:";
            lblNome.Click += label3_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(83, 368);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(39, 15);
            lblIdade.TabIndex = 19;
            lblIdade.Text = "Idade:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(81, 397);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 20;
            lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(83, 426);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 21;
            lblPeso.Text = "Peso:";
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.ActiveCaption;
            txtIdade.Location = new Point(129, 360);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 22;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = SystemColors.ActiveCaption;
            txtAltura.Location = new Point(129, 389);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 23;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = SystemColors.ActiveCaption;
            txtPeso.Location = new Point(129, 418);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 24;
            // 
            // lblMedidas
            // 
            lblMedidas.AutoSize = true;
            lblMedidas.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedidas.Location = new Point(390, 260);
            lblMedidas.Name = "lblMedidas";
            lblMedidas.Size = new Size(84, 23);
            lblMedidas.TabIndex = 25;
            lblMedidas.Text = "Medidas";
            // 
            // txtQuadril
            // 
            txtQuadril.BackColor = SystemColors.ActiveCaption;
            txtQuadril.Location = new Point(390, 389);
            txtQuadril.Name = "txtQuadril";
            txtQuadril.Size = new Size(100, 23);
            txtQuadril.TabIndex = 33;
            // 
            // txtAbdomen
            // 
            txtAbdomen.BackColor = SystemColors.ActiveCaption;
            txtAbdomen.Location = new Point(390, 360);
            txtAbdomen.Name = "txtAbdomen";
            txtAbdomen.Size = new Size(100, 23);
            txtAbdomen.TabIndex = 32;
            txtAbdomen.TextChanged += textBox6_TextChanged;
            // 
            // txtCintura
            // 
            txtCintura.BackColor = SystemColors.ActiveCaption;
            txtCintura.Location = new Point(390, 331);
            txtCintura.Name = "txtCintura";
            txtCintura.Size = new Size(100, 23);
            txtCintura.TabIndex = 31;
            // 
            // lblQuadril
            // 
            lblQuadril.AutoSize = true;
            lblQuadril.Location = new Point(341, 397);
            lblQuadril.Name = "lblQuadril";
            lblQuadril.Size = new Size(49, 15);
            lblQuadril.TabIndex = 30;
            lblQuadril.Text = "Quadril:";
            // 
            // lblAbdomen
            // 
            lblAbdomen.AutoSize = true;
            lblAbdomen.Location = new Point(328, 368);
            lblAbdomen.Name = "lblAbdomen";
            lblAbdomen.Size = new Size(63, 15);
            lblAbdomen.TabIndex = 29;
            lblAbdomen.Text = "Abdômen:";
            lblAbdomen.Click += label9_Click;
            // 
            // lblCintura
            // 
            lblCintura.AutoSize = true;
            lblCintura.Location = new Point(341, 339);
            lblCintura.Name = "lblCintura";
            lblCintura.Size = new Size(49, 15);
            lblCintura.TabIndex = 28;
            lblCintura.Text = "Cintura:";
            // 
            // lblPeitoral
            // 
            lblPeitoral.AutoSize = true;
            lblPeitoral.Location = new Point(341, 305);
            lblPeitoral.Name = "lblPeitoral";
            lblPeitoral.Size = new Size(50, 15);
            lblPeitoral.TabIndex = 27;
            lblPeitoral.Text = "Peitoral:";
            // 
            // txtPeitoral
            // 
            txtPeitoral.BackColor = SystemColors.ActiveCaption;
            txtPeitoral.Location = new Point(390, 297);
            txtPeitoral.Name = "txtPeitoral";
            txtPeitoral.Size = new Size(100, 23);
            txtPeitoral.TabIndex = 26;
            // 
            // lblBraco
            // 
            lblBraco.AutoSize = true;
            lblBraco.Location = new Point(350, 427);
            lblBraco.Name = "lblBraco";
            lblBraco.Size = new Size(40, 15);
            lblBraco.TabIndex = 34;
            lblBraco.Text = "Braço:";
            lblBraco.Click += label12_Click;
            // 
            // lblCoxa
            // 
            lblCoxa.AutoSize = true;
            lblCoxa.Location = new Point(355, 456);
            lblCoxa.Name = "lblCoxa";
            lblCoxa.Size = new Size(36, 15);
            lblCoxa.TabIndex = 35;
            lblCoxa.Text = "Coxa:";
            lblCoxa.Click += label13_Click;
            // 
            // lblPanturrilha
            // 
            lblPanturrilha.AutoSize = true;
            lblPanturrilha.Location = new Point(322, 490);
            lblPanturrilha.Name = "lblPanturrilha";
            lblPanturrilha.Size = new Size(68, 15);
            lblPanturrilha.TabIndex = 36;
            lblPanturrilha.Text = "Panturrilha:";
            lblPanturrilha.Click += label14_Click;
            // 
            // txtBraco
            // 
            txtBraco.BackColor = SystemColors.ActiveCaption;
            txtBraco.Location = new Point(390, 419);
            txtBraco.Name = "txtBraco";
            txtBraco.Size = new Size(100, 23);
            txtBraco.TabIndex = 37;
            txtBraco.TextChanged += textBox9_TextChanged;
            // 
            // txtCoxa
            // 
            txtCoxa.BackColor = SystemColors.ActiveCaption;
            txtCoxa.Location = new Point(390, 448);
            txtCoxa.Name = "txtCoxa";
            txtCoxa.Size = new Size(100, 23);
            txtCoxa.TabIndex = 38;
            txtCoxa.TextChanged += textBox10_TextChanged;
            // 
            // txtPanturrilha
            // 
            txtPanturrilha.BackColor = SystemColors.ActiveCaption;
            txtPanturrilha.Location = new Point(390, 482);
            txtPanturrilha.Name = "txtPanturrilha";
            txtPanturrilha.Size = new Size(100, 23);
            txtPanturrilha.TabIndex = 39;
            // 
            // cbObjetivo
            // 
            cbObjetivo.BackColor = SystemColors.ActiveCaption;
            cbObjetivo.FormattingEnabled = true;
            cbObjetivo.Items.AddRange(new object[] { "Selecione a Opção...", "Emagrecer", "Ganhar massa muscular", "Condicionamento físico" });
            cbObjetivo.Location = new Point(571, 297);
            cbObjetivo.Name = "cbObjetivo";
            cbObjetivo.Size = new Size(121, 23);
            cbObjetivo.TabIndex = 40;
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObjetivo.Location = new Point(589, 254);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(83, 23);
            lblObjetivo.TabIndex = 41;
            lblObjetivo.Text = "Objetivo";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(80, 334);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 43;
            lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.ActiveCaption;
            txtCPF.Location = new Point(129, 331);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 42;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DeepSkyBlue;
            btnSalvar.Location = new Point(589, 340);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 43);
            btnSalvar.TabIndex = 44;
            btnSalvar.Text = "Salvar \r\nAvaliação";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += button1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Image = Properties.Resources.Inserir_um_título__1_;
            lblTitulo.Location = new Point(264, 113);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 65);
            lblTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            lblTitulo.TabIndex = 60;
            lblTitulo.TabStop = false;
            lblTitulo.Click += pictureBox1_Click;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(338, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(130, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 59;
            imgLogo.TabStop = false;
            imgLogo.Click += pictureBox2_Click;
            // 
            // frmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 542);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Controls.Add(btnSalvar);
            Controls.Add(lblCPF);
            Controls.Add(txtCPF);
            Controls.Add(lblObjetivo);
            Controls.Add(cbObjetivo);
            Controls.Add(txtPanturrilha);
            Controls.Add(txtCoxa);
            Controls.Add(txtBraco);
            Controls.Add(lblPanturrilha);
            Controls.Add(lblCoxa);
            Controls.Add(lblBraco);
            Controls.Add(txtQuadril);
            Controls.Add(txtAbdomen);
            Controls.Add(txtCintura);
            Controls.Add(lblQuadril);
            Controls.Add(lblAbdomen);
            Controls.Add(lblCintura);
            Controls.Add(lblPeitoral);
            Controls.Add(txtPeitoral);
            Controls.Add(lblMedidas);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtIdade);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblDados);
            Controls.Add(lblAvaliacao);
            Name = "frmAvaliacao";
            Text = "frmAvaliacao";
            Load += frmAvaliacao_Load;
            ((System.ComponentModel.ISupportInitialize)lblTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAvaliacao;
        private Label lblDados;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblIdade;
        private Label lblAltura;
        private Label lblPeso;
        private TextBox txtIdade;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label lblMedidas;
        private TextBox txtQuadril;
        private TextBox txtAbdomen;
        private TextBox txtCintura;
        private Label lblQuadril;
        private Label lblAbdomen;
        private Label lblCintura;
        private Label lblPeitoral;
        private TextBox txtPeitoral;
        private Label lblBraco;
        private Label lblCoxa;
        private Label lblPanturrilha;
        private TextBox txtBraco;
        private TextBox txtCoxa;
        private TextBox txtPanturrilha;
        private ComboBox cbObjetivo;
        private Label lblObjetivo;
        private Label lblCPF;
        private TextBox txtCPF;
        private Button btnSalvar;
        private PictureBox lblTitulo;
        private PictureBox imgLogo;
    }
}