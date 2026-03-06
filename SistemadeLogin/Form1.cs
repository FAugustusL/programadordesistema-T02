using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SistemadeLogin
{
    public partial class frmTeladeLogin : Form
    {
        private readonly string usuario = "aaa";
        private readonly string senha = "senha123";
        private int TentativasUsadas = 0;
        private const int LimitedeTentativas = 3;
        private bool contaBloqueada = false;

        public frmTeladeLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (contaBloqueada)
            {
                MessageBox.Show("Conta bloqueada por excesso de tentativas.");
                return;
            }

            if (txtUser.Text != usuario)
            {
                MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenha.Text == senha)
            {
                MessageBox.Show("Login Concluído. Não repasse para ninguém em que não confia'!", "Parabéns, Agente Secreto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TentativasUsadas++;

            if (TentativasUsadas >= LimitedeTentativas)
            {
                ContaBloqueada();
                return;
            }

            while (TentativasUsadas >= LimitedeTentativas)
            {
                ContaBloqueada();
                return;
            }

            MessageBox.Show($"Senha incorreta! Tentativas restantes: {LimitedeTentativas - TentativasUsadas}");
            txtSenha.Clear();
            txtSenha.Focus();
        }
        private void ContaBloqueada()
        {
            contaBloqueada = true;
            btnEntrar.Enabled = false;
            MessageBox.Show("Conta bloqueada por excesso de tentativas.", "Bloqueado",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}



