using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Admin_Klient : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int Id;
        OpenFileDialog open;
        SaveFileDialog save;
        public Admin_Klient()
        {
            InitializeComponent();
            NaitaAndmed();
        }
        private void Lisa(object sender, EventArgs e)
        {
            int.TryParse(Telefon_txt.Text, out int TelefonN);
            bool isValidTelefon = Telefon_txt.Text.Trim().Length == 8 && TelefonN > 0;

            if(
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
                    NaitaAndmed();
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
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmed!");
            }
        }
        private void Kustuta(object sender, EventArgs e)
        {
            if (DGW.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGW.SelectedRows[0];
                int selectedRowID = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }

                    string deleteQuery = "DELETE FROM klient WHERE Id = @id";
                    command = new SqlCommand(deleteQuery, connect);
                    command.Parameters.AddWithValue("@id", selectedRowID);
                    command.ExecuteNonQuery();
                    connect.Close();

                    DGW.Rows.Remove(selectedRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Probleem tekkis kustutamisel: " + ex.Message);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vali rida DataGridView-l kustutamiseks");
            }
        }
        private void Uuenda(object sender, EventArgs e)
        {
            if (DGW.SelectedRows.Count > 0)
            {
                DataGridViewRow val_rida = DGW.SelectedRows[0];
                int val_rida_ID = Convert.ToInt32(val_rida.Cells["Id"].Value);

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
                    string UUS_Nimi = Nimi_txt.Text;
                    string UUS_Perenimi = Perenimi_txt.Text;
                    string UUS_Login = Login_txt.Text;
                    string UUS_Salasona = Salasona_txt.Text;
                    string UUS_Email = Email_txt.Text;
                    string UUS_Telefon = Telefon_txt.Text;

                        try
                        {
                            if (connect.State == ConnectionState.Closed)
                            {
                                connect.Open();
                            }                        
                        
                            command = new SqlCommand("UPDATE klient SET nimi = @nim, perenimi = @pnim, login = @log, salasona = @ssona, email = @mail, telefon = @tel", connect);
                            command.Parameters.AddWithValue("@nim", UUS_Nimi);
                            command.Parameters.AddWithValue("@pnim", UUS_Perenimi);
                            command.Parameters.AddWithValue("@log", UUS_Login);
                            command.Parameters.AddWithValue("@ssona", UUS_Salasona);
                            command.Parameters.AddWithValue("@mail", UUS_Email);
                            command.Parameters.AddWithValue("@tel", UUS_Telefon);

                            command.ExecuteNonQuery();
                            connect.Close();
                            NaitaAndmed();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Probleem tekkis uuendamisel: " + ex.Message);
                        }
                        finally
                        {
                            if (connect.State == ConnectionState.Open)
                            {
                                connect.Close();
                            }
                        }
                    }
                else
                {
                    MessageBox.Show("Sisesta andmed!");
                }
            }
            else
            {
                MessageBox.Show("Vali rida DataGridView-l uuendamiseks.");
            }
        }
        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_Toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT id, nimi, perenimi, login, salasona, email, telefon FROM klient", connect);
            adapter_toode.Fill(dt_Toode);
            DGW.Columns.Clear();
            DGW.DataSource = dt_Toode;
            connect.Close();
        }
    }
}
