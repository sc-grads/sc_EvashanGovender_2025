CREATE PROCEDURE NameEmployees AS
BEGIN
	select EmployeeNumber, EmployeeFirstName, EmployeeLastName
	from tblEmployee
END
GO

--Different ways to execute a stored procedure
NameEmployees
exec NameEmployees
EXECUTE NameEmployees
