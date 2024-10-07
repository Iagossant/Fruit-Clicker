namespace Fruit_Clicker
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnUpgrade2 = new System.Windows.Forms.Button();
            this.lblLevel2 = new System.Windows.Forms.Label();
            this.lblPreco2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUpgrade1 = new System.Windows.Forms.Button();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.lblPreco1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPonto = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnConquista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFruit = new System.Windows.Forms.PictureBox();
            this.pnlLoja = new System.Windows.Forms.Panel();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnSkin = new System.Windows.Forms.Button();
            this.pnlUp.SuspendLayout();
            this.btnUpgrade2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.btnUpgrade1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).BeginInit();
            this.pnlLoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.White;
            this.pnlUp.Controls.Add(this.btnUpgrade2);
            this.pnlUp.Controls.Add(this.btnUpgrade1);
            this.pnlUp.Enabled = false;
            this.pnlUp.Location = new System.Drawing.Point(541, 249);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(257, 115);
            this.pnlUp.TabIndex = 1;
            this.pnlUp.Visible = false;
            // 
            // btnUpgrade2
            // 
            this.btnUpgrade2.Controls.Add(this.lblLevel2);
            this.btnUpgrade2.Controls.Add(this.lblPreco2);
            this.btnUpgrade2.Controls.Add(this.pictureBox3);
            this.btnUpgrade2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgrade2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade2.Location = new System.Drawing.Point(24, 60);
            this.btnUpgrade2.Name = "btnUpgrade2";
            this.btnUpgrade2.Size = new System.Drawing.Size(208, 51);
            this.btnUpgrade2.TabIndex = 1;
            this.btnUpgrade2.Text = "+1 POR SEGUNDO";
            this.btnUpgrade2.UseVisualStyleBackColor = true;
            this.btnUpgrade2.Click += new System.EventHandler(this.btnUpgradeTimer_Click);
            // 
            // lblLevel2
            // 
            this.lblLevel2.AutoSize = true;
            this.lblLevel2.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel2.Location = new System.Drawing.Point(4, 3);
            this.lblLevel2.Name = "lblLevel2";
            this.lblLevel2.Size = new System.Drawing.Size(49, 13);
            this.lblLevel2.TabIndex = 2;
            this.lblLevel2.Text = "Level 1";
            // 
            // lblPreco2
            // 
            this.lblPreco2.AutoSize = true;
            this.lblPreco2.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco2.Location = new System.Drawing.Point(30, 33);
            this.lblPreco2.Name = "lblPreco2";
            this.lblPreco2.Size = new System.Drawing.Size(21, 13);
            this.lblPreco2.TabIndex = 1;
            this.lblPreco2.Text = "20";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Fruit_Clicker.Properties.Resources.Pontos;
            this.pictureBox3.Location = new System.Drawing.Point(8, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnUpgrade1
            // 
            this.btnUpgrade1.Controls.Add(this.lblLevel1);
            this.btnUpgrade1.Controls.Add(this.lblPreco1);
            this.btnUpgrade1.Controls.Add(this.pictureBox2);
            this.btnUpgrade1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgrade1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade1.Location = new System.Drawing.Point(24, 3);
            this.btnUpgrade1.Name = "btnUpgrade1";
            this.btnUpgrade1.Size = new System.Drawing.Size(208, 51);
            this.btnUpgrade1.TabIndex = 0;
            this.btnUpgrade1.Text = "+1 POR CLIQUE";
            this.btnUpgrade1.UseVisualStyleBackColor = true;
            this.btnUpgrade1.Click += new System.EventHandler(this.btnUpgradeClick_Click);
            // 
            // lblLevel1
            // 
            this.lblLevel1.AutoSize = true;
            this.lblLevel1.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel1.Location = new System.Drawing.Point(4, 3);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(49, 13);
            this.lblLevel1.TabIndex = 2;
            this.lblLevel1.Text = "Level 1";
            // 
            // lblPreco1
            // 
            this.lblPreco1.AutoSize = true;
            this.lblPreco1.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco1.Location = new System.Drawing.Point(30, 33);
            this.lblPreco1.Name = "lblPreco1";
            this.lblPreco1.Size = new System.Drawing.Size(21, 13);
            this.lblPreco1.TabIndex = 1;
            this.lblPreco1.Text = "20";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Fruit_Clicker.Properties.Resources.Pontos;
            this.pictureBox2.Location = new System.Drawing.Point(8, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.BackColor = System.Drawing.Color.Transparent;
            this.lblPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto.Location = new System.Drawing.Point(93, 34);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(25, 25);
            this.lblPonto.TabIndex = 2;
            this.lblPonto.Text = "0";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Snow;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(17, 397);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 32);
            this.btnUp.TabIndex = 3;
            this.btnUp.Tag = "Upgrade";
            this.btnUp.Text = "Upgrade";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.Interface_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.BackColor = System.Drawing.Color.Snow;
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoja.Location = new System.Drawing.Point(98, 397);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(75, 32);
            this.btnLoja.TabIndex = 4;
            this.btnLoja.Tag = "Loja";
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = false;
            this.btnLoja.Click += new System.EventHandler(this.Interface_Click);
            // 
            // btnConquista
            // 
            this.btnConquista.BackColor = System.Drawing.Color.Snow;
            this.btnConquista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConquista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConquista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConquista.Location = new System.Drawing.Point(179, 397);
            this.btnConquista.Name = "btnConquista";
            this.btnConquista.Size = new System.Drawing.Size(86, 32);
            this.btnConquista.TabIndex = 5;
            this.btnConquista.Tag = "Conquistas";
            this.btnConquista.Text = "Conquistas";
            this.btnConquista.UseVisualStyleBackColor = false;
            this.btnConquista.Click += new System.EventHandler(this.Interface_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Fruit_Clicker.Properties.Resources.Pontos;
            this.pictureBox1.Location = new System.Drawing.Point(42, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbFruit
            // 
            this.pbFruit.BackColor = System.Drawing.Color.Transparent;
            this.pbFruit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFruit.Image = global::Fruit_Clicker.Properties.Resources.Semente;
            this.pbFruit.Location = new System.Drawing.Point(279, 91);
            this.pbFruit.Name = "pbFruit";
            this.pbFruit.Size = new System.Drawing.Size(200, 200);
            this.pbFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFruit.TabIndex = 0;
            this.pbFruit.TabStop = false;
            this.pbFruit.Click += new System.EventHandler(this.pbFruit_Click);
            // 
            // pnlLoja
            // 
            this.pnlLoja.BackColor = System.Drawing.Color.White;
            this.pnlLoja.Controls.Add(this.btnBackground);
            this.pnlLoja.Controls.Add(this.btnSkin);
            this.pnlLoja.Enabled = false;
            this.pnlLoja.Location = new System.Drawing.Point(541, 136);
            this.pnlLoja.Name = "pnlLoja";
            this.pnlLoja.Size = new System.Drawing.Size(257, 107);
            this.pnlLoja.TabIndex = 1;
            this.pnlLoja.Visible = false;
            // 
            // btnBackground
            // 
            this.btnBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackground.Location = new System.Drawing.Point(139, 3);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(100, 100);
            this.btnBackground.TabIndex = 1;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // btnSkin
            // 
            this.btnSkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkin.Location = new System.Drawing.Point(17, 3);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(100, 100);
            this.btnSkin.TabIndex = 0;
            this.btnSkin.Text = "Skin";
            this.btnSkin.UseVisualStyleBackColor = true;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fruit_Clicker.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConquista);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblPonto);
            this.Controls.Add(this.pnlLoja);
            this.Controls.Add(this.pnlUp);
            this.Controls.Add(this.pbFruit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Clicker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Index_FormClosed);
            this.pnlUp.ResumeLayout(false);
            this.btnUpgrade2.ResumeLayout(false);
            this.btnUpgrade2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.btnUpgrade1.ResumeLayout(false);
            this.btnUpgrade1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).EndInit();
            this.pnlLoja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlUp;
        public System.Windows.Forms.PictureBox pbFruit;
        public System.Windows.Forms.Label lblPonto;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnConquista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpgrade1;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnSkin;
        public System.Windows.Forms.Button btnLoja;
        public System.Windows.Forms.Panel pnlLoja;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUpgrade2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lblLevel2;
        public System.Windows.Forms.Label lblPreco2;
        public System.Windows.Forms.Label lblPreco1;
        public System.Windows.Forms.Label lblLevel1;
    }
}

