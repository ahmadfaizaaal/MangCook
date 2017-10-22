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
        Form f = new Form();
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
         
        public void resepProfil(FlowLayoutPanel a)
        {    
            
            for (int i = 0; i <10; i++)
            {
                a.Controls.Add(contentFlow());
            }
        }

        public void dataProfil()
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
