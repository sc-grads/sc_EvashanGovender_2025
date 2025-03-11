USE PracticeDB

Create Table SalesStaff(
	staffID int NOT NULL PRIMARY KEY,
	fName varchar(20) NOT NULL,
	lName varchar(20) NOT NULL
)

INSERT INTO SalesStaff(staffID,fName,lName) Values(200,'Abbas','Mehood')

Select * FROM SalesStaff

INSERT INTO SalesStaff(staffID,fName,lName) Values(300,'Imran','Afzal'),(325,'John','Wick'),(314,'James','Dino')