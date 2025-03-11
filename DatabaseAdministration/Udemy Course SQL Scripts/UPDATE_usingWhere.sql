USE AdventureWorks2022

SELECT FirstName + ' ' + LastName AS FullName,
		TerritoryName,
		TerritoryGroup,
		SalesQuota,
		SalesYTD,
		SalesLastYear
INTO SalesStaff from Sales.vSalesPerson

Select * FROM SalesStaff

UPDATE SalesStaff SET SalesQuota = 500000
UPDATE SalesStaff SET SalesQuota = SalesQuota + 1500000,SalesYTD = SalesYTD - 500