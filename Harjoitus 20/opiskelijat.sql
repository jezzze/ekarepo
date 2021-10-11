-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 11.10.2021 klo 11:49
-- Palvelimen versio: 10.4.16-MariaDB
-- PHP Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `opiskelijat`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `yhteystiedot`
--

CREATE TABLE `yhteystiedot` (
  `Oid` int(11) NOT NULL,
  `etunimi` varchar(25) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `puhelin` varchar(15) NOT NULL,
  `sahkoposti` varchar(35) NOT NULL,
  `opiskelijanumero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `yhteystiedot`
--

INSERT INTO `yhteystiedot` (`Oid`, `etunimi`, `sukunimi`, `puhelin`, `sahkoposti`, `opiskelijanumero`) VALUES
(2, 'sdfgg', 'sddfgg', 'sdfgg', 'sdfg13', 13245);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `yhteystiedot`
--
ALTER TABLE `yhteystiedot`
  ADD PRIMARY KEY (`Oid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `yhteystiedot`
--
ALTER TABLE `yhteystiedot`
  MODIFY `Oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
