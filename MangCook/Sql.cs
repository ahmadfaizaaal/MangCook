﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MangCook
{
    class Sql
    {
        public static MySqlConnection koneksi;
        public static MySqlDataReader reader;
        public static MySqlCommand command;

        public Sql()
        {
            string str = "datasource = localhost; port = 3306; username = root;database =mangcook;";
            koneksi = new MySqlConnection(str);
        }
    }

}
