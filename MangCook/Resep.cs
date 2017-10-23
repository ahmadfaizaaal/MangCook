using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangCook
{
    class Resep:Sql
    {
        Akun akun = new Akun();
        private bool clicked = false;
        private int counter = 1, tempJumlahFavorit;
        private Label jumlahFavorit;
        public void makanan(FlowLayoutPanel flow)
        {
            
            for (int i = 0; i < 8; i++)
            {
                flow.Controls.Add(akun.contentFlow("a", "Jangan Terong", "Ala Gusna", 8));
            }
        }
        
        public void minuman(FlowLayoutPanel fl)
        {            
            for (int i = 0; i < 10; i++)
            {
                fl.Controls.Add(akun.contentFlow("a", "Jangan Mbayung", "Ala Gusna", 9));
            }           
        }

        public void resetflowpanel(FlowLayoutPanel reset)
        {
            reset.Controls.Clear();
        }
        public void detail()
        {

        }

        public void pencarian()
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

        public void klikIconFavorit(object sender, EventArgs e)
        {
            PictureBox favoritIcon = (PictureBox)sender;
            if (!clicked) {
                favoritIcon.Image = global::MangCook.Properties.Resources.stargold;
                clicked = true;
            } else {
                favoritIcon.Image = global::MangCook.Properties.Resources.starkopong;
                clicked = false;
            }
            favoritIcon.Location = new System.Drawing.Point(107, 51);
            favoritIcon.Name = "iconStarChecked_" + counter.ToString();
            counter++;
            favoritIcon.Size = new System.Drawing.Size(16, 16);
            favoritIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            favoritIcon.TabIndex = 24;
            favoritIcon.TabStop = false;
            
        }

        public PictureBox iconStar()
        {
            PictureBox star = new PictureBox();
            star.Image = global::MangCook.Properties.Resources.starkopong;
            star.Location = new System.Drawing.Point(107, 51);
            star.Name = "iconStarChecked_" + counter.ToString();
            counter++;
            star.Size = new System.Drawing.Size(16, 16);
            star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            star.TabIndex = 24;
            star.TabStop = false;
            star.Click += new System.EventHandler(klikIconFavorit);
            return star;
        }
        public Label jumlahFav(int x)
        {
            jumlahFavorit = new Label();
            jumlahFavorit.AutoSize = true;
            jumlahFavorit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jumlahFavorit.Location = new System.Drawing.Point(125, 53);
            //jum.Name = "label17";
            jumlahFavorit.Size = new System.Drawing.Size(13, 13);
            jumlahFavorit.TabIndex = 25;
            jumlahFavorit.Text = x.ToString();
            tempJumlahFavorit = x;
            return jumlahFavorit;
        }
        //------------------------------//
              
    }
}
