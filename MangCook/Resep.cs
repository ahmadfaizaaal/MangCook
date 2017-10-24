﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MangCook
{
    class Resep:Sql
    {
        Akun akun = new Akun();
        private bool clicked = false;
        private int tempJumlahFavorit;
        public Label jumlahFavorit;
        public PictureBox favoritIcon;
        string queri; 
        public static string idResep;
        public void makanan(FlowLayoutPanel flow)
        {
            koneksi.Open();

            queri = "SELECT akun.idAkun,resep.idResep,namaResep,akun.namaDepan,akun.namaBelakang,favorit FROM resep join akun on resep.idAkun = akun.idAkun where resep.kategori = 'Makanan'";
            command = new MySqlCommand(queri,koneksi);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                //flow.Controls.Add(akun.contentFlow("a", "Jangan Terong", "Ala Gusna", "8"));
                string ala = reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang");
                string judulRes = reader.GetString("namaResep");
                string favor = reader.GetString("favorit");
                string idResep = reader.GetString("idResep");
                string idAkun = reader.GetString("idAkun");
                flow.Controls.Add(akun.contentFlow(idAkun, idResep ,"a", judulRes, "Ala " + ala, favor));
            }
            koneksi.Close();
        }
        
        public void minuman(FlowLayoutPanel fl)
        {
            koneksi.Open();
            queri = "SELECT akun.idAkun,resep.idResep,namaResep,akun.namaDepan,akun.namaBelakang,favorit FROM resep join akun on resep.idAkun = akun.idAkun where resep.kategori = 'Minuman'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                //fl.Controls.Add(akun.contentFlow("a", "Jangan Mbayung", "Ala Gusna", "9"));
                string ala = reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang");
                string judulRes = reader.GetString("namaResep");
                string favor = reader.GetString("favorit");
                string idResep = reader.GetString("idResep");
                string idAkun = reader.GetString("idAkun");
                fl.Controls.Add(akun.contentFlow(idAkun, idResep, "a", judulRes, "Ala " + ala, favor));
            }           
            koneksi.Close();
        }

        public void resetflowpanel(FlowLayoutPanel reset)
        {
            reset.Controls.Clear();
        }
        public void setIdResep(string resepId)
        {
            idResep = resepId;
        }

        public void detailData(Label judul, Label ala, PictureBox gambar, RichTextBox kiri, RichTextBox kanan)                 
        {
            koneksi.Open();
            queri = "SELECT * FROM resep join akun on resep.idAkun = akun.idAkun where idResep='"+idResep+"'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {               
                judul.Text = reader.GetString("namaResep");
                ala.Text = "Ala "+reader.GetString("namaDepan")+" "+reader.GetString("namaBelakang");
                //gambar.Image = reader.GetString("favorit");
                kiri.Text = reader.GetString("bahan");
                kanan.Text = reader.GetString("step");  

                
            }
            koneksi.Close();
        }       

        public void pencarian(FlowLayoutPanel flowle,string cari)
        {
            koneksi.Open();
            queri = "SELECT akun.idAkun,resep.idResep,namaResep,akun.namaDepan,akun.namaBelakang,favorit FROM resep join akun on resep.idAkun = akun.idAkun where resep.namaResep like '%" + cari + "%' ";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                string ala = reader.GetString("namaDepan") + " " + reader.GetString("namaBelakang");
                string judulRes = reader.GetString("namaResep");                string favor = reader.GetString("favorit");
                string idResep = reader.GetString("idResep");
                string idAkun = reader.GetString("idAkun");
                flowle.Controls.Add(akun.contentFlow(idAkun, idResep, "a", judulRes, "Ala " + ala, favor));
            }
            koneksi.Close();
        }

        public void klikIconFavorit(object sender, EventArgs e)
        {            
            //if (!clicked) {
            if (!isFavorit())
                {
                favoritIcon.Image = global::MangCook.Properties.Resources.stargold;
                clicked = true;
                tempJumlahFavorit += 1;
                jumlahFavorit.Text = tempJumlahFavorit.ToString();
                koneksi.Close();
                memfavoritkan(0);
            } else {
                favoritIcon.Image = global::MangCook.Properties.Resources.starkopong;
                clicked = false;
                tempJumlahFavorit -= 1;
                jumlahFavorit.Text = tempJumlahFavorit.ToString();
                koneksi.Close();
                memfavoritkan(1);
            }                        
        }

        public void memfavoritkan(int control)
        {
            koneksi.Open();
            queri = "UPDATE resep SET favorit = '" + jumlahFavorit.Text + "' WHERE idResep = '" + favoritIcon.Name + "';";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

            }
            koneksi.Close();
            if (control == 0)
            {
                addToFavorit();
            } else
            {
                deleteFromFavorit();
            }
        }

        public void addToFavorit()
        {
            koneksi.Open();            
            queri = "insert into favorit (idAkun,idResep) value ('" + Akun.idAkun + "','" + favoritIcon.Name + "')";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();
        }
        public void deleteFromFavorit()
        {
            koneksi.Open();
            queri = "delete from favorit where idAkun = '" + Akun.idAkun + "' and idResep = '" + favoritIcon.Name + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();
        }

        //content umum//
        public PictureBox fotoMakanan(string fot)
        {
            PictureBox foto = new PictureBox();
            foto.Image = global::MangCook.Properties.Resources.mang_cook;
            foto.Location = new System.Drawing.Point(0, 0);
            foto.Name = "pictureBox5";
            foto.Size = new System.Drawing.Size(82, 73);
            foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            foto.TabIndex = 15;
            foto.TabStop = false;
            return foto;
        }
        public Label judulMakanan(string judulResep)
        {
            Label judul = new Label();
            judul.AutoSize = true;
            judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            judul.Location = new System.Drawing.Point(79, 8);
            judul.Name = "label19";
            judul.Size = new System.Drawing.Size(80, 16);
            judul.TabIndex = 22;
            judul.Text = judulResep;
            return judul;
        }
        public Label namaAla(string nama)
        {
            Label ala = new Label();
            ala.AutoSize = true;
            ala.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ala.Location = new System.Drawing.Point(82, 27);
            ala.Name = "label18";
            ala.Size = new System.Drawing.Size(78, 12);
            ala.TabIndex = 21;
            ala.Text = nama;

            return ala;
        }
        public PictureBox iconKomen()
        {
            PictureBox icon = new PictureBox();
            icon.Image = global::MangCook.Properties.Resources.komentar;
            icon.Location = new System.Drawing.Point(86, 53);
            icon.Size = new System.Drawing.Size(15, 15);
            icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            icon.TabIndex = 23;
            icon.TabStop = false;
            icon.Name = "iconKomen";
            return icon;
        }

        public PictureBox iconStar(string idResep, string idAkun)
        {            
            favoritIcon = new PictureBox();
            favoritIcon.Image = global::MangCook.Properties.Resources.starkopong;
            favoritIcon.Location = new System.Drawing.Point(107, 51);
            favoritIcon.Name = idResep;            
            favoritIcon.Size = new System.Drawing.Size(16, 16);
            favoritIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            favoritIcon.TabIndex = 24;
            favoritIcon.TabStop = false;
            favoritIcon.Click += new System.EventHandler(klikIconFavorit);            
            if (isFavorit())            
            {
                favoritIcon.Image = global::MangCook.Properties.Resources.stargold;
            } else
            {
                favoritIcon.Image = global::MangCook.Properties.Resources.starkopong;
            }
            return favoritIcon;            
        }
        public Label jumlahFav(string x)
        {
            jumlahFavorit = new Label();
            jumlahFavorit.AutoSize = true;
            jumlahFavorit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jumlahFavorit.Location = new System.Drawing.Point(125, 53);
            jumlahFavorit.Name = "label17";
            jumlahFavorit.Size = new System.Drawing.Size(13, 13);
            jumlahFavorit.TabIndex = 25;
            jumlahFavorit.Text = x;
            tempJumlahFavorit = int.Parse(x);
            return jumlahFavorit;
        }

        public bool isFavorit()
        {
            string isFavorit = "0";
            koneksi.Open();
            string query = "SELECT COUNT(*) AS isFavorit FROM favorit WHERE idAkun = '" + Akun.idAkun + "' and idResep = '" + favoritIcon.Name + "'";
            MySqlCommand command2 = new MySqlCommand(query, koneksi);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                isFavorit = reader2.GetString("isFavorit");
            }
            
            if (isFavorit.Equals("0"))
            {                
                return false;
            } else
            {                
                return true;
            }
            koneksi.Close();
        }
        //------------------------------//
              
    }
}
