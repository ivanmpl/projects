-- Create a new database called 'SampleDB'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
FROM sys.databases
WHERE name = N'SampleDB'
)
CREATE DATABASE SampleDB
GO

-- Create a new table called 'Employees' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Accounts', 'U') IS NOT NULL
DROP TABLE dbo.Accounts
GO
-- Create the table in the specified schema
CREATE TABLE dbo.Accounts
(
    EmployeesId INT NOT NULL PRIMARY KEY,
    -- primary key column
    Name [NVARCHAR](50) NOT NULL,
    Location [NVARCHAR](50) NOT NULL
    -- specify more columns here
);
GO

-- Insert rows into table 'Employees'
INSERT INTO Employees
    ([EmployeesId],[Name],[Location])
VALUES
    ( 1, N'John', N'Australia'),
    ( 2, N'Elizabeth', N'India'),
    ( 3, N'Ralf', N'Germany'),
    ( 4, N'Jake', N'United States'),  
    ( 5, N'Juan', N'Spain')   
GO
-- Query the total count of employees
SELECT COUNT(*) as EmployeeCount
FROM dbo.Employees;
-- Query all employee information
SELECT e.EmployeesId, e.Name, e.Location
FROM dbo.Employees as e
GO