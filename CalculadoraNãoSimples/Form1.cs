using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraNãoSimples
{
    public partial class frmCalculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private Operaçao OperaçaoSelecionada { get; set; }
        private enum Operaçao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao
        }
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = " ";
            lblSinal.Text = "+";

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = " ";
            lblSinal.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = " ";
            lblSinal.Text = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = " ";
            lblSinal.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperaçaoSelecionada)
            {
                case Operaçao.adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operaçao.subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operaçao.multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operaçao.divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Resultado.ToString();
            lblSinal.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " ";
            lblSinal.Text = " ";
        }
    }
}
