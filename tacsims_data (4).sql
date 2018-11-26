-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 02, 2018 at 01:43 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tacsims_data`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_airbase`
--

CREATE TABLE `t_airbase` (
  `id` int(11) NOT NULL,
  `nm_airbase` varchar(50) NOT NULL,
  `force` varchar(10) NOT NULL,
  `munition` varchar(25) NOT NULL,
  `aviation_fuel` varchar(25) NOT NULL,
  `aircrews` varchar(5) NOT NULL,
  `groundcrews` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_airbase`
--

INSERT INTO `t_airbase` (`id`, `nm_airbase`, `force`, `munition`, `aviation_fuel`, `aircrews`, `groundcrews`) VALUES
(1, 'Tarakan', 'Biru', '484', '924408.000000', '38', '150'),
(2, 'Labuan', 'Merah', '452', '950952.000000', '42', '150');

-- --------------------------------------------------------

--
-- Table structure for table `t_airbase_list_aircraft`
--

CREATE TABLE `t_airbase_list_aircraft` (
  `id` int(11) NOT NULL,
  `nm_airbase` varchar(50) NOT NULL,
  `force` varchar(10) NOT NULL,
  `type_aircraft` varchar(25) NOT NULL,
  `available` int(5) NOT NULL,
  `in_repair` int(5) NOT NULL,
  `assigned` int(5) NOT NULL,
  `qra` int(5) NOT NULL,
  `count` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_airbase_list_aircraft`
--

INSERT INTO `t_airbase_list_aircraft` (`id`, `nm_airbase`, `force`, `type_aircraft`, `available`, `in_repair`, `assigned`, `qra`, `count`) VALUES
(1, 'Tarakan', 'Biru', 'SU-30', 0, 0, 0, 0, 4),
(2, 'Tarakan', 'Biru', 'F-16C', 0, 0, 0, 0, 8),
(3, 'Labuan', 'Merah', 'FWA, F/A-18', 2, 0, 0, 0, 6);

-- --------------------------------------------------------

--
-- Table structure for table `t_airbase_list_runway`
--

CREATE TABLE `t_airbase_list_runway` (
  `id` int(11) NOT NULL,
  `nm_airbase` varchar(50) NOT NULL,
  `force` varchar(10) NOT NULL,
  `nm_runway` varchar(50) NOT NULL,
  `length` varchar(25) NOT NULL,
  `width` varchar(25) NOT NULL,
  `direction` varchar(25) NOT NULL,
  `condition` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_airbase_list_runway`
--

INSERT INTO `t_airbase_list_runway` (`id`, `nm_airbase`, `force`, `nm_runway`, `length`, `width`, `direction`, `condition`) VALUES
(1, 'Tarakan', 'Biru', '3/21', '2000.000000', '50.000000', '30.000000', 'Baik'),
(2, 'Labuan', 'Merah', '3/21', '2000.000000', '50.000000', '30.000000', 'Baik');

-- --------------------------------------------------------

--
-- Table structure for table `t_engagement_history`
--

CREATE TABLE `t_engagement_history` (
  `id` int(11) NOT NULL,
  `nm_aircraft` varchar(100) NOT NULL,
  `force` enum('Biru','Merah') NOT NULL,
  `shotby` varchar(100) NOT NULL,
  `forceshot` enum('Biru','Merah') NOT NULL,
  `weapontype` varchar(100) NOT NULL,
  `damage` int(8) NOT NULL,
  `hitfactor` varchar(25) NOT NULL,
  `defensefactor` varchar(25) NOT NULL,
  `starttime` varchar(50) NOT NULL,
  `endtime` varchar(50) NOT NULL,
  `status` enum('Attack','Defense') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_engagement_history`
--

INSERT INTO `t_engagement_history` (`id`, `nm_aircraft`, `force`, `shotby`, `forceshot`, `weapontype`, `damage`, `hitfactor`, `defensefactor`, `starttime`, `endtime`, `status`) VALUES
(1, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3673.72910285', '3674.3939569', 'Attack'),
(2, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Alamo', 1040, '19', '17', '3675.225835085', '3675.225835085', 'Defense'),
(3, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Alamo', 1040, '19', '16', '3683.359383583', '3683.359383583', 'Defense'),
(4, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3686.401324511', '3687.199102879', 'Attack'),
(5, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Sidewinder', 1040, '18', '6', '3673.72910285', '3673.72910285', 'Defense'),
(6, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Alamo', 0, '19', '0', '3675.225835085', '3676.165234089', 'Attack'),
(7, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Alamo', 0, '19', '0', '3683.359383583', '3684.032331944', 'Attack'),
(8, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Sidewinder', 1040, '18', '5', '3686.401324511', '3686.401324511', 'Defense'),
(9, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Alamo', 0, '19', '0', '3693.725984335', '3694.521295071', 'Attack'),
(10, 'QRA', 'Merah', 'SEAD', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3772.427516222', '3773.261569977', 'Attack'),
(11, 'QRA', 'Merah', 'SWEEPER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3836.97172308', '3837.566684723', 'Attack'),
(12, 'QRA', 'Merah', 'SWEEPER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3849.864332914', '3851.920740843', 'Attack'),
(13, 'QRA', 'Merah', 'SWEEPER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3857.470189571', '3858.064781666', 'Attack'),
(14, 'QRA', 'Merah', 'SWEEPER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3865.089767218', '3866.715400457', 'Attack'),
(15, 'QRA', 'Merah', 'STRIKER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3906.594871521', '3908.036290646', 'Attack'),
(16, 'QRA', 'Merah', 'STRIKER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3914.101307631', '3915.323471069', 'Attack'),
(17, 'QRA', 'Merah', 'STRIKER', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3921.626191378', '3922.929768801', 'Attack'),
(18, 'QRA', 'Merah', 'STRIKER', 'Biru', 'Missile, AMRAAM', 0, '22', '0', '3929.545890331', '3930.00733757', 'Attack'),
(23, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Alamo', 1040, '19', '12', '3693.725984335', '3693.725984335', 'Defense'),
(24, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Sidewinder', 0, '18', '0', '3765.97050333', '3769.909190178', 'Attack'),
(25, 'CAP', 'Merah', 'SEAD', 'Biru', 'Missile, Adder', 1040, '19', '7', '3768.685029984', '3768.685029984', 'Defense'),
(31, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Sidewinder', 2080, '18', '4', '3765.97050333', '3765.97050333', 'Defense'),
(32, 'SEAD', 'Biru', 'CAP', 'Merah', 'Missile, Adder', 0, '19', '0', '3768.685029984', '3770.351099014', 'Attack'),
(33, 'SWEEPER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '9', '3836.97172308', '3836.97172308', 'Defense'),
(34, 'SWEEPER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '8', '3849.864332914', '3849.864332914', 'Defense'),
(35, 'SWEEPER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '4', '3857.470189571', '3857.470189571', 'Defense'),
(36, 'SWEEPER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '2', '3865.089767218', '3865.089767218', 'Defense'),
(37, 'STRIKER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '9', '3906.594871521', '3906.594871521', 'Defense'),
(38, 'STRIKER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '8', '3914.101307631', '3914.101307631', 'Defense'),
(39, 'STRIKER', 'Biru', 'QRA', 'Merah', 'Missile, Sidewinder', 1040, '18', '4', '3921.626191378', '3921.626191378', 'Defense'),
(40, 'STRIKER', 'Biru', 'QRA', 'Merah', 'Missile, AMRAAM', 1040, '22', '7', '3929.545890331', '3929.545890331', 'Defense');

-- --------------------------------------------------------

--
-- Table structure for table `t_engagement_history_detail`
--

CREATE TABLE `t_engagement_history_detail` (
  `id` int(11) NOT NULL,
  `id_engagement` int(11) NOT NULL,
  `starttime` varchar(100) NOT NULL,
  `detail` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_engagement_history_detail`
--

INSERT INTO `t_engagement_history_detail` (`id`, `id_engagement`, `starttime`, `detail`) VALUES
(1, 1, '3673.72910285', 'Base Hit Factor 13'),
(2, 1, '3673.72910285', 'Using GCI, Hit Factor +3'),
(3, 1, '3673.72910285', 'Using Data Link, Hit Factor +2'),
(4, 2, '3675.225835085', 'Base Defense Factor 1'),
(5, 2, '3675.225835085', 'Using Defensive Flight Maneuvers, Defense Factor +5'),
(6, 2, '3675.225835085', 'Deploying Chaff, Defense Factor +3'),
(7, 2, '3675.225835085', 'Using Radar Warning Receiver, Defense Factor +5'),
(8, 2, '3675.225835085', 'Using GCI, Defense Factor +3'),
(9, 2, '3675.225835085', 'Attack hits!'),
(10, 3, '3683.359383583', 'Base Defense Factor 1'),
(11, 3, '3683.359383583', 'Using Defensive Flight Maneuvers, Defense Factor +4'),
(12, 3, '3683.359383583', 'Deploying Chaff, Defense Factor +3'),
(13, 3, '3683.359383583', 'Using Radar Warning Receiver, Defense Factor +5'),
(14, 3, '3683.359383583', 'Using GCI, Defense Factor +3'),
(15, 3, '3683.359383583', 'Attack hits!'),
(16, 4, '3686.401324511', 'Base Hit Factor 13'),
(17, 4, '3686.401324511', 'Using GCI, Hit Factor +3'),
(18, 4, '3686.401324511', 'Using Data Link, Hit Factor +2'),
(19, 5, '3673.72910285', 'Base Defense Factor 1'),
(20, 5, '3673.72910285', 'Using Defensive Flight Maneuvers, Defense Factor +5'),
(21, 5, '3673.72910285', 'Attack hits!'),
(22, 6, '3675.225835085', 'Base Hit Factor 17'),
(23, 6, '3675.225835085', 'Using Data Link, Hit Factor +2'),
(24, 7, '3683.359383583', 'Base Hit Factor 17'),
(25, 7, '3683.359383583', 'Using Data Link, Hit Factor +2'),
(26, 8, '3686.401324511', 'Base Defense Factor 1'),
(27, 8, '3686.401324511', 'Using Defensive Flight Maneuvers, Defense Factor +4'),
(28, 8, '3686.401324511', 'Attack hits!'),
(29, 9, '3693.725984335', 'Base Hit Factor 17'),
(30, 9, '3693.725984335', 'Using Data Link, Hit Factor +2'),
(31, 10, '3772.427516222', 'Base Hit Factor 13'),
(32, 10, '3772.427516222', 'Using GCI, Hit Factor +3'),
(33, 10, '3772.427516222', 'Using Data Link, Hit Factor +2'),
(34, 11, '3836.97172308', 'Base Hit Factor 13'),
(35, 11, '3836.97172308', 'Using GCI, Hit Factor +3'),
(36, 11, '3836.97172308', 'Using Data Link, Hit Factor +2'),
(37, 12, '3849.864332914', 'Base Hit Factor 13'),
(38, 12, '3849.864332914', 'Using GCI, Hit Factor +3'),
(39, 12, '3849.864332914', 'Using Data Link, Hit Factor +2'),
(40, 13, '3857.470189571', 'Base Hit Factor 13'),
(41, 13, '3857.470189571', 'Using GCI, Hit Factor +3'),
(42, 13, '3857.470189571', 'Using Data Link, Hit Factor +2'),
(43, 14, '3865.089767218', 'Base Hit Factor 13'),
(44, 14, '3865.089767218', 'Using GCI, Hit Factor +3'),
(45, 14, '3865.089767218', 'Using Data Link, Hit Factor +2'),
(46, 15, '3906.594871521', 'Base Hit Factor 13'),
(47, 15, '3906.594871521', 'Using GCI, Hit Factor +3'),
(48, 15, '3906.594871521', 'Using Data Link, Hit Factor +2'),
(49, 16, '3914.101307631', 'Base Hit Factor 13'),
(50, 16, '3914.101307631', 'Using GCI, Hit Factor +3'),
(51, 16, '3914.101307631', 'Using Data Link, Hit Factor +2'),
(52, 17, '3921.626191378', 'Base Hit Factor 13'),
(53, 17, '3921.626191378', 'Using GCI, Hit Factor +3'),
(54, 17, '3921.626191378', 'Using Data Link, Hit Factor +2'),
(55, 18, '3929.545890331', 'Base Hit Factor 17'),
(56, 18, '3929.545890331', 'Using GCI, Hit Factor +3'),
(57, 18, '3929.545890331', 'Using Data Link, Hit Factor +2'),
(58, 23, '3693.725984335', 'Base Defense Factor 1'),
(59, 23, '3693.725984335', 'Using Defensive Flight Maneuvers, Defense Factor +3'),
(60, 23, '3693.725984335', 'Using Radar Warning Receiver, Defense Factor +5'),
(61, 23, '3693.725984335', 'Using GCI, Defense Factor +3'),
(62, 23, '3693.725984335', 'Attack hits!'),
(63, 24, '3765.97050333', 'Base Hit Factor 13'),
(64, 24, '3765.97050333', 'Using GCI, Hit Factor +3'),
(65, 24, '3765.97050333', 'Using Data Link, Hit Factor +2'),
(66, 25, '3768.685029984', 'Base Defense Factor 1'),
(67, 25, '3768.685029984', 'Using Defensive Flight Maneuvers, Defense Factor +1'),
(68, 25, '3768.685029984', 'Using Radar Warning Receiver, Defense Factor +5'),
(69, 25, '3768.685029984', 'Attack hits!'),
(70, 31, '3765.97050333', 'Base Defense Factor 1'),
(71, 31, '3765.97050333', 'Using Defensive Flight Maneuvers, Defense Factor +3'),
(72, 31, '3765.97050333', 'Attack hits!'),
(73, 32, '3768.685029984', 'Base Hit Factor 17'),
(74, 32, '3768.685029984', 'Using Data Link, Hit Factor +2'),
(75, 33, '3836.97172308', 'Base Defense Factor 1'),
(76, 33, '3836.97172308', 'Using Defensive Flight Maneuvers, Defense Factor +5'),
(77, 33, '3836.97172308', 'Deploying Flares, Defense Factor +3'),
(78, 33, '3836.97172308', 'Attack hits!'),
(79, 34, '3849.864332914', 'Base Defense Factor 1'),
(80, 34, '3849.864332914', 'Using Defensive Flight Maneuvers, Defense Factor +4'),
(81, 34, '3849.864332914', 'Deploying Flares, Defense Factor +3'),
(82, 34, '3849.864332914', 'Attack hits!'),
(83, 35, '3857.470189571', 'Base Defense Factor 1'),
(84, 35, '3857.470189571', 'Using Defensive Flight Maneuvers, Defense Factor +3'),
(85, 35, '3857.470189571', 'Attack hits!'),
(86, 36, '3865.089767218', 'Base Defense Factor 1'),
(87, 36, '3865.089767218', 'Using Defensive Flight Maneuvers, Defense Factor +1'),
(88, 36, '3865.089767218', 'Attack hits!'),
(89, 37, '3906.594871521', 'Base Defense Factor 1'),
(90, 37, '3906.594871521', 'Using Defensive Flight Maneuvers, Defense Factor +5'),
(91, 37, '3906.594871521', 'Deploying Flares, Defense Factor +3'),
(92, 37, '3906.594871521', 'Attack hits!'),
(93, 38, '3914.101307631', 'Base Defense Factor 1'),
(94, 38, '3914.101307631', 'Using Defensive Flight Maneuvers, Defense Factor +4'),
(95, 38, '3914.101307631', 'Deploying Flares, Defense Factor +3'),
(96, 38, '3914.101307631', 'Attack hits!'),
(97, 39, '3921.626191378', 'Base Defense Factor 1'),
(98, 39, '3921.626191378', 'Using Defensive Flight Maneuvers, Defense Factor +3'),
(99, 39, '3921.626191378', 'Attack hits!'),
(100, 40, '3929.545890331', 'Base Defense Factor 1'),
(101, 40, '3929.545890331', 'Using Defensive Flight Maneuvers, Defense Factor +1'),
(102, 40, '3929.545890331', 'Using Radar Warning Receiver, Defense Factor +5'),
(103, 40, '3929.545890331', 'Attack hits!');

-- --------------------------------------------------------

--
-- Table structure for table `t_entity_armament`
--

CREATE TABLE `t_entity_armament` (
  `id` int(11) NOT NULL,
  `time` datetime NOT NULL,
  `name` varchar(25) NOT NULL,
  `force` varchar(10) NOT NULL,
  `type` varchar(100) NOT NULL,
  `value` int(5) NOT NULL,
  `amount` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_entity_armament`
--

INSERT INTO `t_entity_armament` (`id`, `time`, `name`, `force`, `type`, `value`, `amount`) VALUES
(1, '2018-11-02 15:25:30', 'QRA', 'Merah', 'Missile, Sidewinder', 0, 8),
(2, '2018-11-02 15:25:30', 'QRA', 'Merah', 'Bomb, JDAM, 2000lb', 8, 8),
(3, '2018-11-02 15:25:30', 'QRA', 'Merah', 'Missile, AMRAAM', 7, 8),
(4, '2018-11-02 15:25:31', 'CAP', 'Merah', 'Missile, Sidewinder', 0, 8),
(5, '2018-11-02 15:25:31', 'CAP', 'Merah', 'Bomb, JDAM, 2000lb', 0, 8),
(6, '2018-11-02 15:25:31', 'CAP', 'Merah', 'Missile, AMRAAM', 0, 8),
(13, '2018-11-02 15:25:41', 'SEAD', 'Biru', 'Missile, Alamo', 0, 4),
(14, '2018-11-02 15:25:41', 'SEAD', 'Biru', 'High-Explosive', 0, 600),
(15, '2018-11-02 15:25:41', 'SEAD', 'Biru', 'Missile, Krypton', 0, 4),
(16, '2018-11-02 15:25:41', 'SEAD', 'Biru', 'Missile, Adder', 0, 4),
(17, '2018-11-02 15:25:41', 'SEAD', 'Biru', 'Missile, Archer', 0, 4);

-- --------------------------------------------------------

--
-- Table structure for table `t_entity_contact`
--

CREATE TABLE `t_entity_contact` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `force` varchar(5) NOT NULL,
  `detected` varchar(50) NOT NULL,
  `forcedetect` varchar(10) NOT NULL,
  `cif` varchar(25) NOT NULL,
  `location` varchar(100) NOT NULL,
  `altitude` double NOT NULL,
  `distance` double NOT NULL,
  `timedetected` varchar(50) NOT NULL,
  `lasttimedetected` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_entity_contact`
--

INSERT INTO `t_entity_contact` (`id`, `name`, `force`, `detected`, `forcedetect`, `cif`, `location`, `altitude`, `distance`, `timedetected`, `lasttimedetected`) VALUES
(1, 'R. Labuan', 'Merah', 'QRA', 'Merah', 'Detected', '0.0925052  /  2.01154', 336.2845814725817, 887.2459114871552, '1727.743344', '2132.539515'),
(2, 'R. Labuan', 'Merah', 'CAP', 'Merah', 'Detected', '0.0916882  /  2.01926', 336.28458147239326, 48765.04632846001, '1903.886739', '2132.539515'),
(3, 'QRA', 'Merah', 'R. Labuan', 'Biru', 'Detected', '0.0923962  /  2.01161', 35.078363341294285, 887.2459114871552, '1722.465555', '2130.774800'),
(4, 'QRA', 'Merah', 'Labuan', 'Biru', 'Detected', '0.0925052  /  2.01154', 31.484581473985454, 304.79999999719655, '1722.465555', '2130.774800'),
(5, 'R. Labuan', 'Merah', 'QRA', 'Merah', 'Detected', '0.0925052  /  2.01154', 336.2845814725817, 887.2459114871552, '1727.743344', '2660.993234'),
(6, 'R. Labuan', 'Merah', 'CAP', 'Merah', 'Detected', '0.0916882  /  2.01926', 336.28458147239326, 48765.04632846001, '1903.886739', '2660.993234'),
(7, 'R. Tarakan', 'Biru', 'SEAD', 'Biru', 'Detected', '0.0587193  /  2.0511', 3047.999999999205, 7029.662834650013, '2630.530993', '2660.993234'),
(8, 'QRA', 'Merah', 'R. Labuan', 'Biru', 'Detected', '0.0923962  /  2.01161', 35.078363341294285, 887.2459114871552, '1722.465555', '2664.802865'),
(9, 'QRA', 'Merah', 'Labuan', 'Biru', 'Detected', '0.0925052  /  2.01154', 31.484581473985454, 304.79999999719655, '1722.465555', '2664.802865'),
(10, 'SEAD', 'Biru', 'Tarakan', 'Unknown', 'Detected', '0.0580171  /  2.05193', 10.423125786678206, 8457.919108535987, '2630.530993', '2664.287857'),
(11, 'SEAD', 'Biru', 'R. Tarakan', 'Unknown', 'Detected', '0.0581098  /  2.05189', 10.457552976271623, 7960.963101554361, '2630.530993', '2664.287857'),
(12, 'R. Labuan', 'Merah', 'QRA', 'Merah', 'Detected', '0.0925052  /  2.01154', 336.2845814725817, 887.2459114871552, '1727.743344', '3204.002182'),
(13, 'R. Labuan', 'Merah', 'CAP', 'Merah', 'Detected', '0.0916882  /  2.01926', 336.28458147239326, 48765.04632846001, '1903.886739', '3204.002182'),
(14, 'R. Tarakan', 'Biru', 'SWEEPER', 'Biru', 'Detected', '0.0679257  /  2.04031', 3047.999999999592, 96539.84215474599, '2808.666949', '3201.336161'),
(15, 'R. Tarakan', 'Biru', 'STRIKER', 'Biru', 'Detected', '0.0649541  /  2.0438', 3047.999999999773, 67452.00843670133, '2924.740855', '3201.336161'),
(16, 'QRA', 'Merah', 'R. Labuan', 'Biru', 'Detected', '0.0923962  /  2.01161', 35.078363341294285, 887.2459114871552, '1722.465555', '3202.082698'),
(17, 'QRA', 'Merah', 'Labuan', 'Biru', 'Detected', '0.0925052  /  2.01154', 31.484581473985454, 304.79999999719655, '1722.465555', '3202.082698'),
(18, 'SWEEPER', 'Biru', 'STRIKER', 'Biru', 'Detected', '0.0649999  /  2.04374', 3047.999999999245, 29535.457738944748, '2924.740855', '3203.200762'),
(19, 'STRIKER', 'Biru', 'SWEEPER', 'Biru', 'Detected', '0.0680016  /  2.04022', 3047.9999999999704, 28991.691962700803, '2924.740855', '3204.002182'),
(20, 'R. Labuan', 'Merah', 'QRA', 'Merah', 'Detected', '0.0899615  /  2.01452', 336.28458147226553, 24056.364592883234, '1727.743344', '3697.456728'),
(21, 'R. Labuan', 'Merah', 'SEAD', 'Unknown', 'Detected', '0.0854122  /  2.02072', 3047.9999999998013, 72923.19239310789, '3582.573978', '3697.456728'),
(22, 'R. Labuan', 'Merah', 'CAP', 'Merah', 'Detected', '0.0880558  /  2.02033', 641.0845814720387, 61845.84515914285, '3655.268305', '3697.456728'),
(23, 'R. Tarakan', 'Biru', 'CAP', 'Unknown', 'Detected', '0.0882332  /  2.0203', 641.0845814724483, 277132.2023360325, '3657.623046', '3660.652285'),
(24, 'QRA', 'Merah', 'R. Labuan', 'Biru', 'Detected', '0.0923962  /  2.01161', 35.078363341294285, 24110.03124839999, '1722.465555', '3694.521295'),
(25, 'QRA', 'Merah', 'Labuan', 'Biru', 'Detected', '0.0925052  /  2.01154', 31.484581473985454, 24913.292121506158, '1722.465555', '3694.521295'),
(26, 'QRA', 'Merah', 'SEAD', 'Biru', 'Detected', '0.0850298  /  2.02078', 3047.99999999894, 50612.52002455496, '3582.573978', '3655.268305'),
(27, 'CAP', 'Merah', 'SEAD', 'Biru', 'Detected', '0.085365  /  2.02072', 3047.9999999987676, 17351.415623772606, '3657.623046', '3696.317994'),
(28, 'SEAD', 'Biru', 'CAP', 'Unknown', 'Detected', '0.0881107  /  2.02032', 641.0845814702443, 17401.036678878405, '3657.623046', '3695.834713'),
(29, 'SWEEPER', 'Biru', 'STRIKER', 'Biru', 'Detected', '0.0775776  /  2.0292', 3048.000000001083, 29608.888104071735, '3256.838099', '3694.521295'),
(30, 'SWEEPER', 'Biru', 'CAP', 'Merah', 'Detected', '0.0882332  /  2.0203', 641.0845814724483, 59048.47412166193, '3657.623046', '3660.652285'),
(31, 'STRIKER', 'Biru', 'CAP', 'Merah', 'Detected', '0.0882332  /  2.0203', 641.0845814724483, 87399.12983767496, '3657.623046', '3660.652285'),
(32, 'STRIKER', 'Biru', 'SWEEPER', 'Biru', 'Detected', '0.0806119  /  2.02574', 3048.0000000003783, 28524.440809421136, '2924.740855', '3695.552050'),
(33, 'R. Labuan', 'Merah', 'QRA', 'Merah', 'Detected', '0.0853666  /  2.02054', 1555.4845814724638, 72172.47326662022, '1727.743344', '4013.054316');

-- --------------------------------------------------------

--
-- Table structure for table `t_entity_list`
--

CREATE TABLE `t_entity_list` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `force` varchar(10) NOT NULL,
  `type` varchar(100) NOT NULL,
  `count` int(5) NOT NULL,
  `value` int(5) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_entity_list`
--

INSERT INTO `t_entity_list` (`id`, `name`, `force`, `type`, `count`, `value`, `status`) VALUES
(1, 'QRA', 'Merah', 'FWA, F/A-18', 4, 4, 'Hidup'),
(2, 'CAP', 'Merah', 'FWA, F/A-18', 4, 0, 'Mati'),
(3, 'SEAD', 'Biru', 'SU-30', 4, 0, 'Mati'),
(4, 'SWEEPER', 'Biru', 'F-16C', 4, 0, 'Mati'),
(5, 'STRIKER', 'Biru', 'F-16C', 4, 0, 'Mati');

-- --------------------------------------------------------

--
-- Table structure for table `t_master_scenario`
--

CREATE TABLE `t_master_scenario` (
  `id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `value` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_master_scenario`
--

INSERT INTO `t_master_scenario` (`id`, `name`, `value`) VALUES
(1, 'Date Simulation', '1538755200');

-- --------------------------------------------------------

--
-- Table structure for table `t_metric_fuel`
--

CREATE TABLE `t_metric_fuel` (
  `id` int(11) NOT NULL,
  `time` varchar(100) NOT NULL,
  `name` varchar(25) NOT NULL,
  `force` varchar(10) NOT NULL,
  `value` int(5) NOT NULL,
  `amount` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_metric_fuel`
--

INSERT INTO `t_metric_fuel` (`id`, `time`, `name`, `force`, `value`, `amount`) VALUES
(1, '1538757332.54', 'QRA', 'Merah', 21939, 24524),
(2, '1538757332.54', 'CAP', 'Merah', 23019, 24524),
(3, '1538757864.803', 'QRA', 'Merah', 18869, 24524),
(4, '1538757864.803', 'CAP', 'Merah', 19864, 24524),
(5, '1538757864.803', 'SEAD', 'Biru', 43564, 44000),
(6, '1538758404.5', 'QRA', 'Merah', 16002, 24524),
(7, '1538758404.5', 'CAP', 'Merah', 16917, 24524),
(8, '1538758404.5', 'SEAD', 'Biru', 38554, 44000),
(9, '1538758404.5', 'SWEEPER', 'Biru', 14821, 15796),
(10, '1538758404.5', 'STRIKER', 'Biru', 15093, 15796),
(11, '1538758897.457', 'QRA', 'Merah', 13583, 24524),
(12, '1538758897.457', 'CAP', 'Merah', 7176, 24524),
(13, '1538758897.457', 'SEAD', 'Biru', 17145, 44000),
(14, '1538758897.457', 'SWEEPER', 'Biru', 13687, 15796),
(15, '1538758897.457', 'STRIKER', 'Biru', 13945, 15796),
(16, '1538759215.945', 'QRA', 'Merah', 11664, 24524),
(17, '1538759215.945', 'CAP', 'Merah', 0, 24524),
(18, '1538759215.945', 'SEAD', 'Biru', 0, 44000),
(19, '1538759215.945', 'SWEEPER', 'Biru', 0, 15796),
(20, '1538759215.945', 'STRIKER', 'Biru', 0, 15796);

-- --------------------------------------------------------

--
-- Table structure for table `t_mission`
--

CREATE TABLE `t_mission` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `force` varchar(5) NOT NULL,
  `missionname` varchar(100) NOT NULL,
  `timemission` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_mission`
--

INSERT INTO `t_mission` (`id`, `name`, `force`, `missionname`, `timemission`) VALUES
(1, 'R. Labuan', 'Merah', '', 'Night'),
(2, 'R. Tarakan', 'Biru', '', 'Night'),
(3, 'QRA', 'Merah', '', 'Night'),
(4, 'CAP', 'Merah', '', 'Night'),
(5, 'SEAD', 'Biru', '', 'Night'),
(6, 'SWEEPER', 'Biru', '', 'Night'),
(7, 'STRIKER', 'Biru', '', 'Night');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_airbase`
--
ALTER TABLE `t_airbase`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nm_airbase` (`nm_airbase`,`force`);

--
-- Indexes for table `t_airbase_list_aircraft`
--
ALTER TABLE `t_airbase_list_aircraft`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nm_airbase` (`nm_airbase`,`type_aircraft`);

--
-- Indexes for table `t_airbase_list_runway`
--
ALTER TABLE `t_airbase_list_runway`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nm_airbase` (`nm_airbase`,`nm_runway`);

--
-- Indexes for table `t_engagement_history`
--
ALTER TABLE `t_engagement_history`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nm_aircraft` (`nm_aircraft`,`force`,`shotby`,`forceshot`,`weapontype`,`starttime`,`endtime`,`status`);

--
-- Indexes for table `t_engagement_history_detail`
--
ALTER TABLE `t_engagement_history_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `t_entity_armament`
--
ALTER TABLE `t_entity_armament`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `t_metric_cobasenjata_UX1` (`name`,`type`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `t_entity_contact`
--
ALTER TABLE `t_entity_contact`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `t_entity_list`
--
ALTER TABLE `t_entity_list`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD UNIQUE KEY `name` (`name`,`type`);

--
-- Indexes for table `t_master_scenario`
--
ALTER TABLE `t_master_scenario`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `t_metric_fuel`
--
ALTER TABLE `t_metric_fuel`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `t_mission`
--
ALTER TABLE `t_mission`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_airbase`
--
ALTER TABLE `t_airbase`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `t_airbase_list_aircraft`
--
ALTER TABLE `t_airbase_list_aircraft`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `t_airbase_list_runway`
--
ALTER TABLE `t_airbase_list_runway`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `t_engagement_history`
--
ALTER TABLE `t_engagement_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `t_engagement_history_detail`
--
ALTER TABLE `t_engagement_history_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;

--
-- AUTO_INCREMENT for table `t_entity_armament`
--
ALTER TABLE `t_entity_armament`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `t_entity_contact`
--
ALTER TABLE `t_entity_contact`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `t_entity_list`
--
ALTER TABLE `t_entity_list`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `t_master_scenario`
--
ALTER TABLE `t_master_scenario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `t_metric_fuel`
--
ALTER TABLE `t_metric_fuel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `t_mission`
--
ALTER TABLE `t_mission`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
