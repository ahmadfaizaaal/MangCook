using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangCook
{
    public partial class EditProfil : Form
    {
        public string namaDepan, namaBelakang, tglLahir, email, kataSandi, fotoProfil, bio, jenisKelamin;
        Akun akun = new Akun();
        Profil formProfil = new Profil();
        public EditProfil()
        {
            InitializeComponent();
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
        }

        private void btnCariGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ambilGambar = new OpenFileDialog();
            ambilGambar.Filter = "File Gambar (*.jpg)|*.jpg";
            ambilGambar.Title = "Pilih Gambar";
            ambilGambar.DefaultExt = "jpg";

            if (ambilGambar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //menampilkan pada kolom nama gambar
                tbFotoProfil.Text = ambilGambar.SafeFileName;
            }
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
            fotoProfil = tbFotoProfil.Text;
            if (kataSandi == Akun.passwordMasuk)
            {
                Akun.bio = tbBio.Text;
                akun.updateProfil(Akun.idAkun, namaDepan, namaBelakang, jenisKelamin, tglLahir, email, Akun.passwordMasuk);
                this.Hide();
                formProfil.Show();
            }
            else
            {
                MessageBox.Show("Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
