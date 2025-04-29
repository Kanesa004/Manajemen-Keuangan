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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace manajemen_keuangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nama.Focus(); // Kursor langsung berada di textbox nama
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            string nama = Nama.Text;
            string username = User.Text; // Inputan

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username)) //validasi
            {
                MessageBox.Show("Nama lengkap dan username tidak boleh kosong!");
                return;
            }

            string koneksi = "server=localhost;username=root;password=;database=manajemen_keuangan;";
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO pengguna (nama_lengkap, username) VALUES (@nama, @username)"; // menambahkan data pengguna baru
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery(); //eksekusi memasukan dan menyimpan data di database

                    MessageBox.Show("Berhasil mendaftar! Selamat datang", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Arahkan ke Form2 setelah daftar
            Form2 dashboard = new Form2();
            dashboard.Show();
            this.Hide();
        }
    }
}