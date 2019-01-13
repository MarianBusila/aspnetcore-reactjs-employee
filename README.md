# aspnetcore-reactjs-employee
Sample Employee Management System with ASP.NET Core, ReactJS, EntityFrameworkCore

## Prerequisites
- Visual Studio 2017 with .NETCore 2.X
- Node.js
- SQL Server
- SQL ServerM anagement Studio

## Create database tables

- using SQL Server  Management Studio create a new database POC
- create __Cities__ and __Employees__ tables

```
USE POC

CREATE TABLE Cities (      
CityID int IDENTITY(1,1) NOT NULL PRIMARY KEY,      
CityName varchar(20) NOT NULL       
)

CREATE TABLE Employees (      
EmployeeID int IDENTITY(1,1) NOT NULL PRIMARY KEY,      
FirstName varchar(20) NOT NULL ,      
LasttName varchar(20) NOT NULL ,      
CityId int ,
constraint FK_Employee_Cities_Id foreign key (CityId) references Cities(CityId)
)

```

- insert data into __Cities__ and __Employees__ tables

```
INSERT INTO Cities VALUES('Montreal')
INSERT INTO Cities VALUES('Bucharest')

INSERT INTO Employees VALUES ('John', 'Smith', 1)
INSERT INTO Employees VALUES ('Ion', 'Ionescu', 2)
```
