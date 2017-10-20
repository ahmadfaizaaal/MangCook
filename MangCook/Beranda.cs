using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangCook.Properties;

namespace MangCook
{
    public partial class Beranda : Form
    {
        Masuk formMasuk;
        Image search = Resources.searchFix;
        Image makanan = Resources.btnMakanan_FixRed;
        Image minuman = Resources.btnMinuman_FixRed;
        Image beranda = Resources.btnBeranda2;
        Image profil = Resources.btnProfil2;
        Image favorit = Resources.btnFavorit2;
        Image unggah = Resources.btnUnggah2;
        public Beranda(Masuk parent)
        {
            InitializeComponent();
            formMasuk = parent;
            btnSearch.Image = search;
            btnMakanan.Image = makanan;
            btnMinuman.Image = minuman;
            btnBeranda.Image = beranda;
            btnProfil.Image = profil;
            btnFavorit.Image = favorit;
            btnUnggah.Image = unggah;
        }

        public void kategoriMouseEnter(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnMakanan") {
                btnMakanan.Image = Resources.btnMakanan_FixWhite;
            } else if (button.Name == "btnMinuman") {
                btnMinuman.Image = Resources.btnMinuman_FixWhite;
            }
        }

        public void kategoriMouseLeave(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnMakanan") {
                btnMakanan.Image = makanan;
            } else if (button.Name == "btnMinuman") {
                btnMinuman.Image = minuman;
            }
        }

        private void zoomMouseHover(object sender, EventArgs e)
        {
            Image imageTemporary = beranda;
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnBeranda") {
                imageTemporary = beranda;
            } else if (button.Name == "btnProfil") {
                imageTemporary = profil;
            } else if (button.Name == "btnFavorit") {
                imageTemporary = favorit;
            } else if (button.Name == "btnUnggah") {
                imageTemporary = unggah;
            } else if (button.Name == "btnSearch") {
                imageTemporary = search;
            }
            int btnWidth = imageTemporary.Width + ((imageTemporary.Width * 30) / 100);
            int btnHeight = imageTemporary.Height + ((imageTemporary.Height * 30) / 100);
            Bitmap btnHover = new Bitmap(btnWidth, btnHeight);
            Graphics g = Graphics.FromImage(btnHover);
            g.DrawImage(imageTemporary, new Rectangle(Point.Empty, btnHover.Size));
            button.Image = btnHover;
        }

        private void zoomMouseLeave(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnBeranda") {
                button.Image = beranda;
            } else if (button.Name == "btnProfil") {
                button.Image = profil;
            } else if (button.Name == "btnFavorit") {
                button.Image = favorit;
            } else if (button.Name == "btnUnggah") {
                button.Image = unggah;
            } else if (button.Name == "btnSearch") {
                button.Image = search;
            }
        }

        private void Beranda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?", "Keluar", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                formMasuk.Close();
            } else {
                e.Cancel = true;
            }
        }
    }
}
