USE master;
GO

BEGIN TRY
    -- Create database if not exists
    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'AutoTestEG')
    BEGIN
        CREATE DATABASE AutoTestEG;
        PRINT 'Database AutoTestEG created successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Database AutoTestEG already exists.';
    END
END TRY
BEGIN CATCH
    PRINT 'Error occurred while creating database:';
    PRINT 'Error Message: ' + ERROR_MESSAGE();
    -- Re-throw the error to fail the GitHub Action
    THROW;
END CATCH
GO

USE AutoTestEG;
GO

-- Create stored procedure for complete setup with error handling
CREATE OR ALTER PROCEDURE DBCreation
AS
BEGIN
    BEGIN TRY
        -- Create user table if not exists
        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
        BEGIN
            BEGIN TRANSACTION;
            
            CREATE TABLE [Users] (
                [Name] NVARCHAR(100) NOT NULL,
                [Surname] NVARCHAR(100) NOT NULL,
                [Email] NVARCHAR(255) PRIMARY KEY
            );
            PRINT 'Table Users created successfully.';
            
            -- Insert sample data
            INSERT INTO [Users] (Name, Surname, Email)
            VALUES 
                ('Evashan', 'Govender', 'evashan@gmail.com'),
                ('Harry', 'Potter', 'harry@gmail.com'),
                ('Bruce', 'Wayne', 'knight@gmail.com');
            PRINT 'Sample data inserted successfully.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Table Users already exists.';
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        PRINT 'Error occurred in DBCreation procedure:';
        PRINT 'Error Message: ' + ERROR_MESSAGE();
        -- Re-throw the error
        THROW;
    END CATCH
END
GO

BEGIN TRY
    -- Execute the stored procedure
    EXEC DBCreation;
    PRINT 'Database setup completed successfully.';
END TRY
BEGIN CATCH
    PRINT 'Error executing DBCreation procedure:';
    PRINT 'Error Message: ' + ERROR_MESSAGE();
    THROW;
END CATCH
GO

-- Execute the stored procedure
EXEC DBCreation;
GO
GO
