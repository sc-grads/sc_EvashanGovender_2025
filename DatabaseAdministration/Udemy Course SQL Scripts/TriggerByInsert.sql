CREATE TRIGGER EmployeeInsert 
ON Employee
AFTER INSERT
AS
BEGIN
	Insert INTO EmployeeTriggerHistory values (Select max(EmpID) FROM Employee,'Insert')
END
GO

Select * FROM EmployeeTriggerHistory
