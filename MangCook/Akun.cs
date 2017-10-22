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
        Resep res = new Resep();
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
            int count = 0;
            string hasil = "belum ada";
            koneksi.Open();
            queri = "select* from akun where email = '"+email+ "' or pass='" + katSan + "'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 0)
            {
                queri = "insert into mangcook () value('"+namaDepan + "','" + namaBelakang + "','" + email + "','" + katSan + "','" + jeniskel + "','" + tglLahir + "')";
                command = new MySqlCommand(queri, koneksi);
                reader = command.ExecuteReader();
            }
            else
            {
                hasil = "sudah ada";
            }
            return hasil;
            koneksi.Close();                    

        }        
         
        public void profil()
        {          
            
        }
        
        public void memfavorit()
        {

        }

        public void favorit()
        {

        }

        public void komentar()
        {

        }

        public void unggah()
        {

        }
        public void suka()
        {

        }
        
        public Panel contentFlow()
        {
            Panel panFlow = new Panel();
            
            panFlow.BackColor = System.Drawing.Color.Moccasin;
            panFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            panFlow.Controls.Add(res.fotoMakanan("a"));
            panFlow.Controls.Add(res.judulMakanan("Jangan Lodeh"));
            panFlow.Controls.Add(res.namaAla("Ala Gusna Ikhsan"));
            panFlow.Controls.Add(res.iconKomen());
            panFlow.Controls.Add(res.iconStar());
            panFlow.Controls.Add(res.jumlahFav("10"));
            panFlow.Size = new System.Drawing.Size(232, 76);
            return panFlow;
        }       
    }
}
