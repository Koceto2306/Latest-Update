-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2024 at 07:46 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `volleyballrecruitmentagency`
--

-- --------------------------------------------------------

--
-- Table structure for table `teams`
--

CREATE TABLE `teams` (
  `TeamID` int(11) NOT NULL,
  `TeamName` varchar(100) NOT NULL,
  `Category` varchar(20) NOT NULL,
  `Country` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `teams`
--

INSERT INTO `teams` (`TeamID`, `TeamName`, `Category`, `Country`) VALUES
(1, 'Levski Sofia', 'Club', 'Bulgaria'),
(2, 'Neftohimik Burgas', 'Club', 'Bulgaria'),
(3, 'Deya Sport Burgas', 'Club', 'Bulgaria'),
(4, 'Lokomotiv Avia', 'Club', 'Bulgaria'),
(5, 'CSKA Sofia', 'Club', 'Bulgaria'),
(6, 'Montana', 'Club', 'Bulgaria'),
(7, 'Cherno More', 'Club', 'Bulgaria'),
(8, 'Dobruja 07', 'Club', 'Bulgaria'),
(9, 'Pirin Razlog', 'Club', 'Bulgaria'),
(10, 'Dunav Ruse', 'Club', 'Bulgaria'),
(11, 'Beroe', 'Club', 'Bulgaria'),
(12, 'Hebar Pazardzhik', 'Club', 'Bulgaria'),
(13, 'Gas Sales Bluenergy Piacenza', 'Club', 'Italy'),
(14, 'Sir Susa Vim Perugia', 'Club', 'Italy'),
(15, 'Itas Trentino', 'Club', 'Italy'),
(16, 'Rana Verona', 'Club', 'Italy'),
(17, 'Cucine Lube Civitanova', 'Club', 'Italy'),
(18, 'Valsa Group Modena', 'Club', 'Italy'),
(19, 'Sonepar Padova', 'Club', 'Italy'),
(20, 'Gioiella Prisma Taranto', 'Club', 'Italy'),
(21, 'Allianz Milano', 'Club', 'Italy'),
(22, 'Mint Vero Volley Monza', 'Club', 'Italy'),
(23, 'Cisterna Volley', 'Club', 'Italy'),
(24, 'Yuasa Battery Grottazzolina', 'Club', 'Italy'),
(25, 'Galatasaray', 'Club', 'Turkey'),
(26, 'Ziraat Bankasi', 'Club', 'Turkey'),
(27, 'Halkbank', 'Club', 'Turkey'),
(28, 'Spor Toto', 'Club', 'Turkey'),
(29, 'Altekma', 'Club', 'Turkey'),
(30, 'Alanya Bld', 'Club', 'Turkey'),
(31, 'Fenerbahce', 'Club', 'Turkey'),
(32, 'Arkasspor', 'Club', 'Turkey'),
(33, 'Cizre Bld', 'Club', 'Turkey'),
(34, 'Tursad', 'Club', 'Turkey'),
(35, 'Bursa', 'Club', 'Turkey'),
(36, 'Istanbul GSK', 'Club', 'Turkey'),
(37, 'Akkus Bld', 'Club', 'Turkey'),
(38, 'Tourcoing', 'Club', 'France'),
(39, 'Cannes', 'Club', 'France'),
(40, 'Montpellier', 'Club', 'France'),
(41, 'Nice', 'Club', 'France'),
(42, 'Poitiers', 'Club', 'France'),
(43, 'Sete', 'Club', 'France'),
(44, 'Toulouse', 'Club', 'France'),
(45, 'Chaumont', 'Club', 'France'),
(46, 'St. Nazaire', 'Club', 'France'),
(47, 'Paris', 'Club', 'France'),
(48, 'Narbonne', 'Club', 'France'),
(49, 'Tours', 'Club', 'France'),
(50, 'Plessis Robinson', 'Club', 'France');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(64) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `UserType` enum('Player','Coach','Admin') DEFAULT 'Player',
  `RegistrationDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Position` varchar(50) DEFAULT NULL,
  `Height` decimal(5,2) DEFAULT NULL,
  `Weight` decimal(5,2) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `Country` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `PasswordHash`, `Email`, `UserType`, `RegistrationDate`, `FirstName`, `LastName`, `Position`, `Height`, `Weight`, `BirthDate`, `Country`, `MiddleName`) VALUES
(1, 'aaa', '61be55a8e2f6b4e172338bddf184d6dbee29c98853e0a0485ecee7f27b9af0b4', 'koko@gmail.com', 'Player', '2024-10-11 09:16:32', '', '', NULL, NULL, NULL, NULL, NULL, NULL),
(22, 'bbb', '3e744b9dc39389baf0c5a0660589b8402f3dbb49b89b3e75f2c9355852a3c677', 'bbb@gmail.com', 'Player', '2024-12-03 06:42:03', 'b', 'b', 'Opposite Hitter', 198.00, 98.00, '2000-12-03', NULL, 'b');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `teams`
--
ALTER TABLE `teams`
  ADD PRIMARY KEY (`TeamID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `teams`
--
ALTER TABLE `teams`
  MODIFY `TeamID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
