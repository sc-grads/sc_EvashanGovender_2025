USE PracticeDB

Create Table SalesStaffNEW(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	staffID int,
	fName varchar(20),
	lName varchar(20)
)

INSERT SalesStaffNEW (staffID,fName) 
SELECT staffID,fName FROM SalesStaff s Where s.StaffID > 300

Select * FROM SalesStaffNew