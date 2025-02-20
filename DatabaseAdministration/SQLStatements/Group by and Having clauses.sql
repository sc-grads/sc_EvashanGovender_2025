--Group by and having clauses are used when the Aggregate functions are in play
SELECT CustomerID,SUM(TotalAmount) AS AmtSpentPerCustomer
  FROM [PracticeDB].[dbo].[Orders]
  GROUP BY CustomerID 
  HAVING SUM(TotalAmount) > 1000

