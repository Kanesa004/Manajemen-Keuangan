using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manajemen_keuangan
{
    public partial class Form2: Form
    {
       private string koneksi = "server=localhost; username=root; password=; database=manajemen_keuangan;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) 
        {
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    //MessageBox.Show("Koneksi ke database berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terkoneksi:" + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pemasukan_CheckedChanged(object sender, EventArgs e) // Radio button pemasukan
        {
            IsiKategori(1);
        }

        private void pengeluaran_CheckedChanged(object sender, EventArgs e) // Radio button pengeluaran
        {
            IsiKategori(2);
        }

        private void IsiKategori(int idJenisTransaksi) // Untuk query ke pilihan kategori berdasarkan pilihan jenis kategori
        {
            kategori.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "SELECT nama_kategori FROM kategori WHERE idjenis_transaksi = @idJenis";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idJenis", idJenisTransaksi);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kategori.Items.Add(reader.GetString("nama_kategori"));
                }

                if (kategori.Items.Count > 0)
                    kategori.SelectedIndex = 0;
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {

        }

        private void laporan_Click(object sender, EventArgs e) // Digunakan untuk masuk ke dalam form 3
        {
            Form3 form3 = new Form3(); // Membuat objek Form3
            form3.Show();              
            this.Hide();
        }
    }
}

