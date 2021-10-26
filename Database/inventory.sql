-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 11, 2021 at 03:14 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `loyalty`
--

CREATE TABLE IF NOT EXISTS `loyalty` (
  `customer_id` int(10) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `registered` date NOT NULL,
  `points` int(10) NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `loyalty`
--

INSERT INTO `loyalty` (`customer_id`, `first_name`, `last_name`, `contact`, `address`, `registered`, `points`) VALUES
(6, 'Roger', 'Onol', '09317322424', 'Alaminos, Laguna', '2021-02-11', 10),
(7, 'Geriko', 'Ticzon', '09123457654', 'San Pablo, Laguna', '2021-02-11', 10),
(8, 'John Nasser', 'Fuentes', '09765345653', 'San Pablo, Laguna', '2021-02-11', 10),
(9, 'Kyrie Elleison', 'Advincula', '09238765234', 'San Pablo, Laguna', '2021-02-11', 10),
(10, 'Mon', 'Conservado', '09345675256', 'San Pablo, Laguna', '2021-02-11', 10);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `product_id` int(10) NOT NULL AUTO_INCREMENT,
  `product_name` varchar(100) NOT NULL,
  `product_price` int(10) NOT NULL,
  `product_stocks` int(10) NOT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_id`, `product_name`, `product_price`, `product_stocks`) VALUES
(7, 'Earphone', 70, 10),
(8, 'Micro USB Cable', 100, 5),
(9, 'Diamond Painting', 120, 2),
(10, 'Air Soft Toy Gun', 90, 10),
(11, 'Overrun T-Shirt', 250, 5),
(12, 'Drifit Short', 180, 1),
(13, '1TB Seagate Portable Hard Drive', 2500, 1);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE IF NOT EXISTS `transaction` (
  `customer_id` int(10) NOT NULL,
  `product_id` int(10) NOT NULL,
  `price` int(10) NOT NULL,
  `quantity` int(10) NOT NULL,
  `date_purchased` date NOT NULL,
  `type` varchar(100) NOT NULL,
  `points_earned` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`customer_id`, `product_id`, `price`, `quantity`, `date_purchased`, `type`, `points_earned`) VALUES
(6, 7, 70, 1, '2021-02-11', 'member', 1),
(7, 8, 100, 3, '2021-02-11', 'member', 6),
(8, 9, 120, 1, '2021-02-11', 'member', 2),
(9, 10, 90, 1, '2021-02-11', 'member', 2),
(10, 11, 250, 2, '2021-02-11', 'member', 10);
