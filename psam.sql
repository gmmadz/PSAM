CREATE DATABASE  IF NOT EXISTS `psam` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `psam`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: localhost    Database: psam
-- ------------------------------------------------------
-- Server version	5.6.28-log

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
-- Table structure for table `activities`
--

DROP TABLE IF EXISTS `activities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `activities` (
  `activityID` int(11) NOT NULL AUTO_INCREMENT,
  `programID` int(11) NOT NULL,
  `dateAdded` date NOT NULL,
  `activityDesc` varchar(60) NOT NULL,
  `timeTo` varchar(30) NOT NULL,
  `timeFrom` varchar(30) NOT NULL,
  PRIMARY KEY (`activityID`),
  KEY `programID_idx` (`programID`),
  CONSTRAINT `programID` FOREIGN KEY (`programID`) REFERENCES `program` (`programID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activities`
--

LOCK TABLES `activities` WRITE;
/*!40000 ALTER TABLE `activities` DISABLE KEYS */;
/*!40000 ALTER TABLE `activities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `affectedareas`
--

DROP TABLE IF EXISTS `affectedareas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `affectedareas` (
  `disasterID` int(11) NOT NULL,
  `houseHoldID` int(11) NOT NULL,
  KEY `disasterID_idx` (`disasterID`),
  KEY `houseHoldID_idx` (`houseHoldID`),
  CONSTRAINT `ddisasterID` FOREIGN KEY (`disasterID`) REFERENCES `disaster` (`disasterID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `hhouseHoldID` FOREIGN KEY (`houseHoldID`) REFERENCES `household` (`houseHoldID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `affectedareas`
--

LOCK TABLES `affectedareas` WRITE;
/*!40000 ALTER TABLE `affectedareas` DISABLE KEYS */;
INSERT INTO `affectedareas` VALUES (1,64),(1,65);
/*!40000 ALTER TABLE `affectedareas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `budget`
--

DROP TABLE IF EXISTS `budget`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `budget` (
  `budgetID` int(11) NOT NULL AUTO_INCREMENT,
  `programID` int(11) NOT NULL,
  `dateAdded` date NOT NULL,
  `description` varchar(60) NOT NULL,
  `budget` float NOT NULL,
  PRIMARY KEY (`budgetID`),
  KEY `programID_idx` (`programID`),
  CONSTRAINT `budget_ibfk_1` FOREIGN KEY (`programID`) REFERENCES `program` (`programID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `budget`
--

LOCK TABLES `budget` WRITE;
/*!40000 ALTER TABLE `budget` DISABLE KEYS */;
/*!40000 ALTER TABLE `budget` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `casualty`
--

DROP TABLE IF EXISTS `casualty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `casualty` (
  `casualtyID` int(11) NOT NULL AUTO_INCREMENT,
  `respondentID` int(11) NOT NULL,
  `disasterID` int(11) NOT NULL,
  `casualtyType` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`casualtyID`),
  KEY `respondentID_idx` (`respondentID`),
  KEY `disasterID_idx` (`disasterID`),
  CONSTRAINT `disasterID` FOREIGN KEY (`disasterID`) REFERENCES `disaster` (`disasterID`) ON UPDATE CASCADE,
  CONSTRAINT `respondentID` FOREIGN KEY (`respondentID`) REFERENCES `respondent` (`respondentID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `casualty`
--

LOCK TABLES `casualty` WRITE;
/*!40000 ALTER TABLE `casualty` DISABLE KEYS */;
INSERT INTO `casualty` VALUES (8,162,1,'Injured'),(9,163,1,'Missing'),(10,164,1,'Dead'),(11,167,1,'Dead'),(12,168,1,'Dead'),(13,169,1,'Injured');
/*!40000 ALTER TABLE `casualty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `damages`
--

DROP TABLE IF EXISTS `damages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `damages` (
  `damagesID` int(11) NOT NULL AUTO_INCREMENT,
  `disasterID` int(11) NOT NULL,
  `houseHoldID` int(11) NOT NULL,
  `damagedItem` varchar(30) NOT NULL,
  `extendOfDamage` varchar(30) NOT NULL,
  `estimatedCost` float NOT NULL,
  PRIMARY KEY (`damagesID`),
  KEY `disasterID_idx` (`disasterID`),
  KEY `houseHoldID_idx` (`houseHoldID`),
  CONSTRAINT `damages_ibfk_1` FOREIGN KEY (`disasterID`) REFERENCES `disaster` (`disasterID`),
  CONSTRAINT `damages_ibfk_2` FOREIGN KEY (`houseHoldID`) REFERENCES `household` (`houseHoldID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `damages`
--

LOCK TABLES `damages` WRITE;
/*!40000 ALTER TABLE `damages` DISABLE KEYS */;
INSERT INTO `damages` VALUES (11,1,64,'House','Totally Damaged',1000),(12,1,65,'House','Partially Damaged',54154500000);
/*!40000 ALTER TABLE `damages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disaster`
--

DROP TABLE IF EXISTS `disaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `disaster` (
  `disasterID` int(11) NOT NULL AUTO_INCREMENT,
  `employeeID` int(11) DEFAULT NULL,
  `disasterType` varchar(30) NOT NULL,
  `disasterDate` date NOT NULL,
  `disasterCause` varchar(30) NOT NULL,
  PRIMARY KEY (`disasterID`),
  KEY `disaster_ibfk_1` (`employeeID`),
  CONSTRAINT `disaster_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disaster`
--

LOCK TABLES `disaster` WRITE;
/*!40000 ALTER TABLE `disaster` DISABLE KEYS */;
INSERT INTO `disaster` VALUES (1,NULL,'Earthquake','2016-01-01',' omg'),(2,NULL,'Fire','2009-06-15',' lol644644'),(3,NULL,'Epidemic','2016-01-01',' qwdada'),(4,NULL,'Tsunami','2016-01-01',' dfbgdfgdfgdf'),(5,NULL,'Volcanic','2016-01-01',' wawawaw');
/*!40000 ALTER TABLE `disaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `employeeID` int(11) NOT NULL AUTO_INCREMENT,
  `managedBy` varchar(45) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `position` varchar(30) NOT NULL,
  `firstName` varchar(30) NOT NULL,
  `middleName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  PRIMARY KEY (`employeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `expenses` (
  `expenseID` int(11) NOT NULL AUTO_INCREMENT,
  `budgetID` int(11) NOT NULL,
  `dateAdded` date NOT NULL,
  `description` varchar(60) NOT NULL,
  `otherInfo` varchar(60) DEFAULT NULL,
  `itemName` varchar(30) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` float NOT NULL,
  PRIMARY KEY (`expenseID`),
  KEY `progImpID_idx` (`budgetID`),
  CONSTRAINT `budgetID` FOREIGN KEY (`budgetID`) REFERENCES `budget` (`budgetID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expenses`
--

LOCK TABLES `expenses` WRITE;
/*!40000 ALTER TABLE `expenses` DISABLE KEYS */;
/*!40000 ALTER TABLE `expenses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gkkdetails`
--

DROP TABLE IF EXISTS `gkkdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gkkdetails` (
  `gkkID` int(11) NOT NULL AUTO_INCREMENT,
  `gkkName` varchar(45) NOT NULL,
  `district` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  PRIMARY KEY (`gkkID`)
) ENGINE=InnoDB AUTO_INCREMENT=99 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gkkdetails`
--

LOCK TABLES `gkkdetails` WRITE;
/*!40000 ALTER TABLE `gkkdetails` DISABLE KEYS */;
INSERT INTO `gkkdetails` VALUES (1,'San Vicente Ferrer','1','Tacunan'),(2,'San Roque','1','Colagsoy, Tacunan'),(3,'San Roque','1','Biatilisan, Tacunan'),(4,'San Miguel','1','Campo 3, Tacunan'),(5,'San Agustin','1','Santolan, Tacunan'),(6,'Birhen sa Asuncion','1','Tacunan'),(7,'Sto. Niño','1','Tacunan'),(8,'Birhen delos Remedios','2','Matina Biao'),(9,'San Roque','2','Matina Biao'),(10,'Birhen sa Fatima','2','New Zambo, Matina Biao'),(11,'San Isidro Labrador','2','Malogbog, Matina Biao'),(12,'Sto. Niño','2','Egay, Matina Biao'),(13,'San Jose','3','Uraya'),(14,'San Antonio de Padua','3','Upper Mintal'),(15,'San Vicente Ferrer','3','SANAI, Upper Mintal'),(16,'Sta. Cruz','3','Tacunan'),(17,'San Isidro Labrador','3','Upper Mintal'),(18,'San Antonio de Padua','3','Deca Homes'),(19,'San Roque','3','Tacunan Crossing'),(20,'San Lorenzo Ruiz','3','Myrterville, Tacunan Crossing'),(21,'ISKP','3','Tacunan Ula'),(22,'San Roque','3','Tacunan Ula'),(23,'Sto Niño','4','Dacudao, Tugbok'),(24,'Sta. Catalina','4','Tugbok'),(25,'Sto. Niño','4','Garcia, Tugbok'),(26,'Sto. Rosario','4','Tugbok'),(27,'Birhen sa Fatima','4','Mahayahay, Tugbok'),(28,'San Agustin','4','Quarry, Tugbok'),(29,'San Roque','4','Upper Tugbok'),(30,'Sto. Tomas de Villanueva','4','Upper Tugbok'),(31,'Immaculate Concepcion','4','Mahayahay, Tugbok'),(32,'Sto Niño','5','De Agua, Angalan'),(33,'San Roque','5','Angalan'),(34,'San Antonio de Padua','5','Upper de Agua'),(35,'ISKP','5','Angalan'),(36,'La Purisima','5','Naming, Angalan'),(37,'Sta. Cruz','5','Upper Naming, Angalan'),(38,'San Roque','6','New Danao'),(39,'Sr. San Tiago Apostol','6','Manambulan'),(40,'Sto. Niño','6','Manambulan'),(41,'Sta. Cruz','6','Shanghai, Manambulan'),(42,'Birhen sa Kasilak','6','New Bohol, Manambulan'),(43,'San Miguel','6','Pintuan, Toril'),(44,'San Roque','6','Citrus, Manambulan'),(45,'San Roque','7','New Hope'),(46,'Birhen sa Kasilak','7','New Loon, Mintal'),(47,'San Isidro Labrador','7','Sitio Basak, Mintal'),(48,'San Roque','7','Cebuda, Bago-Oshiro'),(49,'San Gabriel','7','Bago-Oshiro'),(50,'Birhen sa Guadalupe','7','POA, Bago-Oshiro'),(51,'Sta. Cruz','7','Kalubihan, Bago-Oshiro'),(52,'San Jose','7','Bago-Ilam, Bago-Oshiro'),(53,'San Isidro Labrador','7','117, Bago-Oshiro'),(54,'Our Lady of Lourdes','7','Bago-Oshiro'),(55,'Sto Niño','7','Mulig, Toril'),(56,'San Miguel','7','Campo, Mintal'),(57,'Sto. Niño','8','Phase I, Relocation'),(58,'Christ the King','8','Phase II, Relocation'),(59,'ISKP','8','Phase III, Relocation'),(60,'San Jose','8','Phase III, Relocation'),(61,'San Isidro Labrador','8','Phase III, Relocation'),(62,'Sacred Heart','8','Green Meadows'),(63,'Sto. Niño','8','Purok 23, Relocation'),(64,'San Antonio de Padua','9','Catalunan Pequeño'),(65,'Sto. Niño','9','Catalunan Pequeño'),(66,'ISKP','9','Catalunan Pequeño'),(67,'Our Lady of Fatima','9','Wellspring Phase I, Catalunan Pequeño'),(68,'Sta. Cruz','9','Cawa-Cawa, Catalunan Pequeño'),(69,'St. Joseph the Worker','9','Samantha Homes, Catalunan Pequeño'),(70,'Padre Pio','9','Highlands, Catalunan Pequeño'),(71,'San Vicente Ferrer','10','Wellspring Phase III, Catalunan Pequeño'),(72,'San Vicente Ferrer','10','Hi-Way, Catalunan Pequeño'),(73,'St. Joseph the Worker','10','Wellspring Phase II, Catalunan Pequeño'),(74,'San Isidro Labrador','10','Walog, Catalunan Pequeño'),(75,'La Purisima','10','Pag-ibig Homes, Catalunan Pequeño'),(76,'Our Lady of Holy Rosary','10','Greenhills Subd., Catalunan Pequeño'),(77,'Birhen sa Fatima','11','Catalunan Pequeño'),(78,'Sta. Cruz','11','Catalunan Pequeño'),(79,'San Isidro Labrador','11','Catalunan Pequeño'),(80,'St. Francis Xavier','11','Bacanaya, Catalunan Pequeño'),(81,'Sacred Heart','11','BRC, Catalunan Pequeño'),(82,'San Vicente Ferrer','11','Purok 20, Catalunan Pequeño'),(83,'Christ the King','11','Purok 21, Catalunan Pequeño'),(84,'San Martin de Porres','12','Mintal'),(85,'Sagrada Pamilya','12','Mintal'),(86,'San Jose','12','Mintal'),(87,'San Lorenzo Ruiz','12','Mintal'),(88,'Sto. Niño','12','Gumamela St., Mintal'),(89,'Birhen sa Asuncion','12','Mintal'),(90,'San Gabriel','12','Santolan, Mintal'),(91,'Sto. Rosario','13','Rubia St., Mintal'),(92,'St. Jude Thaddeus','13','Lantana St., Mintal'),(93,'Sto. Niño','13','Tapay St., Mintal'),(94,'San Isidro Labrador','13','SACA'),(95,'Sacred Heart','13','Rubia St., Mintal'),(96,'San Vicente Ferrer','13','Bandera Española St., Mintal'),(97,'Sto. Niño','13','Champaca St., Mintal'),(98,'Birhen sa Fatima','13','Mintal');
/*!40000 ALTER TABLE `gkkdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `household`
--

DROP TABLE IF EXISTS `household`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `household` (
  `houseHoldID` int(11) NOT NULL AUTO_INCREMENT,
  `gkkID` int(2) NOT NULL,
  `familyMonthlyIncome` varchar(30) NOT NULL,
  `houseOccupancy` varchar(30) NOT NULL,
  `houseStructure` varchar(30) NOT NULL,
  `residenceLocation` varchar(30) NOT NULL,
  `preparation` varchar(30) NOT NULL,
  `isFloodProne` varchar(5) NOT NULL,
  `isMemberGovOrg` varchar(5) NOT NULL,
  `position` varchar(30) NOT NULL,
  `ifCanHelp` varchar(15) NOT NULL,
  `surveyor` varchar(45) DEFAULT NULL,
  `dateOfSurvey` date DEFAULT NULL,
  PRIMARY KEY (`houseHoldID`),
  KEY `gkkID_idx` (`gkkID`),
  CONSTRAINT `gkkID` FOREIGN KEY (`gkkID`) REFERENCES `gkkdetails` (`gkkID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `household`
--

LOCK TABLES `household` WRITE;
/*!40000 ALTER TABLE `household` DISABLE KEYS */;
INSERT INTO `household` VALUES (64,63,'P5,001 - P10,000','Owned','Wooden','None','Manghipos','yes','no','','yes','Elsa G. Torjenes','2014-10-17'),(65,63,'P5,001 - P10,000','Owned','Wooden','None','','no','yes','Police Hotline','yes','Esmeralda Yabes','2014-08-14');
/*!40000 ALTER TABLE `household` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `program`
--

DROP TABLE IF EXISTS `program`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `program` (
  `programID` int(11) NOT NULL AUTO_INCREMENT,
  `employeeID` int(11) NOT NULL,
  `disasterID` int(11) NOT NULL,
  `programTitle` varchar(45) NOT NULL,
  `programDescription` varchar(60) NOT NULL,
  `startTimeFrame` varchar(20) NOT NULL,
  `endTimeFrame` varchar(20) NOT NULL,
  `dateProposed` date NOT NULL,
  `approvedBy` varchar(45) NOT NULL,
  PRIMARY KEY (`programID`),
  KEY `employeeID_idx` (`employeeID`),
  KEY `disasterID_idx` (`disasterID`),
  CONSTRAINT `program_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employeeID`),
  CONSTRAINT `program_ibfk_2` FOREIGN KEY (`disasterID`) REFERENCES `disaster` (`disasterID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `program`
--

LOCK TABLES `program` WRITE;
/*!40000 ALTER TABLE `program` DISABLE KEYS */;
/*!40000 ALTER TABLE `program` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `progress`
--

DROP TABLE IF EXISTS `progress`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `progress` (
  `progressID` int(11) NOT NULL AUTO_INCREMENT,
  `programID` int(11) NOT NULL,
  `dateAdded` date NOT NULL,
  `progress` varchar(30) NOT NULL,
  PRIMARY KEY (`progressID`),
  KEY `programID_idx` (`programID`),
  CONSTRAINT `progress_ibfk_1` FOREIGN KEY (`programID`) REFERENCES `program` (`programID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `progress`
--

LOCK TABLES `progress` WRITE;
/*!40000 ALTER TABLE `progress` DISABLE KEYS */;
/*!40000 ALTER TABLE `progress` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recepient`
--

DROP TABLE IF EXISTS `recepient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `recepient` (
  `recepientID` int(11) NOT NULL AUTO_INCREMENT,
  `houseHoldID` int(11) NOT NULL,
  `programID` int(11) NOT NULL,
  PRIMARY KEY (`recepientID`),
  KEY `houseHoldID_idx` (`houseHoldID`),
  KEY `programID_idx` (`programID`),
  CONSTRAINT `recepient_ibfk_1` FOREIGN KEY (`houseHoldID`) REFERENCES `household` (`houseHoldID`),
  CONSTRAINT `recepient_ibfk_2` FOREIGN KEY (`programID`) REFERENCES `program` (`programID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recepient`
--

LOCK TABLES `recepient` WRITE;
/*!40000 ALTER TABLE `recepient` DISABLE KEYS */;
/*!40000 ALTER TABLE `recepient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respondent`
--

DROP TABLE IF EXISTS `respondent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `respondent` (
  `respondentID` int(11) NOT NULL AUTO_INCREMENT,
  `relatedTo` int(11) NOT NULL,
  `houseHoldID` int(11) NOT NULL,
  `hierarchy` varchar(1) NOT NULL,
  `firstName` varchar(30) NOT NULL,
  `middleName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `role` varchar(15) NOT NULL,
  `nickName` varchar(15) DEFAULT NULL,
  `birthPlace` varchar(50) DEFAULT NULL,
  `birthDate` date DEFAULT NULL,
  `tribe` varchar(30) DEFAULT NULL,
  `employmentType` varchar(20) DEFAULT NULL,
  `position` varchar(30) DEFAULT NULL,
  `company` varchar(30) DEFAULT NULL,
  `companyAddress` varchar(50) DEFAULT NULL,
  `business` varchar(45) DEFAULT NULL,
  `businessType` varchar(45) DEFAULT NULL,
  `marriageType` varchar(45) DEFAULT NULL,
  `civilStatus` varchar(30) DEFAULT NULL,
  `contactNo` varchar(11) DEFAULT NULL,
  `gender` varchar(8) NOT NULL,
  `grade` varchar(30) DEFAULT NULL,
  `school` varchar(45) DEFAULT NULL,
  `ageDependent` int(2) DEFAULT NULL,
  `osy` varchar(45) DEFAULT NULL,
  `employeeID` int(11) DEFAULT NULL,
  PRIMARY KEY (`respondentID`),
  KEY `houseHoldID_idx` (`houseHoldID`),
  CONSTRAINT `res_houseHoldID` FOREIGN KEY (`houseHoldID`) REFERENCES `household` (`houseHoldID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=170 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respondent`
--

LOCK TABLES `respondent` WRITE;
/*!40000 ALTER TABLE `respondent` DISABLE KEYS */;
INSERT INTO `respondent` VALUES (162,0,64,'1','Edgar','A','Abangin','Husband','Pagal','Mabini Comval','1969-01-03','Bisaya','Regular','Cook','San Pedro Hospital','Davao City','','','Catholic','Married','09122075995','Male',NULL,NULL,47,NULL,NULL),(163,162,64,'2','Gerly ','G','Abangin','Wife','Ling-Ling','Davao del Sur','1980-10-10','Visaya',' ','','','','','','Catholic','Married','','Female',NULL,NULL,36,NULL,NULL),(164,162,64,'3','Geraldyn','','Abangin','Daughter',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Female','6','Emilda Elem. School',11,'',1),(165,162,64,'3','Noah','','Abangin','Son',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Male','3','Emilda Elem. School',8,'',1),(166,162,64,'3','Abraham','','Abangin','Son',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Male','','',2,'',1),(167,0,65,'1','Elvie','M','Abonales','Wife','Inday','Zamboanga','1984-08-04','Bisaya','Regular','Therapist','Asmara Inc.','Davao City','','','None','Single','09095380888','Female',NULL,NULL,32,NULL,NULL),(168,167,65,'3','Ricardo','','Abonales','Brother',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Male','HS','Zamboanga',41,'',1),(169,167,65,'3','San Miguel','','Requillo','Cousin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Male','HS','Davao City',25,'',1);
/*!40000 ALTER TABLE `respondent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasking`
--

DROP TABLE IF EXISTS `tasking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tasking` (
  `taskingID` int(11) NOT NULL AUTO_INCREMENT,
  `employeeID` int(11) DEFAULT NULL,
  `firstName` varchar(30) NOT NULL,
  `middleName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `taskTypeID` int(11) NOT NULL,
  PRIMARY KEY (`taskingID`),
  KEY `employeeID_idx` (`employeeID`),
  KEY `taskTypeID_idx` (`taskTypeID`),
  CONSTRAINT `tasking_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employeeID`),
  CONSTRAINT `tasking_ibfk_2` FOREIGN KEY (`taskTypeID`) REFERENCES `tasktype` (`TaskTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasking`
--

LOCK TABLES `tasking` WRITE;
/*!40000 ALTER TABLE `tasking` DISABLE KEYS */;
/*!40000 ALTER TABLE `tasking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasktype`
--

DROP TABLE IF EXISTS `tasktype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tasktype` (
  `TaskTypeID` int(11) NOT NULL AUTO_INCREMENT,
  `taskDescription` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`TaskTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasktype`
--

LOCK TABLES `tasktype` WRITE;
/*!40000 ALTER TABLE `tasktype` DISABLE KEYS */;
/*!40000 ALTER TABLE `tasktype` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-01-03 20:02:07
