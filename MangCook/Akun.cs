using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
        public string login(string emailser, string pass)
        {
            string hasil = "gagal";
            int count = 0;
            koneksi.Open();
            queri = "select* from mangcook where email = and pass=";
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
            queri = "select* from mangcook where email = '"+email+ "' or pass='" + katSan + "'";
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
    }
}
