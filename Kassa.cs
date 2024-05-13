using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Tooded_DB
{
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HV1;Initial Catalog=poodik;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int Id;
        OpenFileDialog open;
        SaveFileDialog save;
        Document document;
        List<string> Tooded_list = new List<string>();//tooded listisse
        private float KoguhinnaSum;
        private bool allhind = false;
        public Kassa(List<string> voetudToodedPoest)
        {
            InitializeComponent();
            Uendakorv(voetudToodedPoest);
            korv.SelectedIndexChanged += korv_valIndex;
            Tooded_list = voetudToodedPoest;
            Allhindkontroll();
        }
        private void Uendakorv(List<string> items)
        {
            foreach (var item in items)
            {
                korv.Items.Add(item);
            }
        }
        private void korv_valIndex(object sender, EventArgs e)
        {
            if (korv.SelectedItem != null)
            {
                string valToode = korv.SelectedItem.ToString();

                float toodeHind = HindAB(valToode);
                hind_txt.Text = toodeHind.ToString();
                hind_txt.ReadOnly = true;

                float HindKokku = ArvutaKorvi();

                if (allhind)
                {
                    toodeHind *= 0.95f;
                    HindKokku *= 0.95f;
                }

                hind_txt.Text = toodeHind.ToString();
                hindkokku_txt.Text = HindKokku.ToString();
                hindkokku_txt.ReadOnly = true;
            }
        }
        private float HindAB(string toodeNimi)
        {
            float toodeHind = 0.0f;

            try
            {
                connect.Open();
                string par = "SELECT Hind FROM Toode WHERE Toodenimetus = @toodenim";
                command = new SqlCommand(par, connect);
                command.Parameters.AddWithValue("@toodenim", toodeNimi);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    toodeHind = Convert.ToSingle(reader["Hind"]);
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Probleem: {ex.Message}");
            }

            return toodeHind;
        }

        private void Maksa(object sender, EventArgs e)
        {
            try
            {
                Kviitung(sender, e);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = Path.Combine(Environment.CurrentDirectory, "..", "..", "Arved"),
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string salvestaMapp = saveFileDialog.FileName;

                    document = new Document();
                    var page = document.Pages.Add();

                    var header = new Aspose.Pdf.Text.TextFragment("         \n         Tallinn\n\n");
                    header.TextState.Font = FontRepository.FindFont("Arial");
                    header.TextState.FontSize = 20;
                    page.Paragraphs.Add(header);

                    var columnHeader = new Aspose.Pdf.Text.TextFragment("Toode              \tHind \tKogus \t Kokku \n");
                    columnHeader.TextState.Font = FontRepository.FindFont("Arial");
                    columnHeader.TextState.FontSize = 12;
                    page.Paragraphs.Add(columnHeader);

                    foreach (var item in Tooded_list)
                    {
                        var content = new Aspose.Pdf.Text.TextFragment(item.Replace("\t", "           ") + "\n");
                        content.TextState.Font = FontRepository.FindFont("Arial");
                        content.TextState.FontSize = 12;
                        page.Paragraphs.Add(content);
                    }

                    page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("==============================================="));
                    var KoguHinnaTekst = new Aspose.Pdf.Text.TextFragment($"                           Kokku maksta: {KoguhinnaSum}€");
                    KoguHinnaTekst.TextState.Font = FontRepository.FindFont("Arial");
                    KoguHinnaTekst.TextState.FontSize = 12;
                    page.Paragraphs.Add(KoguHinnaTekst);

                    document.Save(salvestaMapp);
                    document.Dispose();

                    MessageBox.Show("Arve salvestatud!", "Teavitus");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Probleem: {ex.Message}");
            }
        }
        private void Kviitung(object sender, EventArgs e)
        {
            Tooded_list.Clear();
            KoguhinnaSum = 0;

            var unikToode = korv.Items.Cast<string>().Distinct().ToList();

            foreach (var item in unikToode)
            {
                string toodeNimi = item.ToString();
                float toodeHind = HindAB(toodeNimi);
                int Kogus = korv.Items.Cast<string>().Count(i => i == toodeNimi);
                float KoguHinnaSum = toodeHind * Kogus;

                Tooded_list.Add($"{toodeNimi}\t{toodeHind + "€"}\t{Kogus}\t{KoguHinnaSum + "€"}");

                KoguhinnaSum += KoguHinnaSum;
            }

            if (allhind)
            {
                float allhinnatudKoguhinnaSum = KoguhinnaSum * 0.95f;
                float allhinnatudtoodeHinne = float.Parse(hind_txt.Text) * 0.95f;
                float allhinnatudkoguSum = float.Parse(hindkokku_txt.Text) * 0.95f;

                KoguhinnaSum = allhinnatudKoguhinnaSum;
                hind_txt.Text = allhinnatudtoodeHinne.ToString();
                hindkokku_txt.Text = allhinnatudkoguSum.ToString();
            }
        }
        private float ArvutaKorvi()
        {
            float Koguhind = 0.0f;

            foreach (var item in korv.Items)
            {
                float toodeHind = HindAB(item.ToString());
                Koguhind += toodeHind;
            }

            return Koguhind;
        }
        private void Allhindkontroll()
        {
            Pood pood = Application.OpenForms.OfType<Pood>().FirstOrDefault();
            if (pood != null && pood.LoginlogVormist)
            {
                allhind = true;
                MessageBox.Show("Olete sisseloginud, ehk saate 5% soodustust.");
            }
            else
            {
                MessageBox.Show("Te pole sisseloginud, ehk ei saa 5% soodustust.");
            }
        }

    }
}