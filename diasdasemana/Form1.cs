using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diasdasemana
{
    public partial class frmDiasDaSemana : Form
    {
        public frmDiasDaSemana()
        {
            InitializeComponent();
        }

        private void btnProcurar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var numero = Convert.ToInt16(txtNumero.Text);
                lblDia.Text = semana(numero);
            }

            catch
            {
                MessageBox.Show("Digite um número válido");
            }
        }
        private string semana(int numero)
        {
            var dia = "";

            switch (numero)
            {
                case 1:
                    dia = "Domingo: dia de renovar as energias e preparar o coração para a próxima semana.";
                    break;

                case 2:
                    dia = "Segunda-feira: dia de recomeçar e colocar a vida nos trilhos.";
                    break;

                case 3:
                    dia = "Terça-feira: dia de manter o foco e acelerar o passo.";
                    break;

                case 4:
                    dia = "Quarta-feira: dia de seguir firme, você já chegou na metade.";
                    break;

                case 5:
                    dia = "Quinta-feira: dia de ajustar o que falta e continuar avançando.";
                    break;

                case 6:
                    dia = "Sexta-feira: dia de finalizar bem e agradecer pela semana.";
                    break;
                case 7:
                    dia = "Sábado: dia de descansar a mente e aproveitar o momento";
                    break;

                default:
                    dia = "Inválido";
                    break;

            }

            return dia;
        }
    }
}
        
    
