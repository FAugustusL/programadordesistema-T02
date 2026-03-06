namespace tabuadacomloop
{
    partial class frmTabuadaLoop
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.btnExecutarTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.panelFundo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Cyan;
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.panel1);
            this.panelFundo.Controls.Add(this.panelEsquerda);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(800, 585);
            this.panelFundo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExecutarTabuada);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(426, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 375);
            this.panel1.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txtNumero.Location = new System.Drawing.Point(48, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(237, 62);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(75, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Insira um número";
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.PeachPuff;
            this.panelEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEsquerda.Controls.Add(this.lstTabuada);
            this.panelEsquerda.Location = new System.Drawing.Point(42, 26);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(326, 375);
            this.panelEsquerda.TabIndex = 0;
            // 
            // btnExecutarTabuada
            // 
            this.btnExecutarTabuada.BackColor = System.Drawing.Color.Cyan;
            this.btnExecutarTabuada.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExecutarTabuada.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarTabuada.Location = new System.Drawing.Point(48, 248);
            this.btnExecutarTabuada.Name = "btnExecutarTabuada";
            this.btnExecutarTabuada.Size = new System.Drawing.Size(237, 97);
            this.btnExecutarTabuada.TabIndex = 4;
            this.btnExecutarTabuada.Text = "Executar Tabuada";
            this.btnExecutarTabuada.UseVisualStyleBackColor = false;
            this.btnExecutarTabuada.Click += new System.EventHandler(this.btnExecutarTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 25;
            this.lstTabuada.Location = new System.Drawing.Point(19, 26);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(285, 329);
            this.lstTabuada.TabIndex = 2;
            // 
            // frmTabuadaLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.panelFundo);
            this.Name = "frmTabuadaLoop";
            this.Text = "Tabuada com Loop";
            this.panelFundo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEsquerda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnExecutarTabuada;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}

