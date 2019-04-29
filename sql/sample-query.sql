-- Query the total count of employees
SELECT COUNT(*) as EmployeeCount
FROM dbo.Employees;

-- Query all employee information
SELECT e.EmployeesId, e.Name, e.Location, e.DepartmentId
FROM dbo.Employees as e
GO

-- Query all employee info who are in IT
SELECT e.EmployeesId, e.Name, e.Location, e.DepartmentId
FROM dbo.Employees as e
JOIN dbo.Department as d
ON e.DepartmentId = d.DepartmentId
WHERE d.Name = 'IT'
GO
