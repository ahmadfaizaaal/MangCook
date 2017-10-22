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
    public partial class Favorit : Form
    {
        public Favorit()
        {
            InitializeComponent();
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

        private void btnUnggah_Click(object sender, EventArgs e)
        {
            Unggah unggah = new Unggah();
            this.Hide();
            unggah.Show();
        }

        Akun akun = new Akun();
        private void Favorit_Load(object sender, EventArgs e)
        {
            akun.favorit(flowLayoutPanel1);         
        }

        private void Favorit_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
