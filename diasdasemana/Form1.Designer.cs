namespace diasdasemana
{
    partial class frmDiasDaSemana
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblDigite = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picBrilho = new System.Windows.Forms.PictureBox();
            this.picRosa = new System.Windows.Forms.PictureBox();
            this.picSol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(329, 102);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 47);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigite.ForeColor = System.Drawing.Color.Indigo;
            this.lblDigite.Location = new System.Drawing.Point(142, 9);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(474, 37);
            this.lblDigite.TabIndex = 1;
            this.lblDigite.Text = "Digite o número da semana equivalente a hoje";
            // 
            // lblDia
            // 
            this.lblDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDia.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Indigo;
            this.lblDia.Location = new System.Drawing.Point(149, 167);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(459, 76);
            this.lblDia.TabIndex = 2;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Cyan;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.Indigo;
            this.btnProcurar.Location = new System.Drawing.Point(316, 257);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(126, 35);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Pressione";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProcurar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(232, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lembre-se que a semana começa no Domingo";
            // 
            // picBrilho
            // 
            this.picBrilho.Image = global::diasdasemana.Properties.Resources.Designer__3_;
            this.picBrilho.Location = new System.Drawing.Point(-5, 45);
            this.picBrilho.Name = "picBrilho";
            this.picBrilho.Size = new System.Drawing.Size(141, 135);
            this.picBrilho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrilho.TabIndex = 7;
            this.picBrilho.TabStop = false;
            // 
            // picRosa
            // 
            this.picRosa.Image = global::diasdasemana.Properties.Resources.Designer__2_;
            this.picRosa.Location = new System.Drawing.Point(511, 276);
            this.picRosa.Name = "picRosa";
            this.picRosa.Size = new System.Drawing.Size(177, 183);
            this.picRosa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRosa.TabIndex = 6;
            this.picRosa.TabStop = false;
            // 
            // picSol
            // 
            this.picSol.Image = global::diasdasemana.Properties.Resources.Designer__1_;
            this.picSol.Location = new System.Drawing.Point(622, 9);
            this.picSol.Name = "picSol";
            this.picSol.Size = new System.Drawing.Size(186, 174);
            this.picSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSol.TabIndex = 5;
            this.picSol.TabStop = false;
            // 
            // frmDiasDaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBrilho);
            this.Controls.Add(this.picRosa);
            this.Controls.Add(this.picSol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmDiasDaSemana";
            this.Text = "Dias da semana";
            ((System.ComponentModel.ISupportInitialize)(this.picBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSol;
        private System.Windows.Forms.PictureBox picRosa;
        private System.Windows.Forms.PictureBox picBrilho;
    }
}

