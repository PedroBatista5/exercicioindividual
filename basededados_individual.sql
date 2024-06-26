-- MySQL Script generated by MySQL Workbench
-- Wed Apr 10 15:25:06 2024
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema exercicio_individual
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema exercicio_individual
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `exercicio_individual` DEFAULT CHARACTER SET utf8 ;
USE `exercicio_individual` ;

-- -----------------------------------------------------
-- Table `exercicio_individual`.`tb_produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `exercicio_individual`.`tb_produtos` (
  `id_prod` INT NOT NULL AUTO_INCREMENT,
  `estado_prod` VARCHAR(45) NOT NULL,
  `nome_prod` VARCHAR(45) NOT NULL,
  `fornecedor_prod` VARCHAR(45) NOT NULL,
  `quantidade_prod` INT NOT NULL,
  `preço_prod` DOUBLE NULL,
  `datainicial_prod` DATE NULL,
  `datafinal_prod` DATE NULL,
  PRIMARY KEY (`id_prod`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `exercicio_individual`.`tb_vendas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `exercicio_individual`.`tb_vendas` (
  `id_vendas` INT NOT NULL AUTO_INCREMENT,
  `estadoEnc_vendas` VARCHAR(45) NOT NULL,
  `numNota_vendas` INT NULL,
  `dataEncomenda_vendas` DATE NULL,
  `dataDespacho_vendas` DATE NULL,
  `dataEntrega_vendas` DATE NULL,
  `cod_cliente` INT NULL,
  `valor_vendas` DOUBLE NULL,
  PRIMARY KEY (`id_vendas`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `exercicio_individual`.`tb_itensvenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `exercicio_individual`.`tb_itensvenda` (
  `id_itensvenda` INT NOT NULL AUTO_INCREMENT,
  `estadoLinha_itensvenda` VARCHAR(45) NOT NULL,
  `num_encomenda` INT NULL,
  `quantidade_itensvenda` INT NULL,
  `preco_prod` DOUBLE NULL,
  `valorTotal_itensvenda` DOUBLE NULL,
  PRIMARY KEY (`id_itensvenda`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `exercicio_individual`.`tb_fornecedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `exercicio_individual`.`tb_fornecedores` (
  `id_fornecedor` INT NOT NULL AUTO_INCREMENT,
  `estado_fornecedor` VARCHAR(45) NULL,
  `nome_fornecedor` VARCHAR(70) NOT NULL,
  `email_fornecedor` VARCHAR(80) NULL,
  `telefone_fornecedor` VARCHAR(9) NULL,
  `morada_fornecedor` VARCHAR(70) NULL,
  `dataInicial_fornecedor` DATE NULL,
  PRIMARY KEY (`id_fornecedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `exercicio_individual`.`tb_clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `exercicio_individual`.`tb_clientes` (
  `id_clientes` INT NOT NULL AUTO_INCREMENT,
  `estado_clientes` VARCHAR(45) NULL,
  `nome_clientes` VARCHAR(70) NULL,
  `email_clientes` VARCHAR(70) NULL,
  `telefone_clientes` VARCHAR(9) NULL,
  `morada_clientes` VARCHAR(45) NULL,
  `datainicio_clientes` DATE NULL,
  PRIMARY KEY (`id_clientes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `exercicio_individual`.`tb_funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `exercicio_individual`.`tb_funcionario` (
  `id_funcionario` INT NOT NULL AUTO_INCREMENT,
  `nome_funcionario` VARCHAR(70) NOT NULL,
  `telefone_funcionario` VARCHAR(9) NULL,
  `morada_funcionario` VARCHAR(80) NULL,
  `acesso_funcionario` VARCHAR(45) NULL,
  `estado_funcionario` VARCHAR(45) NULL,
  PRIMARY KEY (`id_funcionario`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
