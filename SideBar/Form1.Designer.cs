namespace SideBar
{
    partial class frmSideBar
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbMenuButton = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelHomeContainer = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSubHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.flSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).BeginInit();
            this.panelHomeContainer.SuspendLayout();
            this.flSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.pbMenuButton);
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 117);
            this.panelMenu.TabIndex = 1;
            // 
            // pbMenuButton
            // 
            this.pbMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenuButton.Image = global::SideBar.Properties.Resources.menu_37dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.pbMenuButton.Location = new System.Drawing.Point(18, 34);
            this.pbMenuButton.Name = "pbMenuButton";
            this.pbMenuButton.Size = new System.Drawing.Size(46, 41);
            this.pbMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuButton.TabIndex = 0;
            this.pbMenuButton.TabStop = false;
            this.pbMenuButton.Click += new System.EventHandler(this.pbMenuButton_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMenu.Location = new System.Drawing.Point(79, 40);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(83, 30);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 30;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // panelHomeContainer
            // 
            this.panelHomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.panelHomeContainer.Controls.Add(this.btnHome);
            this.panelHomeContainer.Controls.Add(this.btnSubHome);
            this.panelHomeContainer.Location = new System.Drawing.Point(3, 126);
            this.panelHomeContainer.MaximumSize = new System.Drawing.Size(246, 124);
            this.panelHomeContainer.MinimumSize = new System.Drawing.Size(246, 66);
            this.panelHomeContainer.Name = "panelHomeContainer";
            this.panelHomeContainer.Size = new System.Drawing.Size(246, 66);
            this.panelHomeContainer.TabIndex = 7;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::SideBar.Properties.Resources.home_37dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(246, 63);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSubHome
            // 
            this.btnSubHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.btnSubHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubHome.FlatAppearance.BorderSize = 0;
            this.btnSubHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHome.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubHome.ForeColor = System.Drawing.Color.Black;
            this.btnSubHome.Image = global::SideBar.Properties.Resources.radio_button_checked_33dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.btnSubHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHome.Location = new System.Drawing.Point(0, 62);
            this.btnSubHome.Name = "btnSubHome";
            this.btnSubHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubHome.Size = new System.Drawing.Size(246, 62);
            this.btnSubHome.TabIndex = 8;
            this.btnSubHome.Text = "         Sub Home";
            this.btnSubHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHome.UseVisualStyleBackColor = false;
            this.btnSubHome.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::SideBar.Properties.Resources.settings_37dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 198);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSettings.Size = new System.Drawing.Size(246, 62);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "         Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Image = global::SideBar.Properties.Resources.home_health_37dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(3, 334);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAbout.Size = new System.Drawing.Size(246, 62);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "         About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Image = global::SideBar.Properties.Resources.help_37dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(3, 266);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHelp.Size = new System.Drawing.Size(246, 62);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "         Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btn_Click);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 1;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // flSideBar
            // 
            this.flSideBar.BackColor = System.Drawing.Color.OrangeRed;
            this.flSideBar.Controls.Add(this.panelMenu);
            this.flSideBar.Controls.Add(this.panelHomeContainer);
            this.flSideBar.Controls.Add(this.btnSettings);
            this.flSideBar.Controls.Add(this.btnHelp);
            this.flSideBar.Controls.Add(this.btnAbout);
            this.flSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flSideBar.Location = new System.Drawing.Point(0, 0);
            this.flSideBar.MaximumSize = new System.Drawing.Size(256, 2000);
            this.flSideBar.MinimumSize = new System.Drawing.Size(80, 2000);
            this.flSideBar.Name = "flSideBar";
            this.flSideBar.Size = new System.Drawing.Size(256, 2000);
            this.flSideBar.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(256, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 62);
            this.lblTitulo.TabIndex = 8;
            // 
            // frmSideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1019, 774);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flSideBar);
            this.Name = "frmSideBar";
            this.Text = "Side Bar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).EndInit();
            this.panelHomeContainer.ResumeLayout(false);
            this.flSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pbMenuButton;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Panel panelHomeContainer;
        private System.Windows.Forms.Button btnSubHome;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.FlowLayoutPanel flSideBar;
        private System.Windows.Forms.Label lblTitulo;
    }
}

