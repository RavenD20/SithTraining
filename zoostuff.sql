USE [CCC]
GO

/****** Object:  Schema [HR]    Script Date: 9/6/2017 8:41:51 PM ******/
CREATE SCHEMA [HR]
GO

create Table Animals
(AnimalID int not null identity (1,1),
AnimalType varchar (25),
NumberOfLegs int,
NumberOfDailyFeedings int
)

insert into Animals
(AnimalType, NumberOfLegs, NumberOfDailyFeedings) values
('Gorilla',2,4),
('Tiger',4,5),
('Kangaroo',2,3),
('Panther',4,3),
('Falcon',2,3)



select * from Animals;

 alter table Animals add FoodType varchar, CountryOfOrigin varchar
 

 
 
 update table Animals 
insert into food
  

select * from Zoo;

alter table Zoo add Location varchar, SquareMiles int

create Table Zoo
(ZooID int not null identity (1,1),
ZooName varchar (35),
SizeOfZoo varchar (20),
NumberOfCages int
)

truncate table zoo

insert into Zoo
(ZooName, SizeOfZoo, NumberOfCages) values
('SandiegoZoo','Large',700),
('SanFranscisoZoo','Large',600),
('ClevelandZoo','Small',100),
('NewYorkCityZoo','Large',650),
('CentralFloridaZoo','Medium',150)














