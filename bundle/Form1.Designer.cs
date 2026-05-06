namespace bundle
{
    partial class frmBundle
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lstBook = new System.Windows.Forms.ListView();
            this.lstBookBundle = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBook
            // 
            this.lstBook.HideSelection = false;
            this.lstBook.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstBook.Location = new System.Drawing.Point(52, 233);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(372, 160);
            this.lstBook.TabIndex = 0;
            this.lstBook.UseCompatibleStateImageBehavior = false;
            // 
            // lstBookBundle
            // 
            this.lstBookBundle.HideSelection = false;
            this.lstBookBundle.Location = new System.Drawing.Point(511, 233);
            this.lstBookBundle.Name = "lstBookBundle";
            this.lstBookBundle.Size = new System.Drawing.Size(350, 160);
            this.lstBookBundle.TabIndex = 1;
            this.lstBookBundle.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBookBundle);
            this.Controls.Add(this.lstBook);
            this.Name = "frmBundle";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBook;
        private System.Windows.Forms.ListView lstBookBundle;
        private System.Windows.Forms.Button button1;
    }
}

