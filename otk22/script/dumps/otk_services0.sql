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
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `id` int NOT NULL,
  `name` varchar(250) NOT NULL,
  `price` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (10,'Проверка на загрязнение окна',1000.00),(20,'Проверка окна на гермитичность',2000.00),(30,'Регулировка ручек Z-16',5000.00),(110,'Монтаж потолка из гипсокартонного листа ГКЛ',5940.30),(120,'Подготовительные работы',10197.48),(130,'Штукатурные работы',1818.64),(140,'Устройство подвесного потолка',2890.81),(160,'Шумо и теплоизоляционные работы',1099.97),(170,'Подготовительные и демонтажные работы',8413.08),(180,'Устройство перегородок',2469.64),(200,'Шумотеплоизоляционные и гидроизоляционные работы',8600.26),(220,'Облицовка стен декоративными материалами',8890.77),(240,'Демонтажные работы',8419.11),(250,'Работы по устройству гидроизоляции и теплошумоизоляции',7529.34),(260,'Работы по устройству стяжки',1025.53),(280,'Работы по устройству напольных покрытий',2791.07),(300,'Прокладка кабеля',7002.97),(310,'Монтаж распаечных коробок и электрощитов',1686.14),(320,'Установка розеток выключателей и другого электрооборудования',4290.00),(330,'Демонтаж проводки',7002.95),(350,'Прокладка труб холодного и горячего водоснабжения',5393.19),(360,'Монтаж и ремонт канализации',1822.30),(370,'Установка инсталляций унитаза биде',9413.15),(380,'Монтаж коллекторного узла',3066.28),(390,'Монтаж фильтра тонкой и грубой очистки редуктора давления',6693.03),(400,'Установка защиты от протечек \"НЕПТУН\"\"\"',3156.13),(410,'Работы по отоплению',6203.56),(420,'Работы по установке и подключению сантехоборудования',9822.58),(430,'Установка жалюзи',4073.94),(440,'Установка рольставней ',2636.17),(450,'Установка подоконников ПВХ или деревянных',7535.74),(460,'Монтаж откосов',1005.05);
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-13 11:43:36
