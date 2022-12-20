/*
SQLyog Community v12.09 (64 bit)
MySQL - 5.7.33-log : Database - laundrymanagement
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`laundrymanagement` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `laundrymanagement`;

/*Table structure for table `tblcustomers` */

DROP TABLE IF EXISTS `tblcustomers`;

CREATE TABLE `tblcustomers` (
  `CustomerID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Contact` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB AUTO_INCREMENT=1009 DEFAULT CHARSET=latin1;

/*Data for the table `tblcustomers` */

insert  into `tblcustomers`(`CustomerID`,`Name`,`Address`,`Contact`) values (1001,'Momo Bear','Apalit','09613536174'),(1003,'Ralph Maglalang','Calumpit','09876543211'),(1004,'Ralph','Apalit','09756167889'),(1006,'Lucho Luch','Macabebe','09999999990'),(1008,'Rochelle Apostol','Pampenga','09192349912');

/*Table structure for table `tblhistory` */

DROP TABLE IF EXISTS `tblhistory`;

CREATE TABLE `tblhistory` (
  `OrderNo` int(11) NOT NULL,
  `Date` date DEFAULT NULL,
  `CustomerID` varchar(10) DEFAULT NULL,
  `Machine` int(11) DEFAULT NULL,
  `Service` varchar(25) DEFAULT NULL,
  `Weight` float DEFAULT NULL,
  `Color` varchar(25) DEFAULT NULL,
  `Stains` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`OrderNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblhistory` */

insert  into `tblhistory`(`OrderNo`,`Date`,`CustomerID`,`Machine`,`Service`,`Weight`,`Color`,`Stains`) values (1,'2018-09-20','1001',2,'Wash',5.6,'White','Minimal'),(3,'2020-11-26','1001',4,'Dry',7.2,'Light','Minimal'),(5,'2020-02-04','1004',7,'Wash & Dry',7,'Dark','None'),(9,'2021-08-04','1003',8,'Dry',4.8,'Black','Heavy'),(18,'2021-08-04','1006',4,'Dry',6.6,'Dark','None'),(28,'2021-08-04','1004',4,'Wash & Dry',1,'White+Light','Medium');

/*Table structure for table `tblorders` */

DROP TABLE IF EXISTS `tblorders`;

CREATE TABLE `tblorders` (
  `OrderNo` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` varchar(10) DEFAULT NULL,
  `Machine` int(11) DEFAULT NULL,
  `Service` varchar(25) DEFAULT NULL,
  `Status` varchar(25) DEFAULT NULL,
  `Weight` float DEFAULT NULL,
  `Color` varchar(25) DEFAULT NULL,
  `Stains` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`OrderNo`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

/*Data for the table `tblorders` */

insert  into `tblorders`(`OrderNo`,`CustomerID`,`Machine`,`Service`,`Status`,`Weight`,`Color`,`Stains`) values (2,'1001',5,'Wash & Dry','For Pick Up',3,'Dark','None'),(4,'1001',3,'Wash & Dry','To pay',4,'Dark','Heavy'),(6,'1004',5,'Dry','On Going',4,'White','Light'),(13,'1006',4,'Wash','To Pay',1,'White','Medium'),(16,'1001',5,'Wash','On Going',1,'Light','None'),(26,'1006',4,'Dry','On Going',2,'Black','Light'),(27,'1006',1,'Wash & Dry','On Going',2,'Dark','Heavy'),(28,'1008',8,'Wash','To pay',1.8,'Light+Dark','Heavy');

/*Table structure for table `tblusers` */

DROP TABLE IF EXISTS `tblusers`;

CREATE TABLE `tblusers` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(25) DEFAULT NULL,
  `Password` varchar(25) DEFAULT NULL,
  `Type` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `tblusers` */

insert  into `tblusers`(`UserID`,`Username`,`Password`,`Type`) values (1,'admin','admin','admin'),(2,'user','user','user'),(3,'ralph','maglalang','admin'),(4,'rochelle','apostol','admin'),(5,'ferwinkle','intal','admin'),(6,'customer','lang','user');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
