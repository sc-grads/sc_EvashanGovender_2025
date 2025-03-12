USE AdventureWorks2022

Select Count(*) AS [Count of Product],Color FROM Production.Product GROUP BY Color Having Color = 'Yellow'
--Output the total number of products grouped by colour having the colour yellow

Select Count(*) AS [Count of Product],Color,Size FROM Production.Product GROUP BY Color,Size Having Size >= '44'
--Output the total number of products grouped by colour and size having the size greater than or equal to 44
