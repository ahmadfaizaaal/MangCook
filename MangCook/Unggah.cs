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

namespace MangCook
{
    public partial class Unggah : Form
    {
        public string idResep, idAkun, judul, kategori, alatBahan, stepMasak, file, date;
        public int fav;
        Akun akun = new Akun();

        private void btnBatalUnggah_Click(object sender, EventArgs e)
        {
            this.Hide();
            formBeranda.Show();
        }

        private void Unggah_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?", "MangCook", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        Beranda formBeranda = new Beranda();
        public Unggah()
        {
            InitializeComponent();
            cbKategori.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ambilGambar = new OpenFileDialog();
            ambilGambar.Filter = "File Gambar (*.jpg)|*.jpg";
            ambilGambar.Title = "Pilih Gambar";
            ambilGambar.DefaultExt = "jpg";

            if (ambilGambar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //menampilkan pada kolom nama gambar
                tbFileGambar.Text = ambilGambar.SafeFileName;
                //Resep.namaGambar = ambilGambar.FileName;
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda formBeranda = new Beranda();
            formBeranda.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil prof = new Profil();
            this.Hide();
            prof.Show();
        }

        private void btnFavorit_Click(object sender, EventArgs e)
        {
            Favorit favo = new Favorit();
            this.Hide();
            favo.Show();
        }

        private void btnUnggahResep_Click(object sender, EventArgs e)
        {
            Resep resep = new Resep();
            //data push
            idResep = "R0001";
            idAkun = Akun.idAkun;
            judul = tbJudulResep.Text;
            file = tbFileGambar.Text;
            DateTime thisDay = DateTime.Today;
            date = thisDay.ToString("yyyy-MM-dd");
            fav = 0;
            kategori = cbKategori.SelectedItem.ToString();
            alatBahan = tbBahan.Text;
            stepMasak = tbStepMasak.Text;

            //panggil method unggah

            if (String.IsNullOrEmpty(tbJudulResep.Text)&& String.IsNullOrEmpty(tbBahan.Text)&& String.IsNullOrEmpty(tbStepMasak.Text)&& String.IsNullOrEmpty(tbFileGambar.Text))
            {
                MessageBox.Show("Kolom Tidak Boleh Kosong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                akun.unggah(idResep, idAkun, judul, file, date, fav, kategori, alatBahan, stepMasak);
                //resep.unggahResep(idResep, idAkun, judul, file, date, fav, kategori, alatBahan, stepMasak);
                this.Hide();
                formBeranda.Show();
            }
        }

        private void tentangPengembang(object sender, EventArgs e)
        {
            Akun.tentangPengembang();
        }
    }
}
