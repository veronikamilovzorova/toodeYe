namespace Tooded_DB
{
    partial class Meeldtetuletamine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.tm_btn = new System.Windows.Forms.Button();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasõna meeldetuletamine";
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(114, 88);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(135, 20);
            this.login_txt.TabIndex = 2;
            // 
            // tm_btn
            // 
            this.tm_btn.Location = new System.Drawing.Point(269, 88);
            this.tm_btn.Name = "tm_btn";
            this.tm_btn.Size = new System.Drawing.Size(75, 46);
            this.tm_btn.TabIndex = 3;
            this.tm_btn.Text = "Tuleta meelde";
            this.tm_btn.UseVisualStyleBackColor = true;
            this.tm_btn.Click += new System.EventHandler(this.Tuleta_meelde);
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(114, 117);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(135, 20);
            this.email_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            // 
            // Meeldtetuletamine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.tm_btn);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Meeldtetuletamine";
            this.Text = "Meeldtetuletamine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Button tm_btn;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label3;
    }
}