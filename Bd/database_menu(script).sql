-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`CARDAPIO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`CARDAPIO` (
  `idCombo` INT NOT NULL AUTO_INCREMENT,
  `nomeCombo` VARCHAR(45) NOT NULL,
  `valorCombo` FLOAT(10,2) NOT NULL,
  PRIMARY KEY (`idCombo`))
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`pedido` (
  `idPedido` varchar (50) NOT NULL,
  `valorTotal` FLOAT NOT NULL,
  `dataPedido` DATETIME NOT NULL,
  `combo1` INT NULL DEFAULT NULL,
  `combo2` INT NULL DEFAULT NULL,
  `combo3` INT NULL DEFAULT NULL,
  `combo4` INT NULL DEFAULT NULL,
  `combo5` INT NULL DEFAULT NULL,
  `CARDAPIO_idCombo` INT NOT NULL,
  PRIMARY KEY (`idPedido`),
  INDEX `fk_pedido_CARDAPIO_idx` (`CARDAPIO_idCombo` ASC) VISIBLE,
  CONSTRAINT `fk_pedido_CARDAPIO`
    FOREIGN KEY (`CARDAPIO_idCombo`)
    REFERENCES `mydb`.`CARDAPIO` (`idCombo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
