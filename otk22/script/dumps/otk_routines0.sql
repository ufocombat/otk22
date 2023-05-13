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
-- Temporary view structure for view `orders_all`
--

DROP TABLE IF EXISTS `orders_all`;
/*!50001 DROP VIEW IF EXISTS `orders_all`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `orders_all` AS SELECT 
 1 AS `id`,
 1 AS `userLogin`,
 1 AS `serviceId`,
 1 AS `discountPercent`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `userorders`
--

DROP TABLE IF EXISTS `userorders`;
/*!50001 DROP VIEW IF EXISTS `userorders`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `userorders` AS SELECT 
 1 AS `Заказ Но`,
 1 AS `Статус`,
 1 AS `Логин`,
 1 AS `Услуга`,
 1 AS `Скидка (%)`,
 1 AS `Сумма Заказа`,
 1 AS `Итого`,
 1 AS `Дата Заказа`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `orders_all`
--

/*!50001 DROP VIEW IF EXISTS `orders_all`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `orders_all` AS select `orders`.`id` AS `id`,`orders`.`userLogin` AS `userLogin`,`orders`.`serviceId` AS `serviceId`,`orders`.`discountPercent` AS `discountPercent`,`orders`.`status` AS `status` from `orders` union select `orders_arch`.`id` AS `id`,`orders_arch`.`userLogin` AS `userLogin`,`orders_arch`.`serviceId` AS `serviceId`,`orders_arch`.`discountPercent` AS `discountPercent`,`orders_arch`.`status` AS `status` from `orders_arch` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `userorders`
--

/*!50001 DROP VIEW IF EXISTS `userorders`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `userorders` (`Заказ Но`,`Статус`,`Логин`,`Услуга`,`Скидка (%)`,`Сумма Заказа`,`Итого`,`Дата Заказа`) AS select `o`.`id` AS `id`,`o`.`status` AS `status`,`o`.`userLogin` AS `userLogin`,`s`.`name` AS `name`,`o`.`discountPercent` AS `discountPercent`,`s`.`price` AS `price`,round((`s`.`price` * (1 - (`o`.`discountPercent` / 100))),2) AS `totalAmount`,`o`.`orderDate` AS `orderDate` from (`orders` `o` join `services` `s`) where (`o`.`serviceId` = `s`.`id`) order by `o`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-13 11:43:37
