using System;
using MySql.Data.MySqlClient;

namespace manajemen_keuangan
{
    class Database
    {
        private string koneksi = "server=localhost;user=root;password=;database=manajemen_keuangan;";

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(koneksi);
            return conn;
        }
    }
}
