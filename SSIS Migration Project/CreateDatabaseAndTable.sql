USE master;
GO

-- Check if the NINES database exists and drop it if it does
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'NINES')
BEGIN
    ALTER DATABASE NINES SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE NINES;
    PRINT 'NINES database dropped successfully.';
END
ELSE
BEGIN
    PRINT 'NINES database does not exist.';
END
GO

-- Create the NINES database
CREATE DATABASE NINES;
GO

-- Switch to the NINES database
USE NINES;
GO

-- Create the Timesheets table
CREATE TABLE Timesheets (
    TimesheetID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeName NVARCHAR(40)  NULL,
    Date DATE  NULL,
    DayOfWeek NVARCHAR(50)  NULL,
    Client NVARCHAR(50)  NULL,
    ClientProjectName NVARCHAR(50)  NULL,
    Description NVARCHAR(30)  NULL,
    Billable NVARCHAR(15)  NULL,
    Comments NVARCHAR(500),
    TotalHours DECIMAL(5,2)  NULL,
    StartTime TIME(0)  NULL,
    EndTime TIME(0)  NULL,
    CONSTRAINT Check_Times CHECK (EndTime > StartTime),
    CONSTRAINT Check_TotalHours CHECK (TotalHours >= 0 AND TotalHours <= 24),
    CONSTRAINT Check_Timesheet_Entry UNIQUE (EmployeeName, Date, StartTime, EndTime)
);
GO

PRINT 'NINES database and Timesheets table created successfully.';
GO

Select * FROM Timesheets