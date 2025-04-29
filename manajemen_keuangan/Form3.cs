using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manajemen_keuangan
{
    public partial class Form3: Form
    {
        private string koneksi = "server=localhost; username=root; password=; database=manajemen_keuangan;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        void TampilData()
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM transaksi", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVlap.DataSource = dt;
            }

        }

        private void exit_Click(object sender, EventArgs e) // Digunakan untuk kembali ke form 2
        {
            Form2 form2 = new Form2(); // Membuat objek Form2
            form2.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string keyword = txtsearch.Text.Trim(); // Ambil teks pencarian

                string query = "SELECT * FROM transaksi WHERE deskripsi LIKE @keyword OR kategori LIKE @keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%"); // Pencarian sebagian teks

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVlap.DataSource = dt;
            }
        }
    }
}
