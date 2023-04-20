USE Northwind

-- 1
SELECT DISTINCT City FROM Customers 
WHERE City IN (SELECT DISTINCT City FROM Employees);

-- 2a
SELECT City FROM Customers c
WHERE City NOT IN (SELECT DISTINCT City FROM Employees)

-- 2b
SELECT c.City FROM Customers c
INNER JOIN Employees e
ON NOT c.City = e.City

-- 3
SELECT p.ProductID, SUM(od.Quantity) as OrderQuantities
FROM Products p INNER JOIN [Order Details] od
ON p.ProductID = od.ProductID
GROUP BY p.ProductID

-- 4
SELECT o.ShipCity, SUM(ProductID) as TotalProducts 
FROM [Order Details] od INNER JOIN Orders o
ON od.OrderID = o.OrderID
GROUP BY ShipCity

-- 5
-- a
SELECT City FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2
UNION
SELECT o.ShipCity as City 
FROM Orders o
GROUP BY ShipCity
HAVING COUNT(o.CustomerID) >= 2

-- b
SELECT tb2.City AS City FROM Customers c
RIGHT JOIN
(SELECT o.ShipCity as City, o.CustomerID AS CustomerID 
FROM Orders o
) tb2 ON c.CustomerID = tb2.CustomerID
GROUP BY tb2.City
HAVING COUNT(c.CustomerID) >= 2

-- 6 
SELECT c.City AS CustomerCities, COUNT(DISTINCT od.ProductID) as DiffProdCount
FROM Orders o
JOIN [Order Details] od
ON o.OrderID = od.OrderID
JOIN Customers c
ON o.CustomerID = c.CustomerID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

-- 7
SELECT DISTINCT c.CompanyName, c.City, o.ShipCity
FROM Customers c
INNER JOIN Orders o
ON o.CustomerID = c.CustomerID
WHERE NOT c.City = o.ShipCity

-- 8
SELECT TOP 5 p.ProductName, AVG(od.UnitPrice) AS AvgPrice, c.City AS PopularCity, SUM(od.Quantity) AS TotalQuantity
FROM Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
INNER JOIN Orders o ON od.OrderID = o.OrderID
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductName, c.City
ORDER BY TotalQuantity DESC;

-- 9   
-- a
SELECT City
FROM Employees
WHERE City NOT IN (
    SELECT DISTINCT o.ShipCity
    FROM Orders o
)
GROUP BY City;

-- b
SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Orders o
ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL

-- 10
SELECT TOP 1 tb1.City 
FROM 
(SELECT e.City, COUNT(o.OrderID) AS OrderCount
FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.City) tb1 
INNER JOIN
(SELECT c.City, SUM(od.Quantity) AS TotalQuantity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City) tb2
ON tb1.City = tb2.City
ORDER BY tb1.OrderCount DESC, tb2.TotalQuantity DESC

-- 11
-- Create a new table with unique records
SELECT DISTINCT *
INTO new_table
FROM Orders;

-- Drop the original table
DROP TABLE Orders;

-- Rename the new table to the original table name
EXEC sp_rename 'new_table', 'Orders';




