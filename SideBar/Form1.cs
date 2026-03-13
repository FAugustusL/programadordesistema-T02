using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBar
{
    public partial class frmSideBar : Form
    {
        bool sidebarExpand;
        bool homeCollapse;
        public frmSideBar()
        {
            InitializeComponent();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {

            // recolher 
            if (sidebarExpand)
            {
                flSideBar.Width -= 10;

               
                if (flSideBar.Width <= flSideBar.MinimumSize.Width)
                {
                    flSideBar.Width = flSideBar.MinimumSize.Width; 
                    sidebarExpand = false;                    
                    SideBarTimer.Stop();
                }
            }
           // expandir
            else
            {
                flSideBar.Width += 30;

             
                if (flSideBar.Width >= flSideBar.MaximumSize.Width)
                {
                    flSideBar.Width = flSideBar.MaximumSize.Width;
                    sidebarExpand = true;                    
                    SideBarTimer.Stop();
                }
            }
        }

        private void pbMenuButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }


        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            //expandir
            if (homeCollapse)
            {
                panelHomeContainer.Height += 10;

                if (panelHomeContainer.Height >= panelHomeContainer.MaximumSize.Height)
                {

                    panelHomeContainer.Height = panelHomeContainer.MaximumSize.Height;
                    homeCollapse = false; 
                    HomeTimer.Stop();

                }
            }

            //recolher
            else
            {
                panelHomeContainer.Height -= 10;

                if (panelHomeContainer.Height <= flSideBar.MinimumSize.Height)
                {

                    panelHomeContainer.Height = panelHomeContainer.MinimumSize.Height;
                    homeCollapse = true; 
                    HomeTimer.Stop();

                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();

            if (sender is Button btn)
            {
                lblTitulo.Text = btn.Text.Trim();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (sender is Button btn)
            {
                lblTitulo.Text = btn.Text.Trim();
            }

        }
    }
}
