using System.Drawing;
using System.Windows.Forms;

namespace Tooded_DB
{
    partial class Login
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
            this.salasona_txt = new System.Windows.Forms.TextBox();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unustasin_btn = new System.Windows.Forms.Button();
            this.loouuuskasutaja_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.logikylalisena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salasona_txt
            // 
            this.salasona_txt.Location = new System.Drawing.Point(100, 140);
            this.salasona_txt.Name = "salasona_txt";
            this.salasona_txt.PasswordChar = '*';
            this.salasona_txt.Size = new System.Drawing.Size(236, 20);
            this.salasona_txt.TabIndex = 0;
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(100, 74);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(236, 20);
            this.login_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salasõna";
            // 
            // unustasin_btn
            // 
            this.unustasin_btn.Location = new System.Drawing.Point(24, 188);
            this.unustasin_btn.Name = "unustasin_btn";
            this.unustasin_btn.Size = new System.Drawing.Size(104, 40);
            this.unustasin_btn.TabIndex = 5;
            this.unustasin_btn.Text = "Unustasin salasõna";
            this.unustasin_btn.UseVisualStyleBackColor = true;
            this.unustasin_btn.Click += new System.EventHandler(this.unustasin_btn_Click);
            // 
            // loouuuskasutaja_btn
            // 
            this.loouuuskasutaja_btn.Location = new System.Drawing.Point(134, 188);
            this.loouuuskasutaja_btn.Name = "loouuuskasutaja_btn";
            this.loouuuskasutaja_btn.Size = new System.Drawing.Size(104, 40);
            this.loouuuskasutaja_btn.TabIndex = 6;
            this.loouuuskasutaja_btn.Text = "Loo uus kasutaja";
            this.loouuuskasutaja_btn.UseVisualStyleBackColor = true;
            this.loouuuskasutaja_btn.Click += new System.EventHandler(this.loouuuskasutaja_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(375, 88);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(68, 58);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logikylalisena
            // 
            this.logikylalisena.Location = new System.Drawing.Point(244, 188);
            this.logikylalisena.Name = "logikylalisena";
            this.logikylalisena.Size = new System.Drawing.Size(104, 40);
            this.logikylalisena.TabIndex = 8;
            this.logikylalisena.Text = "Logi külalisena";
            this.logikylalisena.UseVisualStyleBackColor = true;
            this.logikylalisena.Click += new System.EventHandler(this.logikylalisena_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.logikylalisena);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.loouuuskasutaja_btn);
            this.Controls.Add(this.unustasin_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.salasona_txt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salasona_txt;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button unustasin_btn;
        private System.Windows.Forms.Button loouuuskasutaja_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button logikylalisena;
    }
}