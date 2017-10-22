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
        public bool MakananClicked = true, MinumanClicked;
        //integrasi menu
        public static Profil formProfil;
        public static Favorit formFfavorit;
        public static Unggah formUnggah;
        public Beranda()
        {
            InitializeComponent();
            //formMasuk = parent;
            btnSearch.Image = search;
            btnMakanan.Image = Resources.btnMakanan_FixWhite;
            btnMinuman.Image = minuman;
            btnBeranda.Image = beranda;
            btnProfil.Image = profil;
            btnFavorit.Image = favorit;
            btnUnggah.Image = unggah;
        }
        //public Beranda()
        //{

        //}
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
            if (!MakananClicked) {
                btnMakanan.Image = makanan;
            }
            if (!MinumanClicked) {
                btnMinuman.Image = minuman;
            }
        }

        private void kategoriClick(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnMakanan") {
                MakananClicked = true; MinumanClicked = false;
                btnMakanan.Image = Resources.btnMakanan_FixWhite;
                kategoriMouseEnter(sender, e);                           

            } else if (button.Name == "btnMinuman") {
                MinumanClicked = true; MakananClicked = false;
                btnMinuman.Image = Resources.btnMinuman_FixWhite;
                kategoriMouseEnter(sender, e);
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

        private void Beranda_Load(object sender, EventArgs e)
        {
            Akun a = new Akun();
            a.profil(flowLayoutPanel1);
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void btnUnggah_Click(object sender, EventArgs e)
        {
            Unggah unggah = new Unggah();
            this.Hide();
            unggah.Show();
        }

        private void Beranda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?", "MangCook", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                formMasuk.Close();
            } else {
                e.Cancel = true;
            }
        }              
    }
}
