CREATE DATABASE  IF NOT EXISTS `log4sky` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `log4sky`;
-- MySQL dump 10.13  Distrib 5.7.12, for osx10.9 (x86_64)
--
-- Host: localhost    Database: log4sky
-- ------------------------------------------------------
-- Server version	5.7.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date_written` datetime NOT NULL,
  `territory` varchar(4) CHARACTER SET utf8 NOT NULL,
  `proposition` varchar(16) CHARACTER SET utf8 NOT NULL,
  `proposition_version` varchar(16) CHARACTER SET utf8 NOT NULL,
  `platform` varchar(16) CHARACTER SET utf8 NOT NULL,
  `platform_os` varchar(16) CHARACTER SET utf8 NOT NULL,
  `platform_os_version` varchar(16) CHARACTER SET utf8 NOT NULL,
  `runtime` varchar(16) CHARACTER SET utf8 DEFAULT NULL,
  `runtime_version` varchar(16) CHARACTER SET utf8 DEFAULT NULL,
  `level` varchar(16) CHARACTER SET utf8 NOT NULL,
  `error_type` varchar(32) CHARACTER SET utf8 DEFAULT NULL,
  `error_code` varchar(16) CHARACTER SET utf8 DEFAULT NULL,
  `error_url` varchar(2048) CHARACTER SET utf8 DEFAULT NULL,
  `error_content` longtext NOT NULL,
  `error_line_number` int(11) DEFAULT NULL,
  `error_additional_info` longtext,
  `user_tracking_id` varchar(48) CHARACTER SET utf8 DEFAULT NULL,
  `is_online` bit(1) DEFAULT NULL,
  `is_out_of_locale` bit(1) DEFAULT NULL,
  `is_authenticated` bit(1) DEFAULT NULL,
  `total_memory` int(11) DEFAULT NULL,
  `total_disk_space` int(11) DEFAULT NULL,
  `memory_usage` int(11) DEFAULT NULL,
  `cpu_usage` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1 COMMENT='This table contains all the logs of a given Proposition';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping events for database 'log4sky'
--

--
-- Dumping routines for database 'log4sky'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-11-03 19:26:36
