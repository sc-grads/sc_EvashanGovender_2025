--Provide the sum,average,maximum and minimum of values given a cloumn
SELECT SUM(TotalAmount) AS Revenue,
		AVG(TotalAmount) AS AvgSaleAmt,
		MAX(TotalAmount) AS HighestOrderAmt,
		MIN(TotalAmount) AS LowestOrderAmt
	
  FROM [PracticeDB].[dbo].[Orders]

--Provides the total number of records in a table
 --Select COUNT(*) AS TotalRecords FROM Orders 
