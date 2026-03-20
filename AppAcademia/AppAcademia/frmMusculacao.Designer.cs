namespace AppAcademia
{
    partial class frmMusculacao
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
            lblPlanos = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCPF = new Label();
            txtCPF = new TextBox();
            ckbMensal = new CheckBox();
            ckbSemestral = new CheckBox();
            ckbAnual = new CheckBox();
            lblAgendar = new Label();
            mcCalendario = new MonthCalendar();
            btnAgendar = new Button();
            lblMensalidades = new Label();
            lblDias = new Label();
            ckbTodoDia = new CheckBox();
            lblTitulo = new PictureBox();
            imgLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPlanos
            // 
            lblPlanos.AutoSize = true;
            lblPlanos.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlanos.Location = new Point(37, 198);
            lblPlanos.Name = "lblPlanos";
            lblPlanos.Size = new Size(217, 24);
            lblPlanos.TabIndex = 17;
            lblPlanos.Text = "planos e cadastro";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(69, 231);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLightLight;
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(69, 249);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(159, 23);
            txtNome.TabIndex = 19;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(69, 286);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 20;
            lblCPF.Text = "CPF:";
            lblCPF.Click += label4_Click;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.ControlLightLight;
            txtCPF.ForeColor = Color.Black;
            txtCPF.Location = new Point(69, 304);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(159, 23);
            txtCPF.TabIndex = 21;
            // 
            // ckbMensal
            // 
            ckbMensal.AutoSize = true;
            ckbMensal.Location = new Point(69, 369);
            ckbMensal.Name = "ckbMensal";
            ckbMensal.Size = new Size(116, 19);
            ckbMensal.TabIndex = 22;
            ckbMensal.Text = "Mensal 105,99 R$";
            ckbMensal.UseVisualStyleBackColor = true;
            ckbMensal.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ckbSemestral
            // 
            ckbSemestral.AutoSize = true;
            ckbSemestral.Location = new Point(69, 394);
            ckbSemestral.Name = "ckbSemestral";
            ckbSemestral.Size = new Size(134, 19);
            ckbSemestral.TabIndex = 23;
            ckbSemestral.Text = "Semestral 6x95,99 R$";
            ckbSemestral.UseVisualStyleBackColor = true;
            ckbSemestral.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // ckbAnual
            // 
            ckbAnual.AutoSize = true;
            ckbAnual.Location = new Point(69, 419);
            ckbAnual.Name = "ckbAnual";
            ckbAnual.Size = new Size(104, 19);
            ckbAnual.TabIndex = 24;
            ckbAnual.Text = "Anual 12x85,99";
            ckbAnual.UseVisualStyleBackColor = true;
            // 
            // lblAgendar
            // 
            lblAgendar.AutoSize = true;
            lblAgendar.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAgendar.Location = new Point(524, 166);
            lblAgendar.Name = "lblAgendar";
            lblAgendar.Size = new Size(232, 24);
            lblAgendar.TabIndex = 25;
            lblAgendar.Text = "Agendar Avaliação";
            lblAgendar.Click += label5_Click;
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(529, 215);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 26;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DeepSkyBlue;
            btnAgendar.Cursor = Cursors.Hand;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = SystemColors.ControlText;
            btnAgendar.Location = new Point(610, 399);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(75, 28);
            btnAgendar.TabIndex = 27;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // lblMensalidades
            // 
            lblMensalidades.AutoSize = true;
            lblMensalidades.Location = new Point(91, 340);
            lblMensalidades.Name = "lblMensalidades";
            lblMensalidades.Size = new Size(82, 15);
            lblMensalidades.TabIndex = 58;
            lblMensalidades.Text = "Mensalidades:";
            lblMensalidades.Click += lblMensalidades_Click;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(337, 340);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(95, 15);
            lblDias.TabIndex = 59;
            lblDias.Text = "Dias Disponiveis:";
            // 
            // ckbTodoDia
            // 
            ckbTodoDia.AutoSize = true;
            ckbTodoDia.Location = new Point(337, 369);
            ckbTodoDia.Name = "ckbTodoDia";
            ckbTodoDia.Size = new Size(98, 19);
            ckbTodoDia.TabIndex = 60;
            ckbTodoDia.Text = "Todos os Dias";
            ckbTodoDia.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Image = Properties.Resources.Inserir_um_título__1_;
            lblTitulo.Location = new Point(249, 113);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 82);
            lblTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            lblTitulo.TabIndex = 62;
            lblTitulo.TabStop = false;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(323, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(130, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 61;
            imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e0611a89_07fa_4d1f_9048_1b6d3c35db00;
            pictureBox1.Location = new Point(22, 456);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmMusculacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 518);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Controls.Add(ckbTodoDia);
            Controls.Add(lblDias);
            Controls.Add(lblMensalidades);
            Controls.Add(btnAgendar);
            Controls.Add(mcCalendario);
            Controls.Add(lblAgendar);
            Controls.Add(ckbAnual);
            Controls.Add(ckbSemestral);
            Controls.Add(ckbMensal);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblPlanos);
            Name = "frmMusculacao";
            Text = "frmMusculação";
            Load += frmMusculação_Load;
            ((System.ComponentModel.ISupportInitialize)lblTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPlanos;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCPF;
        private TextBox txtCPF;
        private CheckBox ckbMensal;
        private CheckBox ckbSemestral;
        private CheckBox ckbAnual;
        private Label lblAgendar;
        private MonthCalendar mcCalendario;
        private Button btnAgendar;
        private Label lblMensalidades;
        private Label lblDias;
        private CheckBox ckbTodoDia;
        private PictureBox lblTitulo;
        private PictureBox imgLogo;
        private PictureBox pictureBox1;
    }
}