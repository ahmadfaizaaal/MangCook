-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 24 Okt 2017 pada 09.31
-- Versi Server: 10.1.19-MariaDB
-- PHP Version: 5.6.28

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
  `password` text NOT NULL,
  `bio` varchar(255) NOT NULL DEFAULT 'Hey there! I am using Mang-Cook.',
  `fotoProfil` mediumblob
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`idAkun`, `namaDepan`, `namaBelakang`, `jenisKelamin`, `tanggalLahir`, `email`, `password`, `bio`, `fotoProfil`) VALUES
('A0001', 'Akhmad Muzanni', 'Safi''i', 'Laki-Laki', '1998-06-15', 'aan@gmail.com', 'aan15', 'Hey there! I am using Mang-Cook.', NULL),
('A0002', 'Ahmad', 'Faizal', 'Laki-laki', '1997-06-22', 'af@gmail.com', 'af22', 'Hey there! I am using Mang-Cook.', NULL),
('A0003', 'Gusna Ikhsan', '', 'Laki-Laki', '1996-02-29', 'gusnaikhsan@gmail.com', 'gusna55', 'Hey there! I am using Mang-Cook.', NULL),
('A0004', 'Riza Anizul', 'Fu''ad', 'Laki-Laki', '1996-12-04', 'javajazz0412@gmail.com', 'prabudulgemah', 'Hey there! I am using Mang-Cook.', NULL),
('A0005', 'Moh Zulfiqar', 'Naufal Maulana', 'Laki-Laki', '1997-05-17', 'falnau87@gmail.com', 'patihjanggawa', 'Cinta memang kadang menyakitkan, namun percayalah dengan cinta hidup akan jauh lebih hidup', 0x313936332e6a7067),
('A0006', 'Aidi Rahmani', '', 'Perempuan', '1997-04-24', 'rahmaniaidi@gmail.com', 'aidi123ceria', 'Hey there! I am using Mang-Cook.', NULL),
('A0007', 'Nurul Muhidin', 'Syaifulloh', 'perempuan', '1998-10-01', 'muhidinurulloh@rocketmail.com', 'nurul321', 'Hey there! I am using Mang-Cook.', NULL),
('A0008', 'Mat Sarutobi', '', 'Laki-Laki', '1965-09-30', 'sarutobi@yahoo.co.id', 'hokage03', 'Hey there! I am using Mang-Cook.', NULL),
('A0009', 'Minato Namikaze', '', 'Laki-Laki', '1945-08-16', 'minatokun@yahoo.co.id', 'hokage04', 'Hey there! I am using Mang-Cook.', NULL),
('A0010', 'Mighty Guy', '', 'Laki-Laki', '1987-05-23', 'alistebal@yahoo.co.id', 'guruneli11', 'Hey there! I am using Mang-Cook.', NULL),
('A0011', 'Takatsuki Uchida', '', 'Laki-Laki', '1990-09-05', 'suchidakun@gmail.com', 'kukukunai35', 'Hey there! I am using Mang-Cook.', NULL),
('A0012', 'Kun Fayakun', '', 'Perempuan', '1995-06-01', 'kunanta123@yahoo.com', 'smeogajadi88', 'Hey there! I am using Mang-Cook.', NULL),
('A0013', 'Dul Gemah', '', 'Laki-Laki', '1968-03-08', 'likun234@yahoo.co.id', 'dulaekucing21', 'Hey there! I am using Mang-Cook.', NULL),
('A0014', 'terus prihatin', '', 'Perempuan', '1970-04-15', 'prihatin@yahoo.co.id', 'prihatinsekali33', 'Hey there! I am using Mang-Cook.', NULL),
('A0015', 'Alhamdulillah Anakku', 'Lanang', 'Perempuan', '2000-12-31', 'jelaslanang@gmail.com', 'akulanangsejati123', 'Hey there! I am using Mang-Cook.', NULL);

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

--
-- Dumping data untuk tabel `favorit`
--

INSERT INTO `favorit` (`idAkun`, `idResep`) VALUES
('A0002', 'R0001'),
('A0002', 'R0020'),
('A0003', 'R0031'),
('A0005', 'R0005'),
('A0005', 'R0030');

-- --------------------------------------------------------

--
-- Struktur dari tabel `komentar`
--

CREATE TABLE `komentar` (
  `idKomentar` varchar(5) NOT NULL,
  `idResep` varchar(5) NOT NULL,
  `idAkun` varchar(5) NOT NULL,
  `komentar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `komentar`
--

INSERT INTO `komentar` (`idKomentar`, `idResep`, `idAkun`, `komentar`) VALUES
('K0001', 'R0006', 'A0002', 'tempene kok kecing ??');

--
-- Trigger `komentar`
--
DELIMITER $$
CREATE TRIGGER `tr_autoIdKomentar` BEFORE INSERT ON `komentar` FOR EACH ROW BEGIN
SET @hitung = CONVERT((RIGHT((SELECT idKomentar FROM `komentar` ORDER by idKomentar DESC LIMIT 1), 4)), UNSIGNED) + 1;
if (@hitung >= 1) THEN
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
-- Dumping data untuk tabel `resep`
--

INSERT INTO `resep` (`idResep`, `idAkun`, `namaResep`, `gambar`, `tglUpload`, `favorit`, `kategori`, `bahan`, `step`) VALUES
('R0001', 'A0001', 'Es Lemon Kiwi', 'Lemonkiwi.jpg', '2017-02-25', 1, 'Minuman', '1. Jeruk lemon 1 buah ( di peras airnya )\r\n2. Kiwi 2 buah ( kupas dan potong-potong )\r\n3. Gula pasir 2 sendok makan\r\n4. Soda manis 300 mili liter\r\n5. Es batu secukupnya\r\n', '1. Masukkan air jeruk lemon, kiwi, gula pasir, es batu ke dalam tabung blender .\r\n2. Selanjutnya proses hingga bahan halus lalu tambahkan soda manis, proses kembali hingga semua bahan tercampur rata .\r\n3. Sajikan selagi Dingin .\r\n'),
('R0002', 'A0002', 'Dori Crispy', 'DoriCrispy.jpg', '2017-04-12', 0, 'Makanan', '1. 200 gram fillet ikan dori potong dadu\r\n2. 1 sendok teh Jeruk nipis\r\n3. 1/4 sendok teh Royco kaldu ayam\r\n4. minyak goreng\r\n5. 150 ml air sedingin es\r\n6. 100 gram tepung terigu\r\n7. 1/8 sendok teh lada putih bubuk\r\n8. 200 gram tepung terigu\r\n9. 25 gram tepung beras\r\n10. 1/2 sendok teh Royco kaldu ayam\r\n11. 1/4 sendok teh bawang putih jadikan bubuk halus\r\n12. 1/2 sendok teh baking powder\r\n', '1. Lumuri ikan dory bersama air jeruk nipis dan Royco Rasa Ayam. Diamkan 10 menit.\r\n2. Aduk rata bahan pencelup. Sisihkan. Aduk rata bahan pelapis. Sisihkan.\r\n3. Celupkan ikan ke dalam larutan pencelup. Gulingkan di atas pelapis. Cubit-cuibit sampai keriting.\r\n4. Goreng di dalam minyak yang sudah dipanaskan di atas api sedang sampai kering.\r\n'),
('R0003', 'A0003', 'Apple Cooler', 'AppCool.jpg', '2017-03-01', 0, 'Minuman', '1. Serbat jahe 15 gram\r\n2. Jus apel 80 mili liter\r\n3. Buah apel 1/2\r\n4. Susu rendah lemak 50 mili liter\r\n5. Air gula 50 mili liter\r\n6. Es batu 200 gram\r\n', '1. Campurna kesemua bahan , lalu blender hingga semua bahan tercampur rata .\r\n2. Sajikan , selagi dingin , tambahkan es batu bila perlu .\r\n'),
('R0004', 'A0004', 'Es Lemon Selasih', 'LeSel.jpg', '2017-05-18', 0, 'Minuman', '1. 20 ml air jeruk nipis\r\n2. 350 ml air\r\n3. 6-7 sdm gula pasir\r\n4. 1 sdm selasih yang direndam air\r\n', '1. Campur semua bahan jadi satu.\r\n2. Aduk gula pasir hingga larut, cicipi, jika terlalu asam bisa ditambahkan lagi gula pasirnya.\r\n3. Tambahkan es batu jika lebih suka dingin.\r\n'),
('R0005', 'A0005', 'Es Kacang Merah Coco Pandan', 'Kacangcodan,jpg', '2017-09-24', 0, 'Minuman', '1. 100 gram kacang merah\r\n2. 1 bungkus santan kara\r\n3. 150 ml air\r\n4. 1/2 sdt garam\r\n5. 1 lembar daun pandan\r\n6. Sirup coco pandan secukupnya\r\n', '1. Rebus kacang merah sekitar 15 menit, setelah matang matikan api. Biarkan kacang di panci.\r\n2. Campurkan santan dengan air, rebus beserta daun pandan. Tambahkan garam.\r\n3. Cara penyajian, susun kacang merah, es batu tuang kuah santan dan tambahkan sirup coco pandan. Selesai.\r\n'),
('R0006', 'A0006', 'Tempe Crispy', 'TC.jpg', '2017-06-04', 0, 'Makanan', '1 papan tempe\r\n2 minyak goreng untuk menggoreng\r\n3 1 butir telur kocok ringan\r\n4 200 gram tepung roti\r\n5 100 gram tepung terigu\r\n6 1 bungkus royco kaldu ayam\r\n7 mayones\r\n8 sambal\r\n', '1 Potong-potong tempe memanjang seperti kentang goreng.\r\n2 Dalam wadah terpisah, siapkan telur ayam, tepung roti, tepung terigu. Dalam masing-masing wadah, masukkan masing masing 1/3 bks ROYCO, lalu aduk rata.\r\n3 Balur tempe dalam tepung terigu, masukkan ke dalam telur, kemudian balur dengan tepung roti.\r\n4 Goreng dalam minyak berapi panas sampai kuning kecoklatan. Tiriskan.\r\n5 Sajikan dengan mayo, sambal, lalapan selada dan timun.\r\n'),
('R0007', 'A0007', 'Oseng-Oseng Pedas manis', 'oseng.jpg', '2017-05-25', 0, 'Makanan', '1. 1 bungkus Royco Bumbu Komplit Tempe & Tahu Goreng\r\n2. 50 ml air\r\n3. 10 buah Tahu Sumedang mentah\r\n4. 100 gram tempe iris\r\n5. minyak untuk menggoreng\r\n', '1 Larutkan Royco Bumbu Komplit Tempe & Tahu Goreng dengan air.\r\n2 Tambahkan tahu dan tempe, diamkan selama 30 menit hingga bumbu meresap. Goreng dalam minyak panas dan banyak hingga matang dan berwarna keemasan. Angkat, tiriskan.\r\n3 Taruh tahu dan tempe di atas ulegan. Siram dengan saus kecap.\r\n4 Lalu tekan-tekan dengan batu ulegan\r\n'),
('R0008', 'A0008', 'Lumpia Telo', 'LumTel.jpg', '2017-02-28', 0, 'Makanan', '1. 12 lembar kulit lumpia siap pakai\r\n2. 1 sdm tepung maizena yang dilarutkan dengan 50 ml air\r\n3. minyak, untuk menumis dan menggoreng\r\n', '1. Isian: Di dalam wajan, panaskan 3 sdm minyak. Tumis bawang bombay dan jahe hingga harum.\r\n2. Masukkan jamur, kol, wortel, dan rebung. Masak hingga matang.\r\n3. Tambahkan sisa bahan dan Royco Kaldu Ayam, aduk rata. Angkat.\r\n4. Spring Roll: Ambil 1 lembar kulit lumpia. Isi dengan 1 sdm tumis sayuran. Gulung seperti lumpia, rekatkan sisinya dengan larutan maizena. Ulangi hingga habis.\r\n5. Goreng dalam minyak banyak panas hingga matang dan berwarna keemasan. Angkat, tiriskan.\r\n6. Sajikan segera ditemani saus sambal manis.\r\n'),
('R0009', 'A0009', 'Tahu Sosis Clepor', 'Tasis.jpg', '2017-09-01', 0, 'Makanan', '1. 4 sosis sapi\r\n2. 5 tahu\r\n3. 2 telur sedang\r\n4. 1 wortel potong dadu\r\n5. 3 daun bawang\r\n6. 1/4 sendok teh lada putih bubuk\r\n7. 3 bawang putih cincang\r\n8. 1 bungkus Royco bumbu pelezat serbaguna rasa ayam\r\n9. Garam\r\n', '1. Tumbuk tahu putih hingga lembut lalu tambahkan telur, daun bawang, wortel, bawang putih, garam, dan merica lalu aduk hingga adonan tercampur dengan baik.\r\n2. Potong sosis menjadi empat bagian lalu potongan tadi belah menjadi empat sehingga terlihat seperti gurita atau kuncup bunga.\r\n3. Lalu siapkan cetakan kue putu ayu yang bagian dalamnya diolesi dengan menggunakan minyak lalu masukan adonan tahu yang disiapkan sebelumnya ke dalam cetakan hingga penuh.\r\n4. Setelah itu letakkan sosis yang sudah dibentuk tadi ke atas cetakan yang telah diisi adonan sampai adonan habis lalu kukus dengan api sedang selama 25 menit.\r\n'),
('R0010', 'A0010', 'Es Gabus', 'Gabus.jpg', '2016-12-14', 0, 'Minuman', '1. 1 liter air\r\n2. 250 gram gula\r\n3. 1 bungkus tepung hunkwe\r\n4. 65 ml santan kental\r\n5. Garam secukupnya\r\n6. Pewarna makanan\r\n', '1. Masukkan semua bahan, aduk hingga merata.\r\n2. Didihkan di atas kompor. Masak hingga mengental.\r\n3. Angkat lalu bagi menjadi 3 bagian. Beri pewarna makanan dengan warna yang berbeda.\r\n4. Tuang adonan satu persatu ke dalam wadah.\r\n5. Masukkan dalam freezer, biarkan hingga membeku. Setelah beku, potong sesuai selera lalu sajikan.\r\n'),
('R0011', 'A0011', 'Kue Serabut', 'serabut.jpg', '2017-03-13', 0, 'Makanan', '1. 150 gram tepung ketan\r\n2. 150 gram gula pasir\r\n3. 200 gram kelapa parut sedang\r\n4. 10 gram garam\r\n5. Vanili bubuk secukupnya\r\n6. Pewarna merah atau hijau secukupnya\r\n', '1. Campur semua bahan menjadi satu, aduk rata\r\n2. Jika memakai warna, aduk kelapa parut dengan pewarna lebih dahulu, setelah rata masukkan gula pasir, tepung ketan, garam, dan vanili, aduk rata. Tuang ke dalam loyang ukuran 24 x 24 x4 cm yang telah dialasi dengan daun pisang atau plastic\r\n3. Kukus ke dalam panci pengukus selama 35 menit hingga matang. Angkat dan biarkan dingin\r\n4. Potong-potong, sajikan\r\n'),
('R0012', 'A0012', 'Roti Sobek', 'sobek.jpg', '2017-04-24', 0, 'Makanan', '1. 450 gr tepung terigu protein tinggi (mis. Cakra)\r\n2. 50 gr tepung terigu protein rendah (Kunci Biru)\r\n3. 110 gr gula pasir\r\n4. 75 gr mentega\r\n5. 1 butir kuning telur\r\n6. 1 butir telur utuh\r\n7. 225 ml susu cair full cream dingin (\r\n8. 15 gr susu bubuk\r\n9. 7 gr ragi instan (fermipan)\r\n10. Sejumput garam\r\n', '1. Dalam mixer campur semua bahan jadi satu kecuali garam masuk terakhir setelah semua bahan tercampur rata\r\n2. Uleni sampai kalis elastis\r\n3. Bulatkan adonan, diamkan kira" 30-45 menit (saya tutup pake cling wrap)\r\n4. Kempiskan adonan\r\n5. Bagi"adonan @40gr (saya @50-55gr) bentuk bulat" diamkan lagi selama 15 menit\r\n6. Setelah 15 menit beri isian dan bentuk sesuai selera\r\n7. Diamkan sampai mengembang, setelah mengembang beri olesan, saya pake kuning telur + sedikit susu cair\r\n8. Panggang hingga matang, lamanya bisa disesuaikan dengan oven masing" yaa\r\n9. Ini ada yg saya isi pisang coklat dan sosis\r\n'),
('R0013', 'A0013', 'Jenang Jagung', 'Jagung.jpg', '2017-02-20', 0, 'Makanan', '1. 400 gram jagung\r\n2. 300 ml santan kental\r\n3. 100 gram gula pasir\r\n4. 3 sdm tepung hunkwe\r\n5. 2 lembar daun pandan\r\n6. ½ sdt garam\r\n7. vanili secukupnya\r\n', '1. Campur jagung parut dengan santan, gula, daun pandan, vanili, dan garam, saring\r\n2. Mask sampai matang dan kental, lalu angkat dan tuangkan pada loyang/cetakan yang sudah diolesi dengan air dingin. Biarkan sampai dingin\r\n3. Dinginkan baru potong-potong atau hiasi sesuai selera\r\n'),
('R0014', 'A0014', 'Kue Cubit', 'cubit.jpg', '2017-10-08', 0, 'Makanan', '1. 5 sendok terigu\r\n2. 1 sendok margarin cair\r\n3. 1/2 gelas susu dancow\r\n4. 2 sendok gula\r\n5. 1/2 sendok garam\r\n6. 1 butir telur\r\n7. secukupnya meses seres buat taburan\r\n', '1. Aduk gula dan telur hingga berbusa\r\n2. Tuang terigu dan margarin cair\r\n3. Aduk hingga kental masukan garam dan susu cair\r\n4. Panaskan teflon dgn sedikit margarin\r\n5. Tuang satu sendok makan ke teflon saat setengah matang tuang meses seres biarkan 10 detik angkat\r\n6. Kue cubit siap disajikan\r\n'),
('R0015', 'A0015', 'Bongko Pisang Original', 'Bongsang.jpg', '2016-12-04', 0, 'Makanan', '1. 250 gr tepung beras\r\n2. 25 gr tepung sagu\r\n3. 100 gr gula pasir\r\n4. 1500 santan\r\n5. 1/2 sdm garam\r\n6. daun pandan\r\n7. 10 bh pisang raja/kepok\r\n8. daun pisang\r\n', '1. campur jadi 1 semua bahan > santan+gula+garam+tepung beras+sagu+daun pandan. Setelah rata, masak dengan api kecil hingga agak menjadi bubur. Matikan kompor\r\n2. pisang raja/kepok dipotong2\r\n3. siap membungkus: siapkan daun ambil 2 sdm adonan bubur lembek beri potongan pisang atasnya bisa diberi potongan daun pandan , bungkus\r\n4. dikukus kurang lebih 40 menit menggunakan api sedang.\r\n5. siap disajikan.  \r\n'),
('R0016', 'A0002', 'Ronde Awut-awut', 'ronde.jpg', '2017-03-26', 0, 'Minuman', '1. 250 gr Tepung ketan\r\n2. 100 ml air\r\n3. 2 sdm gula pasir\r\n4. 1/4 sdt garam\r\n5. 1 ltr air\r\n6. 2 ruas jahe\r\n7. 1 ltr air\r\n8. 50 gr gula pasir\r\n9. sejumput garam', '1. Parut jahe yg sudah dikupas, lalu rebus dg 1 liter air, masukkan gula pasir dan garam. Rebus hingga mendidih. Sisihkan.\r\n2. Campur tepung ketan, gula pasir, dan garam, tuang air sedikit2 hingga adonan bisa dipulung.\r\n3. Bagi dua bagian. Satu beri warna merah, satunya lg biarkan putih. Bentuk bulat2. Rebus dlm air mendidih sampai mengapung.\r\n4. Sajikan bersama kuah jahe.'),
('R0017', 'A0006', 'Cendol Polkadot', 'cendolnaga.jpg', '2017-05-08', 0, 'Minuman', '1. 200 gram tepung tapioka\r\n2. 1/2 buah naga merah uk besar\r\n3. 250-300 cc air (tergantung kandungan air dalam buah)\r\n4. 1/4 sdt garam\r\n5. secukupnya es batu\r\n6. secukupnya air dingin\r\n', '1. Haluskan buah naga dengan whisker/garpu *boleh diblender dengan air tapi resikonya biji akan hancur, karena aku nyari polka biar makin imut jadi gak pake blender*\r\n2. Tambahkan garam dan air lalu aduk rata. Tuang tepung sedikit2 sambil diaduk biar nggak ada gumpalan. Aduk hingga benar2 semua adonan tercampur yaa dan tidak bergerindil.\r\n3. Tuang adonan ke caserrol dan panaskan sambil terus diaduk dengan spatula kayu. Masak hingga kental, bening dan meletup2. Matikan api.\r\n4. Siapkan air es dan es batu secukupnya. Dengan cepat cetak adonan cendol menggunakan cetakan stainless khusus cendol yg ada penekannya/bisa manual pake semacam peniris minyak ditekan dengan spatula kayu/seperti aku memakai piping bag yg digunting sedikit ujungnya agar hasil tidak terlalu besar. Sejauh ini pakai piping bag lebih ergonomis karena gak belepotan, nyemplungnya bisa diatur dan juga gak numpuk2in cucian yakkk. *ngeles karena belum ada cetakan cendol nih*\r\n5. Setelah selesai, masukkan kulkas dulu biar dingin dan gak gampang hancur.\r\n6. Cendol siap digunakan deh!!! Bisa dibikin dawet biasa, es campur atau dikreasikan untuk minuman yg segar2\r\n7. Happy cooking dan selamat mencoba.'),
('R0018', 'A0007', 'Es Buah Unyu-unyu', 'unyu.jpg', '2017-01-02', 0, 'Minuman', '1. Mangga Gendong\r\n2. Es Batu\r\n3. Sari Kelapa\r\n4. Buah Naga Merah\r\n5. Susu Kental Manis Warna Putih\r\n6. Air Putih', '1. Potong-potong buah mangga dan buah naga, masukan ke dalam wadah, tambahkan sari kelapa, es batu, air, dan susu kental manis, aduk hingga rata, koreksi rasa.. Sajikan pada saatnya berbuka puasa. Kalo saya suka manis dan banyak susunya. Tidak ada jumlah takaran, disesuaikan dengan banyaknya orang di rumah'),
('R0019', 'A0008', 'Wedang Coro', 'coro.jpg', '2017-10-23', 0, 'Minuman', '1. 300 ml santan dr 1/4 butir kelapa\r\n2. 100 gr gula merah disisir halus/ sesuai 3. selera\r\n3. 2 tangkai serai memarkan\r\n4. 1/2 batang jahe memarkan/ diparut diambil 5. airnya juga boleh\r\n6. 3 batang cengkeh\r\n7. 1/2 batang lengkuas memarkan\r\n8. 2 lembar Pandan\r\n9. Kayu manis', '1. Rebus semua bahan sampai mendidih sambil diaduk.\r\n2. Saring lalu sajikan hangat.'),
('R0020', 'A0001', 'Bento Jagung Keju Pedas', 'bento.jpg', '2017-10-17', 1, 'Makanan', '1. 1 sachet saus pedas\r\n2. secukupnya Keju\r\n3. 1 tongkol jagung manis besar\r\n4. Secukupnya semangka\r\n5. Secukupnya mangga', '1. Rebus jagung manis dalam air mendidih kurang lebih 20 menit, setelah matang angkat dan tiriskan\r\n2. Sisir jagung manis yang sudah matang tersebut ke dalam wadah atau lunch box yang sudah di sediakan\r\n3. Parut keju sesuai selera dan taburkan ke atas jagung yang sudah di sisir secara merata\r\n4. Terakhir masukkan saus pedas ke atasnya secara merata. Untuk menambah selera makan, berilah potongan buah mangga dan semangka buat pelengkap bento\r\n5. Selamat mencoba.'),
('R0021', 'A0009', 'Es Jambu Kafir', 'kafir.jpg', '2017-07-18', 0, 'Minuman', '1. Secukupnya jus jambu biji (merah) diblender dgn madu, kekentalan sesuaikan selera\r\n2. Secukupnya air perasan jeruk purut\r\n3. Secukupnya jeruk purut, iris\r\n4. Secukupnya es batu / es serut\r\n5. Daun jeruk purut/ irisan jambu\r\n6. Secukupnya Gula pasir', '1. Campur jus jambu yg di blender dgn madu (bisa di ganti gula pasir), air perasan jeruk, irisan jeruk dan es batu dalam satu wadah\r\n2. Beri olesan air jeruk nipis di ujung gelas saji, celupkan di gula pasir, tuang campuran jus jambu dan jeruk purut segar, beri garnish, siap untuk di sruput / disedot'),
('R0022', 'A0010', 'Sirop Bhiru', 'hejo.jpg', '2017-10-10', 0, 'Minuman', '1. 800 ml air\r\n2. 100 gram gula pasir\r\n3. 2 buah jeruk nipis\r\n4. 1 buah jeruk lemon\r\n5. 1/4 sdt asam sitrun makanan\r\n6. 1/8 sdt pewarna makanan warna hijau\r\n7. 2 lembar daun pandan, simpulkan\r\n8. 1/4 sdt vanili\r\n9. 4 sdm kelapa muda keruk\r\n10. 100 gram kolang kaling rebus\r\n11. 4 sdm es batu bentuk dadu', '1. Campur air, gula dan daun pandan kemudian masak sampai gula larut. Angkat dan saring.\r\n2. Peras jeruk nipis dan jeruk lemon. Sisihkan airnya, saring.\r\n3. Tambahkan air jeruk, vanili dan pewarna kue pada gula cair, aduk rata.\r\n4. Jerang kembali diatas api, aduk-aduk hingga hangat kuku, tidak perlu sampai mendidih. Angkat tambahkan sitrun, biarkan dingin.\r\n5. Tuang dalam gelas, pertama kolang kaling lalu kelapa muda kemudian sirup dan es batu. Lakukan hal yang sama sampai selesai.\r\n6. Sajikan.'),
('R0023', 'A0011', 'Rempah Kayumanis Asam Jawa', 'Kayuasamjawa.jpg', '2017-06-28', 0, 'Minuman', '1. 1 liter air\r\n2. 200 gram gula aren/ gula kawung (sunda)\r\n3. 75 gram asam Jawa\r\n4. 25 gram kayumanis\r\n5. 50 gram kunyit, iris\r\n6. 50 gram kencur', '1. Rebus air dengan gula aren dan asam jawa hingga mendidih dan gula larur.\r\n2. Masukan kayumanis, kunyit dan kencur. Aduk rata sampai mendidih\r\n3. Angkat, saring dan biarkan mengendap.\r\n4. Siapkan gelas saji, tuangkan dalam gelas sambil disaring kembali.\r\n5. Sajikan hangat atau dingin.'),
('R0024', 'A0012', 'Angsle', 'angsle.jpg', '2017-07-31', 0, 'Minuman', 'Isi:\r\n1. 100 gram kacang hijau, cuci, rendam, rebus \r\n   hingga lunak tetapi tidak terlalu pecah\r\n2. 5 buah putu mayang, siap pakai\r\n3. 3 lembar roti tawar, potong dadu kecil\r\n4. 150 gram biji delima, siap pakai\r\n5. 5 sdm susu kental manis\r\nKuah:\r\n1. 1 liter santan encer\r\n2. 100 gram jahe, memarkan\r\n3. 2 lembar daun pandan, simpulkan\r\n4. 150 gram gula merah\r\n5. 50 gram gula pasir', '1. Rebus santan, jahe, gula merah, daun pandan, dan gula pasir hingga mendidih dan keluar aroma.\r\n2. Cara menyajikan wedang angsle sebagai \r\n   berikut:\r\n   - Putu mayang (paling bawah)\r\n   - Roti (lapis kedua)\r\n   - Kacang hijau rebus (lapis ketiga)\r\n   - Biji delima (lapis keempat)\r\n   - Santan jahe (lapis kelima)\r\n   - Susu kental manis (paling atas)\r\n3. Hidangkan hangat-hangat'),
('R0025', 'A0013', 'Bir Pletok', 'pletok.JPEG', '2017-03-20', 0, 'Minuman', '1. 5 cm batang kayu manis\r\n2. 50 gram jahe merah, memarkan\r\n3. Segenggam kayu secang\r\n4. 2 batang serai, memarkan\r\n5. 100 gram gula pasir\r\n6. ¼ sdt garam\r\n7. 5 butir merica hitam bulat\r\n8. 2 buah cabai jawa\r\n9. 1 liter air', '1. Rebus air sampai mendidih. Masukkan jahe, serai, kayu manis, merica hitam, cabai jawa, dan kayu secang, masak hingga keluar aroma.\r\n2. Masukkan gula dan garam, didihkan kembali agar gula larut, lalu angkat.\r\n3. Hidangkan hangat, dapat juga dihidangkan dalam keadaan dingin'),
('R0026', 'A0014', 'Es Mutiara Ceria', 'ceria.jpg', '2017-04-16', 0, 'Minuman', '1. 200 gr melon, kerok dagingnya\r\n2. 1 buah kelapa muda, kerok dagingnya, \r\n   sisihkan air kelapa mudanya\r\n3. 100 gr biji mutiara, rebus sampai masak\r\n4. 1 bungkus agar-agar merah\r\n5. 100 ml susu full cream atau susu rendah \r\n   lemak\r\n6. Sirup cocopandan atau frambozen, menurut \r\n   selera\r\n7. Es batu atau es serut, sesuai selera', '1. Masak agar-agar sesuai petunjuk dalam \r\n   kemasan, setelah dingin dan mengeras, \r\n   potong dadu. \r\n2. Siapkan mangkuk, masukkan melon, daging \r\n   kelapa muda, biji mutiara, dan agar-agar. \r\n3. Masukkan air kelapa muda, lalu tambahkan \r\n   dengan sirup merah atau cocopandan dan es \r\n   batu \r\n4. Sajikan selagi masih dingin.'),
('R0027', 'A0015', 'Es Patu butung', 'palu.jpg', '2017-04-12', 0, 'Minuman', '1. 6 buah pisang kepok, kukus, potong-potong\r\n2. 150 ml sirop Pisang Ambon\r\n3. 100 ml susu kental manis\r\n4. Es serut\r\n5. Bubur Sumsum: \r\n   - 100 gram tepung beras\r\n   - 75 gram gula pasir\r\n   - 1 liter santan\r\n   - 1 lembar daun pandan\r\n   - ½ sendok teh garam', '1. Bubur Sumsum: Aduk semua bahan hingga \r\n   rata.\r\n2. Masak sambil aduk-aduk hingga kental. \r\n   Angkat dan dinginkan.\r\n3. Siapkan gelas-gelas saji. Beri bubur \r\n   sumsum, potongan pisang.\r\n4. Tutup dengan es serut dan beri sirop serta \r\n   susu kental manis.\r\n5. Sajikan segera.'),
('R0028', 'A0003', 'Ketan Bubuk', 'kebuk.jpg', '2017-02-20', 0, 'Makanan', '1. 500 gram ketan\r\n2. 100 ml santan instant\r\n3. 1 sdm garam\r\n4. 200 ml air panas\r\n5. Bahan taburan\r\n6. 100 gram kedelai kupas\r\n7. 4 sdm gula', '1. Cara memasak ketan : Rendam ketan \r\n   semalam.\r\n2. Kukus ketan selama 20. Angkat, masukkan \r\n   kedalam wadah (panci)\r\n3. Campur ketan dengan garam dan santan \r\n   instant terlebih dahulu. Aduk rata. Lalu \r\n   tambahkan air panas. Aduk rata.\r\n4. Kukus ketan lagi selama 20 menit.\r\n5. Cara membuat bubuk taburan : cuci kedelai \r\n   hingga bersih\r\n6. Sangrai kedelai dengan api kecil hingga \r\n   kecoklatan dan kering\r\n7. Setelah dingin, blender kedelai dan gula \r\n   hingga halus. Ayak.\r\n8. Ketan siap disajikan hangat hangat'),
('R0029', 'A0004', 'Nasi Pecel', 'pecel.jpg', '2017-05-05', 0, 'Makanan', 'Bumbu pecel :\r\n  1. 100 gr kacang tanah\r\n  2. 2 siung bawang putih\r\n  3. secukupnya Kencur\r\n  4. 8 cabe rawit\r\n  5. 2 cabe merah besar\r\n  6. Gula jawa\r\n  7. secukupnya Asam jawa\r\n  8. Garam dapur\r\n  9. Daun jeruk\r\n 10. Bahan utk rempeyek\r\n 11. 500 Tepung beras rose brand\r\n 12. secukupnya Udang ebi\r\n 13. secukupnya Kacang tanah\r\n 14. Garam dapur\r\n 15. 1 sdm gula putih\r\n 16. 3 butir Kemiri\r\n 17. 3 cabe keriting\r\n 18. secukupnya Kunyit utk pewarna\r\n 19. secukupnya Ketumbar\r\n 20. Minyak goreng\r\nSayur hijau :\r\n  1. Kacang panjang\r\n  2. Kecambah atau toge juga bisa', '1. Goreng kacang tanah untuk bumbu \r\n   kemudian sisihkan\r\n2. Goreng bumbu utk bumbu pecel, kemudian \r\n   haluskan bersama kacang tanah. Jgn \r\n   lupa daun jeruk diiris tipis2\r\n3. Selanjutnya membuat rempeyek\r\n4. Haluskan bumbu dan camputkan dgn \r\n   tepung beras bersama udang ebi dan \r\n   kacang tanah. Pastikan tidak terlalu \r\n   encer atau tdk terlalu kental.\r\n5. Panaskan minyak dan rempeyek bisa \r\n   digoreng tipis2 aja.\r\n6. Selanjutnya rebus kacang panjang yg \r\n   sudah dipotong.\r\n7. Setelah kacang agak lunak masukkan \r\n   kecambah atau toge.\r\n8. Setelah matang ditiriskan\r\n9. Dan nasi pecel siap disantap dipagi \r\n   hari utk sarapan anda'),
('R0030', 'A0005', 'Rawon', 'rawon.jpg', '2017-03-01', 1, 'Makanan', '1. 500 gram daging sandung lamur sapi \r\n2. 3 liter air \r\n3. 1 dengkul sapi belah dua \r\n4. 3 lembar daun jeruk purut segar \r\n5. 1 batang serai memarkan \r\n6. 5 sendok makan minyak goreng \r\n7. 3 bungkus Royco rasa sapi\r\n8. 2 daun bawang potong potong seukuran 1cm', '1. Rebus daging dan dengkul sapi hingga \r\n   setengah lunak. Potong daging sesuai \r\n   selera. Sisihkan.\r\n2. Masukkan Royco Bumbu Pelezat Serbaguna \r\n   Rasa Sapi ke dalam air rebusan daging.\r\n3. Tumis bumbu halus, lengkuas, daun \r\n   jeruk, dan serai hingga harum dan \r\n   matang.\r\n4. Masukkan potongan daging ke dalam \r\n   tumisan, masak hingga bumbu meresap.\r\n5. Masukkan tumisan daging ke dalam kuah \r\n   kaldu.\r\n6. Masak dengan api kecil hingga daging \r\n   empuk.\r\n7. Sajikan hangat beserta pelengkap.'),
('R0031', 'A0001', 'Nasi Panggang', 'gb.jpg', '2017-08-08', 1, 'Makanan', 'Nasi', 'Panggang'),
('R0032', 'A0005', 'Tongkol Bawang Kecap', '5-Prinsip-yang-Harus-di-Miliki-Oleh-Seorang-Pemimpin-Training-Leadership.jpg', '2017-10-24', 0, 'Makanan', '- tongkol\n- bawang\n- kecap', '- hidupkan api secukupnya\n- masukkan tongkol kemudian bawang yang dicampur kecap\n- tunggu hingga matang\n- makanan siap disajikan');

--
-- Trigger `resep`
--
DELIMITER $$
CREATE TRIGGER `tr_autoIdResep` BEFORE INSERT ON `resep` FOR EACH ROW BEGIN
SET @hitung = CONVERT((RIGHT((SELECT idResep FROM `resep` ORDER by idResep DESC LIMIT 1), 4)), UNSIGNED) + 1;
if (@hitung >= 1) THEN
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
