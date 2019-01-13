# aspnetcore-reactjs-employee
Sample Employee Management System with ASP.NET Core, ReactJS, EntityFrameworkCore

## Prerequisites
- Visual Studio 2017 with .NETCore 2.X
- Node.js
- SQL Server
- SQL ServerM anagement Studio

## Create database tables

- using SQL Server  Management Studio create a new database POC
- create __City__ and __Employee__ tables

```
USE POC

CREATE TABLE City (      
CityID int IDENTITY(1,1) NOT NULL PRIMARY KEY,      
CityName varchar(20) NOT NULL       
)

CREATE TABLE Employee (      
EmployeeID int IDENTITY(1,1) NOT NULL PRIMARY KEY,      
FirstName varchar(20) NOT NULL ,      
LasttName varchar(20) NOT NULL ,      
CityId int ,
constraint FK_Employee_City_Id foreign key (CityId) references City(CityId)
)

```

- insert data into __City__ and __Employee__ tables

```
INSERT INTO City VALUES('Montreal')
INSERT INTO City VALUES('Bucharest')

INSERT INTO Employee VALUES ('John', 'Smith', 1)
INSERT INTO Employee VALUES ('Ion', 'Ionescu', 2)
```
