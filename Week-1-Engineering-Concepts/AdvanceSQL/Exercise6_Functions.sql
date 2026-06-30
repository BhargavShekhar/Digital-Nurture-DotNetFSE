USE EmployeeManagementSystem;
GO

IF OBJECT_ID('fn_GetAnnualSalary', 'FN') IS NOT NULL
    DROP FUNCTION fn_GetAnnualSalary;
GO

CREATE FUNCTION fn_GetAnnualSalary
(
    @EmployeeID INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(10,2);

    SELECT
        @AnnualSalary = Salary * 12
    FROM Employees
    WHERE EmployeeID = @EmployeeID;

    RETURN @AnnualSalary;
END;
GO

SELECT
    EmployeeID,
    FirstName,
    Salary,
    dbo.fn_GetAnnualSalary(EmployeeID) AS AnnualSalary
FROM Employees;
GO