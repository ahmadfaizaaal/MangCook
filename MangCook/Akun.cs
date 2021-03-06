﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;

namespace MangCook
{
    class Akun : Sql
    {
        //MySqlDataAdapter dataAdapter;
        public string namaDepan, namaBelakang, email, katSan, jeniskel, tglLahir, queri, idResep;
        public static string passwordMasuk, idAkun, namaDpn, namaBlk, jenisKelamin, tggalLahir, emailPengguna, bio;
        public Panel panelFlow,clickedPanel;
        private bool clicked = false;
        public Akun(string namaDepan, string namaBelakang, string email, string katSan, string jeniskel, string tglLahir)
        {
            this.namaDepan = namaDepan;
            this.namaBelakang = namaBelakang;
            this.email = email;
            this.katSan = katSan;
            this.jeniskel = jeniskel;
            this.tglLahir = tglLahir;
        }

        public Akun()
        {

        }
        public string login(string emailuser, string pass)
        {
            string hasil = "gagal";
            int count = 0;
            koneksi.Open();
            queri = "select * from akun where email ='" + emailuser + "' and password='" + pass + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                count += 1;
                idAkun = reader.GetString("idAkun");
            }
            if (count == 1)
            {
                namaDpn = reader.GetString("namaDepan");
                namaBlk = reader.GetString("namaBelakang");
                jenisKelamin = reader.GetString("jenisKelamin");
                tggalLahir = reader.GetString("tanggalLahir");
                emailPengguna = reader.GetString("email");
                passwordMasuk = pass;
                bio = reader.GetString("bio");
                //fotoProfil = reader.GetString("fotoProfil");
                hasil = "sukses";
            }
            koneksi.Close();
            return hasil;
        }

        public string daftar(string namaDepan, string namaBelakang, string email, string katSan, string jeniskel, string tglLahir)
        {
            koneksi.Open();
            queri = "insert into akun (idAkun,namaDepan,namaBelakang,jenisKelamin,tanggalLahir,email,password) value('" + "','" + namaDepan + "','" + namaBelakang + "','" + jeniskel + "','" + tglLahir + "','" + email + "','" + katSan + "')";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            string hasil = "sukses";
            koneksi.Close();
            return hasil;
        }
        public string cekemail(string email)
        {
            int count = 0;
            string hasil;
            koneksi.Open();
            queri = "select* from akun where email = '" + email + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 0)
            {
                hasil = "belum ada";
            }
            else
            {
                hasil = "sudah ada";
            }
            koneksi.Close();
            return hasil;
        }

        public string difavoritkan()
        {
            string jumlahFavorit = "0";
            koneksi.Open();
            queri = "SELECT count(resep.idAkun) AS jumlahFavorit FROM favorit join resep on favorit.idResep = resep.idResep WHERE resep.idAkun = '" + idAkun + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                jumlahFavorit = reader.GetString("jumlahFavorit");
            }
            koneksi.Close();
            return jumlahFavorit;
        }

        public void loadForEdit(string idakun)
        {
            koneksi.Open();
            queri = "SELECT * FROM akun where akun.idAkun = '" + idakun + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                emailPengguna = reader.GetString("email");
                namaDpn = reader.GetString("namaDepan");
                namaBlk = reader.GetString("namaBelakang");
                bio = reader.GetString("bio");
                tggalLahir = reader.GetString("tanggalLahir");
                jenisKelamin = reader.GetString("jenisKelamin");
                EditProfil.bioHasilLoad = bio;
            }
            koneksi.Close();
        }

        int count = 0;
        public void dataProfil(Label post, Label jumfav, PictureBox pic, Label email, Label nama, Label motiv, string idakun)
        {
            koneksi.Open();
            queri = "SELECT * FROM akun where akun.idAkun = '" + idakun + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                //PictureBox hasilGambar = new PictureBox();
                post.Text = count.ToString();
                //jumfav.Text = reader.GetString("favorit");
                //pic.Image =
                email.Text = reader.GetString("email");
                nama.Text = reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang");
                motiv.Text = reader.GetString("bio");

                byte[] img = (byte[])reader["fotoProfil"];
                MemoryStream memorystream = new MemoryStream(img);
                Image temp = Image.FromStream(memorystream);
                pic.Image = new Bitmap(temp);
            }
            koneksi.Close();
            jumfav.Text = difavoritkan();
        }

        public void resepProfil(FlowLayoutPanel a, string y)
        {
            koneksi.Open();
            queri = "SELECT akun.idAkun,resep.idResep, namaResep,akun.namaDepan,akun.namaBelakang,favorit,resep.gambar FROM resep join akun on resep.idAkun = akun.idAkun where akun.idAkun = '" + y + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PictureBox hasilGambar = new PictureBox();
                count += 1;
                string ala = reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang");
                string judulRes = reader.GetString("namaResep");
                string favor = reader.GetString("favorit");
                string idResep = reader.GetString("idResep");
                string idAkun = reader.GetString("idAkun");

                byte[] img = (byte[])reader["gambar"];
                MemoryStream memorystream = new MemoryStream(img);
                Image temp = Image.FromStream(memorystream);
                hasilGambar.Image = new Bitmap(temp);
                a.Controls.Add(contentFlow(idAkun, idResep, hasilGambar, judulRes, "Ala " + ala, favor));
            }
            koneksi.Close();
        }

        public void favorit(FlowLayoutPanel b, string xx)
        {
            koneksi.Open();
            queri = "SELECT * FROM favorit join resep on favorit.idResep = resep.idResep join akun on resep.idAkun = akun.idAkun where favorit.idAkun = '"+xx+"'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PictureBox hasilGambar = new PictureBox();
                string ala = reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang");
                string judulRes = reader.GetString("namaResep");
                string favor = reader.GetString("favorit");
                string idResep = reader.GetString("idResep");
                string idAkun = reader.GetString("idAkun");

                byte[] img = (byte[])reader["gambar"];
                MemoryStream memorystream = new MemoryStream(img);
                Image temp = Image.FromStream(memorystream);
                hasilGambar.Image = new Bitmap(temp);
                b.Controls.Add(contentFlow(idAkun, idResep, hasilGambar, judulRes, "Ala " + ala, favor));
            }
            koneksi.Close();
        }


        public void updateProfil(string idAkun, string namaDepan, string namaBelakang, string jenisKelamin, string tanggalLahir, string email, string password, string bio, byte[] fotoProfil)
        {
            koneksi.Open();
            queri = "update akun SET namaDepan = @namaDepan" +
                ", namaBelakang = @namaBelakang" +
                ", jenisKelamin = @jenisKelamin" +
                ", tanggalLahir = @tanggalLahir" +
                ", email = @email" +
                ", bio = @bio" +
                ", fotoProfil = @fotoProfil " +
                "where idAkun = @idAkun;";

            string queriWithoutImage = "update akun SET namaDepan = @namaDepan" +
                ", namaBelakang = @namaBelakang" +
                ", jenisKelamin = @jenisKelamin" +
                ", tanggalLahir = @tanggalLahir" +
                ", email = @email" +
                ", bio = @bio " +
                "where idAkun = @idAkun;";

            if (fotoProfil != null) {
                command = new MySqlCommand(queri, koneksi);
            } else {
                command = new MySqlCommand(queriWithoutImage, koneksi);
            }

            command.Parameters.Add("@idAkun", MySqlDbType.VarChar, 5);
            command.Parameters.Add("@namaDepan", MySqlDbType.Text);
            command.Parameters.Add("@namaBelakang", MySqlDbType.Text);
            command.Parameters.Add("@jenisKelamin", MySqlDbType.Text);
            command.Parameters.Add("@tanggalLahir", MySqlDbType.Date);
            command.Parameters.Add("@email", MySqlDbType.Text);
            command.Parameters.Add("@bio", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@fotoProfil", MySqlDbType.MediumBlob);

            command.Parameters["@idAkun"].Value = idAkun;
            command.Parameters["@namaDepan"].Value = namaDepan;
            command.Parameters["@namaBelakang"].Value = namaBelakang;
            command.Parameters["@jenisKelamin"].Value = jenisKelamin;
            command.Parameters["@tanggalLahir"].Value = tanggalLahir;
            command.Parameters["@email"].Value = email;
            command.Parameters["@bio"].Value = bio;
            command.Parameters["@fotoProfil"].Value = fotoProfil;

            if (command.ExecuteNonQuery() == 1) {
                MessageBox.Show("Perubahan telah disimpan!", "MangCook", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Perubahan gagal disimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //reader = command.ExecuteReader();
            ////string hasil = "sukses";
            //while (reader.Read())
            //{

            //}
            koneksi.Close();
        }


        public void tampilKomentar(RichTextBox r)
        {
            koneksi.Open();
            queri = "SELECT * FROM komentar join akun on komentar.idAkun = akun.idAkun where idResep = '" + Resep.idResep + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                r.SelectionFont = new Font("century gothic", 10, FontStyle.Bold);
                r.AppendText(reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang"));
                r.SelectionFont = new Font("century gothic", 10, FontStyle.Regular);
                r.AppendText(Environment.NewLine);
                r.AppendText(reader.GetString("komentar"));
                r.AppendText(Environment.NewLine);
                r.AppendText(Environment.NewLine);
            }
            koneksi.Close();

        }
        public void komentar(string isi, RichTextBox ri)
        {
            koneksi.Open();
            queri = "insert into komentar (idKomentar,idResep,idAkun,komentar) values ('','" + Resep.idResep + "','" + Akun.idAkun + "','" + isi + "')";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();

            koneksi.Open();
            queri = "select * from akun where idAkun = '" + Akun.idAkun + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ri.SelectionFont = new Font("century gothic", 10, FontStyle.Bold);
                ri.AppendText(reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang"));
                ri.SelectionFont = new Font("century gothic", 10, FontStyle.Regular);
                ri.AppendText(Environment.NewLine);
                ri.AppendText(isi);
                ri.AppendText(Environment.NewLine);
                ri.AppendText(Environment.NewLine);
                ri.AppendText(Environment.NewLine);
            }
            koneksi.Close();
        }

        public void unggah(string idResep, string idAkun, string judul, byte[] file, string date, int fav, string kategori, string bahan, string step)
        {
            koneksi.Open();

            queri = "INSERT INTO resep (idResep,idAkun,namaResep,gambar,tglUpload,favorit,kategori,bahan,step) " +
                            "VALUES (@idResep, @idAkun, @namaResep, @gambar, @tglUpload, @favorit, @kategori, @bahan, @step)";
            command = new MySqlCommand(queri, koneksi);

            command.Parameters.Add("@idResep", MySqlDbType.VarChar, 5);
            command.Parameters.Add("@idAkun", MySqlDbType.VarChar, 5);
            command.Parameters.Add("@namaResep", MySqlDbType.Text);
            command.Parameters.Add("@gambar", MySqlDbType.MediumBlob);
            command.Parameters.Add("@tglUpload", MySqlDbType.Date);
            command.Parameters.Add("@favorit", MySqlDbType.Int32, 11);
            command.Parameters.Add("@kategori", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@bahan", MySqlDbType.Text);
            command.Parameters.Add("@step", MySqlDbType.Text);

            command.Parameters["@idResep"].Value = idResep;
            command.Parameters["@idAkun"].Value = idAkun;
            command.Parameters["@namaResep"].Value = judul;
            command.Parameters["@gambar"].Value = file;
            command.Parameters["@tglUpload"].Value = date;
            command.Parameters["@favorit"].Value = fav;
            command.Parameters["@kategori"].Value = kategori;
            command.Parameters["@bahan"].Value = bahan;
            command.Parameters["@step"].Value = step;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Gambar telah disimpan!", "MangCook", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            koneksi.Close();
        }


        public void klikPanelContent(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            if (!clicked) {
                panel.BackColor = Color.SandyBrown;
                clickedPanel = panel;
                clicked = true;
                Resep.idResep = panel.Name;
            } else {
                clickedPanel.BackColor = Color.Moccasin;
                panel.BackColor = Color.SandyBrown;
                clickedPanel = panel;
            }           
        }

        public void detailContent(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            Detail formDetailResep = new Detail();
            Resep resep = new Resep();
            //resep.setIdResep(panel.Name);
            Resep.idResep = panel.Name;
            idResep = panel.Name;
            formDetailResep.Show();
        }

        public void hapusContent(string idResep)
        {
            koneksi.Open();
            queri = "delete from komentar where idResep = '"+idResep+"'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();

            koneksi.Open();
            queri = "delete from favorit where idResep = '" + idResep + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();

            koneksi.Open();
            queri = "delete from resep where idResep = '" + idResep + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();
        }


        public Panel contentFlow(string idAkun, string idResep, PictureBox foto, string judul, string ala, string jumlahfavorit)
        {
            Resep resep = new Resep();
            ToolTip toolTipJudulResep = new ToolTip();
            string tempJudul;
            panelFlow = new Panel();
            if (judul.Length > 15)
            {
                tempJudul = judul.Substring(0, 15) + " ..";
            }
            else
            {
                tempJudul = judul;
            }
            panelFlow.Controls.Add(resep.judulMakanan(tempJudul));
            //tool tip untuk judul yang dipangkas-----
            toolTipJudulResep.AutoPopDelay = 3000;
            toolTipJudulResep.InitialDelay = 1000;
            toolTipJudulResep.ReshowDelay = 500;
            toolTipJudulResep.ShowAlways = true;
            toolTipJudulResep.SetToolTip(panelFlow, judul);
            //-----------------------------------------
            panelFlow.BackColor = System.Drawing.Color.Moccasin;
            panelFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            panelFlow.Controls.Add(resep.fotoMakanan(foto));
            panelFlow.Controls.Add(resep.namaAla(ala));
            panelFlow.Controls.Add(resep.iconKomen());
            panelFlow.Controls.Add(resep.iconStar(idResep, idAkun));
            panelFlow.Controls.Add(resep.jumlahFav(jumlahfavorit));
            panelFlow.Size = new System.Drawing.Size(232, 76);
            panelFlow.Name = idResep;
            panelFlow.Click += new System.EventHandler(klikPanelContent);
            panelFlow.DoubleClick += new System.EventHandler(detailContent);
            return panelFlow;
        }

        public static void tentangPengembang()
        {
            MessageBox.Show("Versi Aplikasi :\t\tMangCook v0.01\n\n" +
                  "Tim Pengembang :\n" +
                  "1. Akhmad Muzanni Safi'i\t(155150200111270)\n" +
                  "2. Ahmad Faizal\t\t(155150200111271)\n" +
                  "3. Gusna Ikhsan\t\t(155150200111272)\n" +
                  "4. Aidi Rahman\t\t(155150201111160)\n" +
                  "5. Moh. Zulfiqar Naufal M\t(155150201111353)\n" +
                  "6. Riza Anisul Fu'ad\t\t(155150201111355)\n\n" +
                  "Dosen Pengampu :\nNurizal Dwi Priandani, S.Kom.\n\n" +
                  "Kelas :\nPPK-O", "Tentang Kami", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
