
SELECT FirstName,LastName,Email,ProductName,Category,Price,OrderDate,Quantity,TotalAmount, 
FROM Orders INNER JOIN Products INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID ON Products.ProductID = Orders.ProductID

