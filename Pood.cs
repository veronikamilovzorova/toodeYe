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
    public partial class Pood : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        List<string> voetudList = new List<string>();
        public bool LoginlogVormist { get; set; }
        public Pood()
        {
            InitializeComponent();
            NaitaKategooriad();
            NaitaAndmed();
            Kat_Box.SelectedIndexChanged += Kat_Box_SelectedIndexChanged;
            Olemas.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            Voetud.SelectedIndexChanged += ListBox2_SelectedIndexChanged;
        }
        private void Kassa(object sender, EventArgs e)
        {
            if (voetudList.Count > 0)
            {
                Kassa kassa = new Kassa(voetudList);
                kassa.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tühi korviga pole mõttet minna kassase, ostke midagi!","Hoiatus");
            }
        }
        private void Valju(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NaitaAndmed()
        {
            string valKat = Kat_Box.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(valKat))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT Toodenimetus, KategooriaId FROM Toode WHERE Kategooria IN (SELECT Id FROM Toode WHERE Kategooria_nimetus = @kat)";

               
                    command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@kat", valKat);
                    SqlDataReader reader = command.ExecuteReader();
                    Olemas.Items.Clear();

                    while (reader.Read())
                    {
                        string itemName = reader["Toodenimetus"].ToString();
                        Olemas.Items.Add(itemName);
                    }

                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Probleem: {ex.Message}");
                }
            }
            else
            {
                Olemas.Items.Clear();
            }
        }
        private void NaitaKategooriad()
        {
            Kat_Box.Items.Clear();
            Kat_Box.Text = "";
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);

            foreach (DataRow item in dt_kat.Rows)
            {
                if (!Kat_Box.Items.Contains(item["Kategooria_nimetus"]))
                {
                    Kat_Box.Items.Add(item["Kategooria_nimetus"]);
                }
            }
            connect.Close();
        }
        private void Kat_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            NaitaAndmed();
        }
        private void Lisatoode_korvi(object sender, EventArgs e)
        {
            try
            {
                if (Olemas.SelectedItem != null)
                {
                    string valtoode = Olemas.SelectedItem.ToString();

                    // Kontroll kogusele
                    string kontrollpar = "SELECT Koogus FROM Toode WHERE Toodenimetus = @Nimi";
                    command = new SqlCommand(kontrollpar, connect);
                    command.Parameters.AddWithValue("@Nimi", valtoode);
                    connect.Open();
                    int kogusArv = Convert.ToInt32(command.ExecuteScalar());
                    connect.Close();

                    if (kogusArv > 0)
                    {
                        // Kui toode on olemas, siis laseme votta yks kuni toode jatkub
                        string uuendaPar = "UPDATE Toode SET Koogus = Koogus - 1 WHERE Toodenimetus = @Nimi";
                        command = new SqlCommand(uuendaPar, connect);
                        command.Parameters.AddWithValue("@Nimi", valtoode);
                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();

                        Voetud.Items.Add(valtoode);
                        voetudList.Add(valtoode);
                        Naitakogus(valtoode);
                    }
                    else
                    {
                        MessageBox.Show("Kogus on juba 0!","Hoiatus");
                    }
                }
                else
                {
                    MessageBox.Show("Valige toode");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Probleem: {ex.Message}");
            }
        }
        private void Kustutatoode_korvist(object sender, EventArgs e)
        {
            try
            {
                if (Voetud.SelectedItem != null)
                {
                    string valtoode = Voetud.SelectedItem.ToString();

                    // Tagasi paneme riulile toode e. +1
                    string updateQuery = "UPDATE Toode SET Koogus = Koogus + 1 WHERE Toodenimetus = @Nimi";
                    command = new SqlCommand(updateQuery, connect);
                    command.Parameters.AddWithValue("@Nimi", valtoode);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();

                    Voetud.Items.Remove(valtoode);
                    voetudList.Remove(valtoode);
                    Naitakogus(valtoode);
                }
                else
                {
                    MessageBox.Show("Valige toode");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Probleem: {ex.Message}");
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Olemas.SelectedItem != null)
            {
                string valToode = Olemas.SelectedItem.ToString();
                string piltNimi = string.Empty;

                try
                {
                    connect.Open();
                    string query = "SELECT Pilt, Koogus, Hind FROM Toode WHERE Toodenimetus = @Nimi";
                    command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@Nimi", valToode);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        piltNimi = reader["Pilt"].ToString();
                        string piltMapp = Path.Combine(Path.GetFullPath(@"..\..\Images"), piltNimi);
                        if (File.Exists(piltMapp))
                        {
                            Image pilt = Image.FromFile(piltMapp);
                            olemastoode.SizeMode = PictureBoxSizeMode.StretchImage;
                            olemastoode.ClientSize = new Size(150, 150);
                            olemastoode.Image = (Image)(new Bitmap(pilt, olemastoode.ClientSize));
                        }
                        else
                        {
                            MessageBox.Show($"Pilt '{piltNimi}' ei ole leitud.");
                        }

                        int kogus = Convert.ToInt32(reader["Koogus"]);
                        float hind = Convert.ToSingle(reader["Hind"]);

                        kogus_txt.Text = kogus.ToString();
                        hind_txt.Text = hind.ToString();

                        kogus_txt.ReadOnly = true;
                        hind_txt.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show($"Pilt '{valToode}' ei ole leitud.");
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Probleem: {ex.Message}");
                }
            }
        }        
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Voetud.SelectedItem != null)
            {
                string valToode = Voetud.SelectedItem.ToString();
                string piltNimi = string.Empty;

                try
                {
                    connect.Open();
                    string par = "SELECT Pilt, Koogus, Hind FROM Toode WHERE Toodenimetus = @Nimi";
                    command = new SqlCommand(par, connect);
                    command.Parameters.AddWithValue("@Nimi", valToode);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        piltNimi = reader["Pilt"].ToString();
                        string piltMapp = Path.Combine(Path.GetFullPath(@"..\..\Images"), piltNimi);
                        if (File.Exists(piltMapp))
                        {
                            Image img = Image.FromFile(piltMapp);
                            voetudtoode.SizeMode = PictureBoxSizeMode.StretchImage;
                            voetudtoode.ClientSize = new Size(150, 150);
                            voetudtoode.Image = (Image)(new Bitmap(img, voetudtoode.ClientSize));
                        }
                        else
                        {
                            MessageBox.Show($"Pilt '{piltNimi}' ei ole leitud.");
                        }                       
                    }
                    else
                    {
                        MessageBox.Show($"Toode '{valToode}' ei ole leitud.");
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Probleem: {ex.Message}");
                }
            }
        }
        private void Naitakogus(string valToode)
        {
            try
            {
                connect.Open();
                string par = "SELECT Koogus FROM Toode WHERE Toodenimetus = @itemName";
                command = new SqlCommand(par, connect);
                command.Parameters.AddWithValue("@itemName", valToode);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int kogus = Convert.ToInt32(reader["Kogus"]);
                    kogus_txt.Text = kogus.ToString();
                }
                else
                {
                    MessageBox.Show($"Toode '{valToode}' ei ole leitud.");
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Probleem: {ex.Message}");
            }
        }
    }
}
