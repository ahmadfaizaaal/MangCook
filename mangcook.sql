-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 22 Okt 2017 pada 10.41
-- Versi Server: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mangcook`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akun`
--

CREATE TABLE `akun` (
  `idAkun` varchar(5) NOT NULL,
  `namaDepan` text NOT NULL,
  `namaBelakang` text,
  `jenisKelamin` text NOT NULL,
  `tanggalLahir` date NOT NULL,
  `email` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`idAkun`, `namaDepan`, `namaBelakang`, `jenisKelamin`, `tanggalLahir`, `email`, `password`) VALUES
('A0001', 'Akhmad Muzanni', 'Safi\'i', 'Laki-Laki', '1998-06-15', 'akhmadmuzannisafii@gmail.com', 'muzanni15'),
('A0002', 'Ahmad Faizal', '', '', '0000-00-00', 'ahmadfaizal@gmail.com', 'faizal12'),
('A0003', 'Gusna Ikhsan', '', '', '0000-00-00', 'gusnaikhsan@gmail.com', 'gusna55');

--
-- Trigger `akun`
--
DELIMITER $$
CREATE TRIGGER `tr_autoIdAkun` BEFORE INSERT ON `akun` FOR EACH ROW BEGIN
SET @hitung = CONVERT((RIGHT((SELECT idAkun FROM `akun` ORDER by idAkun DESC LIMIT 1), 4)), UNSIGNED) + 1;
if (@hitung > 1) THEN
if (@hitung < 10) THEN 
SET new.idAkun = concat('A000',@hitung);
ELSEIF (@hitung < 100) THEN
SET new.idAkun = concat('A00',@hitung);
ELSEIF (@hitung < 1000) THEN
SET new.idAkun = concat('A0',@hitung);
ELSE
SET new.idAkun = concat('A',@hitung);
END IF;
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `bahan`
--

CREATE TABLE `bahan` (
  `idBahan` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL,
  `bahan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `favorit`
--

CREATE TABLE `favorit` (
  `idAkun` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `komentar`
--

CREATE TABLE `komentar` (
  `idKomentar` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL,
  `komentar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Trigger `komentar`
--
DELIMITER $$
CREATE TRIGGER `tr_autoIdKomentar` BEFORE INSERT ON `komentar` FOR EACH ROW BEGIN
SET @hitung = CONVERT((RIGHT((SELECT idKomentar FROM `komnetar` ORDER by idKomentar DESC LIMIT 1), 4)), UNSIGNED) + 1;
if (@hitung > 1) THEN
if (@hitung < 10) THEN 
SET new.idKomentar = concat('K000',@hitung);
ELSEIF (@hitung < 100) THEN
SET new.idKomentar = concat('K00',@hitung);
ELSEIF (@hitung < 1000) THEN
SET new.idKomentar = concat('K0',@hitung);
ELSE
SET new.idKomentar = concat('K',@hitung);
END IF;
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `resep`
--

CREATE TABLE `resep` (
  `idResep` varchar(5) NOT NULL,
  `idAkun` varchar(5) NOT NULL,
  `namaResep` text NOT NULL,
  `gambar` text NOT NULL,
  `tglUpload` date NOT NULL,
  `favorit` int(11) NOT NULL,
  `kategori` varchar(20) NOT NULL,
  `bahan` text NOT NULL,
  `step` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Trigger `resep`
--
DELIMITER $$
CREATE TRIGGER `tr_autoIdResep` BEFORE INSERT ON `resep` FOR EACH ROW BEGIN
SET @hitung = CONVERT((RIGHT((SELECT idResep FROM `resep` ORDER by idResep DESC LIMIT 1), 4)), UNSIGNED) + 1;
if (@hitung > 1) THEN
if (@hitung < 10) THEN 
SET new.idResep = concat('R000',@hitung);
ELSEIF (@hitung < 100) THEN
SET new.idResep = concat('R00',@hitung);
ELSEIF (@hitung < 1000) THEN
SET new.idResep = concat('R0',@hitung);
ELSE
SET new.idResep = concat('R',@hitung);
END IF;
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `step`
--

CREATE TABLE `step` (
  `idStep` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL,
  `step` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`idAkun`);

--
-- Indexes for table `bahan`
--
ALTER TABLE `bahan`
  ADD PRIMARY KEY (`idBahan`,`idResep`),
  ADD KEY `idResep` (`idResep`);

--
-- Indexes for table `favorit`
--
ALTER TABLE `favorit`
  ADD PRIMARY KEY (`idAkun`,`idResep`),
  ADD KEY `idResep` (`idResep`);

--
-- Indexes for table `komentar`
--
ALTER TABLE `komentar`
  ADD PRIMARY KEY (`idKomentar`,`idResep`),
  ADD KEY `idResep` (`idResep`);

--
-- Indexes for table `resep`
--
ALTER TABLE `resep`
  ADD PRIMARY KEY (`idResep`),
  ADD KEY `idAkun` (`idAkun`);

--
-- Indexes for table `step`
--
ALTER TABLE `step`
  ADD PRIMARY KEY (`idStep`,`idResep`),
  ADD KEY `idResep` (`idResep`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `bahan`
--
ALTER TABLE `bahan`
  ADD CONSTRAINT `bahan_ibfk_1` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

--
-- Ketidakleluasaan untuk tabel `favorit`
--
ALTER TABLE `favorit`
  ADD CONSTRAINT `favorit_ibfk_1` FOREIGN KEY (`idAkun`) REFERENCES `akun` (`idAkun`),
  ADD CONSTRAINT `favorit_ibfk_2` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

--
-- Ketidakleluasaan untuk tabel `komentar`
--
ALTER TABLE `komentar`
  ADD CONSTRAINT `komentar_ibfk_1` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

--
-- Ketidakleluasaan untuk tabel `resep`
--
ALTER TABLE `resep`
  ADD CONSTRAINT `resep_ibfk_1` FOREIGN KEY (`idAkun`) REFERENCES `akun` (`idAkun`);

--
-- Ketidakleluasaan untuk tabel `step`
--
ALTER TABLE `step`
  ADD CONSTRAINT `step_ibfk_1` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
