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
        Image daftar = Resources.btnDaftar;
        bool clicked = false;
        public Daftar(Masuk parent)
        {
            InitializeComponent();
            formMasuk = parent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            btnCancel.Image = cancel;
            btnDaftar.Image = daftar;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formMasuk.Show();
            this.Hide();
        }
    }
}

