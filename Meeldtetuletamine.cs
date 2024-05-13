using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Meeldtetuletamine : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int Id;
        OpenFileDialog open;
        SaveFileDialog save;
        public Meeldtetuletamine()
        {
            InitializeComponent();
        }

        private void Tuleta_meelde(object sender, EventArgs e)
        {
            if (login_txt.Text.Trim() != string.Empty && email_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    string sisLogin = login_txt.Text.Trim();
                    string sisEmail = email_txt.Text.Trim();

                    connect.Open();
                    command = new SqlCommand("SELECT login, email, salasona FROM klient", connect);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            string AB_Login = reader["login"].ToString();
                            string AB_Email = reader["email"].ToString();

                            if (sisLogin == AB_Login && sisEmail == AB_Email)
                            {
                                MessageBox.Show("Login ja Email on meie andmebaasis.");
                                string salasona = reader["salasona"].ToString();
                                MessageBox.Show($"Teie salasona on: {salasona}");
                                connect.Close();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sellist kasutajat voi emaili pole");                                
                            }
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Probleem tekkis: {ex.Message}");
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmed!");
            }
        }
    }
}
