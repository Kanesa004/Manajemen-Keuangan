using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manajemen_keuangan.Model
{
    class KeuanganModel
    {
        Database db = new Database();


        public bool LoginPengguna(string user, string password)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM pengguna WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows; // true kalau data ditemukan
                        }
                    }
                }
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

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM transaksi";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data transaksi: " + ex.Message);
            }

            return dt;
        }

        // Method pemanggilan isi kategori berdasarkan jenisnya
        public List<string> AmbilKategori(int jenis)
        {

            List<string> kategoriList = new List<string>();

            {
                using (MySqlConnection conn = db.GetConnection())
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

                }

            }

            return kategoriList;
        }

        // Method untuk menyimpan data 
        public void SimpanData(DateTime tanggal, string jenis, string kategori, string jumlah, string deskripsi)
        {
            using (MySqlConnection conn = db.GetConnection())
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
            }

        }

        // Method untuk perbarui data
        public void PerbaruiData(int id, DateTime tanggal, string jenis, string kategori, string jumlah, string deskripsi)
        {

            using (MySqlConnection conn = db.GetConnection())
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
            }
        }

        // Method untuk menghapus data berdasarkan ID
        public void HapusData(int id)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM transaksi WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // Method untuk mencari data berdasarkan jenis, kategori dan deskripsi
        public DataTable CariTransaksi(string keyword)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transaksi WHERE deskripsi LIKE @keyword OR kategori LIKE @keyword OR jenis LIKE @keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            
        }

        public (decimal totalPemasukan, decimal totalPengeluaran) HitungTotal(DataTable data)
        {
            decimal totalPemasukan = 0;
            decimal totalPengeluaran = 0;

            foreach (DataRow row in data.Rows)
            {
                string jenis = row["jenis"].ToString();
                decimal jumlah;
                if (decimal.TryParse(row["jumlah"].ToString(), out jumlah))
                {
                    if (jenis.ToLower() == "pemasukan")
                        totalPemasukan += jumlah;
                    else if (jenis.ToLower() == "pengeluaran")
                        totalPengeluaran += jumlah;
                }
            }

            return (totalPemasukan, totalPengeluaran);
        }



    }
}
