-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 11:06 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtugas`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbtugas`
--

CREATE TABLE `tbtugas` (
  `idTugas` int(11) NOT NULL,
  `judul` varchar(200) NOT NULL,
  `deskripsi` text NOT NULL,
  `tglDibuat` date NOT NULL,
  `deadline` date NOT NULL,
  `status` enum('Belum Selesai','Proses','Selesai') NOT NULL DEFAULT 'Belum Selesai',
  `prioritas` enum('Rendah','Sedang','Tinggi') NOT NULL DEFAULT 'Rendah'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtugas`
--

INSERT INTO `tbtugas` (`idTugas`, `judul`, `deskripsi`, `tglDibuat`, `deadline`, `status`, `prioritas`) VALUES
(1, 'Posttest 5 visual', 'Buatlah program visual yang dapat melakukan CRUD (Create Read Update Delete) dan Dapat melakukan Search Data.', '2026-04-11', '2026-04-13', 'Selesai', 'Tinggi'),
(2, 'Posttest 4 pbo', 'Lanjutkan project seperti posttest sebelumnya,\r\nInstruksi pada posttest sebelumnya tetap wajib diterapkan pada posttest ini.\r\nTerapkan konsep Polymorphism keduanya [Minimal masing-masing 1 fungsi overloading dan 1 fungsi override ]\r\nPenerapan\r\n\r\nPolymorphism harus logis atau tidak \"mengada - ada\"\r\nPoin  + : \r\nMenggunakan lebih dari 1 fungsi Override DAN Overload', '2026-04-11', '2026-04-14', 'Selesai', 'Rendah'),
(4, 'Posttest 4 RPL', 'Buatlah Activity Diagram berdasarkan Use Case yang sudah kalian buat sebelumnya. Pastikan sinkron dengan jumlah use case kalian, jika use case kalian ada 5, maka activity diagram kalian yang dibuat juga 5.\r\nTidak diwajibkan menggunakan komponen fork & join. Opsional aja, tergantung sistem kalian.', '2026-04-11', '2026-04-14', 'Proses', 'Rendah'),
(5, 'Wirausaha dan Teknologi', 'buat laporan jualan kelompok', '2026-04-11', '2026-04-15', 'Proses', 'Sedang'),
(6, 'Latihan 5  rpl', 'buat class diagram Studi Kasus: Sistem Streaming Film (Simplified)', '2026-04-01', '2026-04-29', 'Belum Selesai', 'Sedang'),
(8, 'IMK', 'tugas presentasi display glass kelompok', '2026-04-17', '2026-04-20', 'Proses', 'Sedang'),
(10, 'UAS PBO', 'membuat game kelompok maksimal 5 orang', '2026-04-13', '2026-05-05', 'Belum Selesai', 'Tinggi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbtugas`
--
ALTER TABLE `tbtugas`
  ADD PRIMARY KEY (`idTugas`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbtugas`
--
ALTER TABLE `tbtugas`
  MODIFY `idTugas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
