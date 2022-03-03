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
-- Table structure for table `calendarios`
--

DROP TABLE IF EXISTS `calendarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calendarios` (
  `idcalendarios` int NOT NULL AUTO_INCREMENT,
  `horas_diarias` int NOT NULL,
  `lunes` bit(1) NOT NULL,
  `martes` bit(1) NOT NULL,
  `miercoles` bit(1) NOT NULL,
  `jueves` bit(1) NOT NULL,
  `viernes` bit(1) NOT NULL,
  `sabado` bit(1) NOT NULL,
  `domingo` bit(1) NOT NULL,
  PRIMARY KEY (`idcalendarios`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calendarios`
--

LOCK TABLES `calendarios` WRITE;
/*!40000 ALTER TABLE `calendarios` DISABLE KEYS */;
INSERT INTO `calendarios` VALUES (1,8,_binary '',_binary '',_binary '',_binary '',_binary '',_binary '\0',_binary '\0'),(2,9,_binary '',_binary '',_binary '',_binary '',_binary '\0',_binary '\0',_binary '\0');
/*!40000 ALTER TABLE `calendarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `EmpleadoId` int NOT NULL AUTO_INCREMENT,
  `Codigo_empleado` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Contraseña` varchar(45) NOT NULL,
  `calendarios_idcalendarios` int NOT NULL,
  `roles_idRoles1` int NOT NULL,
  PRIMARY KEY (`EmpleadoId`,`calendarios_idcalendarios`,`roles_idRoles1`),
  UNIQUE KEY `codigo_empleado_UNIQUE` (`Codigo_empleado`),
  UNIQUE KEY `idempleado_UNIQUE` (`EmpleadoId`),
  KEY `fk_empleados_calendarios1_idx` (`calendarios_idcalendarios`),
  KEY `fk_empleados_roles1_idx` (`roles_idRoles1`),
  CONSTRAINT `fk_empleados_calendarios1` FOREIGN KEY (`calendarios_idcalendarios`) REFERENCES `calendarios` (`idcalendarios`),
  CONSTRAINT `fk_empleados_roles1` FOREIGN KEY (`roles_idRoles1`) REFERENCES `roles` (`idRoles`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (2,'123456','adrian','aguer','adri@hotmail.com','agentina',1,1),(3,'345435','carol','montero','carlota@hotmail.com','brownie',2,1);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados_proyectos`
--

DROP TABLE IF EXISTS `empleados_proyectos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados_proyectos` (
  `proyectos_idproyectos` int NOT NULL,
  `empleados_idempleados` int NOT NULL,
  PRIMARY KEY (`proyectos_idproyectos`,`empleados_idempleados`),
  KEY `fk_proyectos_has_empleados_empleados_idx` (`empleados_idempleados`),
  KEY `fk_proyectos_has_empleados_proyectos_idx` (`proyectos_idproyectos`),
  CONSTRAINT `fk_proyectos_has_empleados_empleados` FOREIGN KEY (`empleados_idempleados`) REFERENCES `empleados` (`EmpleadoId`),
  CONSTRAINT `fk_proyectos_has_empleados_proyectos` FOREIGN KEY (`proyectos_idproyectos`) REFERENCES `proyectos` (`idproyectos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados_proyectos`
--

LOCK TABLES `empleados_proyectos` WRITE;
/*!40000 ALTER TABLE `empleados_proyectos` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleados_proyectos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imputaciones`
--

DROP TABLE IF EXISTS `imputaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `imputaciones` (
  `idimputaciones` int NOT NULL AUTO_INCREMENT,
  `dia` tinyint NOT NULL,
  `horas` tinyint NOT NULL,
  `estado` enum('enviado','aprobado','rechazado') NOT NULL,
  `extras` tinyint NOT NULL,
  `empleados_idempleados1` int NOT NULL,
  `semana` int NOT NULL,
  `proyectos_idproyectos` int NOT NULL,
  PRIMARY KEY (`idimputaciones`,`empleados_idempleados1`,`proyectos_idproyectos`),
  UNIQUE KEY `idimputaciones_UNIQUE` (`idimputaciones`),
  KEY `fk_imputaciones_empleados1_idx` (`empleados_idempleados1`),
  CONSTRAINT `fk_imputaciones_empleados1` FOREIGN KEY (`empleados_idempleados1`) REFERENCES `empleados` (`EmpleadoId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imputaciones`
--

LOCK TABLES `imputaciones` WRITE;
/*!40000 ALTER TABLE `imputaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `imputaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proyectos`
--

DROP TABLE IF EXISTS `proyectos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proyectos` (
  `idproyectos` int NOT NULL AUTO_INCREMENT,
  `estado` bit(1) NOT NULL,
  `generico` bit(1) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `imputaciones_idimputaciones` int DEFAULT NULL,
  `responsable_id` int NOT NULL,
  PRIMARY KEY (`idproyectos`),
  KEY `fk_proyectos_imputaciones1_idx` (`imputaciones_idimputaciones`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proyectos`
--

LOCK TABLES `proyectos` WRITE;
/*!40000 ALTER TABLE `proyectos` DISABLE KEYS */;
INSERT INTO `proyectos` VALUES (1,_binary '',_binary '','apolo',0,1);
/*!40000 ALTER TABLE `proyectos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idRoles` int NOT NULL AUTO_INCREMENT,
  `junior` bit(1) NOT NULL,
  `senior` bit(1) NOT NULL,
  `manager` bit(1) NOT NULL,
  PRIMARY KEY (`idRoles`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,_binary '',_binary '\0',_binary '\0');
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

-- Dump completed on 2022-02-28 15:39:10
