namespace MangCook
{
    partial class EditProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfil));
            this.copyRight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTglLahir = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnCariGambar = new System.Windows.Forms.Button();
            this.tbBio = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFotoProfil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmailBaru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamaBelakangBaru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNamaDepanBaru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.panelContent);
            this.panel2.Controls.Add(this.copyRight);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 565);
            this.panel2.TabIndex = 6;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panelContent.BackColor = System.Drawing.Color.Cornsilk;
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.cbJenisKelamin);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.tbTglLahir);
            this.panelContent.Controls.Add(this.btnSimpan);
            this.panelContent.Controls.Add(this.btnBatal);
            this.panelContent.Controls.Add(this.btnCariGambar);
            this.panelContent.Controls.Add(this.tbBio);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.tbFotoProfil);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.tbPassword);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.tbEmailBaru);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.tbNamaBelakangBaru);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.tbNamaDepanBaru);
            this.panelContent.Font = new System.Drawing.Font("Informal Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContent.Location = new System.Drawing.Point(12, 96);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(756, 441);
            this.panelContent.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(174, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Jenis Kelamin";
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisKelamin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJenisKelamin.FormattingEnabled = true;
            this.cbJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cbJenisKelamin.Location = new System.Drawing.Point(323, 166);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(201, 28);
            this.cbJenisKelamin.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(174, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tanggal Lahir";
            // 
            // tbTglLahir
            // 
            this.tbTglLahir.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.tbTglLahir.CustomFormat = "dd MMMM yyyy";
            this.tbTglLahir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbTglLahir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTglLahir.Location = new System.Drawing.Point(323, 128);
            this.tbTglLahir.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tbTglLahir.Name = "tbTglLahir";
            this.tbTglLahir.Size = new System.Drawing.Size(201, 26);
            this.tbTglLahir.TabIndex = 18;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Green;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimpan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(530, 450);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(98, 28);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Maroon;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBatal.Location = new System.Drawing.Point(426, 450);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 28);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCariGambar
            // 
            this.btnCariGambar.BackColor = System.Drawing.Color.LightGray;
            this.btnCariGambar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariGambar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCariGambar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariGambar.Location = new System.Drawing.Point(530, 244);
            this.btnCariGambar.Name = "btnCariGambar";
            this.btnCariGambar.Size = new System.Drawing.Size(98, 28);
            this.btnCariGambar.TabIndex = 13;
            this.btnCariGambar.Text = "Browse";
            this.btnCariGambar.UseVisualStyleBackColor = false;
            this.btnCariGambar.Click += new System.EventHandler(this.btnCariGambar_Click);
            // 
            // tbBio
            // 
            this.tbBio.BackColor = System.Drawing.Color.Moccasin;
            this.tbBio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBio.Location = new System.Drawing.Point(323, 285);
            this.tbBio.Name = "tbBio";
            this.tbBio.Size = new System.Drawing.Size(305, 98);
            this.tbBio.TabIndex = 12;
            this.tbBio.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(249, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(202, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Foto Profil";
            // 
            // tbFotoProfil
            // 
            this.tbFotoProfil.BackColor = System.Drawing.Color.Moccasin;
            this.tbFotoProfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFotoProfil.Location = new System.Drawing.Point(323, 244);
            this.tbFotoProfil.Name = "tbFotoProfil";
            this.tbFotoProfil.Size = new System.Drawing.Size(201, 26);
            this.tbFotoProfil.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(114, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Konfirmasi Kata Sandi";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Moccasin;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(323, 396);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(305, 26);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(232, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // tbEmailBaru
            // 
            this.tbEmailBaru.BackColor = System.Drawing.Color.Moccasin;
            this.tbEmailBaru.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailBaru.Location = new System.Drawing.Point(323, 207);
            this.tbEmailBaru.Name = "tbEmailBaru";
            this.tbEmailBaru.Size = new System.Drawing.Size(305, 26);
            this.tbEmailBaru.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(152, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Belakang";
            // 
            // tbNamaBelakangBaru
            // 
            this.tbNamaBelakangBaru.BackColor = System.Drawing.Color.Moccasin;
            this.tbNamaBelakangBaru.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBelakangBaru.Location = new System.Drawing.Point(323, 87);
            this.tbNamaBelakangBaru.Name = "tbNamaBelakangBaru";
            this.tbNamaBelakangBaru.Size = new System.Drawing.Size(305, 26);
            this.tbNamaBelakangBaru.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(173, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Depan";
            // 
            // tbNamaDepanBaru
            // 
            this.tbNamaDepanBaru.BackColor = System.Drawing.Color.Moccasin;
            this.tbNamaDepanBaru.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaDepanBaru.Location = new System.Drawing.Point(323, 45);
            this.tbNamaDepanBaru.Name = "tbNamaDepanBaru";
            this.tbNamaDepanBaru.Size = new System.Drawing.Size(305, 26);
            this.tbNamaDepanBaru.TabIndex = 0;
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
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = global::MangCook.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(748, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 24);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label copyRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNamaDepanBaru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFotoProfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmailBaru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNamaBelakangBaru;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnCariGambar;
        private System.Windows.Forms.RichTextBox tbBio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker tbTglLahir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbJenisKelamin;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}