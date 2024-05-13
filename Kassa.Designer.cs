namespace Tooded_DB
{
    partial class Kassa
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
            this.korv = new System.Windows.Forms.ListBox();
            this.Maksa_btn = new System.Windows.Forms.Button();
            this.val_toode_pb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hindkokku_txt = new System.Windows.Forms.TextBox();
            this.hind_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.val_toode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // korv
            // 
            this.korv.FormattingEnabled = true;
            this.korv.Location = new System.Drawing.Point(12, 13);
            this.korv.Name = "korv";
            this.korv.Size = new System.Drawing.Size(130, 368);
            this.korv.TabIndex = 1;
            // 
            // Maksa_btn
            // 
            this.Maksa_btn.Location = new System.Drawing.Point(311, 374);
            this.Maksa_btn.Name = "Maksa_btn";
            this.Maksa_btn.Size = new System.Drawing.Size(117, 46);
            this.Maksa_btn.TabIndex = 6;
            this.Maksa_btn.Text = "Maksa";
            this.Maksa_btn.UseVisualStyleBackColor = true;
            this.Maksa_btn.Click += new System.EventHandler(this.Maksa);
            // 
            // val_toode_pb
            // 
            this.val_toode_pb.Location = new System.Drawing.Point(278, 19);
            this.val_toode_pb.Name = "val_toode_pb";
            this.val_toode_pb.Size = new System.Drawing.Size(150, 150);
            this.val_toode_pb.TabIndex = 7;
            this.val_toode_pb.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hind kokku";
            // 
            // hindkokku_txt
            // 
            this.hindkokku_txt.Location = new System.Drawing.Point(12, 400);
            this.hindkokku_txt.Name = "hindkokku_txt";
            this.hindkokku_txt.Size = new System.Drawing.Size(130, 20);
            this.hindkokku_txt.TabIndex = 8;
            // 
            // hind_txt
            // 
            this.hind_txt.Location = new System.Drawing.Point(148, 35);
            this.hind_txt.Name = "hind_txt";
            this.hind_txt.Size = new System.Drawing.Size(100, 20);
            this.hind_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hind";
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hindkokku_txt);
            this.Controls.Add(this.val_toode_pb);
            this.Controls.Add(this.Maksa_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hind_txt);
            this.Controls.Add(this.korv);
            this.Name = "Kassa";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.val_toode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox korv;
        private System.Windows.Forms.Button Maksa_btn;
        private System.Windows.Forms.PictureBox val_toode_pb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hindkokku_txt;
        private System.Windows.Forms.TextBox hind_txt;
        private System.Windows.Forms.Label label2;
    }
}