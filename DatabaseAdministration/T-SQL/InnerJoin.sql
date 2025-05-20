--INNER JOIN
SELECT  tblEmployee.EmployeeNumber,EmployeeFirstName,EmployeeLastName,SUM(Amount) AS SumOfAmount
FROM tblEmployee
JOIN tblTransaction
ON tblEmployee.EmployeeNumber = tblTransaction.EmployeeNumber
GROUP BY tblEmployee.EmployeeNumber,EmployeeFirstName,EmployeeLastName
ORDER BY EmployeeNumber