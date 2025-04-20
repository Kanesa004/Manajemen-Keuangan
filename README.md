# Manajemen-Keuangan

## Deskripsi  
Aplikasi Manajemen Keuangan adalah sistem berbasis Windows Forms (WinForms) yang menggunakan bahasa pemrograman C# dan MySQL untuk menyimpan data. Aplikasi ini bertujuan untuk membantu pengguna mencatat pemasukan dan pengeluaran secara sederhana, menampilkan data dalam bentuk tabel, serta mengedit dan menghapus data yang telah dimasukkan. 

## Fitur
1. Pendaftaran Akun
  - Pengguna dapat mendaftar dengan mengisi nama lengkap dan username.
  - Setelah daftar, pengguna bisa langsung masuk ke halaman utama, dan data pengguna akan tersimpan ke dalam database.
2. Pencatatan Transaksi
  - Terdapat 2 pilihan untuk jenis kategorinya.
  - Pada jenis kategori pemasukan terdapat 3 pilihan kategori seperti gaji, bonus, dan lainnya.
  - Inputan jumlah dan deskripsi untuk kegunaan dari uang tersebut.
  - Simpan Data: Memasukan data inputan ke dalam tabel.
  - Edit Data: Mengedit catatan yang sudah ada.
  - Pemperbarui data: Menyimpan data yang telah diedit
  - Hapus Data: menghapus catatan yang tidak diperlukan.
  - Laporan: menampilkan semua data inputan.
3. Laporan Transaksi
  - Menampilkan data yang telah di inputkan oleh pengguna.
  - Menampilkan jumlah pemasukan, pengeluaran dan sisa uang yang diperoleh dari pemasukan dikurangi pengeluaran.
 
## Penggunaan
- Masukan nama lengkap dan username untuk mengakses halaman utama.
- Pilih jenis transaksi (Pemasukan atau Pengeluaran).
- Pilih kategori yang sesuai.
- Masukkan jumlah dan deskripsi transaksi.
- Klik Simpan untuk menyimpan data yang telah di inputkan.
- Pilih baris data dalam tabel dan klik Edit untuk memperbarui informasi.
- Pilih baris data dalam tabel dan klik Hapus untuk menghapus catatan.
- Klik Perbarui setelah mengedit data agar perubahan tersimpan.
- Klik Laporan untuk menampilkan hasil inputan dan perhitungan pemasukan dan pengeluaran.
- Pada bagian jumlah dan deskripsi akan dikosongkan secara otomatis setelah data disimpan.

## Teknologi yang Digunakan
- Bahasa Pemrograman: `C#`
- UI Framework: `Windows Forms`
- Database: `MySQL`
- Tools: `Visual Studio 2022`, `phpMyAdmin`

## Struktur Form
- **Form1** – Form Daftar
- **Form2** – Form Input Transaksi
- **Form3** – Form Laporan Transaksi


# Desain Mockup
![Form1](https://github.com/user-attachments/assets/8a4d7618-da3a-48f8-ac3a-d7a510e6a120)
![Form2](https://github.com/user-attachments/assets/74aed8c6-6661-4824-8763-0dbf145d0400)
![Form3](https://github.com/user-attachments/assets/0e0c45dd-6dae-40aa-bada-3b44c19ef0f9)

