namespace teladelogin_ninelives
{
    partial class frmResetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConfirmsenha = new System.Windows.Forms.Label();
            this.btnRegistrarnovasenha = new System.Windows.Forms.Button();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarnovasenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidarCodigo = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.lblTextConfirmation = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConfirmsenha);
            this.panel1.Controls.Add(this.btnRegistrarnovasenha);
            this.panel1.Controls.Add(this.txtNovaSenha);
            this.panel1.Controls.Add(this.txtConfirmarnovasenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnValidarCodigo);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.lblEnterEmail);
            this.panel1.Controls.Add(this.lblTextConfirmation);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Location = new System.Drawing.Point(74, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 435);
            this.panel1.TabIndex = 5;
            // 
            // lblConfirmsenha
            // 
            this.lblConfirmsenha.AutoSize = true;
            this.lblConfirmsenha.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.lblConfirmsenha.Location = new System.Drawing.Point(211, 306);
            this.lblConfirmsenha.Name = "lblConfirmsenha";
            this.lblConfirmsenha.Size = new System.Drawing.Size(0, 16);
            this.lblConfirmsenha.TabIndex = 17;
            // 
            // btnRegistrarnovasenha
            // 
            this.btnRegistrarnovasenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnRegistrarnovasenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarnovasenha.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btnRegistrarnovasenha.Location = new System.Drawing.Point(285, 377);
            this.btnRegistrarnovasenha.Name = "btnRegistrarnovasenha";
            this.btnRegistrarnovasenha.Size = new System.Drawing.Size(88, 27);
            this.btnRegistrarnovasenha.TabIndex = 15;
            this.btnRegistrarnovasenha.Text = "ENTER";
            this.btnRegistrarnovasenha.UseVisualStyleBackColor = false;
            this.btnRegistrarnovasenha.Visible = false;
            this.btnRegistrarnovasenha.Click += new System.EventHandler(this.btnRegistrarnovasenha_Click);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.Color.Black;
            this.txtNovaSenha.Location = new System.Drawing.Point(214, 241);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(226, 22);
            this.txtNovaSenha.TabIndex = 14;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            this.txtNovaSenha.Visible = false;
            // 
            // txtConfirmarnovasenha
            // 
            this.txtConfirmarnovasenha.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarnovasenha.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmarnovasenha.Location = new System.Drawing.Point(214, 281);
            this.txtConfirmarnovasenha.Name = "txtConfirmarnovasenha";
            this.txtConfirmarnovasenha.Size = new System.Drawing.Size(226, 22);
            this.txtConfirmarnovasenha.TabIndex = 13;
            this.txtConfirmarnovasenha.UseSystemPasswordChar = true;
            this.txtConfirmarnovasenha.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(201, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter the code was receive in email";
            // 
            // btnValidarCodigo
            // 
            this.btnValidarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnValidarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidarCodigo.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btnValidarCodigo.Location = new System.Drawing.Point(475, 123);
            this.btnValidarCodigo.Name = "btnValidarCodigo";
            this.btnValidarCodigo.Size = new System.Drawing.Size(88, 27);
            this.btnValidarCodigo.TabIndex = 11;
            this.btnValidarCodigo.Text = "ENTER";
            this.btnValidarCodigo.UseVisualStyleBackColor = false;
            this.btnValidarCodigo.Click += new System.EventHandler(this.btnValidarCodigo_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.lblCode.Location = new System.Drawing.Point(201, 164);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 16);
            this.lblCode.TabIndex = 10;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(204, 128);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(226, 22);
            this.txtCode.TabIndex = 9;
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.AutoSize = true;
            this.lblEnterEmail.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.lblEnterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.lblEnterEmail.Location = new System.Drawing.Point(211, 12);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(194, 17);
            this.lblEnterEmail.TabIndex = 8;
            this.lblEnterEmail.Text = "Enter your email or username";
            // 
            // lblTextConfirmation
            // 
            this.lblTextConfirmation.AutoSize = true;
            this.lblTextConfirmation.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.lblTextConfirmation.Location = new System.Drawing.Point(201, 60);
            this.lblTextConfirmation.Name = "lblTextConfirmation";
            this.lblTextConfirmation.Size = new System.Drawing.Size(0, 16);
            this.lblTextConfirmation.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(204, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::teladelogin_ninelives.Properties.Resources._142_Sem_Título_20260316153511__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btnEnter.Location = new System.Drawing.Point(475, 27);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(88, 27);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1012, 614);
            this.Controls.Add(this.panel1);
            this.Name = "frmResetPassword";
            this.Text = "Reset Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.Label lblTextConfirmation;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidarCodigo;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmarnovasenha;
        private System.Windows.Forms.Button btnRegistrarnovasenha;
        private System.Windows.Forms.Label lblConfirmsenha;
    }
}