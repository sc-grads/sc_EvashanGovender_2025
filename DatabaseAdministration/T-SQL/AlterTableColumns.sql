--CREATE TABLE tblEmployee
--(
--EmployeeFirstName VARCHAR(50) NOT NULL,
--EmployeeMidlleName VARCHAR(50) NULL,
--EmployeeLastName VARCHAR(50) NOT NULL,
---EmployeeGovenmentID CHAR(10) NULL,
--DateofBirth DATE NOT NULL
--)

ALTER TABLE tblEmployee 
DROP COLUMN Department 

ALTER TABLE tblEmployee 
ADD Department VARCHAR(15)

INSERT INTO tblEmployee
VALUES (132,'Dylan','A','Word','HN513777D','1992-09-14','Customer Relations')