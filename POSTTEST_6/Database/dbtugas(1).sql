-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2026 at 03:18 AM
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
-- Table structure for table `tbmatakuliah`
--

CREATE TABLE `tbmatakuliah` (
  `ID_Matkul` int(11) NOT NULL,
  `Kode_Matkul` int(20) NOT NULL,
  `Mata_Kuliah` varchar(100) NOT NULL,
  `Dosen_Pengampu` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbmatakuliah`
--

INSERT INTO `tbmatakuliah` (`ID_Matkul`, `Kode_Matkul`, `Mata_Kuliah`, `Dosen_Pengampu`) VALUES
(1, 304, 'PBO', 'Anton Prafanto'),
(2, 302, 'PemVis', 'Awang Harsa'),
(3, 306, 'IMK', 'Ramadiani'),
(4, 301, 'KOMAS', 'Ummul Hairah'),
(5, 410, 'Data Mining', 'Joan Angelina'),
(6, 221, 'RPL', 'Masna Wati'),
(7, 111, 'WirTek', 'Nataniel Dengen'),
(8, 432, 'Sistem Terdistribusi', 'Reza Wardana');

-- --------------------------------------------------------

--
-- Table structure for table `tbtugas`
--

CREATE TABLE `tbtugas` (
  `ID_Tugas` int(11) NOT NULL,
  `ID_Matkul` int(11) NOT NULL,
  `Judul` varchar(200) NOT NULL,
  `Deskripsi` text NOT NULL,
  `Tanggal_Dibuat` date NOT NULL,
  `Deadline` date NOT NULL,
  `Status` enum('Belum Selesai','Proses','Selesai') NOT NULL,
  `Prioritas` enum('Rendah','Sedang','Tinggi') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtugas`
--

INSERT INTO `tbtugas` (`ID_Tugas`, `ID_Matkul`, `Judul`, `Deskripsi`, `Tanggal_Dibuat`, `Deadline`, `Status`, `Prioritas`) VALUES
(1, 1, 'UTS PBO', 'Membuat program yang terdiri perulangan, 2 metode percabangan, enkapsulasi, inheritance, polimorph\r\n\r\nbuat laporan', '2026-02-23', '2026-06-01', 'Proses', 'Sedang'),
(2, 5, 'UTS Data Mining', 'Membuat jurnal clustering dengan k-means dan dbscan', '2026-02-28', '2026-06-01', 'Proses', 'Tinggi'),
(3, 6, 'Posttest 6 RPL', 'membuat sequence diagram secara detailll', '2026-04-23', '2026-04-28', 'Belum Selesai', 'Rendah');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbmatakuliah`
--
ALTER TABLE `tbmatakuliah`
  ADD PRIMARY KEY (`ID_Matkul`);

--
-- Indexes for table `tbtugas`
--
ALTER TABLE `tbtugas`
  ADD PRIMARY KEY (`ID_Tugas`),
  ADD KEY `fk_tugas_matkul` (`ID_Matkul`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbmatakuliah`
--
ALTER TABLE `tbmatakuliah`
  MODIFY `ID_Matkul` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbtugas`
--
ALTER TABLE `tbtugas`
  MODIFY `ID_Tugas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbtugas`
--
ALTER TABLE `tbtugas`
  ADD CONSTRAINT `fk_tugas_matkul` FOREIGN KEY (`ID_Matkul`) REFERENCES `tbmatakuliah` (`ID_Matkul`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
