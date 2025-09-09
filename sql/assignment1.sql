-- Task 0 :-
--  creating database

create database task
 use task
 create table customers(
 customerId int primary key,
 name varchar(50) ,
 address varchar(100) ,
 region varchar(15) 
 )

 create table SmartMeterReadings(
  meterId int primary key,
  customerId int ,
  location varchar(50) ,
  installedDate DATE ,
  readDateTime Datetime,
  energyConsumed float 
  )


  INSERT INTO Customers (customerId, name, address, region) VALUES
(1, 'Shreyansh', '123 Park Street', 'East'),
(2, 'Ghosh', '45 Lake View', 'North'),
(3, 'Challa', '78 Hill Road', 'South'),
(4, 'Sahil', '56 Green Valley', 'West'),
(5, 'Nabhi', '12 River Bank', 'East'),
(6, 'Poojita', '34 Garden Lane', 'South'),
(7, 'Felix', '90 Ocean Drive', 'West'),
(8, 'Ravi', '67 Mountain Top', 'North');

INSERT INTO SmartMeterReadings (meterId, customerId, location, installedDate, readDateTime, energyConsumed) VALUES
(101, 1, 'Kolkata', '2022-01-15', '2025-09-01 08:30:00', 120.5),
(102, 2, 'Delhi', '2022-02-10', '2025-09-02 09:15:00', 98.7),
(103, 3, 'Hyderabad', '2022-03-20', '2025-09-03 10:45:00', 145.3),
(104, 4, 'Mumbai', '2022-04-12', '2025-09-04 11:20:00', 87.6),
(105, 5, 'Chennai', '2022-05-18', '2025-09-05 12:00:00', 132.8),
(106, 6, 'Bangalore', '2022-06-22', '2025-09-06 13:40:00', 156.4),
(107, 7, 'Pune', '2022-07-30', '2025-09-07 14:10:00', 110.2),
(108, 8, 'Jaipur', '2022-08-25', '2025-09-08 15:30:00', 123.9);


-- Task 1 :- 
-- filtering data

select * from customers

select * from SmartMeterReadings 



select * from SmartMeterReadings where energyConsumed between 10 and 150


select * from SmartMeterReadings where installedDate > '2024-04-09'


-- Task 2 :-
-- using aggregate function 

select avg(energyConsumed)  from SmartMeterReadings

select max(energyConsumed)  from SmartMeterReadings

select * from SmartMeterReadings where year(readDateTime) = YEAR(getdate())
