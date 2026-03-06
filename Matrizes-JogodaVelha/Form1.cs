using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrizes_JogodaVelha
{
    public partial class frmJogoDaVelha : Form
    {
        private char?[,] tab = new char?[3, 3];
        bool vezDox;
        int jogadas;
        bool jogoEncerrado;

        public frmJogoDaVelha()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado)
            {
                return;
            }

            Button btn = (Button)sender;
            if (btn.Text != "")

            {
                return;
            }

            btn.Text = vezDox ? "X" : "O";
            jogadas++;

            if (VerificarVencedor())
            {
                lblStatus.Text = $"Jogador {(vezDox ? "X" : "O")} venceu!";
                jogoEncerrado = true;
            }
            else if (jogadas == 9)
            {
                lblStatus.Text = "Empate";
                jogoEncerrado = true;
            }

            else
            {
                vezDox = !vezDox;
                lblStatus.Text = $"Vez do jogador {(vezDox ? "X" : "O")}";
            }
        }
        private bool VerificarVencedor()
        {
            string[,] matriz = new string[3, 3]
            {
                { btn1.Text, btn2.Text, btn3.Text },
                { btn4.Text, btn5.Text, btn6.Text },
                { btn7.Text, btn8.Text, btn9.Text }
            };

            for (int i = 0; i < 3; i++) //linhas e colunas
            {
                if (matriz[i, 0] != "" && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2]) return true;
                if (matriz[0, i] != "" && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i]) return true;
            }
            // diagonais
            if (matriz[0, 0] != "" && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2]) return true;
            if (matriz[0, 2] != "" && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0]) return true;

            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is Button btn && btn.Name != "btnReset")
                    btn.Text = string.Empty;
            }

            vezDox = false;
            jogadas = 0;
            jogoEncerrado = false;
            lblStatus.Text = "vez do jogador O ";

        }
    }
}

    