﻿namespace Tooded_DB
{
    partial class Form1
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Toodenimetus = new System.Windows.Forms.TextBox();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.Hind = new System.Windows.Forms.TextBox();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW
            // 
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Location = new System.Drawing.Point(12, 235);
            this.DGW.Name = "DGW";
            this.DGW.Size = new System.Drawing.Size(734, 171);
            this.DGW.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lisa kategooria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Lisa_Kategooria);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kustuta kategooria";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Kustuta_Kategooria);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Otsi fail";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OtsiFail);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Lisa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Lisa);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(468, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Uuenda";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Uuenda);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(549, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "Kustuta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Kustuta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toode nimetus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategooria";
            // 
            // Toodenimetus
            // 
            this.Toodenimetus.Location = new System.Drawing.Point(143, 29);
            this.Toodenimetus.Name = "Toodenimetus";
            this.Toodenimetus.Size = new System.Drawing.Size(123, 20);
            this.Toodenimetus.TabIndex = 11;
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(143, 62);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(123, 20);
            this.Kogus.TabIndex = 12;
            // 
            // Hind
            // 
            this.Hind.Location = new System.Drawing.Point(143, 95);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(123, 20);
            this.Hind.TabIndex = 13;
            // 
            // Kat_Box
            // 
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(143, 128);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(123, 21);
            this.Kat_Box.TabIndex = 14;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(468, 25);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(150, 150);
            this.pb.TabIndex = 15;
            this.pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.Toodenimetus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGW);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Toodenimetus;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.TextBox Hind;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.PictureBox pb;
    }
}

