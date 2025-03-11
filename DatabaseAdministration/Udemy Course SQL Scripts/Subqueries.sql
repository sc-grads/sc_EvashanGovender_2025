USE AdventureWorks2022

Select * FROM HumanResources.EmployeePayHistory Where BusinessEntityID IN (Select BusinessEntityID FROM HumanResources.EmployeePayHistory Where Rate > 60)

--Outputs the columns in the EmployerepayHistory table Where BusinessID is in a list of businessID where the rate is greater than 60


Select * FROM HumanResources.EmployeePayHistory Where BusinessEntityID IN (Select BusinessEntityID FROM HumanResources.EmployeePayHistory Where Rate = 39.06)

--Outputs the columns in the EmployerepayHistory table Where BusinessID is in a list of businessID where the rate is equal to 39,06


Select * FROM Production.Product Where ProductID IN (Select ProductID FROM Production.ProductInventory Where Quantity > 300)