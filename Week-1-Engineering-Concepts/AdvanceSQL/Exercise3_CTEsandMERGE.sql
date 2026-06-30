SELECT 
    od.ProductID,
    p.CategoryID,
    SUM(od.Quantity * p.Price) AS TotalSales
FROM OrderDetails od
JOIN Products p
ON od.ProductID = p.ProductID
GROUP BY GROUPING SETS (
    (p.CategoryID),
    (od.ProductID),
    ()
);