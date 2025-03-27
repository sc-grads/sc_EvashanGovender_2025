USE master;
GO

-- Create database if not exists
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'AutoTest_EG_27March')
BEGIN
    CREATE DATABASE AutoTest_EG_27March;
    PRINT 'Database AutoTest_EG_27March created successfully.';
END
ELSE
BEGIN
    PRINT 'Database AutoTest_EG_27March already exists.';
END
GO

USE AutoTest_EG_27March;
GO

-- Create stored procedure for complete setup
CREATE OR ALTER PROCEDURE DBCreation
AS
BEGIN
    -- Create user table if not exists
    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
    BEGIN
        CREATE TABLE [Users] (
            [Name] NVARCHAR(100) NOT NULL,
            [Surname] NVARCHAR(100) NOT NULL,
            [Email] NVARCHAR(255) PRIMARY KEY
        );
        PRINT 'Table user created successfully.';
        
        -- Insert sample data
        INSERT INTO [Users] (Name, Surname, Email)
        VALUES 
            ('Evashan', 'Govender', 'evashan@gmail.com'),
            ('Harry', 'Potter', 'harry@gmail.com'),
            ('Bruce', 'Wayne', 'knight@gmail.com');
        PRINT 'Sample data inserted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Table user already exists.';
    END
  
END
GO

-- Execute the stored procedure
EXEC DBCreation;
GO
GO
