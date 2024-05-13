using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Admin_Tooded : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int Id;
        OpenFileDialog open;
        SaveFileDialog save;
        
        public Admin_Tooded()
        {
            InitializeComponent();
            NaitaKategooriad();
            NaitaAndmed();
            DGW.SelectionChanged += DGW_Pilt;
        }
        private void Lisa_Kategooria(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in Kat_Box.Items)
            {
                if (item.ToString() == Kat_Box.Text)
                {
                    on = true;
                    MessageBox.Show("Kategooria on juba olemas");
                }
            }
            if (on == false)
            {
                connect.Open();
                command = new SqlCommand("INSERT INTO Toode(Kategooria_nimetus) VALUES (@kat)", connect);
                command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
        }
        private void Kustuta_Kategooria(object sender, EventArgs e)
        {
            if (Kat_Box.SelectedItem != null)
            {
                string val_kat = Kat_Box.SelectedItem.ToString();

                connect.Open();
                command = new SqlCommand("DELETE FROM Toode WHERE Kategooria_nimetus = @kat", connect);
                command.Parameters.AddWithValue("@kat", val_kat);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
        }
        private void Lisa(object sender, EventArgs e)
        {
            if (Toodenimetus.Text.Trim() != string.Empty && 
                Kogus.Text.Trim() != string.Empty &&
                int.TryParse(Kogus.Text, out int kogusN) && kogusN > 0 && 
                Hind.Text.Trim() != string.Empty &&
                int.TryParse(Kogus.Text, out int HindN) && HindN > 0 &&
                Kat_Box.SelectedItem != null)
            {
                try
                {
                    open = new OpenFileDialog();
                    open.InitialDirectory = @"..\..\Images";
                    open.Multiselect = false;
                    open.Filter = "Images Files(*.jpeg;*.png;*.jpg;*.bmp)|*.jpeg;*.png;*.jpg;*.bmp";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        connect.Open();

                        command = new SqlCommand("SELECT Id FROM Toode WHERE Kategooria_nimetus=@kat", connect);
                        command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                        command.ExecuteNonQuery();
                        Id = Convert.ToInt32(command.ExecuteScalar());

                        string imageFileName = Path.GetFileName(open.FileName);

                        pb.Image = null;

                        string imageDestinationPath = Path.Combine(@"..\..\Images", imageFileName);
                        File.Copy(open.FileName, imageDestinationPath, true);

                        command = new SqlCommand("INSERT INTO Toode (Toodenimetus,Kogus,Hind, Pilt, Kategooriad) VALUES(@toode, @kog, @pc, @pilt, @katID)", connect);
                        command.Parameters.AddWithValue("@toode", Toodenimetus.Text);
                        command.Parameters.Add("@kog", SqlDbType.Int).Value = int.Parse(Kogus.Text);
                        command.Parameters.Add("@pc", SqlDbType.Float).Value = float.Parse(Hind.Text);
                        command.Parameters.AddWithValue("@pilt", imageFileName);
                        command.Parameters.AddWithValue("@katID", Id);
                        
                        command.ExecuteNonQuery();
                        connect.Close();
                        NaitaAndmed();
                    }
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
        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_Toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT TT.Id, TT.Toodenimetus, TT.Kogus, TT.Hind, TT.Pilt, TD.Kategooria_nimetus as Kategooriad FROM TooteTable TT INNER JOIN Toodetable TD ON TT.Kategooriad = TD.Id", connect);
            adapter_toode.Fill(dt_Toode);
            DGW.Columns.Clear();
            DGW.DataSource = dt_Toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.HeaderText = "Kategooriad";
            combo_kat.Name = "KategooriaColumn";
            combo_kat.DataPropertyName = "Kategooriad";
            HashSet<string> uniqueCategories = new HashSet<string>();
            foreach (DataRow item in dt_Toode.Rows)
            {
                string category = item["Kategooriad"].ToString();
                if (!uniqueCategories.Contains(category))
                {
                    uniqueCategories.Add(category);
                    combo_kat.Items.Add(category);
                }
            }
            DGW.Columns.Add(combo_kat);
            DGW.Columns["Kategooriad"].Visible = false;


            connect.Close();
        }
        private void Uuenda(object sender, EventArgs e)
        {
            if (DGW.SelectedRows.Count > 0)
            {
                DataGridViewRow val_rida = DGW.SelectedRows[0];
                int val_rida_ID = Convert.ToInt32(val_rida.Cells["Id"].Value);

                if (Toodenimetus.Text.Trim() != string.Empty &&
                Kogus.Text.Trim() != string.Empty &&
                int.TryParse(Kogus.Text, out int kogusN) && kogusN > 0 &&
                Hind.Text.Trim() != string.Empty &&
                int.TryParse(Kogus.Text, out int HindN) && HindN > 0 &&
                Kat_Box.SelectedItem != null)
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.InitialDirectory = @"..\..\Images";
                    open.Multiselect = false;
                    open.Filter = "Images Files(*.jpeg;*.png;*.jpg;*.bmp)|*.jpeg;*.png;*.jpg;*.bmp";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        string imageFileName = Path.GetFileName(open.FileName);

                        string UUS_ToodeNimetus = Toodenimetus.Text;
                        int UUS_Kogus = int.Parse(Kogus.Text);
                        float UUS_Hind1 = float.Parse(Hind.Text);
                        float UUS_Hind = (float)Math.Round(UUS_Hind1, 2);
                        string UUS_Pilt = imageFileName;
                        string UUS_Kategooria = Kat_Box.SelectedItem.ToString();

                        try
                        {
                            if (connect.State == ConnectionState.Closed)
                            {
                                connect.Open();
                            }
                            command = new SqlCommand("SELECT Id FROM Toode WHERE Kategooria_nimetus = @kat", connect);
                            command.Parameters.AddWithValue("@kat", UUS_Kategooria);
                            int kategooriaId = Convert.ToInt32(command.ExecuteScalar());

                            command = new SqlCommand("UPDATE Toode SET Toodenimetus = @toode, Kogus = @kog, Hind = @pc, Pilt = @pilt, Kategooriad = @katID WHERE Id = @id", connect);
                            command.Parameters.AddWithValue("@toode", UUS_ToodeNimetus);
                            command.Parameters.AddWithValue("@kog", UUS_Kogus);
                            command.Parameters.AddWithValue("@pc", UUS_Hind);
                            command.Parameters.AddWithValue("@pilt", UUS_Pilt);
                            command.Parameters.AddWithValue("@katID", kategooriaId);
                            command.Parameters.AddWithValue("@id", val_rida_ID);

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
                        MessageBox.Show("Vali pilt!");
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

                    string deleteQuery = "DELETE FROM Toode WHERE Id = @id";
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
        private void OtsiFail(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"..\..\Images";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.jpg;*.bmp;*.png)|*.jpeg;*.jpg;*.bmp;*.png";

            if (open.ShowDialog() == DialogResult.OK && Toodenimetus.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\..Images");
                save.FileName = Toodenimetus.Text + Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    Image img = Image.FromFile(save.FileName);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.ClientSize = new Size(150, 150);
                    pb.Image = (Image)(new Bitmap(img, pb.ClientSize));                   
                    //pb.Image=Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toodenimetus või oli vajutatud Cancel");
            }
        }
        public void NaitaKategooriad()
        {
            Kat_Box.Items.Clear();
            Kat_Box.Text = "";
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Toode", connect);
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
        private void DGW_Pilt(object sender, EventArgs e)
        {
            if (DGW.SelectedRows.Count > 0)
            {
                string imageName = DGW.SelectedRows[0].Cells["Pilt"].Value.ToString();
                string imagePath = Path.Combine(Path.GetFullPath(@"..\..\Images"), imageName);                                            

                if (File.Exists(imagePath))
                {
                    Image img = Image.FromFile(imagePath);

                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.ClientSize = new Size(150, 150);
                    pb.Image = (Image)(new Bitmap(img, pb.ClientSize));
                }
                else
                {
                    MessageBox.Show($"Pilt '{imageName}' ei ole leitud.");
                }
            }
            else
            {
                pb.Image = null;
            }
        }        
    }
}