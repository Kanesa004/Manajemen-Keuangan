using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using manajemen_keuangan.Model;
using System.Data;

namespace manajemen_keuangan.Controller
{
    class KeuanganController
    {
        KeuanganModel model = new KeuanganModel();
        public bool Login(string user, string password)
        {
            return model.LoginPengguna(user, password);
        }

        public DataTable TampilTransaksi()
        {
            return model.TampilData();
        }

        public List<string> AmbilKategori(int jenis)
        {
            return model.AmbilKategori(jenis);
        }

        public void SimpanTransaksi(DateTime tanggal, string jenis, string kategori, string jumlah, string deskripsi)
        {
            model.SimpanData(tanggal, jenis, kategori, jumlah, deskripsi);
        }

        public void UpdateTransaksi(int id, DateTime tanggal, string jenis, string kategori, string jumlah, string deskripsi)
        {
            model.PerbaruiData(id, tanggal, jenis, kategori, jumlah, deskripsi);
        }

        public void DeleteTransaksi(int id)
        { 
            model.HapusData(id);
        }

        public DataTable SearchTransaksi(string keyword)
        {
           return  model.CariTransaksi(keyword);
        }

        public (decimal, decimal) HitungTotalTransaksi(DataTable data)
        {
            return model.HitungTotal(data);
        }
    }
}
