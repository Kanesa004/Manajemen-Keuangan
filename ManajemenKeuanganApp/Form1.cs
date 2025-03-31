using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ManajemenKeuanganApp
{
    public partial class Form1: Form
    {
        private int selectedRowIndex = -1; // Menyimpan indeks baris yang dipilih


        public Form1()
        {
            InitializeComponent();
            this.pemasukan.CheckedChanged += new System.EventHandler(this.pemasukan_CheckedChanged);
            this.pengeluaran.CheckedChanged += new System.EventHandler(this.pengeluaran_CheckedChanged);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set judul kolom DataGridView
            LKU.ColumnCount = 5;
            LKU.Columns[0].Name = "Tanggal";
            LKU.Columns[1].Name = "Keterangan";
            LKU.Columns[2].Name = "Kategori";
            LKU.Columns[3].Name = "Jumlah";
            LKU.Columns[4].Name = "Deskripsi";
            pemasukan.Checked = true; // Set default ke Pemasukan
        }

        private void pemasukan_CheckedChanged(object sender, EventArgs e)
        {
            kategori.Items.Clear(); // Hapus isi ComboBox
            kategori.Items.Add("Gaji");
            kategori.Items.Add("Bonus");
            kategori.Items.Add("Lainnya");
            kategori.SelectedIndex = 0; // Pilih item pertama secara otomatis
        }

        private void pengeluaran_CheckedChanged(object sender, EventArgs e)
        {
            kategori.Items.Clear(); // Hapus isi ComboBox
            kategori.Items.Add("Makanan");
            kategori.Items.Add("Transportasi");
            kategori.Items.Add("Tagihan");
            kategori.Items.Add("Liburan");
            kategori.Items.Add("Lainnya");
            kategori.SelectedIndex = 0; // Pilih item pertama secara otomatis
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari input form
            string Tanggal = dateTimePicker1.Value.ToShortDateString();
            string Keterangan = pemasukan.Checked ? "Pemasukan" : "Pengeluaran";
            string Kategori = kategori.SelectedItem?.ToString() ?? "Tidak Dipilih";
            string Jumlah = JU.Text;
            string Deskripsi = deskripsi.Text;
            

            // Validasi jika ada field kosong
            if (string.IsNullOrWhiteSpace(Keterangan) || string.IsNullOrWhiteSpace(Kategori) || string.IsNullOrWhiteSpace(Jumlah) || string.IsNullOrWhiteSpace(Deskripsi))
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tambahkan data ke DataGridView
           LKU.Rows.Add(Tanggal,Keterangan, Kategori, Jumlah, Deskripsi);

            // Kosongkan form setelah data dimasukkan
            ClearFields();
        }

        // Method untuk membersihkan input setelah menekan tombol Simpan
        private void ClearFields()
        {
            kategori.SelectedIndex = -1;
            JU.Clear();
            deskripsi.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (LKU.SelectedRows.Count > 0) // Periksa apakah ada baris yang dipilih
            {
                foreach (DataGridViewRow row in LKU.SelectedRows)
                {
                    if (!row.IsNewRow) // Hindari menghapus baris kosong terakhir
                    {
                        LKU.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (LKU.SelectedRows.Count > 0)
            {
                selectedRowIndex = LKU.SelectedRows[0].Index;
                DataGridViewRow row = LKU.Rows[selectedRowIndex];

                // Memasukkan data dari DataGridView ke input form
                dateTimePicker1.Value = DateTime.Parse(row.Cells[0].Value.ToString());
                if (row.Cells[1].Value.ToString() == "Pemasukan")
                    pemasukan.Checked = true;
                else
                    pengeluaran.Checked = true;

                kategori.SelectedItem = row.Cells[2].Value.ToString();
                JU.Text = row.Cells[3].Value.ToString();
                deskripsi.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void perbarui_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                // Update data di DataGridView
                LKU.Rows[selectedRowIndex].Cells[0].Value = dateTimePicker1.Value.ToShortDateString();
                LKU.Rows[selectedRowIndex].Cells[1].Value = pemasukan.Checked ? "Pemasukan" : "Pengeluaran";
                LKU.Rows[selectedRowIndex].Cells[2].Value = kategori.SelectedItem.ToString();
                LKU.Rows[selectedRowIndex].Cells[3].Value = JU.Text;
                LKU.Rows[selectedRowIndex].Cells[4].Value = deskripsi.Text;

                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedRowIndex = -1; // Reset indeks setelah update
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}

