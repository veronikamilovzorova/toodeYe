namespace Tooded_DB
{
    partial class Admin_Klient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGW = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Nimi_txt = new System.Windows.Forms.TextBox();
            this.Perenimi_txt = new System.Windows.Forms.TextBox();
            this.Login_txt = new System.Windows.Forms.TextBox();
            this.Salasona_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Telefon_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW
            // 
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Location = new System.Drawing.Point(12, 192);
            this.DGW.Name = "DGW";
            this.DGW.Size = new System.Drawing.Size(776, 246);
            this.DGW.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Uuenda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Uuenda);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kustuta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Kustuta);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lisa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Lisa);
            // 
            // Nimi_txt
            // 
            this.Nimi_txt.Location = new System.Drawing.Point(567, 24);
            this.Nimi_txt.Name = "Nimi_txt";
            this.Nimi_txt.Size = new System.Drawing.Size(136, 20);
            this.Nimi_txt.TabIndex = 4;
            // 
            // Perenimi_txt
            // 
            this.Perenimi_txt.Location = new System.Drawing.Point(567, 50);
            this.Perenimi_txt.Name = "Perenimi_txt";
            this.Perenimi_txt.Size = new System.Drawing.Size(136, 20);
            this.Perenimi_txt.TabIndex = 5;
            // 
            // Login_txt
            // 
            this.Login_txt.Location = new System.Drawing.Point(567, 77);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(136, 20);
            this.Login_txt.TabIndex = 6;
            // 
            // Salasona_txt
            // 
            this.Salasona_txt.Location = new System.Drawing.Point(567, 104);
            this.Salasona_txt.Name = "Salasona_txt";
            this.Salasona_txt.PasswordChar = '*';
            this.Salasona_txt.Size = new System.Drawing.Size(136, 20);
            this.Salasona_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Perenimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salasõna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefon";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(567, 130);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(136, 20);
            this.Email_txt.TabIndex = 14;
            // 
            // Telefon_txt
            // 
            this.Telefon_txt.Location = new System.Drawing.Point(567, 156);
            this.Telefon_txt.Name = "Telefon_txt";
            this.Telefon_txt.Size = new System.Drawing.Size(136, 20);
            this.Telefon_txt.TabIndex = 15;
            // 
            // Admin_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Telefon_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salasona_txt);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.Perenimi_txt);
            this.Controls.Add(this.Nimi_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGW);
            this.Name = "Admin_Klient";
            this.Text = "Admin_Klient";
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Nimi_txt;
        private System.Windows.Forms.TextBox Perenimi_txt;
        private System.Windows.Forms.TextBox Login_txt;
        private System.Windows.Forms.TextBox Salasona_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Telefon_txt;
    }
}