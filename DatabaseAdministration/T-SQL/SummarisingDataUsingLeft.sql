Select LEFT(EmployeeLastName,1) AS Initial, COUNT(*) as CountOfInitial
FROM tblEmployee
WHERE DateofBirth > '19760101'
GROUP BY LEFT(EmployeeLastName,1)
HAVING Count(*) >= 20
ORDER BY COUNT(*) DESC,LEFT(EmployeeLastName,1)