-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 22-Maio-2018 às 17:46
-- Versão do servidor: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbestacio`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_disciplina`
--

CREATE TABLE `tb_disciplina` (
  `id` int(11) NOT NULL,
  `nome` varchar(256) NOT NULL,
  `carga_h` int(11) NOT NULL,
  `dsp_desc` varchar(256) NOT NULL,
  `data_reg` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_disciplina`
--

INSERT INTO `tb_disciplina` (`id`, `nome`, `carga_h`, `dsp_desc`, `data_reg`) VALUES
(15, 'C++', 222, 'C++ e POO.', '2018-05-22 12:42:46'),
(16, 'C# ASP .NET', 300, 'C# ASP .NET', '2018-05-22 12:23:16'),
(17, 'Java', 200, 'Java Web', '2018-05-22 12:23:32'),
(18, 'PHP PDO', 222, 'PHP e PDO', '2018-05-22 12:45:49');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_disciplina`
--
ALTER TABLE `tb_disciplina`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_disciplina`
--
ALTER TABLE `tb_disciplina`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
