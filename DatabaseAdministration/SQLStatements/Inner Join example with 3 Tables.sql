Select Customers.FirstName,Customers.LastName,Customers.Email,Products.ProductName,Products.Price,Orders.Quantity,Orders.TotalAmount 
FROM Orders
INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
INNER JOIN Products ON Products.ProductID = Orders.ProductID