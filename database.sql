create database if not exists mobile_shop ; 
use mobile_shop ; 

CREATE TABLE `mobile_shop`.`client` (
  `id` INT NOT NULL DEFAULT 0,
  `book_number` VARCHAR(10) NOT NULL DEFAULT 0,
  `client_name` VARCHAR(75) NOT NULL,
  `client_telephone` VARCHAR(20) NOT NULL,
  `client_address` VARCHAR(100) NULL,
  `guarantor_name` VARCHAR(45) NULL,
  `guarantor_telephone` VARCHAR(45) NULL,
  `product_name` VARCHAR(45) NOT NULL,
  `product_price` DOUBLE NOT NULL,
  `celling_date` VARCHAR(75) NOT NULL,
  `numberofmonths` INT NOT NULL,
  `month_class` DOUBLE NOT NULL,
  `submitted` DOUBLE NOT NULL,
  `notes` TEXT NULL,
  PRIMARY KEY (`id`));


CREATE TABLE `mobile_shop`.`month` (
  `month_id` INT NOT NULL,
  `month_number` INT NOT NULL,
  `month_name` VARCHAR(45) NOT NULL,
  `class` DOUBLE NOT NULL,
  `is_checked` VARCHAR(45) NOT NULL DEFAULT 'false',
  `client_number` INT NOT NULL,
  PRIMARY KEY (`month_id`));





ALTER TABLE `mobile_shop`.`client` 
ADD COLUMN `expire_date` VARCHAR(75) NULL AFTER `notes`,
ADD COLUMN `pushed` INT NULL AFTER `expire_date`,
ADD COLUMN `not_pushed` INT NULL AFTER `pushed`;
