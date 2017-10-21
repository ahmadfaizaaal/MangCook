using System;
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
        public static MySqlDataReader pembaca;
        public static MySqlCommand query;

        public Sql()
        {
            string str = "datasource = localhost; port = 3306; username = root;database =;";
            koneksi = new MySqlConnection(str);
        }
    }

}
