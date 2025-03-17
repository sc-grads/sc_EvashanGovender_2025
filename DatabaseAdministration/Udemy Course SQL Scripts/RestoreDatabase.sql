USE [master]
RESTORE DATABASE [AdventureWorks2022] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER2\MSSQL\Backup\AdventureWorks2022.bak' 
WITH  FILE = 1,  NOUNLOAD,  STATS = 5

GO


