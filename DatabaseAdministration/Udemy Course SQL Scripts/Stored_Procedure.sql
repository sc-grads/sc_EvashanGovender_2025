USE AdventureWorks2022

CREATE Procedure SelectAllPersonAddress
AS
Select * FROM Person.Address
Go;

EXEC SelectAllPersonAddress