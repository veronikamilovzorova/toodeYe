using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{   
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int Id;
        OpenFileDialog open;
        SaveFileDialog save;
        public Login()
        {
            InitializeComponent();           
        }
        private void unustasin_btn_Click(object sender, EventArgs e)
        {
            Meeldtetuletamine meeldetuletamineForm = new Meeldtetuletamine();
            meeldetuletamineForm.Show();            
        }
        private void loouuuskasutaja_btn_Click(object sender, EventArgs e)
        {
            Registreerimine registreerimineForm = new Registreerimine();
            registreerimineForm.Show();           
        }
        private void logikylalisena_Click(object sender, EventArgs e)
        {
            Pood poodForm = new Pood();
            poodForm.Show();

            this.Close();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_txt.Text.Trim() != string.Empty && salasona_txt.Text.Trim() != string.Empty)
                try
                {
                    string sisLogin = login_txt.Text.Trim();
                    string sisSala = salasona_txt.Text.Trim();

                    connect.Open();                   
                    command = new SqlCommand("SELECT login, salasona FROM klient", connect);
                    
                    if (login_txt.Text == "Admin" && salasona_txt.Text == "Admin")
                    {
                        Admin_Klient admin_klientForm = new Admin_Klient();
                        admin_klientForm.Show();

                        Admin_Tooded admin_toodedForm = new Admin_Tooded();
                        admin_toodedForm.Show();

                        this.Close();
                    }
                    else
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                string AB_Login = reader["login"].ToString();
                                string AB_Salasona = reader["salasona"].ToString();

                                if (sisLogin == AB_Login && sisSala == AB_Salasona)
                                {
                                    Pood pood = new Pood();
                                    pood.Show();
                                    pood.LoginlogVormist = true;
                                    connect.Close();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Vale login voi salasona");
                                    connect.Close();
                                }
                            }
                        }
                    }                                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Probleem tekkis: {ex.Message}");
                }
            else
            {
                MessageBox.Show("Sisesta andmed!");
            }
        }
    }
}
