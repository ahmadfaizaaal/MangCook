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
    public partial class Masuk : Form
    {
        Daftar formDaftar;
        Image masuk = Resources.btnMasuk;
        public Masuk()
        {
            InitializeComponent();
            formDaftar = new Daftar();
            txtNamaPengguna.Text = "Nama Pengguna";
            txtKataSandi.Text = "Kata Sandi";
            btnLogin.Image = masuk;
        }

        private void placeHolderEnter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == "Nama Pengguna") {
                textbox.Text = "";
            } else if (textbox.Text == "Kata Sandi") {
                textbox.Text = "";
                textbox.PasswordChar = '\u25CF';
            }
        }

        private void placeHolderLeave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Name == "txtNamaPengguna" && textbox.Text == "") {
                textbox.Text = "Nama Pengguna";
            } else if (textbox.Name == "txtKataSandi" && textbox.Text == "") {
                textbox.PasswordChar = '\0';
                textbox.Text = "Kata Sandi";
            }
        }

        private void loginEnter(object sender, EventArgs e)
        {
            btnLogin.Image = Resources.btnMasukWhite;
        }

        private void loginLeave(object sender, EventArgs e)
        {
            btnLogin.Image = Resources.btnMasuk;
        }

        private void lblSignUp_MouseEnter(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.White;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.IndianRed;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            formDaftar.Show();
            this.Hide();
        }
    }
}
