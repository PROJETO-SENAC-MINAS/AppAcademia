namespace AppAcademia
{
    partial class frmMenu
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
            lblMusculacao = new LinkLabel();
            lblNatacao = new LinkLabel();
            lblDanca = new LinkLabel();
            lblAvaliacao = new LinkLabel();
            lblFicha = new LinkLabel();
            lblModalidade = new Label();
            lblServicos = new Label();
            label1 = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnGerarFicha = new Button();
            lblTitulo = new PictureBox();
            imgLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // lblMusculacao
            // 
            lblMusculacao.ActiveLinkColor = Color.Blue;
            lblMusculacao.AutoSize = true;
            lblMusculacao.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusculacao.LinkColor = Color.Black;
            lblMusculacao.Location = new Point(88, 187);
            lblMusculacao.Name = "lblMusculacao";
            lblMusculacao.Size = new Size(138, 24);
            lblMusculacao.TabIndex = 5;
            lblMusculacao.TabStop = true;
            lblMusculacao.Text = "-Musculação";
            lblMusculacao.LinkClicked += lblMusculacao_LinkClicked;
            // 
            // lblNatacao
            // 
            lblNatacao.ActiveLinkColor = Color.Blue;
            lblNatacao.AutoSize = true;
            lblNatacao.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNatacao.LinkColor = Color.Black;
            lblNatacao.Location = new Point(88, 262);
            lblNatacao.Name = "lblNatacao";
            lblNatacao.Size = new Size(101, 24);
            lblNatacao.TabIndex = 6;
            lblNatacao.TabStop = true;
            lblNatacao.Text = "-Natação";
            lblNatacao.LinkClicked += lblNatacao_LinkClicked;
            // 
            // lblDanca
            // 
            lblDanca.ActiveLinkColor = Color.Blue;
            lblDanca.AutoSize = true;
            lblDanca.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDanca.LinkColor = Color.Black;
            lblDanca.Location = new Point(88, 343);
            lblDanca.Name = "lblDanca";
            lblDanca.Size = new Size(113, 24);
            lblDanca.TabIndex = 7;
            lblDanca.TabStop = true;
            lblDanca.Text = "-Fit Dance";
            lblDanca.LinkClicked += linkLabel3_LinkClicked;
            // 
            // lblAvaliacao
            // 
            lblAvaliacao.ActiveLinkColor = Color.Blue;
            lblAvaliacao.AutoSize = true;
            lblAvaliacao.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvaliacao.LinkColor = Color.Black;
            lblAvaliacao.Location = new Point(556, 187);
            lblAvaliacao.Name = "lblAvaliacao";
            lblAvaliacao.Size = new Size(191, 24);
            lblAvaliacao.TabIndex = 8;
            lblAvaliacao.TabStop = true;
            lblAvaliacao.Text = "-Avaliação Fisíca  ";
            lblAvaliacao.LinkClicked += lblAvaliacao_LinkClicked;
            // 
            // lblFicha
            // 
            lblFicha.ActiveLinkColor = Color.Blue;
            lblFicha.AutoSize = true;
            lblFicha.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFicha.LinkColor = Color.Black;
            lblFicha.Location = new Point(556, 262);
            lblFicha.Name = "lblFicha";
            lblFicha.Size = new Size(0, 24);
            lblFicha.TabIndex = 9;
            // 
            // lblModalidade
            // 
            lblModalidade.AutoSize = true;
            lblModalidade.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModalidade.Location = new Point(109, 113);
            lblModalidade.Name = "lblModalidade";
            lblModalidade.Size = new Size(117, 18);
            lblModalidade.TabIndex = 11;
            lblModalidade.Text = "Modalidades";
            // 
            // lblServicos
            // 
            lblServicos.AutoSize = true;
            lblServicos.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServicos.Location = new Point(556, 113);
            lblServicos.Name = "lblServicos";
            lblServicos.Size = new Size(84, 18);
            lblServicos.TabIndex = 12;
            lblServicos.Text = " Serviços";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(556, 238);
            label1.Name = "label1";
            label1.Size = new Size(176, 48);
            label1.TabIndex = 15;
            label1.Text = "-Ficha Avaliativa\r\nde Exercicios\r\n";
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.ControlLightLight;
            txtCPF.ForeColor = Color.Black;
            txtCPF.Location = new Point(573, 371);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(159, 23);
            txtCPF.TabIndex = 25;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(573, 353);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 24;
            lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLightLight;
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(573, 316);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(159, 23);
            txtNome.TabIndex = 23;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(573, 298);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 22;
            lblNome.Text = "Nome:";
            // 
            // btnGerarFicha
            // 
            btnGerarFicha.BackColor = Color.DeepSkyBlue;
            btnGerarFicha.Cursor = Cursors.Hand;
            btnGerarFicha.FlatStyle = FlatStyle.Flat;
            btnGerarFicha.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerarFicha.ForeColor = SystemColors.ControlText;
            btnGerarFicha.Location = new Point(612, 400);
            btnGerarFicha.Name = "btnGerarFicha";
            btnGerarFicha.Size = new Size(75, 28);
            btnGerarFicha.TabIndex = 52;
            btnGerarFicha.Text = "Gerar Ficha";
            btnGerarFicha.UseVisualStyleBackColor = false;
            btnGerarFicha.Click += btnGerarFicha_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Image = Properties.Resources.Inserir_um_título__1_;
            lblTitulo.Location = new Point(242, 113);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 82);
            lblTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            lblTitulo.TabIndex = 58;
            lblTitulo.TabStop = false;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(316, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(130, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 57;
            imgLogo.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Controls.Add(btnGerarFicha);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(label1);
            Controls.Add(lblServicos);
            Controls.Add(lblModalidade);
            Controls.Add(lblFicha);
            Controls.Add(lblAvaliacao);
            Controls.Add(lblDanca);
            Controls.Add(lblNatacao);
            Controls.Add(lblMusculacao);
            Name = "frmMenu";
            Text = "frmMenu";
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)lblTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lblMusculacao;
        private LinkLabel lblNatacao;
        private LinkLabel lblDanca;
        private LinkLabel lblAvaliacao;
        private LinkLabel lblFicha;
        private Label lblModalidade;
        private Label lblServicos;
        private Label label1;
        private TextBox txtCPF;
        private Label lblCPF;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnGerarFicha;
        private PictureBox lblTitulo;
        private PictureBox imgLogo;
    }
}