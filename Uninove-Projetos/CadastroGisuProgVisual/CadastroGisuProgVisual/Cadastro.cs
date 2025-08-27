using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
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


namespace CadastroGisuProgVisual
{
    public partial class Cadastro : Form
    {
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

        private string caminhoFoto; // Declarar uma variável de classe para armazenar o caminho do arquivo

        private void buttonBuscar_Click(object sender, EventArgs e)
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

        private void buttonBuscarCep_Click(object sender, EventArgs e)

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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoFoto))
            {
                MessageBox.Show("Por favor, selecione uma foto antes de cadastrar.");
                return;
            }

            byte[] dadosFoto = File.ReadAllBytes(caminhoFoto);
            string nome = textBoxNome.Text;
            string sexo = radioButtonFeminino.Checked ? "Fem" : "Masc";
            string datanasc = dateTimePickerDataNasc.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string pais = textBoxPaisdeOrigen.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;
            string cep = textBoxCEP.Text;
            string lougradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string bairro = textBoxBairro.Text;
            string cidade = textBoxCidade.Text;
            string uf = textBoxUF.Text;

            string sql = "INSERT INTO clientes (DadosFoto, nome, sexo, datanasc, telefone, pais, email, senha, cep, lougradouro, numero, bairro, cidade, uf) " +
                         "VALUES (@dadosFoto, @nome, @sexo, @datanasc, @telefone, @pais, @email, @senha, @cep, @lougradouro, @numero, @bairro, @cidade, @uf)";

            MySqlConnection con = null;
            MySqlCommand cmd = null;

            try
            {
                con = new MySqlConnection("server=localhost; uid=root; pwd=; database=gisuenergyandwater; useAffectedRows=true");
                con.Open();

                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dadosFoto", dadosFoto);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@datanasc", datanasc);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@lougradouro", lougradouro);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@uf", uf);

                int qtd_linha = cmd.ExecuteNonQuery();

                if (qtd_linha > 0)
                {
                    MessageBox.Show("Dados cadastrados e salvos com sucesso!");

                    this.Hide();
                    Perfil p = new Perfil(email, senha);
                    p.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível cadastrar e salvar: {ex.Message}");
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

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxCEP.Text = "";
            textBoxLogradouro.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxUF.Text = "";
        }
    }
}
