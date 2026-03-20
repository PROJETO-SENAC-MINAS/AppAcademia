namespace AppAcademia
{
    partial class frmDanca
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
            btnAgendar = new Button();
            mcCalendario = new MonthCalendar();
            lblAgendar = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblPlanos = new Label();
            lblDiasDisponiveis = new Label();
            lblMensalidades = new Label();
            ckbTQS = new CheckBox();
            ckbSQS = new CheckBox();
            ckbAnual = new CheckBox();
            ckbSemestral = new CheckBox();
            ckbMensal = new CheckBox();
            lblTitulo = new PictureBox();
            imgLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DeepSkyBlue;
            btnAgendar.Cursor = Cursors.Hand;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = SystemColors.ControlText;
            btnAgendar.Location = new Point(595, 392);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(75, 28);
            btnAgendar.TabIndex = 51;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(514, 208);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 50;
            // 
            // lblAgendar
            // 
            lblAgendar.AutoSize = true;
            lblAgendar.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAgendar.Location = new Point(541, 165);
            lblAgendar.Name = "lblAgendar";
            lblAgendar.Size = new Size(232, 24);
            lblAgendar.TabIndex = 49;
            lblAgendar.Text = "Agendar Avaliação";
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.ControlLightLight;
            txtCPF.ForeColor = Color.Black;
            txtCPF.Location = new Point(54, 297);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(159, 23);
            txtCPF.TabIndex = 45;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(54, 279);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 44;
            lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLightLight;
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(54, 242);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(159, 23);
            txtNome.TabIndex = 43;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(54, 224);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 42;
            lblNome.Text = "Nome:";
            // 
            // lblPlanos
            // 
            lblPlanos.AutoSize = true;
            lblPlanos.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlanos.Location = new Point(22, 189);
            lblPlanos.Name = "lblPlanos";
            lblPlanos.Size = new Size(217, 24);
            lblPlanos.TabIndex = 41;
            lblPlanos.Text = "planos e cadastro";
            lblPlanos.Click += lblPlanos_Click;
            // 
            // lblDiasDisponiveis
            // 
            lblDiasDisponiveis.AutoSize = true;
            lblDiasDisponiveis.Location = new Point(296, 330);
            lblDiasDisponiveis.Name = "lblDiasDisponiveis";
            lblDiasDisponiveis.Size = new Size(95, 15);
            lblDiasDisponiveis.TabIndex = 58;
            lblDiasDisponiveis.Text = "Dias Disponiveis:";
            // 
            // lblMensalidades
            // 
            lblMensalidades.AutoSize = true;
            lblMensalidades.Location = new Point(97, 330);
            lblMensalidades.Name = "lblMensalidades";
            lblMensalidades.Size = new Size(82, 15);
            lblMensalidades.TabIndex = 57;
            lblMensalidades.Text = "Mensalidades:";
            // 
            // ckbTQS
            // 
            ckbTQS.AutoSize = true;
            ckbTQS.Location = new Point(286, 397);
            ckbTQS.Name = "ckbTQS";
            ckbTQS.Size = new Size(104, 19);
            ckbTQS.TabIndex = 56;
            ckbTQS.Text = "Ter, Qui, Sab... ";
            ckbTQS.UseVisualStyleBackColor = true;
            // 
            // ckbSQS
            // 
            ckbSQS.AutoSize = true;
            ckbSQS.Location = new Point(286, 363);
            ckbSQS.Name = "ckbSQS";
            ckbSQS.Size = new Size(102, 19);
            ckbSQS.TabIndex = 55;
            ckbSQS.Text = "Seg, Qua, Sex..";
            ckbSQS.UseVisualStyleBackColor = true;
            // 
            // ckbAnual
            // 
            ckbAnual.AutoSize = true;
            ckbAnual.Location = new Point(54, 415);
            ckbAnual.Name = "ckbAnual";
            ckbAnual.Size = new Size(116, 19);
            ckbAnual.TabIndex = 54;
            ckbAnual.Text = "Anual = 10x75 R$";
            ckbAnual.UseVisualStyleBackColor = true;
            // 
            // ckbSemestral
            // 
            ckbSemestral.AutoSize = true;
            ckbSemestral.Location = new Point(54, 388);
            ckbSemestral.Name = "ckbSemestral";
            ckbSemestral.Size = new Size(145, 19);
            ckbSemestral.TabIndex = 53;
            ckbSemestral.Text = "Semestral = 6x80,00 R$";
            ckbSemestral.UseVisualStyleBackColor = true;
            // 
            // ckbMensal
            // 
            ckbMensal.AutoSize = true;
            ckbMensal.Location = new Point(54, 363);
            ckbMensal.Name = "ckbMensal";
            ckbMensal.Size = new Size(121, 19);
            ckbMensal.TabIndex = 52;
            ckbMensal.Text = "Mensal = 90,00 R$";
            ckbMensal.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Image = Properties.Resources.Inserir_um_título__1_;
            lblTitulo.Location = new Point(245, 113);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 82);
            lblTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            lblTitulo.TabIndex = 60;
            lblTitulo.TabStop = false;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(319, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(130, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 59;
            imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e0611a89_07fa_4d1f_9048_1b6d3c35db00;
            pictureBox1.Location = new Point(30, 450);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmDanca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 512);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Controls.Add(lblDiasDisponiveis);
            Controls.Add(lblMensalidades);
            Controls.Add(ckbTQS);
            Controls.Add(ckbSQS);
            Controls.Add(ckbAnual);
            Controls.Add(ckbSemestral);
            Controls.Add(ckbMensal);
            Controls.Add(btnAgendar);
            Controls.Add(mcCalendario);
            Controls.Add(lblAgendar);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblPlanos);
            Name = "frmDanca";
            Text = "frmDança";
            ((System.ComponentModel.ISupportInitialize)lblTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgendar;
        private MonthCalendar mcCalendario;
        private Label lblAgendar;
        private TextBox txtCPF;
        private Label lblCPF;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblPlanos;
        private Label lblDiasDisponiveis;
        private Label lblMensalidades;
        private CheckBox ckbTQS;
        private CheckBox ckbSQS;
        private CheckBox ckbAnual;
        private CheckBox ckbSemestral;
        private CheckBox ckbMensal;
        private PictureBox lblTitulo;
        private PictureBox imgLogo;
        private PictureBox pictureBox1;
    }
}