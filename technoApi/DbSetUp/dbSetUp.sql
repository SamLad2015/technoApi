-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema techno
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `techno` ;

-- -----------------------------------------------------
-- Schema techno
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `techno` DEFAULT CHARACTER SET utf8 ;
USE `techno` ;

-- -----------------------------------------------------
-- Table `techno`.`Titles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Titles` ;

CREATE TABLE IF NOT EXISTS `techno`.`Titles` (
  `id` INT NOT NULL,
  `title` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`JobTitles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`JobTitles` ;

CREATE TABLE IF NOT EXISTS `techno`.`JobTitles` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `jobTitle` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`JobTypes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`JobTypes` ;

CREATE TABLE IF NOT EXISTS `techno`.`JobTypes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `jobType` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Profiles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Profiles` ;

CREATE TABLE IF NOT EXISTS `techno`.`Profiles` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `firstName` VARCHAR(45) NOT NULL,
  `lastName` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `mobile` VARCHAR(45) NULL,
  `address1` VARCHAR(45) NULL,
  `address2` VARCHAR(45) NULL,
  `city` VARCHAR(45) NULL,
  `county` VARCHAR(45) NULL,
  `postCode` VARCHAR(45) NULL,
  `TitleId` INT NOT NULL,
  `JobTitleId` INT NOT NULL,
  `JobTypeId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Profiles_Titles1_idx` (`TitleId` ASC),
  INDEX `fk_Profiles_JobTitles1_idx` (`JobTitleId` ASC),
  INDEX `fk_Profiles_JobTypes1_idx` (`JobTypeId` ASC),
  CONSTRAINT `fk_Profiles_Titles1`
    FOREIGN KEY (`TitleId`)
    REFERENCES `techno`.`Titles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Profiles_JobTitles1`
    FOREIGN KEY (`JobTitleId`)
    REFERENCES `techno`.`JobTitles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Profiles_JobTypes1`
    FOREIGN KEY (`JobTypeId`)
    REFERENCES `techno`.`JobTypes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Users` ;

CREATE TABLE IF NOT EXISTS `techno`.`Users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `userName` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `ProfileId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Users_Profiles_idx` (`ProfileId` ASC),
  CONSTRAINT `fk_Users_Profiles`
    FOREIGN KEY (`ProfileId`)
    REFERENCES `techno`.`Profiles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`QualificationTypes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`QualificationTypes` ;

CREATE TABLE IF NOT EXISTS `techno`.`QualificationTypes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `qualificationName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Qualifications`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Qualifications` ;

CREATE TABLE IF NOT EXISTS `techno`.`Qualifications` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `qualification` VARCHAR(45) NULL,
  `organisation` VARCHAR(45) NULL,
  `startDate` DATETIME NOT NULL,
  `endDate` DATETIME NOT NULL,
  `ProfileId` INT NOT NULL,
  `QualificationTypeId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Qualifications_Profiles1_idx` (`ProfileId` ASC),
  INDEX `fk_Qualifications_QualificationTypes1_idx` (`QualificationTypeId` ASC),
  CONSTRAINT `fk_Qualifications_Profiles1`
    FOREIGN KEY (`ProfileId`)
    REFERENCES `techno`.`Profiles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Qualifications_QualificationTypes1`
    FOREIGN KEY (`QualificationTypeId`)
    REFERENCES `techno`.`QualificationTypes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`JobHistory`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`JobHistory` ;

CREATE TABLE IF NOT EXISTS `techno`.`JobHistory` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `jobTitle` VARCHAR(45) NOT NULL,
  `startDate` DATETIME NOT NULL,
  `endDate` DATETIME NOT NULL,
  `JobTypeId` INT NOT NULL,
  `ProfileId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_JobHistory_JobTypes1_idx` (`JobTypeId` ASC),
  INDEX `fk_JobHistory_Profiles1_idx` (`ProfileId` ASC),
  CONSTRAINT `fk_JobHistory_JobTypes1`
    FOREIGN KEY (`JobTypeId`)
    REFERENCES `techno`.`JobTypes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JobHistory_Profiles1`
    FOREIGN KEY (`ProfileId`)
    REFERENCES `techno`.`Profiles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`WidgetSizes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`WidgetSizes` ;

CREATE TABLE IF NOT EXISTS `techno`.`WidgetSizes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `size` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`WidgetClasses`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`WidgetClasses` ;

CREATE TABLE IF NOT EXISTS `techno`.`WidgetClasses` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `className` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Articles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Articles` ;

CREATE TABLE IF NOT EXISTS `techno`.`Articles` (
  `id` INT NOT NULL,
  `title` VARCHAR(45) NOT NULL,
  `contents` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Widgets`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Widgets` ;

CREATE TABLE IF NOT EXISTS `techno`.`Widgets` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NOT NULL,
  `contents` VARCHAR(45) NULL,
  `widgetscol` VARCHAR(45) NULL,
  `WidgetSizeId` INT NOT NULL,
  `WidgetClassId` INT NOT NULL,
  `ArticleId` INT NULL,
  `ParentWidgetId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_widgets_widgetSizes1_idx` (`WidgetSizeId` ASC),
  INDEX `fk_widgets_widgetClasses1_idx` (`WidgetClassId` ASC),
  INDEX `fk_Widgets_Articles1_idx` (`ArticleId` ASC),
  INDEX `fk_Widgets_Widgets1_idx` (`ParentWidgetId` ASC),
  CONSTRAINT `fk_widgets_widgetSizes1`
    FOREIGN KEY (`WidgetSizeId`)
    REFERENCES `techno`.`WidgetSizes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_widgets_widgetClasses1`
    FOREIGN KEY (`WidgetClassId`)
    REFERENCES `techno`.`WidgetClasses` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Widgets_Articles1`
    FOREIGN KEY (`ArticleId`)
    REFERENCES `techno`.`Articles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Widgets_Widgets1`
    FOREIGN KEY (`ParentWidgetId`)
    REFERENCES `techno`.`Widgets` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Comments`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Comments` ;

CREATE TABLE IF NOT EXISTS `techno`.`Comments` (
  `id` INT NOT NULL,
  `comments` VARCHAR(45) NOT NULL,
  `ArticleId` INT NOT NULL,
  `UserId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Comments_Articles1_idx` (`ArticleId` ASC),
  INDEX `fk_Comments_Users1_idx` (`UserId` ASC),
  CONSTRAINT `fk_Comments_Articles1`
    FOREIGN KEY (`ArticleId`)
    REFERENCES `techno`.`Articles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Comments_Users1`
    FOREIGN KEY (`UserId`)
    REFERENCES `techno`.`Users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`FontAwesomeFonts`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`FontAwesomeFonts` ;

CREATE TABLE IF NOT EXISTS `techno`.`FontAwesomeFonts` (
  `id` INT NOT NULL,
  `fontName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `techno`.`Menus`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `techno`.`Menus` ;

CREATE TABLE IF NOT EXISTS `techno`.`Menus` (
  `id` INT NOT NULL,
  `title` VARCHAR(45) NOT NULL,
  `path` VARCHAR(45) NOT NULL,
  `FontAwesomeFontId` INT NULL,
  `ParentMenuId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Menus_FontAwesomeFonts1_idx` (`FontAwesomeFontId` ASC),
  INDEX `fk_Menus_Menus1_idx` (`ParentMenuId` ASC),
  CONSTRAINT `fk_Menus_FontAwesomeFonts1`
    FOREIGN KEY (`FontAwesomeFontId`)
    REFERENCES `techno`.`FontAwesomeFonts` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Menus_Menus1`
    FOREIGN KEY (`ParentMenuId`)
    REFERENCES `techno`.`Menus` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE = '';
GRANT USAGE ON *.* TO technoAdmin;
 DROP USER technoAdmin;
SET SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';
CREATE USER 'technoAdmin' IDENTIFIED BY 'Olive1664%';

GRANT ALL ON `techno`.* TO 'technoAdmin';

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
