using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teladelogin_ninelives
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblRedefinir_Click(object sender, EventArgs e)
        {
            frmResetPassword form = new frmResetPassword();
            form.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmRegistration form = new frmRegistration();
            form.Show();
            this.Hide();

        }
    }
}
