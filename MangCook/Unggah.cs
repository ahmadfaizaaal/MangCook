﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangCook
{
    public partial class Unggah : Form
    {
        public Unggah()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File Gambar (*.jpg)|*.jpg";
            openFileDialog1.Title = "Pilih Gambar";
            openFileDialog1.DefaultExt = "jpg";
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //menampilkan pada kolom nama gambar
                tbFileGambar.Text = openFileDialog1.FileName;
            }
        }
    }
}
