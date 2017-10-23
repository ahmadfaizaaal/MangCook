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
        public string namaLengkap, jenisKelamin, tglLahir;
        Akun akun = new Akun();
        public Daftar(Masuk parent)
        {
            InitializeComponent();
            formMasuk = parent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            btnCancel.Image = cancel;
            btnDaftar.Image = daftar;
            cbJK.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formMasuk.Show();
            this.Hide();
        }

        private void btnDaftar_MouseEnter(object sender, EventArgs e)
        {
            btnDaftar.Image = Resources.btnDaftarWhite;
        }

        private void btnDaftar_MouseLeave(object sender, EventArgs e)
        {
            btnDaftar.Image = daftar;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            DateTime date = dataTglLahir.Value;
            if (!String.IsNullOrEmpty(txtNamaDepan.Text) && !String.IsNullOrEmpty(txtEmail.Text) && 
                !String.IsNullOrEmpty(txtKataSandi.Text) && !String.IsNullOrEmpty(txtKonfirmKataSandi.Text)) {
                if (txtKataSandi.Text == txtKonfirmKataSandi.Text) {
                    namaLengkap = txtNamaDepan.Text + " " + txtNamaBelakang.Text;
                    formMasuk.emailPengguna = txtEmail.Text;
                    formMasuk.kataSandi = txtKataSandi.Text;
                    jenisKelamin = cbJK.SelectedItem.ToString();
                    tglLahir = date.ToString("dd-MM-yyyy");

                    
                    if (akun.cekemail(txtEmail.Text)=="belum ada")
                    {
                        akun.daftar(txtNamaDepan.Text, txtNamaBelakang.Text, txtEmail.Text, txtKataSandi.Text, jenisKelamin, tglLahir);
                        if (MessageBox.Show("Pendaftaran akun telah berhasil!", "MangCook", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            btnCancel_Click(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email telah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                } else {
                    txtKonfirmKataSandi.SelectAll();
                    txtKonfirmKataSandi.Focus();
                    MessageBox.Show("Kata sandi tidak sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Data tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tentangPengembang(object sender, EventArgs e)
        {
            Akun.tentangPengembang();
        }
    }
}

