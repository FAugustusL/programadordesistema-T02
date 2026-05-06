using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teladelogin_ninelives
{
    public partial class frmBundle : Form
    {

        MySqlConnection Conn;
        string data_source = "datasource=localhost; username=root; password=; database=ninelivebooks";

        List<Livro> livrosDisponiveis = new List<Livro>();
        List<Livro> livrosDoGrupo = new List<Livro>();


        public class Livro
        {
            public int Id_Book { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Condition { get; set; }
            public decimal Price { get; set; }
        }


        public frmBundle()
        {

            InitializeComponent();


            lstBook.View = View.Details;
            lstBook.LabelEdit = true;
            lstBook.AllowColumnReorder = true;
            lstBook.FullRowSelect = true;
            lstBook.GridLines = true; 
            
           
          
            lstBook.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lstBook.Columns.Add("Title", 150, HorizontalAlignment.Left);
            lstBook.Columns.Add("Author", 150, HorizontalAlignment.Left);
            lstBook.Columns.Add("Condition", 150, HorizontalAlignment.Left);
            lstBook.Columns.Add("Price", 100, HorizontalAlignment.Left);



            lstBookBundle.View = View.Details;
            lstBookBundle.LabelEdit = true;
            lstBookBundle.AllowColumnReorder = true;
            lstBookBundle.FullRowSelect = true;
            lstBookBundle.GridLines = true;

            lstBookBundle.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Title", 150, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Author", 150, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Price", 100, HorizontalAlignment.Left);
            this.Load += frmBundle_Load;
        }

        private void frmBundle_Load(object sender, EventArgs e)
        {
            BuscarLivrosDoBanco();
            CarregarLivrosBanco();
            
        }


        void BuscarLivrosDoBanco()
        {
            livrosDisponiveis.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();

                    string sql = @"
                SELECT 
                    b.book_id,
                    b.price,
                    b.book_condition,
                    bt.title,
                    bt.author
                FROM book b
                LEFT JOIN book_titles bt
                    ON b.title_id_in_book = bt.title_id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        int id = 0;
                        decimal price = 0;

                        int.TryParse(reader["book_id"]?.ToString(), out id);
                        decimal.TryParse(
                            reader["price"]?.ToString()?.Replace(",", "."),
                            NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out price
                        );

                        Livro livro = new Livro
                        {
                            Id_Book = id,
                            Title = reader["title"]?.ToString() ?? "",
                            Author = reader["author"]?.ToString() ?? "",
                            Condition = reader["book_condition"]?.ToString() ?? "",
                            Price = price
                        };

                        livrosDisponiveis.Add(livro);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERRO AO LER DO BANCO:\n\n" + ex.Message,
                    "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        void CarregarLivrosBanco()
        {
            lstBook.Items.Clear();
         
            foreach (var livro in livrosDisponiveis)
            {

             
                ListViewItem item = new ListViewItem(livro.Id_Book.ToString());
                item.SubItems.Add(livro.Title);
                item.SubItems.Add(livro.Author);
                item.SubItems.Add(livro.Condition);
                item.SubItems.Add(livro.Price.ToString("C"));

                item.Tag = livro;

                lstBook.Items.Add(item);
            }
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            if (lstBook.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um livro.");
                return;
            }

            Livro livro = (Livro)lstBook.SelectedItems[0].Tag;

            if (livrosDoGrupo.Any(l => l.Id_Book == livro.Id_Book))
            {
                MessageBox.Show("Livro já está no bundle.");
                return;
            }

            livrosDoGrupo.Add(livro);
            CarregarLivrosGrupo();
        }
        void CarregarLivrosGrupo()
        {
            lstBookBundle.Items.Clear();

            foreach (var livro in livrosDoGrupo)
            {
                ListViewItem item = new ListViewItem(livro.Id_Book.ToString());
                item.SubItems.Add(livro.Title);
                item.SubItems.Add(livro.Author);
                item.SubItems.Add(livro.Price.ToString("C"));

                item.Tag = livro;

                lstBookBundle.Items.Add(item);
            }
        }

        void SalvarGrupo(int idBundle)
        {
            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                conn.Open();

                foreach (var livro in livrosDoGrupo)
                {
                    string sql = @"INSERT INTO bundle (id_bundle, book_id)
                               VALUES (@bundle, @book)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bundle", idBundle);
                    cmd.Parameters.AddWithValue("@book", livro.Id_Book);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


