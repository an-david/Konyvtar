-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Feb 08. 19:06
-- Kiszolgáló verziója: 10.4.17-MariaDB
-- PHP verzió: 7.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `konyves_ab`
--
CREATE DATABASE IF NOT EXISTS `konyves_ab` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `konyves_ab`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `konyv`
--

CREATE TABLE `konyv` (
  `k_azon` int(11) NOT NULL,
  `cim` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `szerzo` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `kiado` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `megj` varchar(4) COLLATE utf8_hungarian_ci NOT NULL,
  `mufaj` varchar(30) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `konyv`
--

INSERT INTO `konyv` (`k_azon`, `cim`, `szerzo`, `kiado`, `megj`, `mufaj`) VALUES
(3, 'a', 'b', 'c', 'd', 'e'),
(4, '3434', '43', '32432', '4243', '324'),
(5, '3434', '43', '32432', '4243', '324'),
(6, '3434', '43', '32432', '4243', '324');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vasarlas`
--

CREATE TABLE `vasarlas` (
  `szam` int(11) NOT NULL,
  `azon` int(11) NOT NULL,
  `datum` datetime NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vasarlas`
--

INSERT INTO `vasarlas` (`szam`, `azon`, `datum`, `ar`) VALUES
(1, 4, '0000-00-00 00:00:00', 3000),
(3, 3, '0000-00-00 00:00:00', 5500),
(4, 3, '0000-00-00 00:00:00', 12000),
(5, 3, '0000-00-00 00:00:00', 12123),
(6, 3, '0000-00-00 00:00:00', 1233),
(9, 3, '0000-00-00 00:00:00', 233),
(10, 3, '0000-00-00 00:00:00', 12344),
(11, 3, '0000-00-00 00:00:00', 13200),
(12, 3, '0000-00-00 00:00:00', 12000),
(13, 3, '0000-00-00 00:00:00', 120),
(14, 3, '0000-00-00 00:00:00', 12000),
(15, 3, '0000-00-00 00:00:00', 1),
(16, 3, '0000-00-00 00:00:00', 12),
(17, 3, '0000-00-00 00:00:00', 12),
(18, 3, '0000-00-00 00:00:00', 12000),
(19, 3, '0000-00-00 00:00:00', 12000),
(20, 3, '2021-02-08 00:00:00', 12000),
(21, 3, '2021-02-08 07:05:31', 1313);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `konyv`
--
ALTER TABLE `konyv`
  ADD PRIMARY KEY (`k_azon`);

--
-- A tábla indexei `vasarlas`
--
ALTER TABLE `vasarlas`
  ADD PRIMARY KEY (`szam`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `konyv`
--
ALTER TABLE `konyv`
  MODIFY `k_azon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `vasarlas`
--
ALTER TABLE `vasarlas`
  MODIFY `szam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
