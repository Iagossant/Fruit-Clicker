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
            this.btnUpgradeTimer = new System.Windows.Forms.Button();
            this.btnUpgradeClick = new System.Windows.Forms.Button();
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
            this.pnlUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlUp.Controls.Add(this.btnUpgradeTimer);
            this.pnlUp.Controls.Add(this.btnUpgradeClick);
            this.pnlUp.Enabled = false;
            this.pnlUp.Location = new System.Drawing.Point(541, 249);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(257, 102);
            this.pnlUp.TabIndex = 1;
            this.pnlUp.Visible = false;
            // 
            // btnUpgradeTimer
            // 
            this.btnUpgradeTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgradeTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgradeTimer.Location = new System.Drawing.Point(87, 53);
            this.btnUpgradeTimer.Name = "btnUpgradeTimer";
            this.btnUpgradeTimer.Size = new System.Drawing.Size(75, 23);
            this.btnUpgradeTimer.TabIndex = 1;
            this.btnUpgradeTimer.Text = "20";
            this.btnUpgradeTimer.UseVisualStyleBackColor = true;
            this.btnUpgradeTimer.Click += new System.EventHandler(this.btnUpgradeTimer_Click);
            // 
            // btnUpgradeClick
            // 
            this.btnUpgradeClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgradeClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgradeClick.Location = new System.Drawing.Point(87, 24);
            this.btnUpgradeClick.Name = "btnUpgradeClick";
            this.btnUpgradeClick.Size = new System.Drawing.Size(75, 23);
            this.btnUpgradeClick.TabIndex = 0;
            this.btnUpgradeClick.Text = "20";
            this.btnUpgradeClick.UseVisualStyleBackColor = true;
            this.btnUpgradeClick.Click += new System.EventHandler(this.btnUpgradeClick_Click);
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
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(17, 397);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 32);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Upgrade";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Location = new System.Drawing.Point(98, 397);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(75, 32);
            this.btnLoja.TabIndex = 4;
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnConquista
            // 
            this.btnConquista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConquista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConquista.Location = new System.Drawing.Point(179, 397);
            this.btnConquista.Name = "btnConquista";
            this.btnConquista.Size = new System.Drawing.Size(75, 32);
            this.btnConquista.TabIndex = 5;
            this.btnConquista.Text = "Conquistas";
            this.btnConquista.UseVisualStyleBackColor = true;
            this.btnConquista.Click += new System.EventHandler(this.btnConquista_Click);
            // 
            // pictureBox1
            // 
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
            this.pbFruit.Location = new System.Drawing.Point(279, 74);
            this.pbFruit.Name = "pbFruit";
            this.pbFruit.Size = new System.Drawing.Size(200, 200);
            this.pbFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFruit.TabIndex = 0;
            this.pbFruit.TabStop = false;
            this.pbFruit.Click += new System.EventHandler(this.pbFruit_Click);
            // 
            // pnlLoja
            // 
            this.pnlLoja.BackColor = System.Drawing.Color.Transparent;
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
        private System.Windows.Forms.Button btnUpgradeTimer;
        private System.Windows.Forms.Button btnUpgradeClick;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnSkin;
        public System.Windows.Forms.Button btnLoja;
        public System.Windows.Forms.Panel pnlLoja;
    }
}

