namespace AppAcademia
{
    partial class frmFicha
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
            lblDia01 = new Label();
            lbDia01 = new ListBox();
            lbDia02 = new ListBox();
            lblDia02 = new Label();
            lbDia03 = new ListBox();
            lblDia03 = new Label();
            btnImprimir01 = new Button();
            btnImprimir02 = new Button();
            btnImprimir03 = new Button();
            lblTitulo = new PictureBox();
            imgLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lblTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDia01
            // 
            lblDia01.AutoSize = true;
            lblDia01.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia01.Location = new Point(87, 151);
            lblDia01.Name = "lblDia01";
            lblDia01.Size = new Size(124, 46);
            lblDia01.TabIndex = 17;
            lblDia01.Text = "Dia - 1\r\nPeito, Ombro\r\n";
            // 
            // lbDia01
            // 
            lbDia01.FormattingEnabled = true;
            lbDia01.Items.AddRange(new object[] { "Supino reto – 3x10", "", "", "Supino inclinado – 3x10", "", "", "Crucifixo máquina – 3x12", "", "", "Flexão de braço – 3x12", "Desenvolvimento ombro – 3x10", "", "", "Elevação lateral – 3x12", "", "", "Elevação frontal – 3x12", "", "", "Crucifixo inverso – 3x12", "Abdominal – 3x15", "", "", "Esteira 30-40 Minutos" });
            lbDia01.Location = new Point(87, 211);
            lbDia01.Name = "lbDia01";
            lbDia01.Size = new Size(120, 184);
            lbDia01.TabIndex = 18;
            // 
            // lbDia02
            // 
            lbDia02.FormattingEnabled = true;
            lbDia02.Items.AddRange(new object[] { "Puxada frente – 3x10", "", "", "Remada baixa – 3x10", "", "", "Remada unilateral – 3x10", "", "", "Pulldown – 3x12", "Rosca bíceps – 3x10", "", "", "Rosca martelo – 3x10", "", "", "Rosca concentrada – 3x10", "Rosca polia – 3x12", "Abdominal – 3x15", "Bicicleta 30-40 Minutos" });
            lbDia02.Location = new Point(334, 211);
            lbDia02.Name = "lbDia02";
            lbDia02.Size = new Size(120, 184);
            lbDia02.TabIndex = 20;
            // 
            // lblDia02
            // 
            lblDia02.AutoSize = true;
            lblDia02.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia02.Location = new Point(334, 151);
            lblDia02.Name = "lblDia02";
            lblDia02.Size = new Size(140, 46);
            lblDia02.TabIndex = 19;
            lblDia02.Text = "Dia - 2\r\nCostas, bíceps\r\n";
            // 
            // lbDia03
            // 
            lbDia03.FormattingEnabled = true;
            lbDia03.Items.AddRange(new object[] { "Tríceps polia – 3x10", "", "", "Tríceps testa – 3x10", "", "", "Mergulho banco – 3x12", "", "", "Abdominal – 3x15", "Agachamento – 3x10", "", "", "Leg press – 3x10", "", "", "Extensora – 3x12", "", "", "Flexora – 3x12", "Abdominal – 3x15", "Esteira 30-40 Minutos" });
            lbDia03.Location = new Point(586, 211);
            lbDia03.Name = "lbDia03";
            lbDia03.Size = new Size(120, 184);
            lbDia03.TabIndex = 22;
            // 
            // lblDia03
            // 
            lblDia03.AutoSize = true;
            lblDia03.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia03.Location = new Point(586, 151);
            lblDia03.Name = "lblDia03";
            lblDia03.Size = new Size(139, 69);
            lblDia03.TabIndex = 21;
            lblDia03.Text = "Dia - 3\r\nPerna, Tríceps\r\n\r\n";
            // 
            // btnImprimir01
            // 
            btnImprimir01.BackColor = Color.DeepSkyBlue;
            btnImprimir01.Location = new Point(106, 401);
            btnImprimir01.Name = "btnImprimir01";
            btnImprimir01.Size = new Size(75, 23);
            btnImprimir01.TabIndex = 46;
            btnImprimir01.Text = "Imprimir";
            btnImprimir01.UseVisualStyleBackColor = false;
            // 
            // btnImprimir02
            // 
            btnImprimir02.BackColor = Color.DeepSkyBlue;
            btnImprimir02.Location = new Point(360, 401);
            btnImprimir02.Name = "btnImprimir02";
            btnImprimir02.Size = new Size(75, 23);
            btnImprimir02.TabIndex = 47;
            btnImprimir02.Text = "Imprimir";
            btnImprimir02.UseVisualStyleBackColor = false;
            // 
            // btnImprimir03
            // 
            btnImprimir03.BackColor = Color.DeepSkyBlue;
            btnImprimir03.Location = new Point(608, 401);
            btnImprimir03.Name = "btnImprimir03";
            btnImprimir03.Size = new Size(75, 23);
            btnImprimir03.TabIndex = 48;
            btnImprimir03.Text = "Imprimir";
            btnImprimir03.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Image = Properties.Resources.Inserir_um_título__1_;
            lblTitulo.Location = new Point(277, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 46);
            lblTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            lblTitulo.TabIndex = 60;
            lblTitulo.TabStop = false;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_academia;
            imgLogo.Location = new Point(324, -14);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(130, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 59;
            imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e0611a89_07fa_4d1f_9048_1b6d3c35db00;
            pictureBox1.Location = new Point(24, 442);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmFicha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 504);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Controls.Add(btnImprimir03);
            Controls.Add(btnImprimir02);
            Controls.Add(btnImprimir01);
            Controls.Add(lbDia03);
            Controls.Add(lblDia03);
            Controls.Add(lbDia02);
            Controls.Add(lblDia02);
            Controls.Add(lbDia01);
            Controls.Add(lblDia01);
            Name = "frmFicha";
            Text = "frmFicha";
            Load += frmFicha_Load;
            ((System.ComponentModel.ISupportInitialize)lblTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDia01;
        private ListBox lbDia01;
        private ListBox lbDia02;
        private Label lblDia02;
        private ListBox lbDia03;
        private Label lblDia03;
        private Button btnImprimir01;
        private Button btnImprimir02;
        private Button btnImprimir03;
        private PictureBox lblTitulo;
        private PictureBox imgLogo;
        private PictureBox pictureBox1;
    }
}