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
            panelContent.VerticalScroll.Visible = true;
        }

              
        private void Profil_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {                
                Akun akun = new Akun();                            
                flowLayoutPanel1.Controls.Add(akun.contentFlow());                
                //panel3.Controls.Add(akun.panelKiri());

            }
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
    }
}
