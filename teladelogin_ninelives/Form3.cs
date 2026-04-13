using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace teladelogin_ninelives
{
    public partial class frmRegistration : Form
    {
        bool VisiblePassword = false;
        bool VisibleConfirmPassword = false;

        public static string Hashpassword(string password)
        {
            int iterations = 100_000;
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var pbkdf2 = new Rfc2898DeriveBytes(
                 password,
                 salt,
                 iterations,
                 HashAlgorithmName.SHA256
             );

            byte[] hash = pbkdf2.GetBytes(32);

            return $"{iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }
        MySqlConnection Conn;
        string data_source = "datasource=localhost; username=root; password=; database=ninelivebooks";
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtRole.Text.Trim()) ||
                    string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(cbStatus.Text.Trim()) ||
                    string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Conn = new MySqlConnection(data_source);

                Conn.Open();

                MySqlCommand cmd = new MySqlCommand { Connection = Conn };
                cmd.Prepare();


                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string passwordHash = Hashpassword(txtPassword.Text.Trim());



                string status = cbStatus.Text.Trim();

                if (status != "Ative" && status != "Inactive")
                {
                    MessageBox.Show("Invalid status. Use only Active or Inactive.");
                    return;
                }


                cmd.CommandText = "INSERT INTO usuario(user_name, user_role, user_email, user_status, user_password_hash, user_created_at)" +
                    "VALUES(@user_name, @user_role, @user_email, @user_status, @user_password_hash, @user_created_at)";
                cmd.Parameters.AddWithValue("@user_name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@user_role", txtRole.Text.Trim());
                cmd.Parameters.AddWithValue("@user_email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@user_status", cbStatus.Text.Trim());
                cmd.Parameters.AddWithValue("user_password_hash", passwordHash);
                cmd.Parameters.AddWithValue("@user_created_at", hoje);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration was successful.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show($"An error has occurred. Please try again. + {ex.Number} : { ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (Conn != null && Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }

        }
        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            if (VisiblePassword)
            {
                txtPassword.UseSystemPasswordChar = true;
                VisiblePassword = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                VisiblePassword = true;
            }
        }

        private void lblShowConfirmPassword_Click(object sender, EventArgs e)
        {
            if (VisiblePassword)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                VisiblePassword = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                VisibleConfirmPassword = true;
            }
        }
    }
}

