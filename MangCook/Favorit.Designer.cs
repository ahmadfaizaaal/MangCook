﻿namespace MangCook
{
    partial class Favorit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorit));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.copyRight = new System.Windows.Forms.Label();
            this.btnUnggah = new System.Windows.Forms.PictureBox();
            this.btnFavorit = new System.Windows.Forms.PictureBox();
            this.btnProfil = new System.Windows.Forms.PictureBox();
            this.btnBeranda = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnggah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeranda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panelContent);
            this.panel2.Controls.Add(this.copyRight);
            this.panel2.Controls.Add(this.btnUnggah);
            this.panel2.Controls.Add(this.btnFavorit);
            this.panel2.Controls.Add(this.btnProfil);
            this.panel2.Controls.Add(this.btnBeranda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 565);
            this.panel2.TabIndex = 3;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Cornsilk;
            this.panelContent.Controls.Add(this.flowLayoutPanel1);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Location = new System.Drawing.Point(12, 96);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(756, 441);
            this.panelContent.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(743, 359);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(288, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 38);
            this.label9.TabIndex = 7;
            this.label9.Text = "Favorit Saya";
            // 
            // copyRight
            // 
            this.copyRight.AutoSize = true;
            this.copyRight.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRight.ForeColor = System.Drawing.Color.White;
            this.copyRight.Location = new System.Drawing.Point(308, 542);
            this.copyRight.Name = "copyRight";
            this.copyRight.Size = new System.Drawing.Size(165, 13);
            this.copyRight.TabIndex = 12;
            this.copyRight.Text = "Powered by 4 Negeri 5 Menara";
            this.copyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.copyRight.Click += new System.EventHandler(this.tentangPengembang);
            // 
            // btnUnggah
            // 
            this.btnUnggah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnggah.Image = global::MangCook.Properties.Resources.btnUnggah;
            this.btnUnggah.Location = new System.Drawing.Point(675, 43);
            this.btnUnggah.Name = "btnUnggah";
            this.btnUnggah.Size = new System.Drawing.Size(92, 28);
            this.btnUnggah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUnggah.TabIndex = 11;
            this.btnUnggah.TabStop = false;
            this.btnUnggah.Click += new System.EventHandler(this.btnUnggah_Click);
            // 
            // btnFavorit
            // 
            this.btnFavorit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorit.Image = global::MangCook.Properties.Resources.btnFavorit;
            this.btnFavorit.Location = new System.Drawing.Point(577, 43);
            this.btnFavorit.Name = "btnFavorit";
            this.btnFavorit.Size = new System.Drawing.Size(92, 28);
            this.btnFavorit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFavorit.TabIndex = 10;
            this.btnFavorit.TabStop = false;
            // 
            // btnProfil
            // 
            this.btnProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfil.Image = global::MangCook.Properties.Resources.btnProfil;
            this.btnProfil.Location = new System.Drawing.Point(479, 43);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(92, 28);
            this.btnProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProfil.TabIndex = 9;
            this.btnProfil.TabStop = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnBeranda
            // 
            this.btnBeranda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeranda.Image = global::MangCook.Properties.Resources.btnBeranda2;
            this.btnBeranda.Location = new System.Drawing.Point(381, 43);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Size = new System.Drawing.Size(92, 28);
            this.btnBeranda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBeranda.TabIndex = 8;
            this.btnBeranda.TabStop = false;
            this.btnBeranda.Click += new System.EventHandler(this.btnBeranda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cara tepat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MangCook.Properties.Resources.mang_cook;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "cari resep kuliner lezat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mang-Cook";
            // 
            // Favorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Favorit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangCook ~ FAVORIT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Favorit_FormClosing);
            this.Load += new System.EventHandler(this.Favorit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnggah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeranda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label copyRight;
        private System.Windows.Forms.PictureBox btnUnggah;
        private System.Windows.Forms.PictureBox btnFavorit;
        private System.Windows.Forms.PictureBox btnProfil;
        private System.Windows.Forms.PictureBox btnBeranda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}