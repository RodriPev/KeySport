-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: keysport
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `arbitro`
--

DROP TABLE IF EXISTS `arbitro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `arbitro` (
  `idArbitro` int(11) NOT NULL,
  `nomArbitro` varchar(15) DEFAULT NULL,
  `apelArbitro` varchar(15) DEFAULT NULL,
  `nacArbitro` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idArbitro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arbitro`
--

LOCK TABLES `arbitro` WRITE;
/*!40000 ALTER TABLE `arbitro` DISABLE KEYS */;
INSERT INTO `arbitro` VALUES (1,'Matias','Ripoll','1968'),(3404,'Raul','Raul','1980-12-12'),(372369,'Sergio','Rodriguez','1987-08-13');
/*!40000 ALTER TABLE `arbitro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campeonato`
--

DROP TABLE IF EXISTS `campeonato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `campeonato` (
  `idcampeonato` int(11) NOT NULL,
  `localidad` varchar(20) DEFAULT NULL,
  `nomCampeonato` varchar(20) DEFAULT NULL,
  `resultado` varchar(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `deporte` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idcampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campeonato`
--

LOCK TABLES `campeonato` WRITE;
/*!40000 ALTER TABLE `campeonato` DISABLE KEYS */;
INSERT INTO `campeonato` VALUES (0,'nulo','nulo','nulo','2001-01-01','nulo'),(73089,'Uruguay','Liga Uruguaya','En Tabla','0000-00-00','Futbol'),(435303,'Uruguay','Livosur','LobosPPC campeon','0000-00-00','Voleybol'),(807523,'Uruguay','Livosur G','LobosPPC campeon','2022-11-13','Voleybol');
/*!40000 ALTER TABLE `campeonato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `de`
--

DROP TABLE IF EXISTS `de`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `de` (
  `idNotificacion` int(11) DEFAULT NULL,
  `idEvento` int(11) DEFAULT NULL,
  KEY `idNotificacion` (`idNotificacion`),
  KEY `idEvento` (`idEvento`),
  CONSTRAINT `de_ibfk_1` FOREIGN KEY (`idNotificacion`) REFERENCES `notificacion` (`idNotificacion`),
  CONSTRAINT `de_ibfk_2` FOREIGN KEY (`idEvento`) REFERENCES `eventos` (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `de`
--

LOCK TABLES `de` WRITE;
/*!40000 ALTER TABLE `de` DISABLE KEYS */;
/*!40000 ALTER TABLE `de` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipo` (
  `idEquipo` int(11) NOT NULL,
  `nomEquipo` varchar(15) DEFAULT NULL,
  `nacEquipo` varchar(15) DEFAULT NULL,
  `cede` varchar(20) DEFAULT NULL,
  `alineacion` varchar(500) DEFAULT NULL,
  `deporte` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES (1,'LobosPPC','Uruguay','Polideportivo PC','6 en cancha, 2 suplentes',NULL),(2,'Soca','Uruguay','Cancha social Soca','6 en cancha, 3 suplentes',NULL),(199924,'Cerro','Uruguay','La villa del cerro','11 turros','Futbol'),(321591,'Areteia','Uruguay','col Areteia','6 en cancha','Voleybol'),(564441,'Danubio','Uruguay','Jardin del hipodomo','11 en cancha 7 suplentes',''),(590435,'Rodrigo','Pevere','11','1','--'),(718204,'Rodrigo','Pevere','11','1','--'),(763073,'Peñarol','Uruguay','CdS','11 en chancha 7 suplentes',''),(855170,'CACA','dada','sri','en 4','Futbol'),(861050,'Rodrigo','Pevere','11','1','--'),(894234,'enfoque','uruguaya','enfoque','6 en cancha 134 afuera (el)','Futbol'),(936782,'Peñarol Voley','Uruguay','PP','6 en cancha 9 suplentes','voleybol'),(938609,'Nacional','Uruguay','PC','11 en cancha 7 suplentes','Futbol'),(965727,'Rodrigo','Pevere','11','1','--'),(989162,'enfoque','uruguaya','enfoque','6 en cancha 134 afuera (el)','Voleybol');
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equiposcamp`
--

DROP TABLE IF EXISTS `equiposcamp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equiposcamp` (
  `idcampeonato` int(11) NOT NULL,
  `equipos` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idcampeonato`),
  CONSTRAINT `equiposcamp_ibfk_1` FOREIGN KEY (`idcampeonato`) REFERENCES `campeonato` (`idcampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equiposcamp`
--

LOCK TABLES `equiposcamp` WRITE;
/*!40000 ALTER TABLE `equiposcamp` DISABLE KEYS */;
/*!40000 ALTER TABLE `equiposcamp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventos`
--

DROP TABLE IF EXISTS `eventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `eventos` (
  `idEvento` int(11) NOT NULL,
  `fechain` date DEFAULT NULL,
  `fechafin` date DEFAULT NULL,
  `deporte` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventos`
--

LOCK TABLES `eventos` WRITE;
/*!40000 ALTER TABLE `eventos` DISABLE KEYS */;
/*!40000 ALTER TABLE `eventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fotos`
--

DROP TABLE IF EXISTS `fotos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fotos` (
  `imagen` varchar(60) NOT NULL,
  PRIMARY KEY (`imagen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fotos`
--

LOCK TABLES `fotos` WRITE;
/*!40000 ALTER TABLE `fotos` DISABLE KEYS */;
INSERT INTO `fotos` VALUES ('C:UsersLoloDesktopimagenes5'),('‪C:UsersLoloDesktopimagenes2.png');
/*!40000 ALTER TABLE `fotos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugador`
--

DROP TABLE IF EXISTS `jugador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jugador` (
  `idJugador` int(11) NOT NULL,
  `numCamiseta` varchar(2) DEFAULT NULL,
  `nomjugador` varchar(15) DEFAULT NULL,
  `apelJugador` varchar(15) DEFAULT NULL,
  `idEquipo` int(11) DEFAULT NULL,
  `fechaNac` date DEFAULT NULL,
  PRIMARY KEY (`idJugador`),
  KEY `idEquipo` (`idEquipo`),
  CONSTRAINT `jugador_ibfk_1` FOREIGN KEY (`idEquipo`) REFERENCES `equipo` (`idEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugador`
--

LOCK TABLES `jugador` WRITE;
/*!40000 ALTER TABLE `jugador` DISABLE KEYS */;
INSERT INTO `jugador` VALUES (10,'11','Rodrigo','Pevere',1,'2005-05-14'),(358062,'Ro','pevere','11',1,'0000-00-00'),(760829,'1','Emanuel','Etcheverria',1,'2004-12-01');
/*!40000 ALTER TABLE `jugador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manda`
--

DROP TABLE IF EXISTS `manda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `manda` (
  `idNotificacion` int(11) DEFAULT NULL,
  `idSuscripcion` int(11) DEFAULT NULL,
  KEY `idNotificacion` (`idNotificacion`),
  KEY `idSuscripcion` (`idSuscripcion`),
  CONSTRAINT `manda_ibfk_1` FOREIGN KEY (`idNotificacion`) REFERENCES `notificacion` (`idNotificacion`),
  CONSTRAINT `manda_ibfk_2` FOREIGN KEY (`idSuscripcion`) REFERENCES `suscripcion` (`idSuscripcion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manda`
--

LOCK TABLES `manda` WRITE;
/*!40000 ALTER TABLE `manda` DISABLE KEYS */;
/*!40000 ALTER TABLE `manda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mira`
--

DROP TABLE IF EXISTS `mira`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mira` (
  `idEvento` int(11) DEFAULT NULL,
  `ci` int(11) DEFAULT NULL,
  KEY `idEvento` (`idEvento`),
  KEY `ci` (`ci`),
  CONSTRAINT `mira_ibfk_1` FOREIGN KEY (`idEvento`) REFERENCES `eventos` (`idEvento`),
  CONSTRAINT `mira_ibfk_2` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mira`
--

LOCK TABLES `mira` WRITE;
/*!40000 ALTER TABLE `mira` DISABLE KEYS */;
/*!40000 ALTER TABLE `mira` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notificacion`
--

DROP TABLE IF EXISTS `notificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notificacion` (
  `idNotificacion` int(11) NOT NULL,
  PRIMARY KEY (`idNotificacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notificacion`
--

LOCK TABLES `notificacion` WRITE;
/*!40000 ALTER TABLE `notificacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `notificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partido`
--

DROP TABLE IF EXISTS `partido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `partido` (
  `idPartido` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` varchar(10) DEFAULT NULL,
  `resultadoPartido` varchar(50) DEFAULT NULL,
  `idArbitro` int(11) DEFAULT NULL,
  `idEquipo` int(11) DEFAULT NULL,
  `idEquipo2` int(11) DEFAULT NULL,
  `idCampeonato` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPartido`),
  KEY `idArbitro` (`idArbitro`),
  KEY `idEquipo` (`idEquipo`),
  KEY `idEquipo2` (`idEquipo2`),
  KEY `idCampeonato` (`idCampeonato`),
  CONSTRAINT `partido_ibfk_2` FOREIGN KEY (`idArbitro`) REFERENCES `arbitro` (`idArbitro`),
  CONSTRAINT `partido_ibfk_3` FOREIGN KEY (`idEquipo`) REFERENCES `equipo` (`idEquipo`),
  CONSTRAINT `partido_ibfk_4` FOREIGN KEY (`idEquipo2`) REFERENCES `equipo` (`idEquipo`),
  CONSTRAINT `partido_ibfk_5` FOREIGN KEY (`idCampeonato`) REFERENCES `campeonato` (`idcampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partido`
--

LOCK TABLES `partido` WRITE;
/*!40000 ALTER TABLE `partido` DISABLE KEYS */;
INSERT INTO `partido` VALUES (1,'0000-00-00','16:20','3-2',1,NULL,NULL,NULL),(2,'0000-00-00','12:00','3-0',1,NULL,NULL,NULL),(223,'2022-11-08','12:00','Lobos 3-0 Eclipse',1,NULL,NULL,NULL),(1000,'0000-00-00','16:20','3-2',1,NULL,NULL,NULL),(1700,'0000-00-00','16:20','3-2',1,NULL,NULL,NULL),(1740,'0000-00-00','16:20','3-2',1,NULL,NULL,NULL),(1741,'0000-00-00','16:20','3-2',1,NULL,NULL,NULL),(1746,'2022-01-10','16:20','Lobos 3-2 Soca',1,1,2,NULL),(332777,'2022-09-12','12:00','LobosPPC 3-0 Areteia',1,1,321591,0),(673422,'2022-09-10','20:00','LobosPPC 3-1 Peñarol',1,1,936782,807523),(673423,'2022-02-10','20:00','LobosPPC 2-3 Peñarol',1,1,936782,0),(673555,'2022-08-10','20:00','Soca 0-3 Peñarol',1,2,936782,807523),(673955,'2022-10-01','20:00','Soca 0-3 Peñarol',1,2,936782,807523),(990469,'2022-11-12','12:30','Peñarol 5-0 Danubio',1,763073,564441,NULL);
/*!40000 ALTER TABLE `partido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `ci` int(11) NOT NULL,
  `nombre` varchar(15) DEFAULT NULL,
  `apellido` varchar(15) DEFAULT NULL,
  `FechaNac` date DEFAULT NULL,
  `nacionalidad` varchar(15) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `contrasenia` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (0,'\" + txtnom.Text','\"+txtapel.Text+','0000-00-00','\"+txtnac.Text+\"','\"+txtNewUsuario.Text+ \"','\"+txtNewContra.Text+'),(1,'Pitu','Ripoll','0000-00-00','uruguay','PituR@gmail.com','DanubioPasion'),(2,'Pitu','Ripoll','0000-00-00','uruguay','PituR@gmail.com','DanubioPasion'),(3,'Pitu','Ripoll','2000-12-22','uruguay','PituR@gmail.com','DanubioPasion'),(10,'Pedoo','Dominguez','0000-00-00','Uruguay','A@gmail.com','dsa'),(13,'A','A','2005-12-12','a','lolopevere@hotmail.com','a'),(73,'\" + txtnom.Text','\"+txtapel.Text+','0000-00-00','\"+txtnac.Text+\"','\"+txtNewUsuario.Text+ \"','\"+txtNewContra.Text+'),(424,'A','A','2008-12-12','a','mojoripoll1420@gmail.com','aa'),(523,'A','A','2008-12-12','a','mojoripoll1420@hotmail.com','a'),(548,'A','A','2000-12-12','a','lolopevere@hotmail.com','a'),(710,'Rodri','Pev','2022-03-10','Uruguay','lobos@gmail.com','loboss'),(875,'A','A','2000-12-12','a','lolopevere@hotmail.com','a'),(1234,'Abril','Fernandez','2003-02-12','Brazil','Abril@gmail.com','qwe'),(1624,'A','A','2002-12-12','a','lolopevere@hotmail.com','a'),(2520,'Pedoo','Dominguez','1994-05-09','Uruguay','A@gmail.com','dsa'),(6909,'Aa','Aa','2000-10-12','aa','mojoripoll1420@gmail.com','aa'),(7346,'\" + txtnom.Text','\"+txtapel.Text+','0000-00-00','\"+txtnac.Text+\"','\"+txtNewUsuario.Text+ \"','\"+txtNewContra.Text+'),(8246,'A','A','2002-12-12','a','lolopevere@hotmail.com','a'),(8762,'Asda','Asda','2000-12-12','asda','lolopevere@hotmail.com','sdas'),(9638,'A','A','2002-12-12','a','lolopevere@hotmail.com','a'),(9846,'A','A','2009-12-12','a','lolopevere@hotmail.com','a'),(12120,'Pedoo','Dominguez','0000-00-00','Uruguay','A@gmail.com','dsa'),(12324,'Rodrigo','Pevere','2005-05-14','uruguay','rodri@gmail.com','asd'),(32545,'A','A','2008-12-12','a','lolopevere@hotmail.com','aa'),(98765,'Rodrigo','Pevere','2005-05-12','Uruguayo','lolopevere@hotmail.com','Lolo1212'),(112523,'Agustin','Etcheverry','1997-08-12','argentina','Agus@gmail.com','ABC'),(121230,'Pedoo','Dominguez','0000-00-00','Uruguay','A@gmail.com','dsa'),(122442,'A','A','2002-12-12','a','lolopevere@hotmail.com','a'),(123141,'Aa','Aa','2000-12-12','AA','lolopevere@hotmail.com','fdffsf'),(254220,'Pedoo','Dominguez','0000-00-00','Uruguay','A@gmail.com','dsa'),(765765,'Walter','Etcheverria','2004-12-01','Mongolia','Walter@gmail.com','0000'),(1009999,'Ivan','Ibañez','1978-01-12','jamaica','Integer@gmail.com','111'),(1212121,'a','a','1999-02-12','a','a','a'),(2542120,'Pedoo','Dominguez','0000-00-00','Uruguay','A@gmail.com','dsa'),(5477801,'Joaquin','Fernandez','2000-10-10','Suizo','joaco20@gmail.com','1234'),(5556667,'Ajo','Morron','1990-02-16','argentina','pitufin@gmail.com','123'),(54139876,'Maite','Rodriguez','2004-01-14','Uruguaya','Mai@gmail.com','Maite1234');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puede`
--

DROP TABLE IF EXISTS `puede`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puede` (
  `idSuscripcion` int(11) DEFAULT NULL,
  `ci` int(11) DEFAULT NULL,
  KEY `idSuscripcion` (`idSuscripcion`),
  KEY `ci` (`ci`),
  CONSTRAINT `puede_ibfk_1` FOREIGN KEY (`idSuscripcion`) REFERENCES `suscripcion` (`idSuscripcion`),
  CONSTRAINT `puede_ibfk_2` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puede`
--

LOCK TABLES `puede` WRITE;
/*!40000 ALTER TABLE `puede` DISABLE KEYS */;
INSERT INTO `puede` VALUES (1000010,54139876),(798535,1212121);
/*!40000 ALTER TABLE `puede` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscam`
--

DROP TABLE IF EXISTS `suscam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suscam` (
  `ci` int(11) DEFAULT NULL,
  `idCampeonato` int(11) DEFAULT NULL,
  KEY `ci` (`ci`),
  KEY `idCampeonato` (`idCampeonato`),
  CONSTRAINT `suscam_ibfk_1` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`),
  CONSTRAINT `suscam_ibfk_2` FOREIGN KEY (`idCampeonato`) REFERENCES `campeonato` (`idcampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscam`
--

LOCK TABLES `suscam` WRITE;
/*!40000 ALTER TABLE `suscam` DISABLE KEYS */;
/*!40000 ALTER TABLE `suscam` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscripcion`
--

DROP TABLE IF EXISTS `suscripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suscripcion` (
  `idSuscripcion` int(11) NOT NULL,
  `plan` varchar(50) DEFAULT NULL,
  `numTarjeta` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSuscripcion`),
  KEY `numTarjeta` (`numTarjeta`),
  CONSTRAINT `suscripcion_ibfk_1` FOREIGN KEY (`numTarjeta`) REFERENCES `tarjetacredito` (`numTarjeta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscripcion`
--

LOCK TABLES `suscripcion` WRITE;
/*!40000 ALTER TABLE `suscripcion` DISABLE KEYS */;
INSERT INTO `suscripcion` VALUES (0,'1 segundo',12411800),(2,'3 dias',55487),(6847,'Dentro de x años',6842),(95177,'2 segundos',95172),(228215,'7 años',119922),(362519,'2 meses',362514),(626960,'Permanente',16312),(798535,'Anual',46752),(951758,'2 segundos',951753),(966712,'1 mes',2121444),(1000010,'12 dias',1242),(9854758,'3 dias',9854753);
/*!40000 ALTER TABLE `suscripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tabla`
--

DROP TABLE IF EXISTS `tabla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tabla` (
  `id` int(11) NOT NULL,
  `idEquipo` int(11) DEFAULT NULL,
  `idCamp` int(11) DEFAULT NULL,
  `posicion` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idEquipo` (`idEquipo`),
  KEY `idCamp` (`idCamp`),
  CONSTRAINT `tabla_ibfk_1` FOREIGN KEY (`idEquipo`) REFERENCES `equipo` (`idEquipo`),
  CONSTRAINT `tabla_ibfk_2` FOREIGN KEY (`idCamp`) REFERENCES `campeonato` (`idcampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tabla`
--

LOCK TABLES `tabla` WRITE;
/*!40000 ALTER TABLE `tabla` DISABLE KEYS */;
INSERT INTO `tabla` VALUES (100040,1,807523,1),(642387,321591,807523,3),(897511,989162,807523,5);
/*!40000 ALTER TABLE `tabla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarjetacredito`
--

DROP TABLE IF EXISTS `tarjetacredito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tarjetacredito` (
  `numTarjeta` int(11) NOT NULL,
  `fechaVen` date DEFAULT NULL,
  PRIMARY KEY (`numTarjeta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarjetacredito`
--

LOCK TABLES `tarjetacredito` WRITE;
/*!40000 ALTER TABLE `tarjetacredito` DISABLE KEYS */;
INSERT INTO `tarjetacredito` VALUES (0,'0000-00-00'),(12,'2024-06-07'),(123,'2029-02-02'),(1242,'0000-00-00'),(1243,'2000-12-12'),(6842,'2022-12-12'),(12341,'2029-12-12'),(16312,'0000-00-00'),(46752,'0000-00-00'),(55487,'2020-12-12'),(95172,'2099-12-12'),(112265,'2099-12-12'),(119922,'2022-12-12'),(362514,'2029-12-12'),(654987,'2024-09-09'),(951753,'2099-12-12'),(984532,'2022-09-08'),(2121444,'0000-00-00'),(9854753,'2090-12-12'),(12411800,'2023-12-08'),(123456789,'2022-12-12');
/*!40000 ALTER TABLE `tarjetacredito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiene` (
  `idEvento` int(11) DEFAULT NULL,
  `idCampeonato` int(11) DEFAULT NULL,
  KEY `idEvento` (`idEvento`),
  KEY `idCampeonato` (`idCampeonato`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`idEvento`) REFERENCES `eventos` (`idEvento`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`idCampeonato`) REFERENCES `campeonato` (`idcampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usa`
--

DROP TABLE IF EXISTS `usa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usa` (
  `numTarjeta` int(11) DEFAULT NULL,
  `ci` int(11) DEFAULT NULL,
  KEY `numTarjeta` (`numTarjeta`),
  KEY `ci` (`ci`),
  CONSTRAINT `usa_ibfk_1` FOREIGN KEY (`numTarjeta`) REFERENCES `tarjetacredito` (`numTarjeta`),
  CONSTRAINT `usa_ibfk_2` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usa`
--

LOCK TABLES `usa` WRITE;
/*!40000 ALTER TABLE `usa` DISABLE KEYS */;
INSERT INTO `usa` VALUES (2121444,5556667),(46752,1212121);
/*!40000 ALTER TABLE `usa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vende`
--

DROP TABLE IF EXISTS `vende`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vende` (
  `ci` int(11) DEFAULT NULL,
  `imagen` varchar(60) DEFAULT NULL,
  KEY `imagen` (`imagen`),
  KEY `ci` (`ci`),
  CONSTRAINT `vende_ibfk_1` FOREIGN KEY (`imagen`) REFERENCES `fotos` (`imagen`),
  CONSTRAINT `vende_ibfk_2` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vende`
--

LOCK TABLES `vende` WRITE;
/*!40000 ALTER TABLE `vende` DISABLE KEYS */;
/*!40000 ALTER TABLE `vende` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-07 13:20:03
