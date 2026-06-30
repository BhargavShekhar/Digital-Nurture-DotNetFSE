USE EmployeeManagementSystem;
GO

-- Exercise 5: Create a stored procedure to insert a new employee into the Employees table. --

IF OBJECT_ID('sp_InsertEmployee', 'P') IS NOT NULL
    DROP PROCEDURE sp_InsertEmployee;
GO

CREATE PROCEDURE sp_InsertEmployee
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
)
AS
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;
GO

EXEC sp_InsertEmployee
    @FirstName = 'Alex',
    @LastName = 'Brown',
    @DepartmentID = 2,
    @Salary = 7500.00,
    @JoinDate = '2024-01-15';
GO

SELECT *
FROM Employees;
GO

-- Exercise 5: Return  Data from a Stored Procedure. --
IF OBJECT_ID('sp_GetEmployeeCountByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeeCountByDepartment;
GO

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
(
    @DepartmentID INT
)
AS
BEGIN
    SELECT
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO