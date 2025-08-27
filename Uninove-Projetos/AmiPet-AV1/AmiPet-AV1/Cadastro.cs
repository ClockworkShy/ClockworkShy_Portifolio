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

using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace AmiPet_AV1
{
    public partial class Cadastro : Form
    {

        private string caminhoFoto;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void labelVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login p = new Login();
            p.ShowDialog();
            this.Close();

        }
        private void buttonBuscarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialogFoto = new OpenFileDialog())
            {
                openFileDialogFoto.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialogFoto.Title = "Selecionar Foto";

                if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
                {
                    caminhoFoto = openFileDialogFoto.FileName;
                    pictureBoxFoto.ImageLocation = caminhoFoto;
                    textBoxFoto.Text = caminhoFoto;
                }
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoFoto))
            {
                MessageBox.Show("Por favor, selecione uma foto antes de cadastrar.");
                return;
            }

            byte[] foto = File.ReadAllBytes(caminhoFoto);

            string nome = textBoxNome.Text;
            string tipo = comboBoxTipo.Text;
            string genero = comboBoxGenero.Text;
            string raca = textBoxRaca.Text;
            string dono = textBoxDono.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string cep = textBoxCEP.Text;
            string logradouro = textBoxLogradouro.Text;
            string bairro = textBoxBairro.Text;
            string cidade = textBoxCidade.Text;
            string numero = textBoxNumero.Text;
            string uf = textBoxUF.Text;

            string sql = "INSERT INTO clientes (foto, nome, tipo, genero, raca, dono, email, senha, telefone, cep, logradouro, bairro, cidade, numero, uf) " +
                         "VALUES (@foto, @nome, @tipo, @genero, @raca, @dono, @email, @senha, @telefone, @cep, @logradouro, @bairro, @cidade, @numero, @uf)";

            MySqlConnection con = null;
            MySqlCommand cmd = null;

            try
            {
                con = new MySqlConnection("server=localhost; uid=root; pwd=''; database='amipet'");
                con.Open();

                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@raca", raca);
                cmd.Parameters.AddWithValue("@dono", dono);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@uf", uf);

                int qtd_linha = cmd.ExecuteNonQuery();
                if (qtd_linha > 0)
                {
                    MessageBox.Show("Dados salvos com sucesso!");
                    this.Hide();
                    Perfil p = new Perfil(email, senha);
                    p.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível salvar: {ex.Message}");
            }
            finally
            {
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
        private void buttonBuscarCEP_Click(object sender, EventArgs e)
        {
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + textBoxCEP.Text + "/json/");
            myReq.ContentType = "application/json";
            myReq.Method = "GET";
            var myResp = (HttpWebResponse)myReq.GetResponse();

            using (var streamReader = new StreamReader(myResp.GetResponseStream()))
            {
                var resultQR = streamReader.ReadToEnd();
                string jsonStringsign = resultQR;
                JObject meuJson = JObject.Parse(jsonStringsign);

                textBoxLogradouro.Text = meuJson.Root["logradouro"].ToString();
                textBoxBairro.Text = meuJson.Root["bairro"].ToString();
                textBoxCidade.Text = meuJson.Root["localidade"].ToString();
                textBoxUF.Text = meuJson.Root["uf"].ToString();

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxCEP.Text = "";
            textBoxLogradouro.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxNumero.Text = "";
            textBoxUF.Text = "";
        }
    }
}
