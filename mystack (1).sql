-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 07/05/2024 às 04:35
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `mystack`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `empresa`
--

CREATE TABLE `empresa` (
  `NomeEmpresa` varchar(26) NOT NULL,
  `Email` varchar(26) NOT NULL,
  `Senha` varchar(26) NOT NULL,
  `IdEmpresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `empresa`
--

INSERT INTO `empresa` (`NomeEmpresa`, `Email`, `Senha`, `IdEmpresa`) VALUES
('123', '123', '123', 9),
('54', '54', '54', 13),
('43', '434', '43', 14),
('231', '23', '13', 15);

-- --------------------------------------------------------

--
-- Estrutura para tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `Idfornecedor` int(11) NOT NULL,
  `nome` varchar(26) NOT NULL,
  `endereco` varchar(40) NOT NULL,
  `data` varchar(26) NOT NULL,
  `celular` varchar(15) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `email` varchar(26) NOT NULL,
  `idempresa` int(11) NOT NULL,
  `cep` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE `produto` (
  `idproduto` int(11) NOT NULL,
  `nomeproduto` varchar(26) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `dataentrada` varchar(10) NOT NULL,
  `horaentrada` varchar(5) NOT NULL,
  `preco` double NOT NULL,
  `idempresa` int(11) NOT NULL,
  `fornecedor` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `produtosaida`
--

CREATE TABLE `produtosaida` (
  `idproduto` int(11) NOT NULL,
  `datasaida` varchar(10) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `comprador` varchar(26) NOT NULL,
  `horasaida` varchar(5) NOT NULL,
  `preco` double NOT NULL,
  `nomeproduto` varchar(16) NOT NULL,
  `idempresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `Nome` varchar(26) NOT NULL,
  `IdUsuario` int(11) NOT NULL,
  `Senha` varchar(26) NOT NULL,
  `IdEmpresa` int(11) NOT NULL,
  `Nivel` int(11) NOT NULL,
  `Usuario` varchar(26) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`Nome`, `IdUsuario`, `Senha`, `IdEmpresa`, `Nivel`, `Usuario`) VALUES
('Usuario Primario', 1, '54', 0, 3, '54'),
('Usuario Primario', 2, '43', 14, 3, '43'),
('Usuario Primario', 3, '13', 15, 3, '13');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`IdEmpresa`),
  ADD UNIQUE KEY `NomeEmpresa` (`Email`) USING BTREE;

--
-- Índices de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`Idfornecedor`);

--
-- Índices de tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`idproduto`);

--
-- Índices de tabela `produtosaida`
--
ALTER TABLE `produtosaida`
  ADD PRIMARY KEY (`idproduto`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IdUsuario`),
  ADD UNIQUE KEY `Usuario` (`Usuario`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `empresa`
--
ALTER TABLE `empresa`
  MODIFY `IdEmpresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `Idfornecedor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `idproduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de tabela `produtosaida`
--
ALTER TABLE `produtosaida`
  MODIFY `idproduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IdUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
