SELECT Sum(Pay) FROM
(SELECT *,
CASE WHEN DateStart < '{0}' AND(DateEnd > '{1}' OR DateEnd IS NULL) THEN (Salary / 25) * DATEDIFF(day, '{0}', '{1}')
WHEN DateStart >= '{0}' AND(DateEnd > '{1}' OR DateEnd IS NULL) THEN(Salary / 25) * DATEDIFF(day, DateStart, '{1}')
WHEN DateStart < '{0}' AND DateEnd <= '{1}' THEN(Salary / 25) * DATEDIFF(day, '{0}', DateEnd)
WHEN DateStart >= '{0}' AND DateEnd <= '{1}' THEN(Salary / 25) * DATEDIFF(day, DateStart, DateEnd)
END AS Pay FROM(SELECT * FROM Employee WHERE DateStart <= '{1}' AND DateEnd >= '{0}') As Employees) As Pay