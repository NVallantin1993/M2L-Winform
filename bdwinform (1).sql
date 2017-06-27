-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Mar 27 Juin 2017 à 12:32
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdwinform`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

CREATE TABLE `adherent` (
  `idAdherent` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `sexe` varchar(1) DEFAULT NULL,
  `naissance` varchar(50) NOT NULL,
  `rueAdresse` varchar(1000) NOT NULL,
  `cp` varchar(10) NOT NULL,
  `ville` varchar(50) NOT NULL,
  `cotisation` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `adherent`
--

INSERT INTO `adherent` (`idAdherent`, `nom`, `prenom`, `sexe`, `naissance`, `rueAdresse`, `cp`, `ville`, `cotisation`) VALUES
(8, 'Delacruz', 'Abigail', 'M', '2002-04-28 13:26:52', '160-7550 Nisl Street', '88682', 'Rueil-Malmaison', 47),
(9, 'Beard', 'Harrison', 'M', '1997-11-04 01:36:42', 'Ap #668-6089 Enim, Rd.', '41870', 'Hope', 75),
(10, 'Shaw', 'Shaeleigh', 'F', '1984-03-29 03:00:58', '972-2189 Non St.', '29473', 'Vance', 43),
(11, 'Brooks', 'Avram', 'F', '1997-02-27 17:16:46', '887-3801 Vel Ave', '23949', 'Ichtegem', 96),
(12, 'Garcia', 'Margaret', 'M', '1985-05-10 18:01:33', '2572 Eget Av.', '35311', 'St. Pölten', 98),
(13, 'Herrera', 'Ronan', 'F', '1980-11-27 22:55:06', '828-8326 Turpis. Rd.', '14941', 'Zapallar', 91),
(14, 'Browning', 'Danielle', 'F', '1986-03-03 17:07:03', 'Ap #834-3786 Velit Rd.', '84687', 'Sens', 81),
(15, 'Nieves', 'Jaquelyn', 'M', '2000-09-01 23:32:22', '193-785 Curae; St.', '62055', 'Bellary', 58),
(16, 'Townsend', 'Otto', 'M', '1992-07-05 01:55:03', '394-6830 Et, Rd.', '14554', 'Hawera', 45),
(17, 'Benton', 'Miriam', 'M', '1990-10-22 09:34:40', '682-8452 Libero. St.', '57613', 'Piegaro', 88),
(18, 'Barron', 'Blythe', 'M', '1979-03-17 11:08:15', '321-843 Lectus Rd.', '94697', 'Indianapolis', 93),
(19, 'Horne', 'Jeanette', 'M', '1993-10-23 14:54:05', '2961 Magna. Av.', '08712', 'Bangor', 59),
(20, 'Barnett', 'Ifeoma', 'M', '1980-09-02 19:21:27', '871-9728 Ligula. Ave', '20581', 'Vlimmeren', 67),
(21, 'Schultz', 'Ray', 'F', '1994-03-25 01:10:43', 'Ap #657-4127 Libero St.', '73955', 'Ponta Grossa', 49),
(22, 'Wilkerson', 'Phelan', 'M', '1992-04-28 01:30:05', 'Ap #238-7815 Egestas St.', '95851', 'Birori', 87),
(23, 'Washington', 'Kirsten', 'F', '2001-12-25 22:25:39', 'P.O. Box 520, 1833 Euismod Av.', '13775', 'Akola', 77),
(24, 'Petersen', 'Vladimir', 'M', '1979-12-16 13:26:33', '469-9685 Nonummy Rd.', '83022', 'Freire', 89),
(25, 'Thompson', 'Arsenio', 'M', '1996-07-13 05:51:43', '9307 Cum Av.', '57078', 'Stalowa Wola', 61),
(26, 'Hatfield', 'David', 'M', '1980-03-31 00:45:24', 'P.O. Box 125, 1718 Primis St.', '99019', 'Stade', 67),
(27, 'Maldonado', 'Channing', 'F', '1995-03-17 20:44:58', '669-9622 Dis Avenue', '57061', 'Dietzenbach', 60),
(28, 'Cameron', 'Wesley', 'M', '2001-09-24 21:24:53', 'Ap #101-6432 Nec Road', '33100', 'Bad Dürkheim', 51),
(29, 'Berg', 'Kermit', 'F', '2001-10-05 13:28:12', '990-2548 Proin Rd.', '47615', 'North Las Vegas', 97),
(30, 'Hanson', 'Shellie', 'F', '1988-12-01 12:28:59', 'P.O. Box 878, 2593 Posuere Rd.', '93119', 'Staßfurt', 75),
(31, 'Johnson', 'Rae', 'M', '1989-03-14 18:39:18', 'P.O. Box 836, 7773 Arcu Ave', '07921', 'Leamington', 46),
(32, 'Pace', 'Slade', 'M', '1979-06-30 15:54:22', '6533 Non St.', '80555', 'Herne', 76),
(33, 'Powers', 'Ina', 'F', '1979-09-03 15:26:56', 'P.O. Box 166, 5856 Fusce Road', '45617', 'Yahyal?', 51),
(34, 'Daugherty', 'Wylie', 'M', '2001-03-18 12:28:54', '7487 Tempor Av.', '52226', 'Borgo Valsugana', 47),
(35, 'Contreras', 'Kaden', 'M', '1993-10-11 16:47:14', 'Ap #291-553 Nec Street', '05541', 'Gontrode', 75),
(36, 'Bishop', 'Sebastian', 'M', '1993-01-13 12:28:07', '5218 Gravida St.', '65354', 'Enterprise', 42),
(37, 'Gamble', 'Benjamin', 'M', '2001-01-27 18:21:15', '572-4201 Aenean Street', '02346', 'Borgerhout', 85),
(38, 'Bender', 'Ruth', 'F', '1991-11-19 01:33:36', '4793 A St.', '93416', 'Castelmarte', 65),
(39, 'Pate', 'Tanisha', 'M', '1995-11-07 21:55:07', '608-2818 Donec Street', '32463', 'Köthen', 80),
(40, 'Powers', 'Maris', 'F', '1984-04-01 21:30:48', 'P.O. Box 982, 1243 Odio Ave', '03278', 'Bansberia', 47),
(41, 'Kemp', 'Zeus', 'F', '1999-09-25 21:48:30', '885-8322 Lacus. Road', '47330', 'Sant\'Angelo a Cupolo', 50),
(42, 'Dickson', 'Geoffrey', 'M', '1981-12-25 23:43:56', '122 Sem. Av.', '26419', 'Conselice', 98),
(43, 'Witt', 'Zachery', 'M', '1983-10-09 22:06:23', 'Ap #360-8953 Euismod Road', '33571', 'Maunath Bhanjan', 63),
(44, 'David', 'Maile', 'M', '1987-04-09 22:29:47', '275-1636 Proin Rd.', '25254', 'Ravenstein', 53),
(45, 'Cash', 'Colleen', 'F', '1998-06-23 18:23:32', 'Ap #745-3552 Euismod St.', '76355', 'South Dum Dum', 60),
(46, 'Rice', 'Ashton', 'F', '1989-07-20 03:37:34', '4926 Nulla Street', '20765', 'Massenhoven', 99),
(47, 'Carver', 'Rafael', 'M', '1978-12-19 08:14:02', 'Ap #471-462 Sed Road', '58468', 'Pulle', 76),
(48, 'Doyle', 'Shea', 'F', '1987-03-05 19:18:27', '284-2007 Ligula. Rd.', '10990', 'San Antonio', 56),
(49, 'Dejesus', 'Bruno', 'F', '1987-12-20 01:31:38', 'P.O. Box 708, 3473 Ornare Rd.', '57978', 'Meerdonk', 47),
(50, 'Valentine', 'Cailin', 'F', '1980-07-12 11:24:28', '4525 Dolor Avenue', '03934', 'Erpion', 49),
(51, 'Levine', 'Lamar', 'M', '1995-10-23 07:44:01', '335-1051 Feugiat St.', '25776', 'Aurora', 85),
(52, 'Hopkins', 'Kitra', 'F', '1984-11-19 15:58:17', '8465 Quam St.', '47286', 'Bendigo', 67),
(53, 'Raymond', 'Leroy', 'F', '1997-12-21 02:16:55', 'Ap #257-9172 Turpis Rd.', '23316', 'Dover', 60),
(54, 'Rodgers', 'Aphrodite', 'M', '1999-07-28 19:03:13', 'Ap #928-6120 Mauris St.', '98758', 'Tarvisio', 74),
(55, 'Holman', 'Kay', 'F', '2002-05-10 05:35:35', 'P.O. Box 934, 6553 Nulla St.', '69901', 'Essex', 70),
(56, 'Buckley', 'Zeph', 'F', '1979-05-31 18:47:40', 'P.O. Box 612, 4026 Velit St.', '98538', 'Montignies-Saint-Christophe', 77),
(57, 'Maynard', 'Imogene', 'F', '1992-09-22 04:21:35', 'Ap #714-1973 Imperdiet Street', '02244', 'Friedberg', 74),
(58, 'Campbell', 'Neve', 'M', '1992-06-26 11:40:12', 'Ap #308-9005 Magnis Rd.', '43156', 'Gembloux', 57),
(59, 'Dyer', 'Quon', 'M', '2002-01-04 16:03:43', '8099 Aliquet, Rd.', '58395', 'Whithorn', 75),
(60, 'Moss', 'Gannon', 'M', '1992-01-22 16:13:56', '2302 Quam. St.', '59757', 'Bierk Bierghes', 73),
(61, 'Gilliam', 'Francis', 'M', '1991-02-14 11:50:50', 'P.O. Box 148, 9280 Tortor. Street', '12510', 'Berhampore', 99),
(62, 'Fowler', 'Shellie', 'F', '2002-08-31 19:04:50', 'Ap #666-8129 Nec St.', '40788', 'Fossato di Vico', 71),
(63, 'Murphy', 'Emmanuel', 'F', '1996-11-12 08:51:36', 'Ap #213-2870 Lacus. Av.', '36315', 'San Isidro', 60),
(64, 'Suarez', 'Chadwick', 'M', '1978-11-06 10:06:46', '6911 Vulputate Street', '95551', 'Creil', 41),
(65, 'Small', 'Wynter', 'F', '1985-01-26 00:01:09', '5364 Cursus, Road', '44695', 'Heide', 47),
(66, 'Britt', 'Clementine', 'F', '2001-07-19 17:51:40', '3960 Feugiat Street', '65658', 'Weiz', 41),
(67, 'Noel', 'Evelyn', 'M', '1981-12-19 00:14:16', '9943 Molestie Road', '04119', 'Ararat', 51),
(68, 'Velez', 'Selma', 'M', '1995-08-31 12:20:15', 'Ap #893-989 Morbi Street', '61944', 'Chicoutimi', 75),
(69, 'Tillman', 'Melanie', 'F', '1986-01-19 03:19:17', '908 Penatibus Road', '93874', 'Stroud', 92),
(70, 'Silva', 'Fitzgerald', 'F', '2002-03-29 20:45:51', 'Ap #239-4163 Commodo Rd.', '62940', 'Grand-Leez', 77),
(71, 'Lucas', 'Xaviera', 'F', '1978-01-29 05:54:41', 'P.O. Box 209, 9011 Eget Avenue', '63486', 'Kinross', 87),
(72, 'Hanson', 'Dieter', 'M', '1978-01-03 07:42:25', '5344 Gravida Rd.', '50310', 'MŽlin', 53),
(73, 'Summers', 'Russell', 'F', '1988-08-09 10:47:42', 'P.O. Box 894, 5732 Proin Avenue', '06570', 'Mellery', 98),
(74, 'Morin', 'Yvonne', 'F', '1991-12-12 12:19:20', 'P.O. Box 984, 4426 Auctor Av.', '13715', 'Green Bay', 78),
(75, 'Rojas', 'Molly', 'M', '1998-05-17 22:38:29', 'Ap #213-6590 Tristique St.', '33921', 'Joliet', 75),
(76, 'Jacobs', 'Gary', 'F', '1994-11-26 13:40:05', 'P.O. Box 910, 3146 Euismod Rd.', '28264', 'Capannori', 60),
(77, 'Logan', 'Ivan', 'M', '1978-08-28 05:10:45', 'P.O. Box 552, 4138 Sit St.', '67162', 'Bruckneudorf', 90),
(78, 'Sloan', 'Norman', 'F', '1990-10-19 04:49:24', 'Ap #355-5721 Quis Rd.', '73454', 'Kobbegem', 46),
(79, 'Glass', 'Audrey', 'F', '1999-01-29 02:11:55', 'Ap #849-7109 Libero Rd.', '32298', 'Gönen', 91),
(80, 'Wilkinson', 'Martha', 'M', '1996-05-25 20:26:57', '453-7784 A St.', '25759', 'Melbourne', 77),
(81, 'Jarvis', 'Ciara', 'M', '1990-06-27 14:58:27', '1031 Molestie Avenue', '58250', 'Lanester', 89),
(82, 'Mcdaniel', 'Jerome', 'F', '1992-04-12 04:07:26', 'Ap #171-7097 Facilisis Road', '79907', 'Saint-Nicolas', 90),
(83, 'Hinton', 'Yvette', 'M', '1984-08-07 07:02:32', '1703 Neque Avenue', '43636', 'Salt Spring Island', 47),
(84, 'Odom', 'Macon', 'F', '1989-03-22 21:34:14', 'P.O. Box 234, 810 Vitae Avenue', '88509', 'Marchienne-au-Pont', 50),
(85, 'Flores', 'Samson', 'F', '1978-07-26 22:30:49', '849-2550 Vel Road', '41741', 'Sapele', 75),
(86, 'Benjamin', 'Wynne', 'F', '1983-01-18 12:54:41', 'P.O. Box 781, 5759 Risus Rd.', '83928', 'Terragnolo', 57),
(87, 'Pickett', 'Amaya', 'F', '1981-08-02 13:06:22', 'P.O. Box 845, 6870 Ac Road', '81475', 'Hollabrunn', 64),
(88, 'Manning', 'Stacey', 'F', '1984-07-23 15:29:32', '9835 Libero Avenue', '36187', 'Fontaine-l\'Evque', 66),
(89, 'Flores', 'Hashim', 'M', '1996-02-02 23:19:10', 'P.O. Box 849, 7122 Et Av.', '40112', 'Rödermark', 82),
(90, 'George', 'Peter', 'M', '2002-04-08 15:17:16', 'Ap #148-4874 Vel Rd.', '63845', 'Thirimont', 59),
(91, 'Weaver', 'Tanner', 'M', '1980-12-24 06:17:47', 'Ap #600-1153 A Rd.', '92260', 'Fiuminata', 64),
(92, 'Leblanc', 'Ahmed', 'F', '1996-03-09 19:18:05', '661-2837 Dui. St.', '31424', 'Sankt Ingbert', 75),
(93, 'Rowland', 'Emi', 'F', '1993-05-31 02:13:15', '845-7083 Quisque St.', '78370', 'Minneapolis', 73),
(94, 'Stout', 'Sylvia', 'F', '1998-12-27 05:45:28', 'P.O. Box 762, 4767 Diam St.', '55867', 'Pisa', 59),
(95, 'Langley', 'Lisandra', 'M', '1987-12-25 23:40:42', 'P.O. Box 986, 236 Suspendisse Rd.', '49392', 'Shawinigan', 65),
(96, 'Walters', 'Hector', 'F', '1988-02-08 01:25:26', '7852 Vulputate Avenue', '83974', 'Milford Haven', 100),
(97, 'Lyons', 'Noelani', 'F', '2001-05-18 04:08:32', '228-9723 Orci Ave', '87645', 'Saint-GŽry', 60),
(98, 'Rivas', 'Lisandra', 'M', '1982-05-11 14:08:53', 'Ap #970-8267 Dictum Ave', '03882', 'San Marcello Pistoiese', 66),
(99, 'Kelley', 'Oscar', 'F', '1993-12-16 13:16:28', 'P.O. Box 221, 5753 Fringilla Avenue', '62275', 'Birmingham', 87),
(100, 'Brown', 'Hedy', 'F', '1999-10-06 13:29:09', 'Ap #890-3193 Imperdiet Ave', '53011', 'Offenburg', 48),
(101, 'Saunders test', 'Maggie', 'F', '8/9/1990', '1882 Eget St.', '52747', 'LouveignŽ', 94),
(102, 'Klein test', 'Justin', 'F', '17/7/2001', '4214 Ac Road', '95120', 'Silvan', 83);

-- --------------------------------------------------------

--
-- Structure de la table `club`
--

CREATE TABLE `club` (
  `nom` varchar(50) NOT NULL,
  `site` varchar(50) NOT NULL,
  `adresse` varchar(1000) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `idClub` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `club`
--

INSERT INTO `club` (`nom`, `site`, `adresse`, `telephone`, `email`, `type`, `idClub`) VALUES
('club de poney de lorraine', 'www.cdpdl.com', '78 rue du poney Poneyland 78945', '0845964265', 'cdpdl@outlook.fr', 'poney', 0),
('Club de tennis de Lorraine bonjour', 'www.jaie.com', '48 rue des frites', '0215313543', 'bonjour@bonjour.com', 'Tennis', 1),
('Club de foot de lorraine', 'www.Cdfdl.com', 'rue des mimosa Washington 99451', '0512457895', 'cdfdl@outlook.com', 'foot', 2);

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

CREATE TABLE `evenement` (
  `DateDebut` datetime NOT NULL,
  `DateFin` datetime NOT NULL,
  `idclub` int(11) NOT NULL,
  `nom` varchar(1000) NOT NULL,
  `id` int(11) NOT NULL,
  `type` varchar(75) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `evenement`
--

INSERT INTO `evenement` (`DateDebut`, `DateFin`, `idclub`, `nom`, `id`, `type`) VALUES
('2017-02-27 18:35:27', '2017-11-07 02:46:33', 58, 'Posuere At Industries', 1, 'Public Relations'),
('2017-12-17 01:51:12', '2016-08-20 02:04:47', 19, 'Pellentesque Industries', 2, 'Accounting'),
('2016-10-02 17:13:39', '2016-04-03 08:33:02', 62, 'Lorem Vehicula Et Ltd', 3, 'Public Relations'),
('2016-08-06 10:51:20', '2017-06-28 17:40:10', 47, 'Phasellus Libero Incorporated', 4, 'Accounting'),
('2017-05-05 15:51:29', '2016-03-01 05:40:06', 57, 'Cursus Luctus Associates', 5, 'Customer Service'),
('2017-07-11 17:40:47', '2016-06-19 12:05:51', 87, 'Eu Industries', 6, 'Public Relations'),
('2017-05-11 02:59:22', '2016-10-13 11:42:01', 18, 'Etiam Ligula Tortor Incorporated', 7, 'Finances'),
('2017-09-03 08:16:20', '2016-10-30 00:57:21', 100, 'Urna Nec Inc.', 8, 'Human Resources'),
('2017-10-12 20:25:50', '2016-07-01 18:30:06', 75, 'Metus Vitae Velit Associates', 9, 'Human Resources'),
('2017-01-20 17:22:20', '2018-01-24 11:49:34', 32, 'Eget Limited', 10, 'Accounting'),
('2017-01-22 07:17:00', '2017-01-25 23:02:37', 10, 'Interdum Enim Associates', 11, 'Public Relations'),
('2016-08-07 05:31:21', '2016-06-28 01:27:18', 30, 'Quis Pede Inc.', 12, 'Legal Department'),
('2016-04-10 20:58:36', '2016-03-17 01:13:32', 66, 'Ullamcorper Duis At Company', 13, 'Payroll'),
('2017-07-09 19:54:23', '2017-07-30 18:46:26', 35, 'Semper Rutrum Institute', 14, 'Customer Service'),
('2017-01-21 18:06:48', '2016-07-20 02:07:15', 73, 'Eu Odio Phasellus Incorporated', 15, 'Finances'),
('2016-06-14 10:42:54', '2017-11-14 11:01:08', 31, 'Fusce Aliquam Incorporated', 16, 'Payroll'),
('2017-03-28 10:39:45', '2016-08-16 03:05:09', 60, 'Dui Nec Tempus Industries', 17, 'Customer Service'),
('2016-10-25 14:37:39', '2017-03-27 13:05:06', 70, 'Lorem Associates', 18, 'Customer Relations'),
('2016-06-16 01:41:18', '2017-03-18 19:50:54', 44, 'In Mi LLC', 19, 'Public Relations'),
('2017-06-01 13:31:26', '2017-03-13 10:22:17', 54, 'Diam Lorem Industries', 20, 'Payroll'),
('2017-06-02 05:54:20', '2016-04-07 08:07:27', 41, 'Rhoncus Institute', 21, 'Payroll'),
('2016-12-31 23:48:12', '2016-09-08 07:06:03', 5, 'Nisl Maecenas Company', 22, 'Customer Relations'),
('2017-09-15 21:14:11', '2016-08-24 06:55:24', 1, 'Montes Nascetur Ridiculus Corporation', 23, 'Research and Development'),
('2017-12-08 05:11:17', '2017-02-27 11:30:18', 35, 'Ultrices Posuere PC', 24, 'Media Relations'),
('2017-02-07 01:40:09', '2016-09-25 12:29:30', 48, 'In Consectetuer Ipsum Foundation', 25, 'Customer Service'),
('2017-12-17 05:29:25', '2018-02-23 20:48:41', 87, 'Mattis Inc.', 26, 'Accounting'),
('2016-08-07 18:30:27', '2016-05-19 20:31:16', 28, 'Vulputate Eu Associates', 27, 'Customer Service'),
('2016-09-03 16:11:44', '2017-02-13 07:21:17', 63, 'Ut Molestie In Consulting', 28, 'Research and Development'),
('2017-12-22 19:41:05', '2016-03-22 15:36:53', 35, 'A Auctor Non Inc.', 29, 'Human Resources'),
('2018-02-23 08:35:15', '2016-11-13 15:08:10', 28, 'Donec Felis Orci PC', 30, 'Tech Support'),
('2017-06-12 22:02:49', '2016-03-03 09:49:13', 88, 'Malesuada Incorporated', 31, 'Sales and Marketing'),
('2018-02-27 10:19:10', '2016-07-30 13:46:15', 44, 'Elementum LLC', 32, 'Advertising'),
('2016-06-07 19:23:16', '2017-01-14 22:30:28', 80, 'Nunc LLP', 33, 'Media Relations'),
('2016-06-28 13:49:08', '2016-04-27 23:57:25', 32, 'Mauris Sapien Cursus Corporation', 34, 'Legal Department'),
('2017-10-03 20:15:14', '2017-02-28 21:35:49', 94, 'Montes Associates', 35, 'Asset Management'),
('2016-06-28 01:57:29', '2017-10-10 15:53:44', 99, 'Sed Congue Elit Inc.', 36, 'Research and Development'),
('2017-04-08 16:51:04', '2017-07-31 15:07:58', 26, 'Viverra Donec Corp.', 37, 'Media Relations'),
('2016-06-12 13:54:48', '2017-05-14 20:39:05', 12, 'Lorem Vehicula Institute', 38, 'Quality Assurance'),
('2016-03-18 23:17:48', '2016-04-27 06:28:38', 6, 'Magna Company', 39, 'Public Relations'),
('2017-06-16 22:54:16', '2018-02-16 16:27:46', 33, 'Suspendisse Inc.', 40, 'Accounting'),
('2016-04-26 17:50:59', '2016-10-14 07:04:39', 58, 'Lorem Limited', 41, 'Finances'),
('2016-11-25 05:23:09', '2017-03-02 19:00:18', 59, 'Eros Proin Ultrices Foundation', 42, 'Media Relations'),
('2016-09-04 12:30:34', '2016-05-21 19:45:37', 8, 'Lorem Ipsum Sodales Corp.', 43, 'Research and Development'),
('2017-04-06 19:44:45', '2016-05-20 23:17:57', 11, 'Nulla Magna Malesuada Limited', 44, 'Legal Department'),
('2016-12-17 07:08:58', '2016-09-17 06:41:35', 2, 'Semper Consulting', 45, 'Accounting'),
('2017-07-23 11:27:12', '2017-02-22 22:34:05', 88, 'Nunc Sed Institute', 46, 'Sales and Marketing'),
('2017-10-01 16:45:06', '2016-08-29 12:34:35', 6, 'Et Consulting', 47, 'Customer Relations'),
('2016-10-13 11:07:04', '2016-05-25 21:48:49', 42, 'Venenatis Vel PC', 48, 'Asset Management'),
('2017-07-27 19:23:27', '2017-05-21 22:21:45', 58, 'Curabitur Consequat Lectus Foundation', 49, 'Asset Management'),
('2017-07-06 05:11:35', '2017-10-10 23:34:47', 84, 'Egestas Industries', 50, 'Research and Development'),
('2017-08-14 16:41:40', '2017-01-11 00:01:35', 17, 'Non Associates', 51, 'Tech Support'),
('2016-11-07 22:32:26', '2017-01-10 16:18:09', 20, 'Sed Eget Lacus LLC', 52, 'Public Relations'),
('2017-12-25 06:16:47', '2017-07-06 02:36:17', 82, 'Laoreet Company', 53, 'Tech Support'),
('2016-09-07 04:51:22', '2016-07-02 14:45:58', 15, 'Vitae Incorporated', 54, 'Finances'),
('2017-06-22 13:20:58', '2016-04-11 20:06:34', 13, 'Eu Corp.', 55, 'Finances'),
('2017-04-30 06:44:24', '2017-09-05 08:26:00', 52, 'Ullamcorper Industries', 56, 'Advertising'),
('2017-05-01 05:33:43', '2017-07-01 05:44:16', 85, 'Nulla Ltd', 57, 'Payroll'),
('2016-08-23 05:34:01', '2016-10-17 06:07:08', 67, 'Aliquet Industries', 58, 'Asset Management'),
('2017-02-16 01:14:00', '2017-03-12 09:13:26', 11, 'Placerat Augue Sed Inc.', 59, 'Legal Department'),
('2016-11-28 09:57:57', '2017-01-13 12:56:00', 79, 'Nunc Mauris Inc.', 60, 'Advertising'),
('2017-07-07 12:12:36', '2017-11-03 00:00:48', 73, 'Dui Cum Sociis LLC', 61, 'Payroll'),
('2016-03-24 21:21:31', '2017-02-02 21:40:54', 50, 'Nulla Facilisi Incorporated', 62, 'Media Relations'),
('2017-02-14 08:14:16', '2017-10-29 10:38:18', 13, 'A Mi Fringilla PC', 63, 'Research and Development'),
('2017-08-25 13:43:00', '2017-07-14 19:42:32', 1, 'Phasellus PC', 64, 'Legal Department'),
('2017-02-12 16:32:57', '2016-05-21 14:54:51', 45, 'Gravida Molestie Arcu LLC', 65, 'Quality Assurance'),
('2017-04-25 03:45:58', '2016-03-07 14:12:35', 29, 'Quisque Libero Lacus Ltd', 66, 'Tech Support'),
('2017-09-01 19:29:39', '2016-03-09 07:43:11', 67, 'Sed Sapien Nunc Limited', 67, 'Customer Service'),
('2017-05-08 16:09:18', '2017-03-27 07:14:30', 70, 'Orci Lacus Vestibulum Foundation', 68, 'Payroll'),
('2017-01-18 02:51:49', '2016-09-14 23:58:15', 56, 'Torquent Limited', 69, 'Advertising'),
('2016-05-26 05:21:28', '2017-05-26 04:09:46', 51, 'Mollis Corporation', 70, 'Finances'),
('2018-02-13 22:26:37', '2016-03-28 16:30:14', 2, 'Donec Porttitor LLC', 71, 'Customer Relations'),
('2016-10-27 20:41:12', '2016-12-15 04:33:20', 32, 'Sem Company', 72, 'Customer Service'),
('2016-03-12 00:51:23', '2016-07-13 02:47:43', 3, 'Id Inc.', 73, 'Sales and Marketing'),
('2016-06-29 19:05:31', '2016-03-30 19:03:16', 23, 'Facilisis Facilisis Magna LLC', 74, 'Asset Management'),
('2017-08-17 17:21:44', '2016-02-28 02:32:39', 22, 'Duis Mi Corporation', 75, 'Finances'),
('2017-09-05 08:17:16', '2017-01-28 06:33:41', 67, 'Blandit Mattis Limited', 76, 'Finances'),
('2017-06-24 11:36:25', '2017-01-14 16:33:46', 87, 'Nam Ligula Inc.', 77, 'Research and Development'),
('2016-12-18 11:00:32', '2017-08-30 12:47:59', 58, 'Quam Vel PC', 78, 'Accounting'),
('2017-03-25 19:27:35', '2017-08-16 13:50:52', 42, 'Quam A LLP', 79, 'Media Relations'),
('2017-12-09 00:42:26', '2016-08-29 07:27:07', 23, 'Enim Condimentum Eget Institute', 80, 'Research and Development'),
('2016-08-18 13:16:52', '2016-03-29 12:09:58', 35, 'Tortor Dictum Eu Associates', 81, 'Research and Development'),
('2017-09-20 22:38:24', '2017-08-08 09:22:36', 96, 'At Arcu Vestibulum Corporation', 82, 'Accounting'),
('2018-02-08 05:56:34', '2016-09-07 05:09:18', 22, 'Blandit LLP', 83, 'Sales and Marketing'),
('2016-11-28 04:45:13', '2017-07-04 10:41:02', 77, 'Nascetur Ridiculus Mus Associates', 84, 'Asset Management'),
('2018-01-14 17:28:14', '2017-03-15 18:57:35', 22, 'Dolor Sit Amet Company', 85, 'Accounting'),
('2017-11-30 09:09:46', '2017-06-17 23:33:04', 95, 'Malesuada Ut Sem Industries', 86, 'Payroll'),
('2016-10-06 07:28:36', '2016-04-14 17:34:59', 5, 'Neque Non Consulting', 87, 'Research and Development'),
('2016-07-16 03:10:35', '2017-12-17 22:46:47', 99, 'Placerat Cras Company', 88, 'Human Resources'),
('2016-12-20 14:42:10', '2016-04-27 03:28:07', 48, 'Dolor Quisque Tincidunt Consulting', 89, 'Tech Support'),
('2017-01-25 11:04:13', '2017-07-23 14:41:32', 70, 'Urna Company', 90, 'Research and Development'),
('2016-06-18 23:45:07', '2016-06-13 03:36:03', 93, 'Nibh PC', 91, 'Sales and Marketing'),
('2017-05-05 23:10:10', '2017-10-11 13:09:31', 17, 'Luctus Lobortis Class LLP', 92, 'Tech Support'),
('2016-05-19 05:51:34', '2016-04-21 12:34:04', 68, 'Enim Curabitur Industries', 93, 'Finances'),
('2017-11-14 12:08:09', '2017-03-20 10:07:10', 66, 'Sociis Natoque Penatibus LLC', 94, 'Finances'),
('2017-03-06 15:45:06', '2017-04-13 04:04:20', 98, 'Suspendisse Ac Inc.', 95, 'Customer Service'),
('2016-08-06 01:35:32', '2017-11-09 13:21:43', 100, 'Semper Egestas Limited', 96, 'Finances'),
('2017-11-02 00:26:40', '2016-03-29 03:53:20', 56, 'Aliquam Tincidunt LLC', 97, 'Finances'),
('2017-07-06 17:34:24', '2017-06-19 05:18:00', 9, 'Mollis Lectus Pede Limited', 98, 'Customer Service'),
('2016-12-17 00:41:06', '2017-09-13 05:32:54', 93, 'Aliquet Magna A Incorporated', 99, 'Public Relations'),
('2017-07-31 15:36:24', '2016-11-23 03:16:05', 99, 'Interdum Enim Non PC', 100, 'Advertising');

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

CREATE TABLE `inscription` (
  `idEvent` int(11) NOT NULL,
  `idAdherent` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `inscription`
--

INSERT INTO `inscription` (`idEvent`, `idAdherent`) VALUES
(87, 63),
(10, 4),
(55, 52),
(90, 76),
(10, 2),
(10, 92),
(31, 67),
(60, 29),
(5, 56),
(35, 3),
(23, 87),
(66, 66),
(49, 61),
(34, 48),
(34, 94),
(2, 42),
(90, 4),
(71, 15),
(27, 52),
(68, 37),
(98, 5),
(86, 29),
(25, 14),
(82, 60),
(15, 34),
(84, 34),
(6, 91),
(82, 60),
(29, 85),
(19, 67),
(50, 31),
(95, 59),
(63, 52),
(90, 86),
(39, 35),
(50, 30),
(99, 63),
(35, 43),
(8, 61),
(45, 95),
(99, 64),
(54, 78),
(86, 74),
(93, 81),
(50, 20),
(23, 9),
(82, 3),
(6, 49),
(39, 85),
(27, 29),
(80, 43),
(92, 11),
(30, 55),
(17, 55),
(27, 65),
(77, 87),
(5, 67),
(74, 62),
(27, 67),
(38, 95),
(56, 27),
(63, 56),
(85, 34),
(49, 26),
(75, 32),
(85, 43),
(78, 89),
(75, 64),
(62, 75),
(31, 27),
(95, 25),
(50, 29),
(7, 55),
(18, 41),
(91, 64),
(5, 17),
(2, 35),
(76, 84),
(37, 70),
(91, 83),
(8, 77),
(16, 2),
(68, 28),
(65, 94),
(84, 2),
(74, 62),
(82, 53),
(82, 86),
(93, 100),
(24, 62),
(52, 92),
(41, 3),
(93, 81),
(61, 7),
(3, 72),
(27, 64),
(67, 50),
(14, 62);

-- --------------------------------------------------------

--
-- Structure de la table `license`
--

CREATE TABLE `license` (
  `numero` varchar(20) NOT NULL,
  `idClub` int(11) NOT NULL,
  `idAdherent` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `license`
--

INSERT INTO `license` (`numero`, `idClub`, `idAdherent`) VALUES
('11964296', 0, 97),
('12527153', 0, 90),
('13243129', 1, 58),
('13682551', 1, 91),
('14103287', 0, 89),
('14306830', 1, 71),
('14521836', 0, 97),
('14755997', 1, 16),
('14908164', 1, 24),
('15161488', 1, 1),
('16313169', 2, 38),
('16647751', 1, 2),
('17095465', 2, 19),
('17340998', 2, 77),
('18219393', 0, 35),
('18805825', 1, 71),
('19747682', 2, 100),
('21222767', 2, 83),
('21613441', 2, 74),
('22107627', 1, 77),
('22429401', 0, 99),
('23041780', 1, 39),
('23545792', 0, 62),
('23921841', 1, 34),
('24026871', 0, 99),
('24080342', 0, 30),
('24181408', 2, 85),
('24264257', 1, 33),
('24807908', 1, 99),
('24976336', 1, 71),
('25155761', 0, 10),
('26026077', 1, 65),
('26145940', 0, 6),
('26302386', 2, 49),
('26486509', 1, 22),
('27750157', 0, 27),
('27989604', 0, 26),
('28047267', 2, 4),
('29206374', 0, 45),
('29480914', 2, 41),
('30207703', 0, 8),
('30771681', 1, 41),
('30775931', 2, 62),
('30906001', 0, 64),
('31247980', 0, 1),
('31611666', 1, 40),
('32081929', 2, 57),
('32798127', 1, 1),
('33217864', 0, 16),
('33508309', 0, 39),
('33849063', 1, 37),
('34155994', 1, 85),
('34291985', 0, 86),
('34357929', 1, 34),
('34596131', 2, 73),
('34672290', 1, 30),
('34801433', 1, 49),
('35273492', 2, 23),
('35381648', 0, 2),
('37518375', 2, 21),
('39752300', 2, 10),
('40544149', 0, 12),
('41244530', 1, 11),
('41583579', 2, 70),
('41595169', 2, 85),
('42101419', 0, 1),
('42791966', 2, 57),
('44551936', 2, 32),
('44685915', 0, 67),
('45081547', 0, 46),
('45326564', 1, 48),
('45396189', 2, 91),
('45777514', 1, 35),
('45966043', 2, 29),
('46040014', 1, 44),
('46366932', 0, 56),
('46381835', 0, 10),
('46385231', 2, 12),
('46999667', 0, 65),
('47062259', 1, 14),
('47417215', 0, 89),
('48716068', 2, 8),
('48760754', 2, 97),
('49475673', 2, 49),
('50219191', 1, 72),
('5024843', 0, 33),
('50312594', 0, 63),
('50610683', 1, 19),
('50637262', 1, 87),
('5333280', 0, 79),
('5595705', 1, 17),
('5809273', 1, 32),
('7212628', 0, 23),
('7551142', 2, 68),
('8008366', 1, 78),
('8955894', 1, 69),
('9128970', 0, 49),
('9191010', 2, 2),
('9252614', 2, 63),
('9768697', 0, 15);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD PRIMARY KEY (`idAdherent`);

--
-- Index pour la table `club`
--
ALTER TABLE `club`
  ADD PRIMARY KEY (`idClub`);

--
-- Index pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `license`
--
ALTER TABLE `license`
  ADD PRIMARY KEY (`numero`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `adherent`
--
ALTER TABLE `adherent`
  MODIFY `idAdherent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;
--
-- AUTO_INCREMENT pour la table `club`
--
ALTER TABLE `club`
  MODIFY `idClub` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
