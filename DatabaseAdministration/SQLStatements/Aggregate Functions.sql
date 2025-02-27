SELECT 
    SUM(TotalAmount) AS REVENUE,
    AVG(TotalAmount) AS AvgSaleAmt,
    MAX(TotalAmount) AS HighestOrderAmt,
    MIN(TotalAmount) AS LowestOrderAmt
FROM ORDERS
