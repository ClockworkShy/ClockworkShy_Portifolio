using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AmiPet_AV1
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
                con = new MySqlConnection("server=localhost; uid=root; pwd=; database=amipet");
                con.Open();

                string query = "SELECT * FROM clientes WHERE email = @email AND senha = @senha";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int fotoIndex = reader.GetOrdinal("foto");

                    if (!reader.IsDBNull(fotoIndex))
                    {
                        byte[] dadosFoto = (byte[])reader[fotoIndex];
                        pictureBoxFoto.Image = ByteArrayToImage(dadosFoto);
                    }

                    string nome = reader["nome"].ToString();
                    string tipo = reader["tipo"].ToString();
                    string genero = reader["genero"].ToString();
                    string raca = reader["raca"].ToString();
                    string dono = reader["dono"].ToString();
                    string telefone = reader["telefone"].ToString();
                    string cep = reader["cep"].ToString();
                    string logradouro = reader["logradouro"].ToString();
                    string numero = reader["numero"].ToString();
                    string bairro = reader["bairro"].ToString();
                    string cidade = reader["cidade"].ToString();
                    string uf = reader["uf"].ToString();

                    labelNome.Text = nome;
                    labelTipo.Text = tipo;
                    labelGenero.Text = genero;
                    labelRaca.Text = raca;
                    labelDono.Text = dono;
                    labelEmail.Text = email;
                    labelTelefone.Text = telefone;
                    labelCEP.Text = cep;
                    labelLogradouro.Text = logradouro;
                    labelNumero.Text = numero;
                    labelBairro.Text = bairro;
                    labelCidade.Text = cidade;
                    labelUF.Text = uf;
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
