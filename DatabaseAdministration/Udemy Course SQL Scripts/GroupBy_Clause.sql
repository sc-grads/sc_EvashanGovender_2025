USE AdventureWorks2022

Select PostalCode,COUNT(PostalCode) AS [Postal Code Count] FROM Person.Address GROUP BY PostalCode ORDER BY [Postal Code Count] DESC

--Outputs the postal code aswell as the total count of each postal code arranged in descending order of the postal code total count

Select PostalCode,City,COUNT(*) FROM Person.Address GROUP BY City,PostalCode ORDER BY City DESC

--Outputs the city and postal code and the total count of the city and postal code grouped together in descending order of city