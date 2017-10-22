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
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            //Beranda beranda = new Beranda();
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
            //data push
            idResep = "10019";
            idAkun = "A0001";
            judul = tbJudulResep.Text;
            file = tbFileGambar.Text;
            date = "2017/10/27";
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
                this.Hide();
                formBeranda.Show();
            }
        }
    }
}
