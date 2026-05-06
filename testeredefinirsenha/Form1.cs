using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeredefinirsenha

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexao =
            "datasource = localhost; username=root; password=; database=teste";

        private void btnEnter_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o e-mail.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string codigo = GerarCodigo();

                SalvarCodigo(email, codigo);
                EnviarEmail(email, codigo);

                MessageBox.Show(
                    "Código enviado para o e-mail informado.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao enviar o código:" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void EnviarEmail(string emailDestino, string codigo)
        {
            using (MailMessage mail = new MailMessage())
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                mail.From = new MailAddress("ninelivest3@gmail.com", "Sistema");
                mail.To.Add(emailDestino);
                mail.Subject = "Redefinição de Senha";
                mail.Body = $"Seu código de redefinição de senha é:{codigo}" +
                            "Este código expira em 10 minutos.";

                smtp.Credentials = new NetworkCredential(
                    "ninelivest3@gmail.com",
                    "pntg rkgm kvza xvtj"
                );
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
        }
        private string GerarCodigo()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }
        private void SalvarCodigo(string email, string codigo)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string sql = @"
            INSERT INTO recuperacao_senha (email, codigo, data_expiracao)
            VALUES (@email, @codigo, DATE_ADD(NOW(), INTERVAL 10 MINUTE));
        ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}


