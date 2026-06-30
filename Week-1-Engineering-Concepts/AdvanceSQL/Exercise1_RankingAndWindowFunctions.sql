USE OnlineRetailStore;
GO

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        CategoryID,
        Price,
        ROW_NUMBER() OVER(
            PARTITION BY CategoryID
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        CategoryID,
        Price,
        RANK() OVER(
            PARTITION BY CategoryID
            ORDER BY Price DESC
        ) AS RankNum
    FROM Products
) AS RankedProducts
WHERE RankNum <= 3;

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        CategoryID,
        Price,
        DENSE_RANK() OVER(
            PARTITION BY CategoryID
            ORDER BY Price DESC
        ) AS DenseRankNum
    FROM Products
) AS RankedProducts
WHERE DenseRankNum <= 3;