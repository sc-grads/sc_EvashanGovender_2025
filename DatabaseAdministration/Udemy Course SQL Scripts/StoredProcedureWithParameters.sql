USE AdventureWorks2022

CREATE Procedure SelectAllPersonAddressWithParam (@City varchar(20))
AS
Select * FROM Person.Address Where City = @City

EXEC SelectAllPersonAddressWithParam @City = 'New York'
--OR
--EXEC SelectAllPersonAddressWithParam 'New York'
