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
IF OBJECT_ID('dbo.Employees', 'U') IS NOT NULL
DROP TABLE dbo.Employees
GO
-- Create the table in the specified schema
CREATE TABLE dbo.Employees
(
    EmployeesId INT NOT NULL PRIMARY KEY,
    -- primary key column
    Name [NVARCHAR](50) NOT NULL,
    Location [NVARCHAR](50) NOT NULL,
    Title [NVARCHAR](50) NOT NULL,
    DepartmentId INT NOT NULL
    -- specify more columns here
);
GO

-- Insert rows into table 'Employees'
INSERT INTO Employees
    ([EmployeesId],[Name],[Location],[Title],[DepartmentId])
VALUES
    ( 1, N'John', N'Australia', N'Recruiter', 1),
    ( 2, N'Elizabeth', N'India', N'Software Developer', 2),
    ( 3, N'Ralf', N'Germany', N'Business Analyst', 2),
    ( 4, N'Jake', N'United States', N'QA', 2),
    ( 5, N'Juan', N'Spain', N'CEO', 3)   
GO

-- Create a new table called 'Department' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Department', 'U') IS NOT NULL
DROP TABLE dbo.Department
GO
-- Create the table in the specified schema
CREATE TABLE dbo.Department
(
    DepartmentId INT NOT NULL PRIMARY KEY,
    -- primary key column
    Name [NVARCHAR](50) NOT NULL,
    Location [NVARCHAR](50) NOT NULL
    -- specify more columns here
);
GO

-- Insert rows into table 'Department'
INSERT INTO Department
    ( -- columns to insert data into
    [DepartmentId], [Name], [Location]
    )
VALUES
    (1, N'HR', N'Mexico'),
    (2, N'IT', N'China'),
    (3, N'Management', N'USA')
GO