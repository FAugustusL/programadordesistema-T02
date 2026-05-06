using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace teste
{
    public partial class Form1 : Form
    {
        string imagePath;
        public byte[] ImageBytes { get; set; }

        MySqlConnection Conn;
        string data_source = "datasource=localhost; username=root; password=; database=ninelivebooks";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddImg_Click(object sender, EventArgs e)

        {

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)

            {

                image.Image = new Bitmap(dlg.FileName);

                imagePath = dlg.FileName;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Conn = new MySqlConnection(data_source);

            Conn.Open();

            MySqlCommand cmd = new MySqlCommand { Connection = Conn };
            MySqlCommand c = new MySqlCommand { Connection = Conn };
            cmd.Prepare();


            cmd.CommandText = "INSERT INTO book_titles(title_id, title, author, iSBN, pages, book_type, book_approx_weight, publisher, publication_year, book_language, genre, book_description, book_image)" +
                "VALUES(@title_id, @title, @author, @iSBN, @pages, @book_type, @book_approx_weight, @publisher, @publication_year, @book_language, @genre, @book_description, @book_image)";
            cmd.Parameters.AddWithValue("@title_id", "NL002");
            cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@iSBN", txtIsbn.Text.Trim());
            cmd.Parameters.AddWithValue("@pages", txtPages.Text.Trim());
            cmd.Parameters.AddWithValue("@book_type", cbType.Text.Trim());
            cmd.Parameters.AddWithValue("@book_approx_weight", txtWeight.Text.Trim());
            cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text.Trim());
            cmd.Parameters.AddWithValue("@publication_year", txtPubYear.Text.Trim());
            cmd.Parameters.AddWithValue("@book_language", txtLanguage.Text.Trim());
            cmd.Parameters.AddWithValue("@genre", txtGenre.Text.Trim());
            cmd.Parameters.AddWithValue("@book_description", "Desc"); 
            cmd.Parameters.AddWithValue("@book_image", image);

                c.CommandText = "INSERT INTO book(book_id, price, book_condition, book_status, reason_status, defected_notes, title_id_in_book)" +
                    "VALUES(@book_id, @price, @book_condition, @book_status, @reason_status, @defected_notes, @title_id_in_book)";
                c.Parameters.AddWithValue("@book_id", "NL001");
                c.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                c.Parameters.AddWithValue("@book_condition", cbCondition.Text.Trim());
                c.Parameters.AddWithValue("@book_status", cbStatus.Text.Trim());
                c.Parameters.AddWithValue("@reason_status", txtReason.Text.Trim());
                c.Parameters.AddWithValue("@defected_notes", txtNotes.Text.Trim());
                c.Parameters.AddWithValue("@title_id_in_book", "NL001");



                cmd.ExecuteNonQuery();
                c.ExecuteNonQuery(); 

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
        }

        //public Image CoverImage
        //{
        //    get
        //    {
        //        if (ImageBytes == null || ImageBytes.Length == 0)
        //            return null;

        //        using (var ms = new MemoryStream(ImageBytes))
        //        {
        //            return Image.FromStream(ms);
        //        }
        //    }
    }
}

