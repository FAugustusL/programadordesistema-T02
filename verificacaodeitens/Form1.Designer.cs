namespace verificacaodeitens
{
    partial class frmVerEstoque
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduto5 = new System.Windows.Forms.Label();
            this.LblProduto4 = new System.Windows.Forms.Label();
            this.lblProduto3 = new System.Windows.Forms.Label();
            this.lblProduto2 = new System.Windows.Forms.Label();
            this.lblProduto1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(423, 195);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(261, 46);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(420, 118);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(267, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Insira o codigo do produto";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(498, 282);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(122, 44);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVerificar_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProduto5);
            this.panel1.Controls.Add(this.LblProduto4);
            this.panel1.Controls.Add(this.lblProduto3);
            this.panel1.Controls.Add(this.lblProduto2);
            this.panel1.Controls.Add(this.lblProduto1);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 276);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pêra: Número de produto = 0009";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Limão: Número de produto = 0008";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manga: Número de produto = 0007";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Morango: Número de produto = 0006";
            // 
            // lblProduto5
            // 
            this.lblProduto5.AutoSize = true;
            this.lblProduto5.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto5.Location = new System.Drawing.Point(10, 125);
            this.lblProduto5.Name = "lblProduto5";
            this.lblProduto5.Size = new System.Drawing.Size(178, 20);
            this.lblProduto5.TabIndex = 4;
            this.lblProduto5.Text = "Uva: Número de produto = 0005";
            // 
            // LblProduto4
            // 
            this.LblProduto4.AutoSize = true;
            this.LblProduto4.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProduto4.Location = new System.Drawing.Point(10, 98);
            this.LblProduto4.Name = "LblProduto4";
            this.LblProduto4.Size = new System.Drawing.Size(199, 20);
            this.LblProduto4.TabIndex = 3;
            this.LblProduto4.Text = "Abacaxi: Número de produto = 0004";
            // 
            // lblProduto3
            // 
            this.lblProduto3.AutoSize = true;
            this.lblProduto3.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto3.Location = new System.Drawing.Point(10, 71);
            this.lblProduto3.Name = "lblProduto3";
            this.lblProduto3.Size = new System.Drawing.Size(196, 20);
            this.lblProduto3.TabIndex = 2;
            this.lblProduto3.Text = "Laranja: Número de produto = 0003";
            // 
            // lblProduto2
            // 
            this.lblProduto2.AutoSize = true;
            this.lblProduto2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto2.Location = new System.Drawing.Point(10, 44);
            this.lblProduto2.Name = "lblProduto2";
            this.lblProduto2.Size = new System.Drawing.Size(197, 20);
            this.lblProduto2.TabIndex = 1;
            this.lblProduto2.Text = "Banana: Número de produto = 0002";
            // 
            // lblProduto1
            // 
            this.lblProduto1.AutoSize = true;
            this.lblProduto1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto1.ForeColor = System.Drawing.Color.Black;
            this.lblProduto1.Location = new System.Drawing.Point(10, 17);
            this.lblProduto1.Name = "lblProduto1";
            this.lblProduto1.Size = new System.Drawing.Size(186, 20);
            this.lblProduto1.TabIndex = 0;
            this.lblProduto1.Text = "Maçã: Número de produto = 0001";
            // 
            // frmVerEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmVerEstoque";
            this.Text = "Verificação do estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProduto2;
        private System.Windows.Forms.Label lblProduto1;
        private System.Windows.Forms.Label lblProduto5;
        private System.Windows.Forms.Label LblProduto4;
        private System.Windows.Forms.Label lblProduto3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

