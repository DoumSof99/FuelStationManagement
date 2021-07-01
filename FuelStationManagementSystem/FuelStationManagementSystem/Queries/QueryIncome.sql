SELECT SUM(DiscountValue) AS 'Income' 
FROM [Transaction] 
WHERE [Date] BETWEEN '{0}' AND '{1}'