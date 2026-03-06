using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace verificacaodeitens
{
    public partial class frmVerEstoque : Form
    {
        private readonly Dictionary<string, int> estoque = new Dictionary<string, int>();
        public frmVerEstoque()
        {
            InitializeComponent();
        }

        private void btnVerificar_MouseClick(object sender, MouseEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, coloque o número do produto.");
                return;
            }
            int quantidade1 = 7;
            int quantidade2 = 6;
            int quantidade3 = 4;
            int quantidade4 = 15;
            int quantidade5 = 6;
            int quantidade6 = 8;
            int quantidade7 = 5;
            int quantidade8 = 6;
            int quantidade9 = 4;
            int itens = 5;
            string codigo = txtCodigo.Text;

            if (codigo == "0001")
            {
                if (quantidade1 >= itens)
                    MessageBox.Show("Quantidade Suficiente.");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0002")
            {
                if (quantidade2 >= itens)
                    MessageBox.Show("Quantidade Suficiente.");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0003")
            {
                if (quantidade3 >= itens)
                    MessageBox.Show("Quantidade Suficiente.");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0004")
            {
                if (quantidade4 >= itens)
                    MessageBox.Show("Quantidade Suficiente.");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0005")
            {
                if (quantidade5 >= itens)
                    MessageBox.Show("Quantidade Suficiente.");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0006")
            {
                if (quantidade6 >= itens)
                    MessageBox.Show("Quantidade Suficiente");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0007")
            {
                if (quantidade7 >= itens)
                    MessageBox.Show("Quantidade Suficiente");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0008")
            {
                if (quantidade8 >= itens)
                    MessageBox.Show("Quantidade Suficiente");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else if (codigo == "0009")
            {
                if (quantidade9 >= itens)
                    MessageBox.Show("Quantidade Suficiente");
                else
                    MessageBox.Show("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
            }
            else
            {
                MessageBox.Show("Número invalido, por favor selecione da tabela ao lado");
            }
        }
    }
}       
            
            
   