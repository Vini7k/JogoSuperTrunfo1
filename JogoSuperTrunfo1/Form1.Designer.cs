namespace JogoSuperTrunfo1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            botaoSortear = new Button();
            lblCartasMaquina = new Label();
            lblCartasJogador = new Label();
            botaoComparar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Atributo1 = new RadioButton();
            Atributo2 = new RadioButton();
            Atributo3 = new RadioButton();
            Atributo4 = new RadioButton();
            botaoSortearJogada = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // botaoSortear
            // 
            botaoSortear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoSortear.BackColor = Color.DarkSlateBlue;
            botaoSortear.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            botaoSortear.BackgroundImageLayout = ImageLayout.Stretch;
            botaoSortear.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botaoSortear.ForeColor = Color.DarkSlateBlue;
            botaoSortear.Location = new Point(403, 162);
            botaoSortear.Name = "botaoSortear";
            botaoSortear.Size = new Size(122, 52);
            botaoSortear.TabIndex = 0;
            botaoSortear.Text = "SORTEAR CARTAS";
            botaoSortear.UseVisualStyleBackColor = false;
            botaoSortear.Click += botaoSortear_Click;
            // 
            // lblCartasMaquina
            // 
            lblCartasMaquina.BackColor = Color.FromArgb(119, 46, 158);
            lblCartasMaquina.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCartasMaquina.ForeColor = Color.DarkSlateBlue;
            lblCartasMaquina.Image = Properties.Resources.ImagemFundoResources;
            lblCartasMaquina.Location = new Point(689, 46);
            lblCartasMaquina.Name = "lblCartasMaquina";
            lblCartasMaquina.Size = new Size(52, 54);
            lblCartasMaquina.TabIndex = 2;
            lblCartasMaquina.Text = " ";
            lblCartasMaquina.TextAlign = ContentAlignment.MiddleCenter;
            lblCartasMaquina.UseCompatibleTextRendering = true;
            // 
            // lblCartasJogador
            // 
            lblCartasJogador.BackColor = Color.FromArgb(119, 46, 158);
            lblCartasJogador.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCartasJogador.ForeColor = Color.DarkSlateBlue;
            lblCartasJogador.Image = Properties.Resources.ImagemFundoResources;
            lblCartasJogador.Location = new Point(329, 46);
            lblCartasJogador.Name = "lblCartasJogador";
            lblCartasJogador.Size = new Size(52, 54);
            lblCartasJogador.TabIndex = 2;
            lblCartasJogador.Text = " ";
            lblCartasJogador.TextAlign = ContentAlignment.MiddleCenter;
            lblCartasJogador.UseCompatibleTextRendering = true;
            // 
            // botaoComparar
            // 
            botaoComparar.BackColor = Color.DarkSlateBlue;
            botaoComparar.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            botaoComparar.BackgroundImageLayout = ImageLayout.Stretch;
            botaoComparar.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botaoComparar.ForeColor = Color.DarkSlateBlue;
            botaoComparar.Location = new Point(403, 318);
            botaoComparar.Name = "botaoComparar";
            botaoComparar.Size = new Size(122, 52);
            botaoComparar.TabIndex = 4;
            botaoComparar.Text = "COMPARAR CARTAS";
            botaoComparar.UseVisualStyleBackColor = false;
            botaoComparar.Click += botaoComparar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlText;
            pictureBox1.BackgroundImage = Properties.Resources.cartaVerso2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(175, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlText;
            pictureBox2.BackgroundImage = Properties.Resources.cartaVerso2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(540, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 295);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Atributo1
            // 
            Atributo1.BackColor = SystemColors.ControlText;
            Atributo1.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            Atributo1.BackgroundImageLayout = ImageLayout.Stretch;
            Atributo1.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Atributo1.ForeColor = Color.DarkSlateBlue;
            Atributo1.Location = new Point(12, 119);
            Atributo1.Name = "Atributo1";
            Atributo1.Size = new Size(147, 52);
            Atributo1.TabIndex = 7;
            Atributo1.TabStop = true;
            Atributo1.Text = "VELOCIDADE MAXIMA";
            Atributo1.TextAlign = ContentAlignment.MiddleCenter;
            Atributo1.UseVisualStyleBackColor = false;
            // 
            // Atributo2
            // 
            Atributo2.BackColor = SystemColors.ControlText;
            Atributo2.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            Atributo2.BackgroundImageLayout = ImageLayout.Stretch;
            Atributo2.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Atributo2.ForeColor = Color.DarkSlateBlue;
            Atributo2.Location = new Point(12, 177);
            Atributo2.Name = "Atributo2";
            Atributo2.Size = new Size(114, 37);
            Atributo2.TabIndex = 8;
            Atributo2.TabStop = true;
            Atributo2.Text = "POTENCIA";
            Atributo2.TextAlign = ContentAlignment.MiddleCenter;
            Atributo2.UseVisualStyleBackColor = false;
            // 
            // Atributo3
            // 
            Atributo3.BackColor = SystemColors.ControlText;
            Atributo3.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            Atributo3.BackgroundImageLayout = ImageLayout.Stretch;
            Atributo3.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Atributo3.ForeColor = Color.DarkSlateBlue;
            Atributo3.Location = new Point(12, 220);
            Atributo3.Name = "Atributo3";
            Atributo3.Size = new Size(78, 37);
            Atributo3.TabIndex = 9;
            Atributo3.TabStop = true;
            Atributo3.Text = "PESO";
            Atributo3.TextAlign = ContentAlignment.MiddleCenter;
            Atributo3.UseVisualStyleBackColor = false;
            // 
            // Atributo4
            // 
            Atributo4.BackColor = SystemColors.ControlText;
            Atributo4.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            Atributo4.BackgroundImageLayout = ImageLayout.Stretch;
            Atributo4.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Atributo4.ForeColor = Color.DarkSlateBlue;
            Atributo4.Location = new Point(12, 263);
            Atributo4.Name = "Atributo4";
            Atributo4.Size = new Size(98, 37);
            Atributo4.TabIndex = 10;
            Atributo4.TabStop = true;
            Atributo4.Text = "TORQUE";
            Atributo4.TextAlign = ContentAlignment.MiddleCenter;
            Atributo4.UseVisualStyleBackColor = false;
            // 
            // botaoSortearJogada
            // 
            botaoSortearJogada.BackColor = Color.DarkSlateBlue;
            botaoSortearJogada.BackgroundImage = Properties.Resources.ImagemFundoResources2;
            botaoSortearJogada.BackgroundImageLayout = ImageLayout.Stretch;
            botaoSortearJogada.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botaoSortearJogada.ForeColor = Color.DarkSlateBlue;
            botaoSortearJogada.Location = new Point(403, 236);
            botaoSortearJogada.Name = "botaoSortearJogada";
            botaoSortearJogada.Size = new Size(122, 55);
            botaoSortearJogada.TabIndex = 11;
            botaoSortearJogada.Text = "MOSTRAR CARTAS";
            botaoSortearJogada.UseVisualStyleBackColor = false;
            botaoSortearJogada.Click += botaoSortearJogada_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(119, 46, 158);
            label1.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Image = Properties.Resources.ImagemFundoResources;
            label1.Location = new Point(540, 46);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(127, 54);
            label1.TabIndex = 12;
            label1.Text = "CARTAS MÁQUINA";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(119, 46, 158);
            label2.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Image = Properties.Resources.ImagemFundoResources;
            label2.Location = new Point(175, 46);
            label2.Name = "label2";
            label2.Size = new Size(127, 54);
            label2.TabIndex = 13;
            label2.Text = "CARTAS JOGADOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.ImagemCarrosFundo__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botaoSortearJogada);
            Controls.Add(Atributo4);
            Controls.Add(Atributo3);
            Controls.Add(Atributo2);
            Controls.Add(Atributo1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(botaoComparar);
            Controls.Add(lblCartasJogador);
            Controls.Add(lblCartasMaquina);
            Controls.Add(botaoSortear);
            ForeColor = Color.DarkSlateBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botaoSortear;
        private Label lblCartasMaquina;
        private Label lblCartasJogador;
        private Button botaoComparar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RadioButton Atributo1;
        private RadioButton Atributo2;
        private RadioButton Atributo3;
        private RadioButton Atributo4;
        private Button botaoSortearJogada;
        private Label label1;
        private Label label2;
    }
}