IF object_ID('NameEmployees','P') IS NOT NULL
DROP PROCEDURE NameEmployees
GO

CREATE PROCEDURE NameEmployees(@EmployeeNumber int) as
BEGIN
	IF exists (Select * from tblEmployee where EmployeeNumber = @EmployeeNumber)
	BEGIN
		select EmployeeNumber, EmployeeFirstName, EmployeeLastName
		from tblEmployee
		where EmployeeNumber = @EmployeeNumber
	END
END
GO

NameEmployees 4
execute NameEmployees 223
exec NameEmployees 323


DECLARE @EmployeeName int = 123
select @EmployeeName
