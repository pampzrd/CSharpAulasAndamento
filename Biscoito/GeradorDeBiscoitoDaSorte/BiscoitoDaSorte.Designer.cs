namespace GeradorDeBiscoitoDaSorte
{
    partial class BiscoitoDaSorte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiscoitoDaSorte));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Red;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(208, 135);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BISCOITO DA SORTE";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AllowDrop = true;
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.MistyRose;
            this.lblMensagem.Font = new System.Drawing.Font("Miriam Mono CLM", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMensagem.Location = new System.Drawing.Point(75, 197);
            this.lblMensagem.MaximumSize = new System.Drawing.Size(0, 120);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMensagem.Size = new System.Drawing.Size(110, 36);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "sorte";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblMensagem.Visible = false;
            // 
            // btnSorteio
            // 
            this.btnSorteio.BackColor = System.Drawing.Color.IndianRed;
            this.btnSorteio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSorteio.Location = new System.Drawing.Point(140, 340);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(220, 80);
            this.btnSorteio.TabIndex = 2;
            this.btnSorteio.Text = "Gerador";
            this.btnSorteio.UseVisualStyleBackColor = false;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFechar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Brown;
            this.btnFechar.Location = new System.Drawing.Point(400, 340);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(220, 80);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pic01
            // 
            this.pic01.BackColor = System.Drawing.Color.Transparent;
            this.pic01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic01.BackgroundImage")));
            this.pic01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic01.Location = new System.Drawing.Point(12, 12);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(754, 496);
            this.pic01.TabIndex = 5;
            this.pic01.TabStop = false;
            this.pic01.Click += new System.EventHandler(this.pic01_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Location = new System.Drawing.Point(60, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 120);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BiscoitoDaSorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic01);
            this.Name = "BiscoitoDaSorte";
            this.Text = "Biscoito Da Sorte";
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic01;
    }
}

