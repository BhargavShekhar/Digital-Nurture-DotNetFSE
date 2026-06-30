IF DB_ID('OnlineRetailStore') IS NULL
BEGIN
    CREATE DATABASE OnlineRetailStore;
END
GO

USE OnlineRetailStore
GO

-- CREATE TABLE Categories
-- (
--     CategoryID INT PRIMARY KEY,
--     CategoryName VARCHAR(100) NOT NULL,
-- )

-- CREATE TABLE Products
-- (
--     ProductID INT PRIMARY KEY,
--     ProductName VARCHAR(100) NOT NULL,
--     CategoryID INT NOT NULL,
--     Price DECIMAL(10, 2) NOT NULL,

--     FOREIGN KEY (CategoryID)
--         REFERENCES Categories(CategoryID)
-- )
-- GO

-- CREATE TABLE Customers
-- (
--     CustomerID INT PRIMARY KEY,
--     FirstName VARCHAR(50) NOT NULL,
--     LastName VARCHAR(50) NOT NULL,
--     Email VARCHAR(100) UNIQUE
-- );
-- GO

-- CREATE TABLE Orders
-- (
--     OrderID INT PRIMARY KEY,
--     CustomerID INT NOT NULL,
--     OrderDate DATE NOT NULL,

--     FOREIGN KEY (CustomerID) 
--         REFERENCES Customers(CustomerID)
-- );
-- GO

-- CREATE TABLE OrderDetails
-- (
--     OrderDetailID INT PRIMARY KEY,
--     OrderID INT NOT NULL,
--     ProductID INT NOT NULL,
--     Quantity INT NOT NULL,

--     FOREIGN KEY (OrderID)
--         REFERENCES Orders(OrderID),

--     FOREIGN KEY (ProductID)
--         REFERENCES Products(ProductID)
-- );
-- GO

INSERT INTO Categories (CategoryID, CategoryName)
VALUES
(1, 'Electronics'),
(2, 'Clothing'),
(3, 'Books'),
(4, 'Furniture');
GO

INSERT INTO Products (ProductID, ProductName, CategoryID, Price)
VALUES
(101, 'Laptop', 1, 65000.00),
(102, 'Smartphone', 1, 30000.00),
(103, 'T-Shirt', 2, 800.00),
(104, 'Novel', 3, 450.00),
(105, 'Desk', 4, 5000.00),
(106, 'Headphones', 1, 2500.00),
(107, 'Chair', 4, 3500.00),
(108, 'Keyboard', 1, 1500.00),
(109, 'Laptop2', 1, 70000.00);
GO

INSERT INTO Customers (CustomerID, FirstName, LastName, Email)
VALUES
(1, 'John', 'Doe', 'john@example.com'),
(2, 'Jane', 'Smith', 'jane@example.com'),
(3, 'Michael', 'Johnson', 'michael@example.com'),
(4, 'Emily', 'Davis', 'emily@example.com');
GO

INSERT INTO Orders (OrderID, CustomerID, OrderDate)
VALUES
(1001, 1, '2024-01-15'),
(1002, 2, '2024-02-10'),
(1003, 3, '2024-02-20'),
(1004, 1, '2024-03-01');
GO

INSERT INTO OrderDetails (OrderDetailID, OrderID, ProductID, Quantity)
VALUES
(1, 1001, 101, 1),
(2, 1001, 106, 2),
(3, 1002, 103, 3),
(4, 1002, 104, 2),
(5, 1003, 102, 1),
(6, 1003, 108, 1),
(7, 1004, 105, 1),
(8, 1004, 107, 4);
GO

ALTER TABLE Customers
ADD Region VARCHAR(50);
GO

UPDATE Customers
SET Region =
CASE CustomerID
    WHEN 1 THEN 'East'
    WHEN 2 THEN 'West'
    WHEN 3 THEN 'North'
    WHEN 4 THEN 'South'
END;
GO

SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Customers;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;