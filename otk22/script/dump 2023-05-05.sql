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
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(250) NOT NULL,
  `address` varchar(250) NOT NULL,
  `phone` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'ОТК','',''),(2,'ООО Ромашка','г. Ростов-на-Дону, ул. Садовая, 26','9282000001'),(3,'ООО Ремонтно Строительное Предприятие Асфальт','г. Батайск, ул. Горького, 27','9283000003'),(4,'ИП Петров','г. Аксай, ул. Гагарина, 28','9283000004');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `userLogin` varchar(50) NOT NULL,
  `serviceId` int NOT NULL,
  `discountPercent` decimal(10,2) DEFAULT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Новый',
  PRIMARY KEY (`id`),
  KEY `fk_users_idx` (`userLogin`),
  KEY `fk_services_idx` (`serviceId`),
  KEY `fk_statuses_idx` (`status`),
  CONSTRAINT `fk_services` FOREIGN KEY (`serviceId`) REFERENCES `services` (`id`),
  CONSTRAINT `fk_statuses` FOREIGN KEY (`status`) REFERENCES `statuses` (`status`),
  CONSTRAINT `fk_users` FOREIGN KEY (`userLogin`) REFERENCES `users` (`login`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (4,'roma',10,10.00,'Новый'),(7,'alla',10,10.00,'Новый'),(8,'alla',30,50.00,'Обрабатывается');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `orders_arch` VALUES (5,'roma',20,10.00,'Выполнен'),(6,'admin',10,0.00,'Обрабатывается');
/*!40000 ALTER TABLE `orders_arch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `code` varchar(50) NOT NULL,
  `description` varchar(250) NOT NULL,
  `employee` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES ('client','Роль клиент',0),('laborant','Роль Лаборанта',1),('manager','Роль менеджера',1);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `statuses`
--

DROP TABLE IF EXISTS `statuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `statuses` (
  `status` varchar(50) NOT NULL,
  `description` varchar(250) NOT NULL,
  `level` int DEFAULT '100',
  PRIMARY KEY (`status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statuses`
--

LOCK TABLES `statuses` WRITE;
/*!40000 ALTER TABLE `statuses` DISABLE KEYS */;
INSERT INTO `statuses` VALUES ('Возващен','Возвращен с дефектом на производство',400),('Выполнен','Заказ выполнен',300),('Новый','Новый заказ',100),('Обрабатывается','Заказ обрабатывается',200);
/*!40000 ALTER TABLE `statuses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tmp`
--

DROP TABLE IF EXISTS `tmp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tmp` (
  `id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tmp`
--

LOCK TABLES `tmp` WRITE;
/*!40000 ALTER TABLE `tmp` DISABLE KEYS */;
INSERT INTO `tmp` VALUES (110),(120),(130),(140),(160),(170),(180),(190),(200),(220),(240),(250),(260),(280),(290),(300),(310),(320),(330),(340),(350),(360),(370),(380),(390),(400),(410),(420),(430),(440),(450),(460);
/*!40000 ALTER TABLE `tmp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `login` varchar(50) NOT NULL,
  `customerId` int NOT NULL,
  `roleCode` varchar(50) NOT NULL,
  `name` varchar(250) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`login`),
  KEY `fk_customers_idx` (`customerId`),
  KEY `fk_roles_idx` (`roleCode`),
  CONSTRAINT `fk_customers` FOREIGN KEY (`customerId`) REFERENCES `customers` (`id`),
  CONSTRAINT `fk_roles` FOREIGN KEY (`roleCode`) REFERENCES `roles` (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('admin',1,'manager','Иванов Максим','1'),('alla',2,'client','Алла Илинична','2'),('roma',2,'client','Роман Александрович','2'),('sasha',1,'laborant','Иванов Максим (Лаборант)','1'),('yana',2,'client','Яна Александровна','2');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `услуги+`
--

DROP TABLE IF EXISTS `услуги+`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `услуги+` (
  `id` int DEFAULT NULL,
  `name` text,
  `price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `услуги+`
--

LOCK TABLES `услуги+` WRITE;
/*!40000 ALTER TABLE `услуги+` DISABLE KEYS */;
INSERT INTO `услуги+` VALUES (110,'Монтаж потолка из гипсокартонного листа ГКЛ',5940.3),(120,'Подготовительные работы',10197.48),(130,'Штукатурные работы',1818.64),(140,'Устройство подвесного потолка',2890.81),(150,'Малярные работы',5908.63),(160,'Шумо и теплоизоляционные работы',1099.97),(170,'Подготовительные и демонтажные работы',8413.08),(180,'Устройство перегородок',2469.64),(190,'Штукатурные работы',5205.54),(200,'Шумотеплоизоляционные и гидроизоляционные работы',8600.26),(210,'Плиточные работы',6671.98),(220,'Облицовка стен декоративными материалами',8890.77),(230,'Малярные работы',9337.68),(240,'Демонтажные работы',8419.11),(250,'Работы по устройству гидроизоляции и теплошумоизоляции',7529.34),(260,'Работы по устройству стяжки',1025.53),(270,'Плиточные работы',3666.14),(280,'Работы по устройству напольных покрытий',2791.07),(290,'Подготовительные работы',3060.18),(300,'Прокладка кабеля',7002.97),(310,'Монтаж распаечных коробок и электрощитов',1686.14),(320,'Установка розеток выключателей и другого электрооборудования',4290),(330,'Демонтаж проводки',7002.95),(340,'Подготовительные работы',7994.64),(350,'Прокладка труб холодного и горячего водоснабжения',5393.19),(360,'Монтаж и ремонт канализации',1822.3),(370,'Установка инсталляций унитаза биде',9413.15),(380,'Монтаж коллекторного узла',3066.28),(390,'Монтаж фильтра тонкой и грубой очистки редуктора давления',6693.03),(400,'Установка защиты от протечек \"НЕПТУН\"\"\"',3156.13),(410,'Работы по отоплению',6203.56),(420,'Работы по установке и подключению сантехоборудования',9822.58),(430,'Установка жалюзи',4073.94),(440,'Установка рольставней ',2636.17),(450,'Установка подоконников ПВХ или деревянных',7535.74),(460,'Монтаж откосов',1005.05);
/*!40000 ALTER TABLE `услуги+` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-05 11:25:33
