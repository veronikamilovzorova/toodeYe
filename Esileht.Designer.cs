using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tooded_DB
{
    partial class Esileht
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
            this.button1 = new System.Windows.Forms.Button();
            this.hindsai1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logi sisse e-poodi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Logi_sisse);
            // 
            // hindsai1
            // 
            this.hindsai1.Location = new System.Drawing.Point(37, 413);
            this.hindsai1.Name = "hindsai1";
            this.hindsai1.Size = new System.Drawing.Size(35, 20);
            this.hindsai1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label9.Location = new System.Drawing.Point(192, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Vaatke rohkem meie pooes!!!";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Esileht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hindsai1);
            this.Controls.Add(this.button1);
            this.Name = "Esileht";
            this.Text = "Esileht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Label hindsai1;
        private Label label9;
    }
}