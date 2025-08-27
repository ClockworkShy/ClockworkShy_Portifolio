/*
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⡀⠀⠀⠀⠀⣀⡤⠤⠤⠔⠒⢂⡤⠤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⡌⢇⢀⣠⠖⠋⠁⠀⣀⣤⠶⠚⠋⠉⢧⡀⠉⠉⠒⠶⠦⣄⣀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡇⠘⣿⠃⠀⢀⣶⠟⠋⣁⡄⠀⢀⣤⠖⠛⠒⠦⣤⣄⣀⠀⠉⠛⠲⡄⢀⡾⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⡀⠹⡀⠀⣸⡇⢀⡞⠁⣠⠞⠉⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠦⣤⡹⣟⢡⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡖⠸⡇⠀⢹⡴⣿⡇⢸⠀⣼⠁⠀⠀⠀⠀⠀⠀⠀⠲⡀⠀⢄⠀⠀⠀⠹⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡾⠁⢀⣷⣶⢞⡥⠛⢷⣿⣰⠇⠀⠀⢀⠀⠀⠀⠀⠀⠀⠹⡄⠈⢳⠀⠀⠀⠹⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠁⠀⢸⡄⢹⣦⠀⢆⢸⣿⣿⡀⠀⠀⣾⠀⠀⡤⠀⠀⠀⠀⡇⠀⣠⣧⠀⠀⠀⣷⢿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⢰⡇⠀⠀⡞⡇⠘⣎⣆⢸⣏⡇⣿⣧⣄⠀⣿⠀⣸⡷⢀⣀⠾⣿⣇⣰⣿⡿⣠⠆⢀⣿⣾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⡾⠀⠀⠀⢹⣽⡀⣿⣿⢸⣽⣧⠻⣝⠻⣷⣾⣾⣿⣷⢽⣫⣼⠟⠛⠭⠟⠻⣧⣾⣟⣿⣁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠀⢀⠈⢿⠛⠉⢸⠸⣿⣿⠀⢸⠀⣾⣴⣿⣿⣿⣷⣦⣤⠀⠀⠀⣠⣴⣟⣿⡷⢤⡈⠙⠓⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⣸⠀⠀⠀⢸⠀⠘⣧⡠⣾⡄⢸⡟⠀⢸⠠⠿⣯⣿⣿⢿⣿⡆⠀⠀⠀⢸⣿⣿⣿⡏⢿⡄⠉⠙⢦⡀⠈⠲⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⡇⢀⠀⠀⣾⠀⠀⠹⣟⠫⠴⢯⡇⠀⡿⣤⣄⡺⠏⠉⠉⠉⠀⠀⠀⠀⠈⠉⠚⢿⣷⡎⢹⣤⠴⠊⣉⣉⠓⠚⠛⠓⢶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⢀⡇⢸⠆⠀⣏⡄⠀⠀⢻⣄⣠⡼⠁⢀⡇⠻⠿⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠘⢻⣯⠟⠋⢁⡴⠋⠀⣀⣤⣌⣉⠉⠙⠻⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⢸⡇⢸⡀⢰⣹⠁⠀⠀⣼⠿⣷⣄⣀⣼⠀⠀⣤⣴⣶⠟⠀⠀⠀⢰⣶⣴⣷⠂⢐⣿⣇⡀⠔⢉⣠⡶⠋⢁⣀⣀⠈⠉⠉⠓⢿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⡇⢸⣇⡟⡟⠀⠀⣰⠃⠀⢹⡾⢿⣿⣆⠀⠙⠛⠁⠀⠀⠀⠀⣀⣭⣉⣤⢄⣾⠏⠹⠧⠴⡿⢧⡶⠋⠉⠀⠙⢧⡀⠀⠀⠘⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣼⠁⠀⢠⡏⠀⠀⠀⢻⡀⢹⣿⣧⡀⠀⠀⠀⠈⠉⠩⣿⣿⡏⢡⡾⡇⠀⢰⡇⠀⣧⠀⠘⢦⡀⠀⠀⠀⡗⠀⠀⠀⢸⣇⠀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⠀⣄⠀⢹⡏⠀⠀⡞⠀⠀⠀⢠⠈⣷⡈⣿⣇⣙⣷⢦⣤⠤⠤⠤⣄⣀⣠⣿⡇⡀⠀⠀⣇⠀⢿⠀⠀⠘⣷⠀⠀⠀⡇⠀⠀⠀⠀⢷⡀⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⠀⢠⠏⢠⡿⠀⠀⣸⠁⠀⠀⠀⢸⡆⢹⡿⣿⣿⣿⠟⠃⠀⠀⠀⠀⠈⠉⡻⢿⣧⣇⠀⠀⠸⣄⠘⣧⡀⠀⠈⠳⣄⠀⠀⠀⠀⠀⠀⠸⣧⠀⠀⠀⠀⠀⠀⠀
        ⠀⠀⠀⠀⠀⣠⡿⢣⣿⠇⠀⢰⠇⠀⠀⠀⠀⢸⡇⢸⣿⣿⣿⠇⠀⠀⠀⣴⣿⣛⣻⣦⡄⠐⢹⢿⣷⣤⡀⠘⣆⠘⣧⠀⠐⢲⣈⠙⢿⠓⠀⠀⠀⠀⠹⣧⡀⠀⠀⠀⠀⠀
        ⠀⠀⠀⢠⣾⠞⢀⡾⡃⠀⠀⣾⠀⠀⠀⠀⠀⢸⠁⣼⣿⢳⡏⠀⠀⠀⠠⣝⠿⣇⣀⣿⠇⠀⠀⠀⢻⣿⣿⣅⢸⡦⢸⡇⠀⠐⠉⣹⢿⡇⠀⠀⠀⠀⠀⣿⡝⣳⡄⠀⠀⠀
        ⠀⠀⡴⣿⠋⠀⣼⠁⡇⠀⢠⠇⠀⠀⠀⠀⢠⢇⣼⢫⠇⠀⢧⠀⠀⠀⠀⠈⠉⠀⠉⠁⠀⠀⠀⠀⠈⢻⣿⣿⣾⣦⣼⣗⠒⠀⣸⡗⢿⣷⣀⣀⣀⣀⣀⣹⠿⠘⡇⠀⠀⠀
        ⠀⣼⣹⠃⠀⣰⠁⢸⡇⠀⣼⠀⠀⠀⠀⠀⢠⢿⠃⣼⠀⠀⢸⡿⡛⠛⠛⠲⢤⣤⡀⠀⠀⠀⠀⠀⢀⣸⡟⢯⠛⢿⣿⣿⣟⠓⠼⣇⠀⠈⠉⠉⠉⠉⠁⠀⠀⠀⡇⠀⠀⠀
        ⢰⢷⡇⠀⢠⠏⢀⣿⠀⠀⡿⠀⠀⠀⠀⠀⢯⠇⠀⣿⠀⠀⠀⢻⣷⠂⠠⠤⠤⣀⣉⠛⠲⠤⠴⠛⢋⣀⡤⠾⢧⣻⡟⢾⣽⣛⠶⣽⡀⠀⠀⠀⠀⠀⠀⢀⣀⣴⠟⠀⠀⠀
        ⠸⣸⡇⠀⡿⠀⣸⢿⡇⠀⡇⠀⠀⠀⠀⠀⣾⠀⠀⢻⡀⠀⠀⠈⣿⣆⠀⠀⠀⠀⠈⣹⠞⣀⡴⠊⢉⡀⠀⠀⠀⠻⣷⣞⠳⣽⣷⡈⠉⠳⣶⠶⠶⡞⠋⢩⡁⠘⣧⠀⠀⠀
        ⠀⠙⣿⡀⡇⠀⣿⢸⡇⠀⡇⠀⠀⠀⡀⠀⡇⠀⠀⠈⡇⠀⠀⠀⠘⢿⣆⡀⡀⠀⣾⢷⢾⡁⠀⠀⠀⠙⢦⡀⠀⠀⠈⠻⣷⣄⠄⠁⢄⠀⠈⢳⡄⢱⡀⠀⢳⡀⠸⣇⠀⠀
        ⠀⠀⠀⠹⣿⠀⣿⠈⡇⣧⣿⠀⠀⠀⡇⠀⡇⠀⠀⠀⣿⠀⠀⠀⠀⠀⠉⠛⢷⣤⣿⣸⡇⠘⢦⡀⠀⠀⠀⠙⢦⡀⠀⠀⠈⠻⣷⣄⠘⣆⠀⠈⡇⠘⡇⠀⠈⢇⠀⢿⡀⠀
        ⠀⠀⠀⠀⢻⣀⣧⢸⣧⠹⡹⡄⠀⠀⣇⠀⣧⡀⠀⠀⠘⣧⠀⠀⠀⠀⠀⠀⠀⠘⠿⣽⣷⡦⠀⠉⠲⣄⠀⠀⠀⠙⠦⣀⠀⠀⠈⠿⣷⣿⠀⢀⣷⠀⣿⠀⠀⢸⡄⠈⣧⠀
        ⠀⠀⠀⠀⠈⢻⣿⢸⠚⣇⠻⡽⣦⡀⠹⡀⢻⢣⡀⠀⠀⠘⢷⡄⠀⠀⠀⠀⠀⠀⡼⠁⠙⠻⢶⣄⠀⠈⠓⣄⠀⠀⠀⠈⠁⢠⣀⡀⠈⠙⠲⣼⡇⠀⢻⠀⠀⠘⠀⠀⢻⠀
        ⠀⠀⠀⠀⠀⠈⢻⣿⡇⠘⢦⡹⣞⡻⣦⢳⡈⢣⡙⠦⣀⠀⠀⠻⣦⡀⠀⠀⠀⣾⠁⠀⠀⠀⠀⠙⠳⣄⡀⠀⠙⠦⣄⡀⠀⠀⠀⠉⠓⢦⡀⠺⣷⣆⢸⠀⠀⠀⠀⠀⠈⡇
        ⠀⠀⠀⠀⠀⠀⠀⢱⡇⠀⠀⠙⢎⡙⠮⣷⣳⡀⠑⢄⣀⠙⠲⢤⣘⢿⣦⡀⢸⡏⠀⠀⠀⠀⠀⠀⠀⠀⠙⠲⣄⠀⠀⠉⠙⠲⣄⠀⠀⠀⠱⡄⠈⠻⣿⣄⠀⢀⠀⠀⠀⡇
        ⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠀⠀⠀⠑⣤⣌⢻⡻⢦⡀⠈⠀⠀⠀⠈⢻⣏⠿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣬⣝⡦⣀⠀⠀⠈⢦⡀⠀⠀⠁⠀⠀⠈⠻⢷⣼⠀⠀⢠⠃
        ⠀⠀⠀⠀⠀⠀⢀⡞⠁⠀⠀⠀⠀⠀⠘⣦⠙⣧⡜⣏⢳⡀⠀⠀⠀⠀⢿⣾⠈⠻⣷⣄⠀⠀⠀⠀⠀⠀⠀⢸⠅⢸⡇⠈⠻⣤⠀⠀⠱⣄⠀⠀⠀⠲⣄⡀⠀⠙⢷⣠⡾⠀
        ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠆⢱⠸⠎⢦⠙⠆⠀⠀⠀⠘⣿⡇⠀⠈⡿⣷⣤⣤⣀⡀⠀⠀⣿⡀⣿⠁⠀⠀⠙⣿⣕⡀⠘⠶⢴⡄⠀⠀⠉⠒⢄⠀⣙⣦⣀

  ___            _                 ___   _  _       _       ___       __   __    _   
 | _ \  ___   __| |  _ _   ___    | _ \ | || |     /_\     |   \      \ \ / /   /_\  
 |  _/ / -_) / _` | | '_| / _ \   |  _/ | __ |    / _ \    | |) |  _   \ V /   / _ \ 
 |_|   \___| \__,_| |_|   \___/   |_|   |_||_|   /_/ \_\   |___/  (_)   \_/   /_/ \_\
                                                                                     
  ___     _     _     ____  ___   _   ___    __    ___   ___   ____  ____            
 | _ \   /_\   (_)   |__ / |_  ) / | |_  )  /  \  |_  ) | __| |__ / |__  |           
 |   /  / _ \   _     |_ \  / /  | |  / /  | () |  / /  |__ \  |_ \   / /            
 |_|_\ /_/ \_\ (_)   |___/ /___| |_| /___|  \__/  /___| |___/ |___/  /_/             

*/
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroGisuProgVisual
{
    public partial class Login : Form
    {

        private string email;
        private string senha;

        public Login()
        {
            InitializeComponent();

        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;

            string sql = "SELECT * FROM clientes WHERE email = @email AND senha = @senha";

            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                con = new MySqlConnection("server='localhost';uid='root';pwd='';database='gisuenergyandwater'");
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.Hide();
                    Perfil p = new Perfil(email, senha);
                    p.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Email ou senha inválidos!!! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠ Erro no sistema: {ex.Message}");
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
    



private void labelNaotenhoCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro p = new Cadastro();
            p.ShowDialog();
            this.Close();
        }
    }
}
