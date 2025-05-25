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
using manajemen_keuangan.Controller;
using MySql.Data.MySqlClient;

namespace manajemen_keuangan
{
    public partial class Form2: Form
    {
        KeuanganController controller = new KeuanganController();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) 
        {
 
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

        private void IsiKategori(int jenis) // Untuk query ke pilihan kategori berdasarkan pilihan jenisnya
        {
            kategori.Items.Clear();

            // Panggil fungsi AmbilKategori dari CRUDS
            List<string> kategoriList = controller.AmbilKategori(jenis);

            foreach (var kat in kategoriList)
            {
                kategori.Items.Add(kat);
            }

            if (kategori.Items.Count > 0)
                kategori.SelectedIndex = 0; // Setelah data diisi, set default yang pertama
        }

        private void DGVtransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVtransaksi.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                DataGridViewRow row = DGVtransaksi.Rows[e.RowIndex];

                // Tanggal
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);

                // Jenis (Radio Button)
                pemasukan.Checked = row.Cells["jenis"].Value?.ToString() == "Pemasukan";
                pengeluaran.Checked = row.Cells["jenis"].Value?.ToString() == "Pengeluaran";

                // Kategori, Jumlah, Deskripsi
                kategori.Text = row.Cells["kategori"].Value?.ToString() ?? "";
                JU.Text = row.Cells["jumlah"].Value?.ToString() ?? "";
                deskripsi.Text = row.Cells["deskripsi"].Value?.ToString() ?? "";
            }
        }

        void TampilData()
        {
            DGVtransaksi.DataSource = controller.TampilTransaksi(); // Panggil fungsi tampil data dalam kelas CRUDS
            
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
            // Validasi input 
            if (string.IsNullOrWhiteSpace(JU.Text) || string.IsNullOrWhiteSpace(kategori.Text))
            {
                MessageBox.Show("Mohon isi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menyimpan data melalui CRUDS
            string jenis = pemasukan.Checked ? "Pemasukan" : "Pengeluaran";
            controller.SimpanTransaksi(dateTimePicker1.Value, jenis, kategori.Text, JU.Text, deskripsi.Text);

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

            string jenis = pemasukan.Checked ? "Pemasukan" : "Pengeluaran";
            int id = Convert.ToInt32(DGVtransaksi.CurrentRow.Cells["id"].Value);
            controller.UpdateTransaksi(id,dateTimePicker1.Value, jenis, kategori.Text, JU.Text, deskripsi.Text);  // Panggil fungsi update dari CRUDS


            TampilData();
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
                    int id = Convert.ToInt32(DGVtransaksi.CurrentRow.Cells["id"].Value); 
                    controller.DeleteTransaksi(id); // Panggil fungsi hapus dari CRUDS
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData(); // Refresh setelah hapus
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
           
            string keyword = seacrh.Text.Trim(); // Ambil teks pencarian

            DataTable hasil = controller.SearchTransaksi(keyword); // 🔍 Panggil fungsi cari dari kelas CRUDS
            DGVtransaksi.DataSource = hasil;

            if (hasil.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


