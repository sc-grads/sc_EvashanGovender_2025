USE master;
GO

-- Create stored procedure to automate DB, table, and data insertion
CREATE PROCEDURE SetupDatabaseAndTable
AS
BEGIN
    -- Create Database if not exists
    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'AutoTestDB')
    BEGIN
        EXEC('CREATE DATABASE AutoTestDB');
    END;

    -- Switch to the new database
USE AutoTestDB;

    -- Create Table if not exists
    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
    BEGIN
        CREATE TABLE Users (
            Id INT IDENTITY(1,1) PRIMARY KEY,
            Name NVARCHAR(100),
            Surname NVARCHAR(100),
            Email NVARCHAR(100)
        );
    END;

    -- Insert sample data (if table is empty)
    IF NOT EXISTS (SELECT * FROM Users)
    BEGIN
        INSERT INTO Users (Name, Email) VALUES
        ('John', 'Doe', 'john@example.com'),
        ('Jane', 'Doe', 'jane@example.com');
        ('Evashan', 'Govender','evashan@gmail.com')
    END;
END;
GO

-- Execute the stored procedure
EXEC SetupDatabaseAndTable;
