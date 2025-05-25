using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace manajemen_keuangan
{
    class CRUDS
    {
        Database db = new Database();
        private MySqlConnection conn;


        public CRUDS()
        {
            conn = db.GetConnection(); // Menggunakan kelas Database untuk koneksi
        }

        public bool LoginPengguna(string user, string password)
        {

            try
            {
                conn.Open();

                string query = "SELECT * FROM pengguna WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                bool berhasil = reader.HasRows; // true kalau data ditemukan

                conn.Close();

                return berhasil;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // READ - Ambil semua data transaksi
        public DataTable TampilData()
        {
            DataTable dt = new DataTable();
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM transaksi", conn);
                    da.Fill(dt);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data transaksi: " + ex.Message);
                }
            }
            return dt;
        }

        // Method pemanggilan isi kategori berdasarkan jenisnya
        public List<string> AmbilKategori(int jenis)
        {
            List<string> kategoriList = new List<string>();

            {
                conn.Open();
                string query = "SELECT nama_kategori FROM kategori WHERE jenis = @jenis"; // Mengambil nama-nama kategori berdasarkan jenis
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kategoriList.Add(reader.GetString("nama_kategori"));
                }
                conn.Close();
            }

            return kategoriList;
        }

        // Method untuk menyimpan data 
        public void SimpanData(DateTime tanggal, string jenis, string kategori, string jumlah, string deskripsi)
        {
            {
                conn.Open();
                string query = "INSERT INTO transaksi (tanggal, jenis, kategori, jumlah, deskripsi) VALUES (@tgl, @jenis, @kat, @jml, @desk)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@kat", kategori);
                cmd.Parameters.AddWithValue("@jml", jumlah);
                cmd.Parameters.AddWithValue("@desk", deskripsi);

                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        // Method untuk perbarui data
        public void PerbaruiData(int id, DateTime tanggal, string jenis, string kategori, string jumlah, string deskripsi)
        {

            {
                conn.Open();
                string query = "UPDATE transaksi SET tanggal = @tgl, jenis = @jenis, kategori = @kat, jumlah = @jml, deskripsi = @desk WHERE id= @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@kat", kategori);
                cmd.Parameters.AddWithValue("@jml", jumlah);
                cmd.Parameters.AddWithValue("@desk", deskripsi);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // Method untuk menghapus data berdasarkan ID
        public void HapusData(int id)
        {
            try
            {
                
                conn.Open();
                string query = "DELETE FROM transaksi WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method untuk mencari data berdasarkan jenis, kategori dan deskripsi
        public DataTable CariTransaksi(string keyword)
        {

            {
                conn.Open();
                string query = "SELECT * FROM transaksi WHERE deskripsi LIKE @keyword OR kategori LIKE @keyword OR jenis LIKE @keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
    

}
