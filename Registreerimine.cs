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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tooded_DB
{
    public partial class Registreerimine : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int Id;
        OpenFileDialog open;
        SaveFileDialog save;
        public Registreerimine()
        {
            
            InitializeComponent();
            Salasona_txt.UseSystemPasswordChar = true;
        }

        private void Naita_Salasona(object sender, EventArgs e)
        {
            if (c1.Checked)
            {
                Salasona_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Salasona_txt.UseSystemPasswordChar = true;
            }

        }

        private void Loo_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(Telefon_txt.Text, out int TelefonN);
            bool isValidTelefon = Telefon_txt.Text.Trim().Length == 8 && TelefonN > 0;

            if (
                Nimi_txt.Text.Trim() != string.Empty &&
                Perenimi_txt.Text.Trim() != string.Empty &&
                Login_txt.Text.Trim() != string.Empty &&
                Salasona_txt.Text.Trim() != string.Empty &&
                Email_txt.Text.Trim() != string.Empty &&
                Telefon_txt.Text.Trim() != string.Empty &&
                isValidTelefon
                )
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("INSERT INTO klient (nimi, perenimi, login, salasona, email, telefon) VALUES(@nim, @pnim, @log, @ssona, @mail, @tel)", connect);
                    command.Parameters.AddWithValue("@nim", Nimi_txt.Text);
                    command.Parameters.AddWithValue("@pnim", Perenimi_txt.Text);
                    command.Parameters.AddWithValue("@log", Login_txt.Text);
                    command.Parameters.AddWithValue("@ssona", Salasona_txt.Text);
                    command.Parameters.AddWithValue("@mail", Email_txt.Text);
                    command.Parameters.AddWithValue("@tel", Telefon_txt.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Kasutaja on loodud");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Andmebaasiga viga: {ex.Message}");
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmed!");
            }
        }
    }
}