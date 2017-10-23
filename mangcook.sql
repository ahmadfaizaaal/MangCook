-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 22, 2017 at 07:05 PM
-- Server version: 10.1.21-MariaDB
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
-- Table structure for table `akun`
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
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`idAkun`, `namaDepan`, `namaBelakang`, `jenisKelamin`, `tanggalLahir`, `email`, `password`) VALUES
('A0001', 'Akhmad Muzanni', 'Safi\'i', 'Laki-Laki', '1998-06-15', 'akhmadmuzannisafii@gmail.com', 'muzanni15'),
('A0002', 'Ahmad Faizal', '', 'Laki-Laki', '1997-06-22', 'ahmadfaizal@gmail.com', 'faizal12'),
('A0003', 'Gusna Ikhsan', '', 'Laki-Laki', '1996-02-29', 'gusnaikhsan@gmail.com', 'gusna55'),
('A0004', 'Riza Anizul', 'Fu\'ad', 'Laki-Laki', '1996-12-04', 'javajazz0412@gmail.com', 'prabudulgemah'),
('A0005', 'Moh Zulfiqar', 'Naufal Maulana', 'Laki-Laki', '1997-05-17', 'mznaufalmaulana@student.ub.ac.id', 'patihjanggawa'),
('A0006', 'Aidi Rahmani', '', 'Perempuan', '1997-04-24', 'rahmaniaidi@gmail.com', 'aidi123ceria'),
('A0007', 'Nurul Muhidin', 'Syaifulloh', 'perempuan', '1998-10-01', 'muhidinurulloh@rocketmail.com', 'nurul321'),
('A0008', 'Mat Sarutobi', '', 'Laki-Laki', '1965-09-30', 'sarutobi@yahoo.co.id', 'hokage03'),
('A0009', 'Minato Namikaze', '', 'Laki-Laki', '1945-08-16', 'minatokun@yahoo.co.id', 'hokage04'),
('A0010', 'Mighty Guy', '', 'Laki-Laki', '1987-05-23', 'alistebal@yahoo.co.id', 'guruneli11'),
('A0011', 'Takatsuki Uchida', '', 'Laki-Laki', '1990-09-05', 'suchidakun@gmail.com', 'kukukunai35'),
('A0012', 'Kun Fayakun', '', 'Perempuan', '1995-06-01', 'kunanta123@yahoo.com', 'smeogajadi88'),
('A0013', 'Dul Gemah', '', 'Laki-Laki', '1968-03-08', 'likun234@yahoo.co.id', 'dulaekucing21'),
('A0014', 'terus prihatin', '', 'Perempuan', '1970-04-15', 'prihatin@yahoo.co.id', 'prihatinsekali33'),
('A0015', 'Alhamdulillah Anakku', 'Lanang', 'Perempuan', '2000-12-31', 'jelaslanang@gmail.com', 'akulanangsejati123');

--
-- Triggers `akun`
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
-- Table structure for table `bahan`
--

CREATE TABLE `bahan` (
  `idBahan` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL,
  `bahan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `favorit`
--

CREATE TABLE `favorit` (
  `idAkun` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `komentar`
--

CREATE TABLE `komentar` (
  `idKomentar` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL,
  `komentar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Triggers `komentar`
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
-- Table structure for table `resep`
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
-- Dumping data for table `resep`
--

INSERT INTO `resep` (`idResep`, `idAkun`, `namaResep`, `gambar`, `tglUpload`, `favorit`, `kategori`, `bahan`, `step`) VALUES
('RS001', 'A0001', 'Es Lemon Kiwi', 'Lemonkiwi.jpg', '2017-02-25', 0, 'Minuman', '1.Jeruk lemon 1 buah ( di peras airnya )\r\n2.Kiwi 2 buah ( kupas dan potong-potong )\r\n3.Gula pasir 2 sendok makan\r\n4.Soda manis 300 mili liter\r\n5.Es batu secukupnya\r\n', '1.Masukkan air jeruk lemon, kiwi, gula pasir, es batu ke dalam tabung blender .\r\n2.Selanjutnya proses hingga bahan halus lalu tambahkan soda manis, proses kembali hingga semua bahan tercampur rata .\r\n3.Sajikan selagi Dingin .\r\n'),
('RS002', 'A0002', 'Dori Crispy', 'DoriCrispy.jpg', '2017-04-12', 0, 'Makanan', '1. 200 gram fillet ikan dori potong dadu\r\n2. 1 sendok teh Jeruk nipis\r\n3. 1/4 sendok teh Royco kaldu ayam\r\n4. minyak goreng\r\n5. 150 ml air sedingin es\r\n6. 100 gram tepung terigu\r\n7. 1/8 sendok teh lada putih bubuk\r\n8. 200 gram tepung terigu\r\n9. 25 gram tepung beras\r\n10. 1/2 sendok teh Royco kaldu ayam\r\n11. 1/4 sendok teh bawang putih jadikan bubuk halus\r\n12. 1/2 sendok teh baking powder\r\n', '1.Lumuri ikan dory bersama air jeruk nipis dan Royco Rasa Ayam. Diamkan 10 menit.\r\n2.Aduk rata bahan pencelup. Sisihkan. Aduk rata bahan pelapis. Sisihkan.\r\n3.Celupkan ikan ke dalam larutan pencelup. Gulingkan di atas pelapis. Cubit-cuibit sampai keriting.\r\n4.Goreng di dalam minyak yang sudah dipanaskan di atas api sedang sampai kering.\r\n'),
('RS003', 'A0003', 'Apple Cooler', 'AppCool.jpg', '2017-03-01', 0, 'Minuman', '1. Serbat jahe 15 gram\r\n2. Jus apel 80 mili liter\r\n3. Buah apel 1/2\r\n4. Susu rendah lemak 50 mili liter\r\n5. Air gula 50 mili liter\r\n6. Es batu 200 gram\r\n', '1. Campurna kesemua bahan , lalu blender hingga semua bahan tercampur rata .\r\n2. Sajikan , selagi dingin , tambahkan es batu bila perlu .\r\n'),
('RS004', 'A0004', 'Es Lemon Selasih', 'LeSel.jpg', '2017-05-18', 0, 'Minuman', '1. 20 ml air jeruk nipis\r\n2. 350 ml air\r\n3. 6-7 sdm gula pasir\r\n4. 1 sdm selasih yang direndam air\r\n', '1.  Campur semua bahan jadi satu.\r\n2.  Aduk gula pasir hingga larut, cicipi, jika terlalu asam bisa ditambahkan lagi gula pasirnya.\r\n3.  Tambahkan es batu jika lebih suka dingin.\r\n'),
('RS005', 'A0005', 'Es Kacang Merah Coco Pandan', 'Kacangcodan,jpg', '2017-09-24', 0, 'Minuman', '1. 100 gram kacang merah\r\n2. 1 bungkus santan kara\r\n3. 150 ml air\r\n4. 1/2 sdt garam\r\n5. 1 lembar daun pandan\r\n6. Sirup coco pandan secukupnya\r\n', '1.  Rebus kacang merah sekitar 15 menit, setelah matang matikan api. Biarkan kacang di panci.\r\n2.  Campurkan santan dengan air, rebus beserta daun pandan. Tambahkan garam.\r\n3.  Cara penyajian, susun kacang merah, es batu tuang kuah santan dan tambahkan sirup coco pandan. Selesai.\r\n'),
('RS006', 'A0006', 'Tempe Crispy', 'TC.jpg', '2017-06-04', 0, 'Makanan', '1 papan tempe\r\n2 minyak goreng untuk menggoreng\r\n3 1 butir telur kocok ringan\r\n4 200 gram tepung roti\r\n5 100 gram tepung terigu\r\n6 1 bungkus royco kaldu ayam\r\n7 mayones\r\n8 sambal\r\n', '1 Potong-potong tempe memanjang seperti kentang goreng.\r\n2 Dalam wadah terpisah, siapkan telur ayam, tepung roti, tepung terigu. Dalam masing-masing wadah, masukkan masing masing 1/3 bks ROYCO, lalu aduk rata.\r\n3 Balur tempe dalam tepung terigu, masukkan ke dalam telur, kemudian balur dengan tepung roti.\r\n4 Goreng dalam minyak berapi panas sampai kuning kecoklatan. Tiriskan.\r\n5 Sajikan dengan mayo, sambal, lalapan selada dan timun.\r\n'),
('RS007', 'A0007', 'Oseng-Oseng Pedas manis', 'oseng.jpg', '2017-05-25', 0, 'Makanan', '1. 1 bungkus Royco Bumbu Komplit Tempe & Tahu Goreng\r\n2. 50 ml air\r\n3. 10 buah Tahu Sumedang mentah\r\n4. 100 gram tempe iris\r\n5. minyak untuk menggoreng\r\n', '1 Larutkan Royco Bumbu Komplit Tempe & Tahu Goreng dengan air.\r\n2 Tambahkan tahu dan tempe, diamkan selama 30 menit hingga bumbu meresap. Goreng dalam minyak panas dan banyak hingga matang dan berwarna keemasan. Angkat, tiriskan.\r\n3 Taruh tahu dan tempe di atas ulegan. Siram dengan saus kecap.\r\n4 Lalu tekan-tekan dengan batu ulegan\r\n'),
('RS008', 'A0008', 'Lumpia Telo', 'LumTel.jpg', '2017-02-28', 0, 'Makanan', '1. 12 lembar kulit lumpia siap pakai\r\n2. 1 sdm tepung maizena yang dilarutkan dengan 50 ml air\r\n3. minyak, untuk menumis dan menggoreng\r\n', '1. Isian: Di dalam wajan, panaskan 3 sdm minyak. Tumis bawang bombay dan jahe hingga harum.\r\n2. Masukkan jamur, kol, wortel, dan rebung. Masak hingga matang.\r\n3. Tambahkan sisa bahan dan Royco Kaldu Ayam, aduk rata. Angkat.\r\n4. Spring Roll: Ambil 1 lembar kulit lumpia. Isi dengan 1 sdm tumis sayuran. Gulung seperti lumpia, rekatkan sisinya dengan larutan maizena. Ulangi hingga habis.\r\n5. Goreng dalam minyak banyak panas hingga matang dan berwarna keemasan. Angkat, tiriskan.\r\n6. Sajikan segera ditemani saus sambal manis.\r\n'),
('RS009', 'A0009', 'Tahu Sosis Clepor', 'Tasis.jpg', '2017-09-01', 0, 'Makanan', '1. 4 sosis sapi\r\n2. 5 tahu\r\n3. 2 telur sedang\r\n4. 1 wortel potong dadu\r\n5. 3 daun bawang\r\n6. 1/4 sendok teh lada putih bubuk\r\n7. 3 bawang putih cincang\r\n8. 1 bungkus Royco bumbu pelezat serbaguna rasa ayam\r\n9. Garam\r\n', '1. Tumbuk tahu putih hingga lembut lalu tambahkan telur, daun bawang, wortel, bawang putih, garam, dan merica lalu aduk hingga adonan tercampur dengan baik.\r\n2. Potong sosis menjadi empat bagian lalu potongan tadi belah menjadi empat sehingga terlihat seperti gurita atau kuncup bunga.\r\n3. Lalu siapkan cetakan kue putu ayu yang bagian dalamnya diolesi dengan menggunakan minyak lalu masukan adonan tahu yang disiapkan sebelumnya ke dalam cetakan hingga penuh.\r\n4. Setelah itu letakkan sosis yang sudah dibentuk tadi ke atas cetakan yang telah diisi adonan sampai adonan habis lalu kukus dengan api sedang selama 25 menit.\r\n'),
('RS010', 'A0010', 'Es Gabus', 'Gabus.jpg', '2016-12-14', 0, 'Minuman', '1. 1 liter air\r\n2. 250 gram gula\r\n3. 1 bungkus tepung hunkwe\r\n4. 65 ml santan kental\r\n5. Garam secukupnya\r\n6. Pewarna makanan\r\n', '1.	Masukkan semua bahan, aduk hingga merata.\r\n2.	Didihkan di atas kompor. Masak hingga mengental.\r\n3.	Angkat lalu bagi menjadi 3 bagian. Beri pewarna makanan dengan warna yang berbeda.\r\n4.	Tuang adonan satu persatu ke dalam wadah.\r\n5.	Masukkan dalam freezer, biarkan hingga membeku. Setelah beku, potong sesuai selera lalu sajikan.\r\n'),
('RS011', 'A0011', 'Kue Serabut', 'serabut.jpg', '2017-03-13', 0, 'Makanan', '1. 150 gram tepung ketan\r\n2. 150 gram gula pasir\r\n3. 200 gram kelapa parut sedang\r\n4. 10 gram garam\r\n5. Vanili bubuk secukupnya\r\nPewarna merah atau hijau secukupnya\r\n', '1.	Campur semua bahan menjadi satu, aduk rata\r\n2.	Jika memakai warna, aduk kelapa parut dengan pewarna lebih dahulu, setelah rata masukkan gula pasir, tepung ketan, garam, dan vanili, aduk rata. Tuang ke dalam loyang ukuran 24 x 24 x4 cm yang telah dialasi dengan daun pisang atau plastic\r\n3.	Kukus ke dalam panci pengukus selama 35 menit hingga matang. Angkat dan biarkan dingin\r\n4.	Potong-potong, sajikan\r\n'),
('RS012', 'A0012', 'Roti Sobek', 'sobek.jpg', '2017-04-24', 0, 'Makanan', '1.	450 gr tepung terigu protein tinggi (mis. Cakra)\r\n2.	50 gr tepung terigu protein rendah (Kunci Biru)\r\n3.	110 gr gula pasir\r\n4.	75 gr mentega\r\n5.	1 butir kuning telur\r\n6.	1 butir telur utuh\r\n7.	225 ml susu cair full cream dingin (\r\n8.	15 gr susu bubuk\r\n9.	7 gr ragi instan (fermipan)\r\n10.	Sejumput garam\r\n', '1.	Dalam mixer campur semua bahan jadi satu kecuali garam masuk terakhir setelah semua bahan tercampur rata\r\n2.	Uleni sampai kalis elastis\r\n3.	Bulatkan adonan, diamkan kira\" 30-45 menit (saya tutup pake cling wrap)\r\n4.	Kempiskan adonan\r\n5.	Bagi\"adonan @40gr (saya @50-55gr) bentuk bulat\" diamkan lagi selama 15 menit\r\n6.	Setelah 15 menit beri isian dan bentuk sesuai selera\r\n7.	Diamkan sampai mengembang, setelah mengembang beri olesan, saya pake kuning telur + sedikit susu cair\r\n8.	Panggang hingga matang, lamanya bisa disesuaikan dengan oven masing\" yaa\r\n9.	Ini ada yg saya isi pisang coklat dan sosis\r\n'),
('RS013', 'A0013', 'Jenang Jagung', 'Jagung.jpg', '2017-02-20', 0, 'Makanan', '1. 400 gram jagung\r\n2. 300 ml santan kental\r\n3. 100 gram gula pasir\r\n4. 3 sdm tepung hunkwe\r\n5. 2 lembar daun pandan\r\n6. ½ sdt garam\r\n7. vanili secukupnya\r\n', '1.	Campur jagung parut dengan santan, gula, daun pandan, vanili, dan garam, saring\r\n2.	Mask sampai matang dan kental, lalu angkat dan tuangkan pada loyang/cetakan yang sudah diolesi dengan air dingin. Biarkan sampai dingin\r\n3.	Dinginkan baru potong-potong atau hiasi sesuai selera\r\n'),
('RS014', 'A0014', 'Kue Cubit', 'cubit.jpg', '2017-10-08', 0, 'Makanan', '1.	5 sendok terigu\r\n2.	1 sendok margarin cair\r\n3.	1/2 gelas susu dancow\r\n4.	2 sendok gula\r\n5.	1/2 sendok garam\r\n6.	1 butir telur\r\n7.	secukupnya meses seres buat taburan\r\n', '1.	Aduk gula dan telur hingga berbusa\r\n2.	Tuang terigu dan margarin cair\r\n3.	Aduk hingga kental masukan garam dan susu cair\r\n4.	Panaskan teflon dgn sedikit margarin\r\n5.	Tuang satu sendok makan ke teflon saat setengah matang tuang meses seres biarkan 10 detik angkat\r\n6.	Kue cubit siap disajikan\r\n'),
('RS015', 'A0015', 'Bongko Pisang Original', 'Bongsang.jpg', '2016-12-04', 0, 'Makanan', '1.	250 gr tepung beras\r\n2.	25 gr tepung sagu\r\n3.	100 gr gula pasir\r\n4.	1500 santan\r\n5.	1/2 sdm garam\r\n6.	daun pandan\r\n7.	10 bh pisang raja/kepok\r\n8.	daun pisang\r\n', '1.	campur jadi 1 semua bahan > santan+gula+garam+tepung beras+sagu+daun pandan....setelah rata...masak dengan api kecil hingga agak menjadi bubur....matikan kompor\r\n2.	pisang raja/kepok dipotong2\r\n3.	siap membungkus: siapkan daun...ambil 2 sdm adonan bubur lembek...beri potongan pisang....atasnya bisa diberi potongan daun pandan....bungkus\r\n4.	dikukus kurang lebih 40 menit...menggunakan api sedang.\r\n5.	siap disajikan.  \r\n');

--
-- Triggers `resep`
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
-- Table structure for table `step`
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
-- Constraints for dumped tables
--

--
-- Constraints for table `bahan`
--
ALTER TABLE `bahan`
  ADD CONSTRAINT `bahan_ibfk_1` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

--
-- Constraints for table `favorit`
--
ALTER TABLE `favorit`
  ADD CONSTRAINT `favorit_ibfk_1` FOREIGN KEY (`idAkun`) REFERENCES `akun` (`idAkun`),
  ADD CONSTRAINT `favorit_ibfk_2` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

--
-- Constraints for table `komentar`
--
ALTER TABLE `komentar`
  ADD CONSTRAINT `komentar_ibfk_1` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

--
-- Constraints for table `resep`
--
ALTER TABLE `resep`
  ADD CONSTRAINT `resep_ibfk_1` FOREIGN KEY (`idAkun`) REFERENCES `akun` (`idAkun`);

--
-- Constraints for table `step`
--
ALTER TABLE `step`
  ADD CONSTRAINT `step_ibfk_1` FOREIGN KEY (`idResep`) REFERENCES `resep` (`idResep`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
