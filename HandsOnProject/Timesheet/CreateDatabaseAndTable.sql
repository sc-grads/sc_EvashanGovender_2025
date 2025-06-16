USE master;
GO

-- Check if the NINES database exists and drop it if it does
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'TimesheetDB')
BEGIN
    DROP DATABASE TimesheetDB;
    PRINT 'TimesheetDB database dropped successfully.';
END
ELSE
BEGIN
    PRINT 'TimesheetDB database does not exist.';
END
GO

-- Create the NINES database
CREATE DATABASE TimesheetDB;
GO

-- Switch to the NINES database
USE TimesheetDB;
GO

-- Create the Timesheets table
CREATE TABLE Timesheet (
    TimesheetID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT NULL,
    Date DATE  NULL,
    DayOfWeek NVARCHAR(50)  NULL,
    ClientID INT NULL,
    ClientProjectName NVARCHAR(50)  NULL,
    Description NVARCHAR(30)  NULL,
    Billable NVARCHAR(15)  NULL,
    Comments NVARCHAR(MAX) NULL,
    TotalHours DECIMAL(5,2)  NULL,
    StartTime TIME(0)  NULL,
    EndTime TIME(0)  NULL,
    CONSTRAINT Check_Times CHECK (EndTime > StartTime),
    CONSTRAINT Check_TotalHours CHECK (TotalHours >= 0 AND TotalHours <= 24),
    CONSTRAINT Check_Timesheet_Entry UNIQUE (EmployeeID, Date, StartTime, EndTime)
);

CREATE TABLE Leave (
    LeaveID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT  NOT NULL,
    TypeOfLeave NVARCHAR(50) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    NumberOfDays INT NOT NULL,
    ApprovalObtained NVARCHAR(20)  NULL,
    SickNote NVARCHAR(255) NULL,
    CONSTRAINT chk_dates CHECK (StartDate <= EndDate),
    CONSTRAINT chk_days CHECK (NumberOfDays >= 0),
    CONSTRAINT unique_leave UNIQUE (EmployeeID, TypeOfLeave, StartDate, EndDate)
);

CREATE TABLE AuditLog (
    AuditLogID INT PRIMARY KEY IDENTITY(1,1),
    Timestamp DATETIME NOT NULL DEFAULT GETDATE(),
    EmployeeName NVARCHAR(100),
	Type NVARCHAR(100) NOT NULL,
	Month NVARCHAR(100) NOT NULL,
    Details NVARCHAR(MAX)
);

CREATE TABLE Employee(
	EmployeeID INT PRIMARY KEY IDENTITY(1,1),
	EmployeeName NVARCHAR(100)
);

CREATE TABLE Client(
	ClientID INT PRIMARY KEY IDENTITY(1,1),
	ClientName NVARCHAR(100)
);
 
CREATE TABLE ErrorLog (
    ErrorLogID INT PRIMARY KEY IDENTITY(1,1),
    FilePath NVARCHAR(350) NULL,
    ErrorMessage NVARCHAR(MAX),
    Timestamp DATETIME DEFAULT GETDATE()
);

GO

PRINT 'TimesheetDB database and Timesheet table created successfully.';
GO
