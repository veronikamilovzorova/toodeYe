using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Esileht : Form
    {
        PictureBox pb_logo_pood, pb1, pb2, pb3;

        public Esileht()
        {
            InitializeComponent();
            Pildid();
            CustomizeFormAppearance();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reklaam_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Logi_sisse(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Pildid()
        {
            pb_logo_pood = new PictureBox();
            pb_logo_pood.Image = new Bitmap("../../Images/komm.jpg");
            pb_logo_pood.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_logo_pood.Location = new Point(12, 12);
            pb_logo_pood.ClientSize = new Size(150, 150);

            pb1 = new PictureBox();
            pb1.Image = new Bitmap("../../Images/banan.jpg");
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.Location = new Point(12, 240);
            pb1.ClientSize = new Size(100, 100);

            pb2 = new PictureBox();
            pb2.Image = new Bitmap("../../Images/oun.jpg");
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.Location = new Point(145, 240);
            pb2.ClientSize = new Size(100, 100);

            pb3 = new PictureBox();
            pb3.Image = new Bitmap("../../Images/twix.png");
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.Location = new Point(280, 240);
            pb3.ClientSize = new Size(100, 100);

            Controls.Add(pb_logo_pood);
            Controls.Add(pb1);
            Controls.Add(pb2);
            Controls.Add(pb3);
        }

        private void CustomizeFormAppearance()
        {
           

            button1.ForeColor = Color.Black;


            button1.Font = new Font("Arial", 12, FontStyle.Bold);
        }
    }
}
