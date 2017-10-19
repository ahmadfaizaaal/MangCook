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
    public partial class Daftar : Form
    {
        Masuk formMasuk;
        Image cancel = Resources.cancel;
        bool clicked = false;
        public Daftar()
        {
            InitializeComponent();
            formMasuk = new Masuk();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            btnCancel.Image = cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formMasuk.Show();
            clicked = true;
        }

        private void Daftar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clicked)
            {
                e.Cancel = true;
            }
        }
    }
}

