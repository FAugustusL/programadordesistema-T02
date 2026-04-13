using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//acessando o pacote do mysql
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace crud
{
    public partial class frmcadastrodeclientes : Form
    {
        //conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";
        public frmcadastrodeclientes()
        {
            InitializeComponent();

            //configuração inicial do listView para exibição dos dados do cliente

            lstCliente.View = View.Details; //define para visualização em "detalhes"
            lstCliente.LabelEdit = true; // permite editar o titulo de colunas
            lstCliente.AllowColumnReorder = true; //permite reordernar colunas
            lstCliente.FullRowSelect = true; //seleciona uma linha inteira ao clicar
            lstCliente.GridLines = true; //exibe as linhas em grade no listview

            //definindo as colunas do list view

            lstCliente.Columns.Add("Código", 100, HorizontalAlignment.Left); //coluna do código
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left);//coluna do Nome Completo
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left);//coluna do Nome Social
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left);//coluna do Email
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left);//coluna do CPF

            //Carrega dados dos clientes na interface
            carregar_clientes();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Preencha os campos", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF Inválido, Certifique-se de que tenha 11 dígitos númericos.", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand { Connection = Conexao };
                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf)" + "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Contato inserido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //limpa os campos após o sucesso

                txtNomeCompleto.Text = string.Empty;
                txtNomeSocial.Text = "";
                txtEmail.Text = "";
                txtCPF.Text = "";

                //recarrega os clientes na listview
                carregar_clientes();

                //muda para a aba de consulta
                tabControl1.SelectedIndex = 1;
            }

            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechado,mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
        //função para validar o comprimento e formato do cpf
        private bool isValidCPFLength(string cpf)

        {
            //remove todos os caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            //verifica se o cpf tem exatemente a 11 digitos
            return cpf.Length == 11;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY codigo DESC";
                carregar_clientes_com_query(query);
        }

        private void carregar_clientes_com_query(string query)
        {
            try
            {
                //cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //se a consulta contem o parametro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }
                //executa o comando e obtem os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //limpa os itens existentes no listview antes de adicionar novos
                lstCliente.Items.Clear();

                //preenche o listview com os dados do clientes
                while (reader.Read())
                {
                    //cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)), //codigo
                        reader.GetString(1),  //nome completo
                        reader.GetString(2),  //nome social
                        reader.GetString(3),  // email
                        reader.GetString(4), // cpf
                    };

                    //adiciona a linha ao listview
                    lstCliente.Items.Add(new ListViewItem(row));
                }
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechado,mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
        private void carregar_clientes()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY codigo DESC";
            carregar_clientes_com_query(query);
                }
    }
}
