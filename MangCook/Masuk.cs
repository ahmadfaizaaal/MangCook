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
        public static Daftar formDaftar;
        public static Beranda formBeranda;
        Image masuk = Resources.btnMasuk;
        public string emailPengguna = "ahmadfaizaaal@gmail.com";
        public string kataSandi = "bismillah22";
        public Masuk()
        {
            InitializeComponent();
            formDaftar = new Daftar(this);
            formBeranda = new Beranda(this);
            txtEmail.Text = "Email Pengguna";
            txtKataSandi.Text = "Kata Sandi";
            btnLogin.Image = masuk;
        }

        private void placeHolderEnter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == "Email Pengguna") {
                textbox.Text = "";
            } else if (textbox.Text == "Kata Sandi") {
                textbox.Text = "";
                textbox.PasswordChar = '\u25CF';
            }
        }

        private void placeHolderLeave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Name == "txtEmail" && textbox.Text == "") {
                textbox.Text = "Email Pengguna";
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cekAuthority();
        }

        public void cekAuthority()
        {
            if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtKataSandi.Text)) {
                if (txtEmail.Text == emailPengguna && txtKataSandi.Text == kataSandi) {
                    formBeranda.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Email pengguna atau kata sandi salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Isi email pengguna dan kata sandi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void whenEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cekAuthority();
            }
        }
    }
}
