USE AdventureWorks2022

Select * FROM HumanResources.EmployeePayHistory ORDER BY Rate

Select * FROM HumanResources.EmployeePayHistory ORDER BY Rate DESC

Select * FROM HumanResources.EmployeePayHistory Where YEAR(ModifiedDate) = 2014 ORDER BY ModifiedDate,Rate

--ORDER BY is default as Ascending or you can specify it as ORDER BY Rate ASC