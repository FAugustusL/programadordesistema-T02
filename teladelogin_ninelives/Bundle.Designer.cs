namespace teladelogin_ninelives
{
    partial class frmBundle
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstBook = new System.Windows.Forms.ListView();
            this.lstBookBundle = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstBook
            // 
            this.lstBook.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBook.HideSelection = false;
            this.lstBook.Location = new System.Drawing.Point(26, 259);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(685, 383);
            this.lstBook.TabIndex = 1;
            this.lstBook.UseCompatibleStateImageBehavior = false;
            // 
            // lstBookBundle
            // 
            this.lstBookBundle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.lstBookBundle.HideSelection = false;
            this.lstBookBundle.Location = new System.Drawing.Point(887, 259);
            this.lstBookBundle.Name = "lstBookBundle";
            this.lstBookBundle.Size = new System.Drawing.Size(685, 383);
            this.lstBookBundle.TabIndex = 2;
            this.lstBookBundle.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmBundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstBookBundle);
            this.Controls.Add(this.lstBook);
            this.Controls.Add(this.button1);
            this.Name = "frmBundle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bundle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstBook;
        private System.Windows.Forms.ListView lstBookBundle;
        private System.Windows.Forms.Button button2;
    }
}