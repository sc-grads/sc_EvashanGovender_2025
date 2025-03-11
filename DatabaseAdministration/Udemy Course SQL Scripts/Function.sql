Create Table FunctionEmployee(
	EmpID int Primary Key,
	FirstName varchar(50) NULL,
	LastName varchar(50) Null,
	Salary int NULL,
	Address varchar(100) NULL
)

Insert INTO FunctionEmployee(EmpID,FirstName,LastName,Salary,Address) VALUES (1,'Mohan','Chauahn','22000','Delhi'),(2,'Asif','Khan',15000,'Delhi'),
																			 (3,'Bhuvnesh','Shakya',19000,'Noida'),(4,'Deepak','Kumar',19000,'Noida')

Select * FROM FunctionEmployee

Create Function fnGetEmpFullName(@FirstName varchar(50), @LastName varchar(50))
returns varchar(101)
AS
Begin
return(Select @Firstname + ' ' + @LastName)
End

Select dbo.fnGetEmpFullName(FirstName,LastName) as FullName, Salary FROM FunctionEmployee