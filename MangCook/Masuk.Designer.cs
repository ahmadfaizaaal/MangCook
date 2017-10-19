namespace MangCook
{
    partial class Masuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masuk));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panelMasuk = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblBlmPunyaAkun = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.txtKataSandi = new System.Windows.Forms.TextBox();
            this.txtNamaPengguna = new System.Windows.Forms.TextBox();
            this.copyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panelMasuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::MangCook.Properties.Resources.mang_cook;
            this.pctLogo.Location = new System.Drawing.Point(309, 72);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(167, 173);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // panelMasuk
            // 
            this.panelMasuk.BackColor = System.Drawing.Color.Transparent;
            this.panelMasuk.Controls.Add(this.lblSignUp);
            this.panelMasuk.Controls.Add(this.lblBlmPunyaAkun);
            this.panelMasuk.Controls.Add(this.btnLogin);
            this.panelMasuk.Controls.Add(this.txtKataSandi);
            this.panelMasuk.Controls.Add(this.txtNamaPengguna);
            this.panelMasuk.Location = new System.Drawing.Point(248, 251);
            this.panelMasuk.Name = "panelMasuk";
            this.panelMasuk.Size = new System.Drawing.Size(289, 217);
            this.panelMasuk.TabIndex = 1;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSignUp.Location = new System.Drawing.Point(178, 100);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(52, 16);
            this.lblSignUp.TabIndex = 4;
            this.lblSignUp.Text = "Daftar!";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            this.lblSignUp.MouseEnter += new System.EventHandler(this.lblSignUp_MouseEnter);
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            // 
            // lblBlmPunyaAkun
            // 
            this.lblBlmPunyaAkun.AutoSize = true;
            this.lblBlmPunyaAkun.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlmPunyaAkun.ForeColor = System.Drawing.Color.White;
            this.lblBlmPunyaAkun.Location = new System.Drawing.Point(57, 100);
            this.lblBlmPunyaAkun.Name = "lblBlmPunyaAkun";
            this.lblBlmPunyaAkun.Size = new System.Drawing.Size(126, 16);
            this.lblBlmPunyaAkun.TabIndex = 3;
            this.lblBlmPunyaAkun.Text = "Belum punya akun? |";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = global::MangCook.Properties.Resources.btnMasuk;
            this.btnLogin.Location = new System.Drawing.Point(87, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 35);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.MouseEnter += new System.EventHandler(this.loginEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.loginLeave);
            // 
            // txtKataSandi
            // 
            this.txtKataSandi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKataSandi.Location = new System.Drawing.Point(15, 61);
            this.txtKataSandi.Name = "txtKataSandi";
            this.txtKataSandi.Size = new System.Drawing.Size(261, 27);
            this.txtKataSandi.TabIndex = 1;
            this.txtKataSandi.Text = "Kata Sandi";
            this.txtKataSandi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKataSandi.Enter += new System.EventHandler(this.placeHolderEnter);
            this.txtKataSandi.Leave += new System.EventHandler(this.placeHolderLeave);
            // 
            // txtNamaPengguna
            // 
            this.txtNamaPengguna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPengguna.Location = new System.Drawing.Point(15, 14);
            this.txtNamaPengguna.Name = "txtNamaPengguna";
            this.txtNamaPengguna.Size = new System.Drawing.Size(261, 27);
            this.txtNamaPengguna.TabIndex = 0;
            this.txtNamaPengguna.Text = "Nama Pengguna";
            this.txtNamaPengguna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNamaPengguna.Enter += new System.EventHandler(this.placeHolderEnter);
            this.txtNamaPengguna.Leave += new System.EventHandler(this.placeHolderLeave);
            // 
            // copyRight
            // 
            this.copyRight.AutoSize = true;
            this.copyRight.BackColor = System.Drawing.Color.Transparent;
            this.copyRight.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRight.ForeColor = System.Drawing.Color.White;
            this.copyRight.Location = new System.Drawing.Point(308, 539);
            this.copyRight.Name = "copyRight";
            this.copyRight.Size = new System.Drawing.Size(165, 13);
            this.copyRight.TabIndex = 2;
            this.copyRight.Text = "Powered by 4 Negeri 5 Menara";
            this.copyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.copyRight);
            this.Controls.Add(this.panelMasuk);
            this.Controls.Add(this.pctLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Masuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mang-Cook ~ LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.panelMasuk.ResumeLayout(false);
            this.panelMasuk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel panelMasuk;
        private System.Windows.Forms.TextBox txtNamaPengguna;
        private System.Windows.Forms.TextBox txtKataSandi;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblBlmPunyaAkun;
        private System.Windows.Forms.Label copyRight;
    }
}