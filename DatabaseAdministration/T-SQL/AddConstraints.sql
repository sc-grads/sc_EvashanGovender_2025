-- Unique Constraint
Alter table tblEmployee
ADD Constraint unqGovernmentID UNIQUE (EmployeeGovenmentID)

Alter table tblTransaction
ADD constraint unqTransaction UNIQUE(Amount,DateOfTransaction,EmployeeNumber)

--Default Constraint
ALTER TABLE tblTransaction
ADD DateOfEntry datetime

ALTER TABLE tblTransaction
ADD CONSTRAINT defDateOfEntry DEFAULT GETDATE() for DateOfEntry

--Check constraint
Alter table tblTransaction
ADD CONSTRAINT chkAmount CHECK (Amount > -1000 and Amount < 1000)

--Using the with nocheck, it does not check the existing data in the dats
ALTER TABLE tblEmployee with nocheck
ADD CONSTRAINT chkMiddle check
(REPLACE(EmployeeMidlleName,'.','') = EmployeeMidlleName or EmployeeMidlleName is null)