using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangCook
{
    class Resep
    {
        public static void makanan()
        {

        }
        
        public static void minuman()
        {

        }

        public static void detail()
        {

        }

        public static void pencarian()
        {

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
        public Label judulMakanan(string judul)
        {
            Label jud = new Label();
            jud.AutoSize = true;
            jud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jud.Location = new System.Drawing.Point(79, 8);
            jud.Name = "label19";
            jud.Size = new System.Drawing.Size(80, 16);
            jud.TabIndex = 22;
            jud.Text = judul;
            return jud;
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
        public PictureBox iconStar()
        {
            PictureBox star = new PictureBox();
            star.Image = global::MangCook.Properties.Resources.starkopong;
            star.Location = new System.Drawing.Point(107, 51);
            star.Name = "iconStar";
            star.Size = new System.Drawing.Size(16, 16);
            star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            star.TabIndex = 24;
            star.TabStop = false;
            return star;
        }
        public Label jumlahFav(string x)
        {
            Label jum = new Label();
            jum.AutoSize = true;
            jum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jum.Location = new System.Drawing.Point(125, 53);
            jum.Name = "label17";
            jum.Size = new System.Drawing.Size(13, 13);
            jum.TabIndex = 25;
            jum.Text = x;
            return jum;
        }
        //------------------------------//
              
    }
}
