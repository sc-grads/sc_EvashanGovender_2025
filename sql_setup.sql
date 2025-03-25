USE master;
GO

-- Create database if not exists
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'AutoTestDB')
BEGIN
    CREATE DATABASE AutoTestDB;
    PRINT 'Database AutoTestDB created successfully.';
END
ELSE
BEGIN
    PRINT 'Database AutoTestDB already exists.';
END
GO

USE AutoTestDB;
GO

-- Create stored procedure for complete setup
CREATE OR ALTER PROCEDURE AutomateCreation
AS
BEGIN
    -- Create user table if not exists
    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'user')
    BEGIN
        CREATE TABLE [user] (
            [Name] NVARCHAR(100) NOT NULL,
            [Surname] NVARCHAR(100) NOT NULL,
            [Email] NVARCHAR(255) PRIMARY KEY
        );
        PRINT 'Table user created successfully.';
        
        -- Insert sample data
        INSERT INTO [user] (Name, Surname, Email)
        VALUES 
            ('John', 'Doe', 'john.doe@example.com'),
            ('Jane', 'Smith', 'jane.smith@example.com'),
            ('Admin', 'User', 'admin@autotest.com');
        PRINT 'Sample data inserted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Table user already exists.';
    END
    
    -- Additional setup logic can be added here
END
GO

-- Execute the stored procedure
EXEC usp_InitializeAutoTestDB;
GO
