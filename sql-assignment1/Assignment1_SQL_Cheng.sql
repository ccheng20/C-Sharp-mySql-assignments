USE AdventureWorks2019;

-- 1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product;

-- 2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE NOT ListPrice = 0;

-- 3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL;

-- 4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE NOT Color IS NULL;

-- 5
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE NOT Color IS NULL AND ListPrice > 0;

-- 6
SELECT CONCAT(Name, ' ', Color) AS NameAndColor
FROM Production.Product
WHERE Color IS NOT NULL;

-- 7
SELECT 'NAME: ' + Name + '- - COLOR: ' + Color
From Production.Product
Where Name Like '[lmhc][hl]_[ic][rn][ar][ni][kn][ag]%'

-- 8
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500;

-- 9
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color = 'Black' OR Color ='Blue';

-- 10
SELECT * 
FROM Production.Product
WHERE Name LIKE 'S%';

-- 11
SELECT Name, ListPrice
FROM Production.Product
WHERE NAME LIKE 'S%'
ORDER BY Name;

-- 12
SELECT Name, ListPrice
FROM Production.Product
WHERE NAME LIKE 'A%' OR NAME LIKE 'S%'
ORDER BY Name;

-- 13
SELECT Name
FROM Production.Product
WHERE NAME LIKE 'SPO[^K]%'
ORDER BY Name;

-- 14
SELECT DISTINCT(Color)
FROM Production.Product
ORDER BY Color DESC;

-- 15
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
ORDER BY ProductSubcategoryID, Color;