using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using manajemen_keuangan.Controller;
using MySql.Data.MySqlClient;

namespace manajemen_keuangan
{
    
    public partial class Form3: Form
    {
        KeuanganController controller = new KeuanganController();
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
            DGVlap.DataSource = controller.TampilTransaksi(); // memanggil fungsi tampil data dari kelas CRUDS
            HitungTotal();

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
                string keyword = txtsearch.Text.Trim(); // Ambil teks pencarian

                DataTable hasil = controller.SearchTransaksi(keyword); // memanggil fungsi cari dari kelas CRUDS
                DGVlap.DataSource = hasil;

                if (hasil.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            HitungTotal();
        }

        void HitungTotal()
        {
            if (DGVlap.DataSource != null)
            {
                (decimal totalPemasukan, decimal totalPengeluaran) = controller.HitungTotalTransaksi((DataTable)DGVlap.DataSource);
                decimal sisa = totalPemasukan - totalPengeluaran;

                CultureInfo culture = new CultureInfo("id-ID");

                // Label output
                totalPM.Text = totalPemasukan.ToString("C0", culture);      // total pemasukan
                totalPN.Text = totalPengeluaran.ToString("C0", culture);    // total pengeluaran
                SisaUang.Text = sisa.ToString("C0", culture);               // sisa uang
            }

        }

        private void exit_Click(object sender, EventArgs e) // Digunakan untuk kembali ke form 2
        {
            Form2 form2 = new Form2(); // Membuat objek Form2
            form2.Show();
            this.Hide();
        }

    }
}
