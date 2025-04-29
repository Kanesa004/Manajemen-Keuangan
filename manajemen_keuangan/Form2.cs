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
using System.Windows.Forms.VisualStyles;
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
            TampilData();
        }

        private void pemasukan_CheckedChanged(object sender, EventArgs e) // Radio button pemasukan
        {
            IsiKategori(1);
        }

        private void pengeluaran_CheckedChanged(object sender, EventArgs e) // Radio button pengeluaran
        {
            IsiKategori(2);
        }

        private void IsiKategori(int jenis) // Untuk query ke pilihan kategori berdasarkan pilihan jenis kategori
        {
            kategori.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "SELECT nama_kategori FROM kategori WHERE jenis = @jenis"; // Mengambil nama-nama katgoeri di kolom idjenis_transaksi
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jenis",jenis);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kategori.Items.Add(reader.GetString("nama_kategori"));
                }

                if (kategori.Items.Count > 0)
                    kategori.SelectedIndex = 0; // setelah data di isi nilai kembali nol
            }
        }

        private void DGVtransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVtransaksi.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                DataGridViewRow row = DGVtransaksi.Rows[e.RowIndex];
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);
                pemasukan.Checked = row.Cells["jenis"].Value.ToString() == "Pemasukan";
                pengeluaran.Checked = row.Cells["jenis"].Value.ToString() == "Pengeluaran";
                kategori.Text = row.Cells["kategori"].Value.ToString() ?? ""; ;
                JU.Text = row.Cells["jumlah"].Value.ToString() ?? ""; ;
                deskripsi.Text = row.Cells["deskripsi"].Value.ToString() ?? ""; 

            }
        }

        void TampilData()
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM transaksi", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVtransaksi.DataSource = dt;
            }
        }
        void BersihkanForm()
        {
            dateTimePicker1.Value = DateTime.Now;
            pemasukan.Checked = false;
            pengeluaran.Checked = false;
            kategori.Items.Clear();
            kategori.Text = "";
            JU.Clear();
            deskripsi.Clear();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            // Validasi input sederhana
            if (string.IsNullOrWhiteSpace(JU.Text) || string.IsNullOrWhiteSpace(kategori.Text))
            {
                MessageBox.Show("Mohon isi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string jenis = pemasukan.Checked ? "Pemasukan" : "Pengeluaran";
                    string query = "INSERT INTO transaksi (tanggal, jenis, kategori, jumlah, deskripsi) VALUES (@tgl, @jenis, @kat, @jml, @desk)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@tgl", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@kat", kategori.Text);
                    cmd.Parameters.AddWithValue("@jml", JU.Text);
                    cmd.Parameters.AddWithValue("@desk", deskripsi.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TampilData(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TampilData();
            BersihkanForm();
        }


        private void perbarui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(JU.Text) || string.IsNullOrWhiteSpace(kategori.Text))
            {
                MessageBox.Show("Mohon isi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string jenis = pemasukan.Checked ? "Pemasukan" : "Pengeluaran";
                    string query = "UPDATE transaksi SET tanggal = @tgl, jenis = @jenis, kategori = @kat, jumlah = @jml, deskripsi = @desk WHERE id= @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@tgl", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@kat", kategori.Text);
                    cmd.Parameters.AddWithValue("@jml", JU.Text);
                    cmd.Parameters.AddWithValue("@desk", deskripsi.Text);
                    cmd.Parameters.AddWithValue("@id", DGVtransaksi.CurrentRow.Cells["id"].Value); // diambil dari id di tabel transaksi

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TampilData(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BersihkanForm();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (DGVtransaksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(koneksi))
                    {
                        conn.Open();
                        string query = "DELETE FROM transaksi WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", DGVtransaksi.CurrentRow.Cells["id"].Value); // diambil dari id_transaksi di tabel transaksi
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TampilData(); // Refresh DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BersihkanForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string keyword = seacrh.Text.Trim(); // Ambil teks pencarian

                string query = "SELECT * FROM transaksi WHERE deskripsi LIKE @keyword OR kategori LIKE @keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%"); // Pencarian sebagian teks

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVtransaksi.DataSource = dt;
            }
        }

        private void laporan_Click(object sender, EventArgs e) // Digunakan untuk masuk ke dalam form 3
        {
            Form3 form3 = new Form3(); // Membuat objek Form3
            form3.Show();
            this.Hide();
        }

    }
}


