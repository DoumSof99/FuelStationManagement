SELECT SUM(TotalCost) AS 'ExpensesCost' 
FROM [Transaction] 
WHERE [Date] BETWEEN '{0}' AND '{1}'