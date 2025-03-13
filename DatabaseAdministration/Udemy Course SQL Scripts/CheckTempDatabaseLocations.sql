Select name,physical_name as CurrentLocation
FROM sys.master_files
Where database_id = DB_ID(N'tempdb');
Go