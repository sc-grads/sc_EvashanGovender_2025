Use AdventureWorks2022

UPDATE SalesStaff SET SalesQuota = sp.SalesQuota 
FROM SalesStaff ss INNER JOIN Sales.vSalesPerson sp
ON ss.FullName = sp.FirstName + ' ' + sp.LastName

Select * FROM SalesStaff
