using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using static teladelogin_ninelives.frmLogin;

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


            // cbRole.Items.Clear();

           //  cbRole.Items.Add("User");

            if (Sessao.User_Role != "Administrator")
           {
                btnAdd.Visible = false;
           }
            ////////////////////////////////////////////////////
            if (Sessao.User_Role == "Administrator")
            {
                btnRegister.Visible = false;
            }
            ////////////////////////////////////////////////////
            if (Sessao.User_Role == "Administrator")
           {
                cbRole.Items.Add("Administrator");
            }

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(cbRole.Text.Trim()) ||
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


                string role = cbRole.Text.Trim();

                if (role != "Administrator" && role != "Staff")
                {
                    MessageBox.Show("Invalid status. Use only Administrator or Staff.");
                    return;
                }


                cmd.CommandText = "INSERT INTO usuario(user_name, user_role, user_email, user_status, user_password_hash, user_created_at)" +
                    "VALUES(@user_name, @user_role, @user_email, @user_status, @user_password_hash, @user_created_at)";
                cmd.Parameters.AddWithValue("@user_name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@user_role", cbRole.Text.Trim());
                cmd.Parameters.AddWithValue("@user_email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@user_status", cbStatus.Text.Trim());
                cmd.Parameters.AddWithValue("user_password_hash", passwordHash);
                cmd.Parameters.AddWithValue("@user_created_at", hoje);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration was successful.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show($"An error has occurred. Please try again. + {ex.Number} : {ex.Message}",
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



        private void lblIrLogin_Click(object sender, EventArgs e)
        {

            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAberto1_Click(object sender, EventArgs e)
        {

            if (VisibleConfirmPassword)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                picAberto1.Image = Properties.Resources.visibility_off_24dp_000000_FILL0_wght400_GRAD0_opsz24;
                VisibleConfirmPassword = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                picAberto1.Image = Properties.Resources.visibility_24dp_000000_FILL0_wght400_GRAD0_opsz24;
                VisibleConfirmPassword = true;
            }

        }

        private void picAberto2_Click(object sender, EventArgs e)
        {
            if (VisiblePassword)
            {
                txtPassword.UseSystemPasswordChar = true;
                picAberto2.Image = Properties.Resources.visibility_off_24dp_000000_FILL0_wght400_GRAD0_opsz24;
                VisiblePassword = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                picAberto2.Image = Properties.Resources.visibility_24dp_000000_FILL0_wght400_GRAD0_opsz24;
                VisiblePassword = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(cbRole.Text.Trim()) ||
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


                string role = cbRole.Text.Trim();

                if (role != "Administrator" && role != "User")
                {
                    MessageBox.Show("Invalid status. Use only Administrator or User.");
                    return;
                }


                cmd.CommandText = "INSERT INTO usuario(user_name, user_role, user_email, user_status, user_password_hash, user_created_at)" +
                    "VALUES(@user_name, @user_role, @user_email, @user_status, @user_password_hash, @user_created_at)";
                cmd.Parameters.AddWithValue("@user_name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@user_role", cbRole.Text.Trim());
                cmd.Parameters.AddWithValue("@user_email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@user_status", cbStatus.Text.Trim());
                cmd.Parameters.AddWithValue("user_password_hash", passwordHash);
                cmd.Parameters.AddWithValue("@user_created_at", hoje);


                cmd.ExecuteNonQuery();

                MessageBox.Show("New Employee added.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show($"An error has occurred. Please try again. + {ex.Number} : {ex.Message}",
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
        }/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

