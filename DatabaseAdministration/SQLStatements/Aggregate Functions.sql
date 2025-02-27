SELECT 
    SUM(TotalAmount) AS Revenue,
    AVG(TotalAmount) AS AvgSaleAmt,
    MAX(TotalAmount) AS HighestOrderAmt,
    MIN(TotalAmount) AS LowestOrderAmt
FROM ORDERS
