using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MangCook.Properties;

namespace MangCook
{
    public partial class EditProfil : Form
    {
        public string namaDepan, namaBelakang, tglLahir, email, kataSandi, bio, jenisKelamin;
        public PictureBox gambarProfil;
        public static string bioHasilLoad;
        public byte[] fotoProfil;
        Akun akun = new Akun();
        Profil formProfil = new Profil();
        public EditProfil()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tbNamaDepanBaru.Text = Akun.namaDpn;
            tbNamaBelakangBaru.Text = Akun.namaBlk;
            tbTglLahir.Text = Akun.tggalLahir;
            tbEmailBaru.Text = Akun.emailPengguna;
            if (Akun.jenisKelamin.ToLower() == "laki-laki")
            {
                cbJenisKelamin.SelectedIndex = 0;
            }
            else
            {
                cbJenisKelamin.SelectedIndex = 1;
            }
            tbBio.Text = bioHasilLoad;
            //tbFotoProfil.Text = Akun.fotoProfil;
        }

        bool clicked = false;
        private void btnCariGambar_Click(object sender, EventArgs e)
        {
            gambarProfil = new PictureBox();
            OpenFileDialog ambilGambar = new OpenFileDialog();
            ambilGambar.Filter = "File Gambar (*.jpg)|*.jpg";
            ambilGambar.Title = "Pilih Gambar";
            ambilGambar.DefaultExt = "jpg";

            if (ambilGambar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                clicked = true;
                //menampilkan pada kolom nama gambar
                tbFotoProfil.Text = ambilGambar.SafeFileName;
                gambarProfil.Image = Image.FromFile(ambilGambar.FileName);
            }
        }

        

        public byte[] byteImage()
        {
            MemoryStream memoryStream = new MemoryStream();
            gambarProfil.Image.Save(memoryStream, gambarProfil.Image.RawFormat);
            byte[] image = memoryStream.ToArray();
            return image;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime date = tbTglLahir.Value;
            namaDepan = tbNamaDepanBaru.Text;
            namaBelakang = tbNamaBelakangBaru.Text;
            tglLahir = date.ToString("yyyy-MM-dd");
            email = tbEmailBaru.Text;
            jenisKelamin = cbJenisKelamin.Text;
            kataSandi = tbPassword.Text;
            if (clicked) {
                fotoProfil = byteImage();
                clicked = false;
            }
            bio = tbBio.Text;
            if (kataSandi == Akun.passwordMasuk)
            {
                akun.updateProfil(Akun.idAkun, namaDepan, namaBelakang, jenisKelamin, tglLahir, email, Akun.passwordMasuk, bio, fotoProfil);
                this.Hide();
                formProfil.Show();
            }
            else
            {
                MessageBox.Show("Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            formProfil.Show();
        }

        private void tentangPengembang(object sender, EventArgs e)
        {
            Akun.tentangPengembang();
        }
    }
}
