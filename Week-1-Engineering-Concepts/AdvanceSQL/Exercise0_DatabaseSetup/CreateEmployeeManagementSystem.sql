IF DB_ID('EmployeeManagementSystem') IS NULL
BEGIN
    CREATE DATABASE EmployeeManagementSystem;
END
GO

USE EmployeeManagementSystem;
GO

IF OBJECT_ID('Employees', 'U') IS NOT NULL
    DROP TABLE Employees;

IF OBJECT_ID('Departments', 'U') IS NOT NULL
    DROP TABLE Departments;
GO

CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DepartmentID INT NOT NULL,
    Salary DECIMAL(10,2) NOT NULL,
    JoinDate DATE NOT NULL,

    CONSTRAINT FK_Employees_Departments
        FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
);
GO

INSERT INTO Departments
VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');
GO

SET IDENTITY_INSERT Employees ON;

INSERT INTO Employees
(
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    JoinDate
)
VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-30');

SET IDENTITY_INSERT Employees OFF;
GO

SELECT * FROM Departments;
SELECT * FROM Employees;
GO