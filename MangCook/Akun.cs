using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace MangCook
{
    class Akun:Sql
    {              
        public string namaDepan, namaBelakang, email, katSan, jeniskel, tglLahir, queri;
                
        public Akun(string namaDepan, string namaBelakang, string email, string katSan,string jeniskel, string tglLahir)
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
            queri = "select * from akun where email ='"+emailuser+ "' and password='" + pass + "'";
            command = new MySqlCommand(queri,koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                count += 1;
            }
            if (count==1)
            {
                hasil = "sukses";
            }
            koneksi.Close();
            return hasil;
        }

        public string daftar(string namaDepan, string namaBelakang, string email, string katSan, string jeniskel, string tglLahir)
        {            
            koneksi.Open();           
            queri = "insert into akun (idAkun,namaDepan,namaBelakang,jenisKelamin,tanggalLahir,email,password) value('"+"','" + namaDepan + "','" + namaBelakang + "','" + jeniskel + "','" + tglLahir + "','" + email + "','" + katSan + "')";
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
        int count = 0;
        public void dataProfil(Label post, Label jumfav, PictureBox pic, Label email, Label nama, Label motiv, string x)
        {
            koneksi.Open();
            queri = "SELECT * FROM resep join akun on resep.idAkun = akun.idAkun where akun.idAkun = '" + x + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                post.Text = count.ToString();
                jumfav.Text = reader.GetString("favorit");
                //pic.Image =
                email.Text = reader.GetString("email");
                nama.Text = reader.GetString("namaDepan");
                motiv.Text = "Kuat Ora sambat";
            }
            
        }

        public void resepProfil(FlowLayoutPanel a,string y)
        {
            koneksi.Open();
            queri = "SELECT namaResep,akun.namaDepan,favorit FROM resep join akun on resep.idAkun = akun.idAkun where akun.idAkun = '"+y+"'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                count += 1;
                string ala = reader.GetString("namaDepan");
                string judulRes = reader.GetString("namaResep");
                string favor = reader.GetString("favorit");
                a.Controls.Add(contentFlow("a", judulRes, ala, favor));
            }
        }
       
        public void memfavorit()
        {

        }

        public void favorit(FlowLayoutPanel b, string xx)
        {
            koneksi.Open();
            queri = "SELECT * favorit FROM favorit join resep on favorit.idResep = resep.idResep where favorit.idAkun = '"+xx+"'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                string ala = reader.GetString("namaDepan");
                string judulRes = reader.GetString("namaResep");
                string favor = reader.GetString("favorit");
                b.Controls.Add(contentFlow("a",judulRes,ala,favor));
            }
        }

        public void komentar()
        {

        }

        public void unggah(string idResep, string idAkun, string judul, string file, string date, int fav, string kategori, string bahan, string step)
        {
            koneksi.Open();
            queri = "insert into resep (idResep,idAkun,namaResep,gambar,tglUpload,favorit,kategori,bahan,step) value('" + idResep + "','" + idAkun + "','" + judul + "','" + file + "','" + date + "','" + fav + "','" + kategori + "','" + bahan + "','" + step + "')";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            koneksi.Close();
        }
        
        public Panel contentFlow(string foto, string judul, string ala, string jumlahfavorit)
        {
            Resep res = new Resep();
            Panel panFlow = new Panel();            
            panFlow.BackColor = System.Drawing.Color.Moccasin;
            panFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            panFlow.Controls.Add(res.fotoMakanan(foto));
            panFlow.Controls.Add(res.judulMakanan(judul));
            panFlow.Controls.Add(res.namaAla(ala));
            panFlow.Controls.Add(res.iconKomen());
            panFlow.Controls.Add(res.iconStar());
            panFlow.Controls.Add(res.jumlahFav(jumlahfavorit));
            panFlow.Size = new System.Drawing.Size(232, 76);
            return panFlow;
        }       
    }
}
