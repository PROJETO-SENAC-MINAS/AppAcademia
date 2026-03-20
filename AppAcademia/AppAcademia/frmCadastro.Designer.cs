namespace AppAcademia
{
    partial class frmCadastro
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
            lblcadastro = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            lbltelefone = new Label();
            txtSenha = new TextBox();
            lblConfirmar = new Label();
            txtConfirmar = new TextBox();
            btnCadastrar = new Button();
            imgLogo = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblcadastro
            // 
            lblcadastro.AutoSize = true;
            lblcadastro.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcadastro.Location = new Point(152, 132);
            lblcadastro.Name = "lblcadastro";
            lblcadastro.Size = new Size(89, 18);
            lblcadastro.TabIndex = 12;
            lblcadastro.Text = "Cadastro";
            lblcadastro.Click += label1_Click;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(132, 224);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 16;
            lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(132, 178);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(86, 15);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome Usuario:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(132, 196);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(152, 23);
            txtNome.TabIndex = 14;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(132, 242);
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '*';
            txtCPF.Size = new Size(152, 23);
            txtCPF.TabIndex = 13;
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(132, 273);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(55, 15);
            lbltelefone.TabIndex = 18;
            lbltelefone.Text = "Telefone:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(132, 291);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 17;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(132, 324);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(99, 15);
            lblConfirmar.TabIndex = 20;
            lblConfirmar.Text = "Confirmar Senha:";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(132, 342);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PasswordChar = '*';
            txtConfirmar.Size = new Size(152, 23);
            txtConfirmar.TabIndex = 19;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.LimeGreen;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ControlText;
            btnCadastrar.Location = new Point(166, 385);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 27);
            btnCadastrar.TabIndex = 21;
            btnCadastrar.Text = "CADASTRARr";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(101, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(183, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 56;
            imgLogo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(419, 426);
            dataGridView1.TabIndex = 57;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(imgLogo);
            Controls.Add(btnCadastrar);
            Controls.Add(lblConfirmar);
            Controls.Add(txtConfirmar);
            Controls.Add(lbltelefone);
            Controls.Add(txtSenha);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(txtCPF);
            Controls.Add(lblcadastro);
            Name = "frmCadastro";
            Text = "frmCadastro";
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblcadastro;
        private Label lblCPF;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCPF;
        private Label lbltelefone;
        private TextBox txtSenha;
        private Label lblConfirmar;
        private TextBox txtConfirmar;
        private Button btnCadastrar;
        private PictureBox imgLogo;
        private DataGridView dataGridView1;
    }
}