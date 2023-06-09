-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: myuniversity
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (1,'Mahabuba Joty','root','Mogbazar','mahabuba@gmail.com');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `class` (
  `ClassID` int(11) NOT NULL,
  `CourseID` int(11) DEFAULT NULL,
  `Time` varchar(20) DEFAULT NULL,
  `WeekDays` varchar(20) DEFAULT NULL,
  `Capacity` int(11) DEFAULT NULL,
  `Enrolled` int(11) DEFAULT NULL,
  `Status` bit(1) DEFAULT NULL,
  `TeacherID` varchar(9) DEFAULT NULL,
  `RoomNo` int(4) DEFAULT NULL,
  `Sunday` int(11) DEFAULT NULL,
  `Monday` int(11) DEFAULT NULL,
  `Tuesday` int(11) DEFAULT NULL,
  `Wednesday` int(11) DEFAULT NULL,
  `Thursday` int(11) DEFAULT NULL,
  `semester` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ClassID`),
  KEY `CourseID` (`CourseID`),
  KEY `TeacherID` (`TeacherID`),
  CONSTRAINT `class_ibfk_1` FOREIGN KEY (`CourseID`) REFERENCES `course` (`CourseID`),
  CONSTRAINT `class_ibfk_2` FOREIGN KEY (`TeacherID`) REFERENCES `teacher` (`TeacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class`
--

LOCK TABLES `class` WRITE;
/*!40000 ALTER TABLE `class` DISABLE KEYS */;
INSERT INTO `class` VALUES (0,0,'0','0',0,0,'\0','0',0,0,0,0,0,0,'Spring 2018'),(1,1,'8-11','S-T',40,2,'','18-0002',3011,1,0,1,0,0,'Spring 2018'),(2,1,'11-2','S-T',40,0,'','18-0002',3011,1,0,1,0,0,'Spring 2018'),(3,2,'8-11','M-W',40,2,'','18-0001',3011,0,1,0,1,0,'Spring 2018'),(4,2,'11-2','M-W',40,0,'','18-0001',3011,0,1,0,1,0,'Spring 2018'),(5,3,'8-11','S-T',40,40,'\0','18-0001',3011,1,0,1,0,0,'Fall 2017'),(6,4,'8-11','M-W',40,40,'\0','18-0001',3011,1,0,1,0,0,'Fall 2017'),(7,6,'11-2','S-T',40,40,'\0','18-0001',3011,1,0,1,0,0,'Fall 2017'),(8,7,'11-2','M-W',40,40,'\0','18-0001',3011,1,0,1,0,0,'Fall 2017'),(9,9,'2-3.30','S-T',40,40,'\0','18-0001',3011,1,0,1,0,0,'Fall 2017'),(10,5,'8-10','S-T',40,40,'\0','18-0001',3011,1,0,1,0,0,'Summer 2017'),(11,8,'10-12','S-T',40,40,'\0','18-0001',3011,1,0,1,0,0,'Summer 2017'),(12,14,'12-2','S-T',40,40,'\0','18-0001',3011,1,0,1,0,1,'Summer 2017'),(13,1,'8-11','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(14,1,'11-2','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(15,1,'2-5','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(16,2,'8-11','M-T',40,0,'\0','18-0001',3011,0,1,0,1,0,'Summer 2018'),(17,2,'11-2','M-T',40,0,'\0','18-0001',3011,0,1,0,1,0,'Summer 2018'),(18,2,'2-5','M-T',40,0,'\0','18-0001',3011,0,1,0,1,0,'Summer 2018'),(19,10,'8-10','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(20,10,'10-12','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(21,10,'12-2','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(22,11,'8-10','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(23,12,'8-10','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(24,13,'8-10','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(25,15,'8-10','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018'),(26,15,'10-12','S-T',40,0,'\0','18-0001',3011,1,0,1,0,0,'Summer 2018');
/*!40000 ALTER TABLE `class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `complain`
--

DROP TABLE IF EXISTS `complain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `complain` (
  `complainText` varchar(100) DEFAULT NULL,
  `ID` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `complain`
--

LOCK TABLES `complain` WRITE;
/*!40000 ALTER TABLE `complain` DISABLE KEYS */;
INSERT INTO `complain` VALUES ('Khub problem e asi bhaaii... ','Annonymas'),('How are you ??','18-0001-1'),('','Annonymas'),('','Annonymas');
/*!40000 ALTER TABLE `complain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course` (
  `CourseID` int(11) NOT NULL,
  `Name` varchar(25) DEFAULT NULL,
  `Credit` int(11) DEFAULT NULL,
  `Department` varchar(25) DEFAULT NULL,
  `preReq` int(11) DEFAULT NULL,
  PRIMARY KEY (`CourseID`),
  KEY `preReq` (`preReq`),
  CONSTRAINT `course_ibfk_1` FOREIGN KEY (`preReq`) REFERENCES `course` (`CourseID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` VALUES (0,'0',0,'0',0),(1,'Data Structures',3,'Computer Science',4),(2,'OOP2',3,'Computer Science',3),(3,'OOP1',3,'Computer Science',4),(4,'C++',3,'Computer Science',5),(5,'C',3,'Computer Science',0),(6,'Data Base',3,'Computer Science',5),(7,'Algorithm',3,'Computer Science',4),(8,'Diff Calculas',3,'Mathmetics',0),(9,'Int Calculas',3,'Mathmetics',8),(10,'Complex Variable',3,'Mathmetics',9),(11,'Matrices',3,'Mathmetics',10),(12,'Engineering Math',3,'Mathmetics',11),(13,'CS Math',3,'Computer Science',12),(14,'English 1',3,'English',0),(15,'English 2',3,'English',14);
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deletetable`
--

DROP TABLE IF EXISTS `deletetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deletetable` (
  `adminId` int(11) DEFAULT NULL,
  `deleteElement` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deletetable`
--

LOCK TABLES `deletetable` WRITE;
/*!40000 ALTER TABLE `deletetable` DISABLE KEYS */;
/*!40000 ALTER TABLE `deletetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gradetable`
--

DROP TABLE IF EXISTS `gradetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gradetable` (
  `sID` varchar(10) DEFAULT NULL,
  `classID` int(11) DEFAULT NULL,
  `Grade` varchar(2) DEFAULT NULL,
  `pk` varchar(2) NOT NULL,
  PRIMARY KEY (`pk`),
  KEY `sID` (`sID`),
  KEY `classID` (`classID`),
  CONSTRAINT `gradetable_ibfk_1` FOREIGN KEY (`sID`) REFERENCES `student` (`StudentID`),
  CONSTRAINT `gradetable_ibfk_2` FOREIGN KEY (`classID`) REFERENCES `class` (`ClassID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gradetable`
--

LOCK TABLES `gradetable` WRITE;
/*!40000 ALTER TABLE `gradetable` DISABLE KEYS */;
INSERT INTO `gradetable` VALUES ('18-0001-1',5,'A+','1'),('18-0001-1',6,'A+','2'),('18-0001-1',7,'C','3'),('18-0001-1',8,'C-','4'),('18-0001-1',9,'D','5'),('18-0001-1',10,'A+','6'),('18-0001-1',11,'B+','7'),('18-0001-1',12,'B','8');
/*!40000 ALTER TABLE `gradetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lendbook`
--

DROP TABLE IF EXISTS `lendbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lendbook` (
  `ID` int(11) NOT NULL,
  `BookName` varchar(50) DEFAULT NULL,
  `SID` varchar(45) DEFAULT NULL,
  `LendedDate` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lendbook`
--

LOCK TABLES `lendbook` WRITE;
/*!40000 ALTER TABLE `lendbook` DISABLE KEYS */;
INSERT INTO `lendbook` VALUES (2,'Let Us C','18-0001-1','2017-04-29'),(3,'Let Us C','18-0001-1','2018-04-29');
/*!40000 ALTER TABLE `lendbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `librarian`
--

DROP TABLE IF EXISTS `librarian`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `librarian` (
  `LibrarianID` int(11) NOT NULL,
  `name` varchar(40) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `gender` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  PRIMARY KEY (`LibrarianID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `librarian`
--

LOCK TABLES `librarian` WRITE;
/*!40000 ALTER TABLE `librarian` DISABLE KEYS */;
INSERT INTO `librarian` VALUES (1,'Ashraf Mishbah','root','Male','ashraf@gmail.com',10000);
/*!40000 ALTER TABLE `librarian` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `library`
--

DROP TABLE IF EXISTS `library`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `library` (
  `BookID` int(3) NOT NULL,
  `BookName` varchar(50) DEFAULT NULL,
  `Author` varchar(50) DEFAULT NULL,
  `Available` int(3) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `library`
--

LOCK TABLES `library` WRITE;
/*!40000 ALTER TABLE `library` DISABLE KEYS */;
INSERT INTO `library` VALUES (1,'Let Us C','Yashavant Kanetkar',7,'Study'),(2,'Shongkho Nil Karagar','Humayun Ahmed',5,'Novel'),(3,'Discrete Math','Tanvir Mahmud Khan',10,'Study'),(4,'Badshah Namdar','Humayun Ahmed',5,'Novel'),(5,'Java Programming','Tanvir Mahmud Khan',1,'Study'),(6,'Advance Programming','Imon',2,'Study'),(7,'Database in Advance','Joty',2,'Study'),(8,'Nondito Noroke','Humayun Ahmed',14,'Novel'),(9,'Ami Topu','Jafar Iqbal',2,'Novel'),(10,'Notun Boi','Tanvir Mahmud Khan',2,'Novel');
/*!40000 ALTER TABLE `library` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libraryincome`
--

DROP TABLE IF EXISTS `libraryincome`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `libraryincome` (
  `Date` date DEFAULT NULL,
  `income` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libraryincome`
--

LOCK TABLES `libraryincome` WRITE;
/*!40000 ALTER TABLE `libraryincome` DISABLE KEYS */;
INSERT INTO `libraryincome` VALUES ('2018-04-30',7300);
/*!40000 ALTER TABLE `libraryincome` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `messages`
--

DROP TABLE IF EXISTS `messages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `messages` (
  `sID` varchar(10) DEFAULT NULL,
  `tID` varchar(9) DEFAULT NULL,
  `texts` varchar(50) DEFAULT NULL,
  `seen` int(1) DEFAULT NULL,
  `toTeacher` int(1) DEFAULT NULL,
  `toStudent` int(1) DEFAULT NULL,
  KEY `sID` (`sID`),
  KEY `tID` (`tID`),
  CONSTRAINT `messages_ibfk_1` FOREIGN KEY (`sID`) REFERENCES `student` (`StudentID`),
  CONSTRAINT `messages_ibfk_2` FOREIGN KEY (`tID`) REFERENCES `teacher` (`TeacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `messages`
--

LOCK TABLES `messages` WRITE;
/*!40000 ALTER TABLE `messages` DISABLE KEYS */;
INSERT INTO `messages` VALUES ('18-0001-1','18-0002','gggrggrgr',0,1,0),('18-0001-1','18-0002','',0,1,0),('18-0001-1','18-0001','bbtgb',0,1,0);
/*!40000 ALTER TABLE `messages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingtable`
--

DROP TABLE IF EXISTS `ratingtable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingtable` (
  `sID` varchar(10) DEFAULT NULL,
  `tID` varchar(9) DEFAULT NULL,
  `done` int(1) DEFAULT NULL,
  KEY `sID` (`sID`),
  KEY `tID` (`tID`),
  CONSTRAINT `ratingtable_ibfk_1` FOREIGN KEY (`sID`) REFERENCES `student` (`StudentID`),
  CONSTRAINT `ratingtable_ibfk_2` FOREIGN KEY (`tID`) REFERENCES `teacher` (`TeacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingtable`
--

LOCK TABLES `ratingtable` WRITE;
/*!40000 ALTER TABLE `ratingtable` DISABLE KEYS */;
INSERT INTO `ratingtable` VALUES ('18-0001-1','18-0002',0),('18-0001-1','18-0001',0);
/*!40000 ALTER TABLE `ratingtable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `semester`
--

DROP TABLE IF EXISTS `semester`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `semester` (
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semester`
--

LOCK TABLES `semester` WRITE;
/*!40000 ALTER TABLE `semester` DISABLE KEYS */;
INSERT INTO `semester` VALUES ('Fall 2017'),('Spring 2018'),('Summer 2017');
/*!40000 ALTER TABLE `semester` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student` (
  `StudentID` varchar(10) NOT NULL,
  `FirstName` varchar(10) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `Department` varchar(20) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `Gender` varchar(6) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `NID` varchar(30) DEFAULT NULL,
  `cgpa` double DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `ClassID1` int(11) DEFAULT NULL,
  `ClassID2` int(11) DEFAULT NULL,
  `ClassID3` int(11) DEFAULT NULL,
  `ClassID4` int(11) DEFAULT NULL,
  `ClassID5` int(11) DEFAULT NULL,
  `ClassID6` int(11) DEFAULT NULL,
  `ClassID7` int(11) DEFAULT NULL,
  `ClassID8` int(11) DEFAULT NULL,
  `totalCredit` int(3) DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  KEY `ClassID1` (`ClassID1`),
  KEY `ClassID2` (`ClassID2`),
  KEY `ClassID3` (`ClassID3`),
  KEY `ClassID4` (`ClassID4`),
  KEY `ClassID5` (`ClassID5`),
  KEY `ClassID6` (`ClassID6`),
  KEY `ClassID7` (`ClassID7`),
  KEY `ClassID8` (`ClassID8`),
  CONSTRAINT `student_ibfk_1` FOREIGN KEY (`ClassID1`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_2` FOREIGN KEY (`ClassID2`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_3` FOREIGN KEY (`ClassID3`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_4` FOREIGN KEY (`ClassID4`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_5` FOREIGN KEY (`ClassID5`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_6` FOREIGN KEY (`ClassID6`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_7` FOREIGN KEY (`ClassID7`) REFERENCES `class` (`ClassID`),
  CONSTRAINT `student_ibfk_8` FOREIGN KEY (`ClassID8`) REFERENCES `class` (`ClassID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES ('18-0001-1','Tanvir','Mahmud Khan','Computer Science','root','Male','Mirpur, Dhaka','8212',3.78,'01554035483','sajid8212@gmail.com',1,3,0,0,0,0,0,0,15),('18-0002-1','Imon','Parvez','Computer Science','root','Male','Dhanmondi, Dhaka','8212',3.5,'01554035483','sajid8212@gmail.com',1,3,0,0,0,0,0,0,120);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teacher` (
  `TeacherId` varchar(9) NOT NULL,
  `FirstName` varchar(10) DEFAULT NULL,
  `LastName` varchar(10) DEFAULT NULL,
  `Department` varchar(20) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `Gender` varchar(6) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `NID` varchar(30) DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  `joiningDate` varchar(50) DEFAULT NULL,
  `DOB` varchar(50) DEFAULT NULL,
  `rating` double DEFAULT NULL,
  `nRating` int(11) DEFAULT NULL,
  PRIMARY KEY (`TeacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES ('0',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),('18-0001','Asif','Ur Rahman','Computer Science','root','Male','Mirpur, Dhaka','8212','01554035483','asif@aiub.edu',80000,'2018-01-01','1985-01-01',3,2),('18-0002','Shamsur','Rahim','Computer Science','root','Male','Mirpur, Dhaka','8212','01554035483','shamsur@aiub.edu',80000,'2018-01-01','1985-01-01',1.5,8);
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `total`
--

DROP TABLE IF EXISTS `total`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `total` (
  `TotalStudents` int(11) DEFAULT NULL,
  `TotalTeacher` int(11) DEFAULT NULL,
  `pk` int(11) NOT NULL,
  `totalLibrarian` int(11) DEFAULT NULL,
  `totalCourse` int(11) DEFAULT NULL,
  `totalBook` int(11) DEFAULT NULL,
  `totalLendBook` int(11) DEFAULT NULL,
  PRIMARY KEY (`pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `total`
--

LOCK TABLES `total` WRITE;
/*!40000 ALTER TABLE `total` DISABLE KEYS */;
INSERT INTO `total` VALUES (2,2,1,1,15,10,3);
/*!40000 ALTER TABLE `total` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-30  0:34:44
