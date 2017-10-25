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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();            
        }

        Akun akun = new Akun();
        private void Profil_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width - 3, pictureBox2.Height - 3);
            Region rg = new Region(gp);
            pictureBox2.Region = rg;
            akun.resepProfil(flowLayoutPanel1, Akun.idAkun);
            akun.dataProfil(label9, label10, pictureBox2, label4, label5, label6, Akun.idAkun);
        }               

        private void bisaDiklik(object sender, EventArgs e)
        {
            Detail det = new Detail();
            det.Show();
            this.Hide();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda formBeranda = new Beranda();
            formBeranda.Show();
            this.Hide();
           
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

        private void Profil_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnEditProfil_Click(object sender, EventArgs e)
        {
            Akun akun = new Akun();
            akun.loadForEdit(Akun.idAkun);
            EditProfil formEditProfil = new EditProfil();
            formEditProfil.Show();
            this.Hide();
        }

        private void tentangPengembang(object sender, EventArgs e)
        {
            Akun.tentangPengembang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masuk mas = new Masuk();
            this.Hide();
            mas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Akun ak = new Akun();
            ak.hapusContent(Resep.idResep);
            this.Hide();
            Profil pro = new Profil();
            pro.Show();
        }
    }
}
