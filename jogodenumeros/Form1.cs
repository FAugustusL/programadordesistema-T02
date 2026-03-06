using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogoNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogoNumeros()
        {
            InitializeComponent();
        }



        private void frmJogoNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); // numero aleatório entre 1 a 100

        }

        private void btnTentativa_Click(object sender, EventArgs e)
        {
            if (jogoGanho)
            {
                txtResultado.Text = "Você já acertou o número! Reinicie o jogo para jogar novamente";
                return;
            }
            if (numeroTentativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou";
                return;
            }
            if (int.TryParse(txtNumeroInserido.Text, out palpitedoJogador) || palpitedoJogador < 1 || palpitedoJogador > 100)
            {
                txtResultado.Text = "Por favor, insira um número entre 1 e 100";
                return;
            }

            numeroTentativas--;
            lblNumerosTentativas.Text = numeroTentativas.ToString();
        }
    }
}
