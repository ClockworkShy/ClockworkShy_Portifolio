using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmiPet_AV1
{
    public partial class Login : Form
    {
        private string email;
        private string senha;

        public Login()
        {
            InitializeComponent();
        }

        private void labelNaoTenhoCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro p = new Cadastro();
            p.ShowDialog();
            this.Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            email = textBoxEmail.Text;
            senha = textBoxSenha.Text;

            string sql = "SELECT * FROM clientes WHERE email = @email AND senha = @senha";

            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd='';database='amipet';charset=utf8mb4"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        con.Open();

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Login bem-sucedido!");
                                this.Hide();
                                Perfil p = new Perfil(email, senha);
                                p.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Email ou senha inválidos!!!");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.ToString()}");
            }
        }
    }
}

