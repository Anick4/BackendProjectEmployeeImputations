-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: imputacionesdb
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `calendars`
--

DROP TABLE IF EXISTS `calendars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calendars` (
  `calendar_id` int NOT NULL AUTO_INCREMENT,
  `daily_hours` int NOT NULL,
  `monday` bit(1) NOT NULL,
  `tuesday` bit(1) NOT NULL,
  `wednesday` bit(1) NOT NULL,
  `thursday` bit(1) NOT NULL,
  `friday` bit(1) NOT NULL,
  `saturday` bit(1) NOT NULL,
  `sunday` bit(1) NOT NULL,
  PRIMARY KEY (`calendar_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calendars`
--

LOCK TABLES `calendars` WRITE;
/*!40000 ALTER TABLE `calendars` DISABLE KEYS */;
INSERT INTO `calendars` VALUES (1,8,_binary '',_binary '',_binary '',_binary '',_binary '',_binary '\0',_binary '\0'),(2,9,_binary '',_binary '',_binary '',_binary '',_binary '\0',_binary '\0',_binary '\0');
/*!40000 ALTER TABLE `calendars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `employee_code` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `calendar_id` int NOT NULL,
  `role_id` int NOT NULL,
  PRIMARY KEY (`employee_id`),
  UNIQUE KEY `employee_code_UNIQUE` (`employee_code`),
  UNIQUE KEY `employee_id_UNIQUE` (`employee_id`),
  KEY `fk_employees_calendars_idx` (`calendar_id`),
  KEY `fk_employees_roles_idx` (`role_id`) /*!80000 INVISIBLE */,
  CONSTRAINT `fk_employees_calendars_id` FOREIGN KEY (`calendar_id`) REFERENCES `calendars` (`calendar_id`),
  CONSTRAINT `fk_employees_roles_id` FOREIGN KEY (`role_id`) REFERENCES `roles` (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (2,'123456','adrian','aguer','adri@hotmail.com','agentina',1,1),(3,'345435','carol','montero','carlota@hotmail.com','brownie',2,1);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees_projects`
--

DROP TABLE IF EXISTS `employees_projects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees_projects` (
  `id` int NOT NULL AUTO_INCREMENT,
  `project_id` int NOT NULL,
  `employee_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `fk_projects_has_employees_employees_idx` (`employee_id`) /*!80000 INVISIBLE */,
  KEY `fk_projects_has_employees_projects.idx` (`project_id`) /*!80000 INVISIBLE */,
  CONSTRAINT `fk_projects_has_employees_employees` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`),
  CONSTRAINT `fk_projects_has_employees_projects` FOREIGN KEY (`project_id`) REFERENCES `projects` (`project_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees_projects`
--

LOCK TABLES `employees_projects` WRITE;
/*!40000 ALTER TABLE `employees_projects` DISABLE KEYS */;
/*!40000 ALTER TABLE `employees_projects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imputations`
--

DROP TABLE IF EXISTS `imputations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `imputations` (
  `imputation_id` int NOT NULL AUTO_INCREMENT,
  `day` tinyint NOT NULL,
  `hours` tinyint NOT NULL,
  `extra_hours` tinyint NOT NULL,
  `state` enum('sent','approved','rejected') NOT NULL,
  `employee_id` int NOT NULL,
  `week` int NOT NULL,
  `project_id` int NOT NULL,
  PRIMARY KEY (`imputation_id`),
  UNIQUE KEY `imputations_id_UNIQUE` (`imputation_id`),
  KEY `fk_imputations_employees_idx` (`employee_id`),
  KEY `fk_imputations_projects_id_idx` (`project_id`),
  CONSTRAINT `fk_imputations_employees_id` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`),
  CONSTRAINT `fk_imputations_projects_id` FOREIGN KEY (`project_id`) REFERENCES `projects` (`project_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imputations`
--

LOCK TABLES `imputations` WRITE;
/*!40000 ALTER TABLE `imputations` DISABLE KEYS */;
INSERT INTO `imputations` VALUES (2,1,4,4,'sent',2,3,1),(3,1,4,0,'sent',2,3,2),(4,2,3,2,'sent',2,3,1);
/*!40000 ALTER TABLE `imputations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projects` (
  `project_id` int NOT NULL AUTO_INCREMENT,
  `state` bit(1) NOT NULL,
  `generic` bit(1) NOT NULL,
  `name` varchar(45) NOT NULL,
  `responsible` int NOT NULL,
  PRIMARY KEY (`project_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projects`
--

LOCK TABLES `projects` WRITE;
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects` VALUES (1,_binary '',_binary '','apolo',1),(2,_binary '',_binary '','afrodita',2),(3,_binary '',_binary '','ares',3);
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `role_id` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(45) NOT NULL,
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Junior'),(2,'Senior'),(3,'Manager');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-04 10:41:48
