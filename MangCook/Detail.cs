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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Detail_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKirimKomentar_Click(object sender, EventArgs e)
        {
            Akun akn = new Akun();
            akn.komentar(textBox1.Text,richTextBox2);
            textBox1.Text = "";
            //MessageBox.Show(Resep.idResep + " " + Akun.idAkun, "Tes", MessageBoxButtons.OK);
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            Resep res = new Resep();
            Akun akun = new Akun();
            //MessageBox.Show(Resep.idResep+" "+Akun.idAkun, "Tes", MessageBoxButtons.OK);
            res.detailData(label11, label12, pictureBox2, richTextBox1, tbResep);
            akun.tampilKomentar(richTextBox2);
            
        }

        
    }
}
