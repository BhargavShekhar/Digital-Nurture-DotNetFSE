USE OnlineRetailStore;
GO

-- GROUPING SETS --

SELECT
    c.Region,
    p.CategoryID,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
JOIN Customers c
    ON o.CustomerID = c.CustomerID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY GROUPING SETS
(
    (c.Region),
    (p.CategoryID),
    (c.Region, p.CategoryID)
)
ORDER BY c.Region, p.CategoryID;

-- ROLLUP --

SELECT
    c.Region,
    p.CategoryID,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
JOIN Customers c
    ON o.CustomerID = c.CustomerID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY ROLLUP
(
    c.Region,
    p.CategoryID
)
ORDER BY c.Region, p.CategoryID;

-- CUBE --

SELECT
    c.Region,
    p.CategoryID,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
JOIN Customers c
    ON o.CustomerID = c.CustomerID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY CUBE
(
    c.Region,
    p.CategoryID
)
ORDER BY c.Region, p.CategoryID;