CREATE DATABASE  IF NOT EXISTS `otk` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `otk`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: otk
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `orders_arch`
--

DROP TABLE IF EXISTS `orders_arch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders_arch` (
  `id` int NOT NULL,
  `userLogin` varchar(50) NOT NULL,
  `serviceId` int NOT NULL,
  `discountPercent` decimal(10,2) DEFAULT NULL,
  `status` varchar(50) NOT NULL,
  `orderDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_users_idx` (`userLogin`),
  KEY `fk_services_idx` (`serviceId`),
  KEY `fk_statuses_idx` (`status`),
  CONSTRAINT `fk_services_arch` FOREIGN KEY (`serviceId`) REFERENCES `services` (`id`),
  CONSTRAINT `fk_statuses_arch` FOREIGN KEY (`status`) REFERENCES `statuses` (`status`),
  CONSTRAINT `fk_users_arch` FOREIGN KEY (`userLogin`) REFERENCES `users` (`login`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders_arch`
--

LOCK TABLES `orders_arch` WRITE;
/*!40000 ALTER TABLE `orders_arch` DISABLE KEYS */;
INSERT INTO `orders_arch` VALUES (5,'roma',20,10.00,'Выполнен','2023-05-01 10:36:29'),(6,'admin',10,0.00,'Обрабатывается','2023-05-01 10:36:29'),(9,'alla',130,3.00,'Выполнен','2023-05-01 10:36:29'),(11,'yana',130,0.00,'Новый','2023-05-11 10:39:37');
/*!40000 ALTER TABLE `orders_arch` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-13 11:43:37
