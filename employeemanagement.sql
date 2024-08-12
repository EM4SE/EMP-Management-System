-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Aug 12, 2024 at 01:20 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employeemanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `designations`
--

CREATE TABLE `designations` (
  `id` int(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci;

--
-- Dumping data for table `designations`
--

INSERT INTO `designations` (`id`, `name`, `description`) VALUES
(21, 'Chief Financial Officer (CFO)', 'Manages the company’s finances, including financial planning and reporting.'),
(22, 'Chief Operating Officer (COO)', 'Oversees the day-to-day operations and ensures business processes run '),
(23, 'General Manager (GM)', 'Manages overall operations of a business unit or location.\n'),
(24, 'Operations Manager', 'Oversees daily operations and ensures efficiency.'),
(25, 'Marketing Manager', 'Develops and implements marketing strategies.'),
(26, 'Sales Manager', 'Leads the sales team and manages sales strategies.'),
(27, 'Finance Manager', 'Manages financial planning and analysis for a department or unit.'),
(28, 'Human Resources Manage', 'Manages recruitment, employee relations, and HR policies.'),
(29, 'IT Manager', 'Oversees the IT department and manages technology infrastructure.'),
(30, 'Product Manager', ' Manages the development and lifecycle of a product.'),
(31, 'Customer Service Manager', 'Oversees customer service operations and support.'),
(32, 'Software Engineer', 'Develops and maintains software applications.'),
(33, 'Data Analyst', 'Analyzes data to support business decisions.'),
(34, 'Graphic Designer', 'Creates visual content for marketing and branding.'),
(36, 'Chief Executive Officer (CEO)', 'Oversees the overall operations and strategy of the company.');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `fullname` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `contact` int(20) NOT NULL,
  `address` text NOT NULL,
  `gender` varchar(20) NOT NULL,
  `dob` date NOT NULL,
  `designation` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `branch` varchar(255) NOT NULL,
  `dateOfJoin` date NOT NULL,
  `empType` varchar(255) NOT NULL,
  `empStatus` varchar(255) NOT NULL DEFAULT 'Active',
  `bankAccount` int(50) NOT NULL DEFAULT 10000
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `fullname`, `email`, `contact`, `address`, `gender`, `dob`, `designation`, `department`, `branch`, `dateOfJoin`, `empType`, `empStatus`, `bankAccount`) VALUES
(19, 'Anjana Ekanayaka', 'anjana@gmail.com', 756441389, 'A9 Road ,kandy', 'Male', '2000-02-01', 'Customer Service Manager', 'Marketing', 'Sales Office', '2024-08-11', 'Internship', 'Active', 10000),
(20, 'Hasitha Pathmasiri ', 'hasitha@gmail.com', 757207801, 'katugastota,kandy', 'Male', '2000-02-16', 'Data Analyst', 'Sales', 'Research and Development (R&D) Center', '2024-07-30', 'Temporary Employment', 'Active', 10000),
(21, 'Milinda Ekanayaka', 'milinda@gmail.com', 768831063, 'kandy,mathale', 'Female', '2000-02-01', 'IT Manager', 'Sales', 'Manufacturing Plant', '2024-08-11', 'Contract Employment', 'Active', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `name`, `password`) VALUES
('adminw', 'Anjana Ek', 'admin'),
('emase', 'Anjana\r\n', 'anjana2966'),
('user', 'Anjana ', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `designations`
--
ALTER TABLE `designations`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `designations`
--
ALTER TABLE `designations`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
