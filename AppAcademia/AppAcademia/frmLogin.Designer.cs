namespace AppAcademia
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnENTRAR = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblCadastro = new LinkLabel();
            imgLogo = new PictureBox();
            lblTitulo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).BeginInit();
            SuspendLayout();
            // 
            // btnENTRAR
            // 
            btnENTRAR.BackColor = Color.LimeGreen;
            btnENTRAR.Cursor = Cursors.Hand;
            btnENTRAR.FlatStyle = FlatStyle.Flat;
            btnENTRAR.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnENTRAR.ForeColor = SystemColors.ControlText;
            btnENTRAR.Location = new Point(360, 308);
            btnENTRAR.Name = "btnENTRAR";
            btnENTRAR.Size = new Size(75, 23);
            btnENTRAR.TabIndex = 2;
            btnENTRAR.Text = "ENTRAR";
            btnENTRAR.UseVisualStyleBackColor = false;
            btnENTRAR.Click += btnENTRAR_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(321, 267);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(321, 221);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(152, 23);
            txtUsuario.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(321, 203);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(321, 249);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Location = new Point(348, 345);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(100, 15);
            lblCadastro.TabIndex = 3;
            lblCadastro.TabStop = true;
            lblCadastro.Text = "Cadastrar Usuario";
            lblCadastro.LinkClicked += lblCadastro_LinkClicked;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(301, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(185, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 55;
            imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Image = Properties.Resources.Inserir_um_título__1_;
            lblTitulo.Location = new Point(196, 118);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(388, 82);
            lblTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            lblTitulo.TabIndex = 56;
            lblTitulo.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Controls.Add(lblCadastro);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(btnENTRAR);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnENTRAR;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblLogin;
        private Label lblSenha;
        private LinkLabel lblCadastro;
        private PictureBox imgLogo;
        private PictureBox lblTitulo;
    }
}
