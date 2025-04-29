-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 29 Apr 2025 pada 16.00
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `manajemen_keuangan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategori`
--

CREATE TABLE `kategori` (
  `id_kategori` int(11) NOT NULL,
  `nama_kategori` varchar(100) NOT NULL,
  `jenis` enum('Pemasukan','Pengeluaran') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kategori`
--

INSERT INTO `kategori` (`id_kategori`, `nama_kategori`, `jenis`) VALUES
(1, 'Gaji', 'Pemasukan'),
(2, 'Bonus', 'Pemasukan'),
(3, 'Lainnya', 'Pemasukan'),
(4, 'Makanan', 'Pengeluaran'),
(5, 'Transportasi', 'Pengeluaran'),
(6, 'Tagihan', 'Pengeluaran'),
(7, 'Belanja', 'Pengeluaran'),
(8, 'Hiburan', 'Pengeluaran'),
(9, 'Lainnya', 'Pengeluaran');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengguna`
--

CREATE TABLE `pengguna` (
  `id_pengguna` int(11) NOT NULL,
  `nama_lengkap` varchar(100) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pengguna`
--

INSERT INTO `pengguna` (`id_pengguna`, `nama_lengkap`, `username`) VALUES
(1, 'mau', 'aku'),
(2, 'akuu', 'ini'),
(3, 'kanesa', 'nesa'),
(4, 'hai', 'hello'),
(6, 'aku kanesa', 'nesaaku'),
(7, 'samini', 'mini'),
(8, 'akumakan', 'makanaku'),
(9, 'mehek', 'mehek'),
(10, 'kimana', 'manami'),
(11, 'kumanau', 'uuu'),
(12, 'ikimanusia', 'manu'),
(13, 'kikaiaamk', 'haiakak'),
(14, 'jumini', 'jummjum'),
(15, 'asik', 'sik'),
(16, 'akuikam', 'kamis'),
(17, 'jumini', 'cahyo'),
(18, 'akimila', 'mila'),
(19, 'kimoan', 'oan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `jenis` enum('Pemasukan','Pengeluaran') NOT NULL,
  `kategori` varchar(100) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id`, `tanggal`, `jenis`, `kategori`, `jumlah`, `deskripsi`) VALUES
(1, '2025-04-25', 'Pengeluaran', 'Tagihan', 200000, 'Listrik'),
(2, '2025-04-26', 'Pengeluaran', 'Makanan', 60, 'nasi'),
(4, '2025-04-26', 'Pengeluaran', 'Makanan', 100, 'party'),
(6, '2025-04-26', 'Pengeluaran', 'Belanja', 800, 'sayur'),
(8, '2025-04-26', 'Pengeluaran', 'Makanan', 20000, 'endok'),
(9, '2025-04-16', 'Pemasukan', 'Bonus', 7000, 'canva'),
(11, '2025-04-26', 'Pengeluaran', 'Makanan', 89000, 'sempol'),
(13, '2025-04-26', 'Pengeluaran', 'Lainnya', 8900, 'yaa'),
(14, '2025-04-26', 'Pengeluaran', 'Makanan', 900, 'i');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indeks untuk tabel `pengguna`
--
ALTER TABLE `pengguna`
  ADD PRIMARY KEY (`id_pengguna`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `kategori`
--
ALTER TABLE `kategori`
  MODIFY `id_kategori` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `pengguna`
--
ALTER TABLE `pengguna`
  MODIFY `id_pengguna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
