using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CadastroGisuProgVisual
{
    public partial class Perfil : Form
    {
        private string email;
        private string senha;

        public Perfil(string email, string senha)
        {
            InitializeComponent();
            this.email = email;
            this.senha = senha;
            CarregarDadosPerfil(email, senha);
        }

        private void CarregarDadosPerfil(string email, string senha)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                con = new MySqlConnection("server=localhost; uid=root; pwd=; database=gisuenergyandwater");
                con.Open();

                string query = "SELECT * FROM clientes WHERE email = @email AND senha = @senha";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] dadosFoto = (byte[])reader["DadosFoto"];
                    string nome = reader["nome"].ToString();
                    string sexo = reader["sexo"].ToString();
                    string datanasc = reader["datanasc"].ToString();
                    string telefone = reader["telefone"].ToString();
                    string pais = reader["pais"].ToString();
                    string cep = reader["cep"].ToString();
                    string lougradouro = reader["lougradouro"].ToString();
                    string numero = reader["numero"].ToString();
                    string bairro = reader["bairro"].ToString();
                    string cidade = reader["cidade"].ToString();
                    string uf = reader["uf"].ToString();

                    pictureBoxFoto.Image = ByteArrayToImage(dadosFoto);
                    labelNome.Text = nome;
                    labelSexo.Text = sexo;
                    labelDataNasc.Text = datanasc;
                    labelEmail.Text = email;
                    labelTelefone.Text = telefone;
                    labelPaisdeOrigem.Text = pais;
                    labelCep.Text = cep;
                    labelLogradouro.Text = lougradouro;
                    labelNumero.Text = numero;
                    labelBairro.Text = bairro;
                    labelCidade.Text = cidade;
                    labelUf.Text = uf;
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas. Por favor, verifique seu email e senha.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do perfil: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    

    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Hide();
                Login p = new Login();
                p.ShowDialog();
                this.Close();
            }

    }
}
