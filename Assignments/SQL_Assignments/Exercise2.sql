/* Exercise 2
Write separate queries using a join, a subquery, a CTE, and then an EXISTS 
to list all AdventureWorks customers who have not placed an order.
*/

--CONNECT TO DATABASE
USE AdventureWorks2017;

-- SELECT * FROM Sales.Customer;

-- SELECT * FROM Sales.SalesOrderHeader ORDER BY CustomerID;

-- JOIN

SELECT SC.CustomerID AS 'CustomerID With JOIN'
FROM Sales.SalesOrderHeader AS SOH
RIGHT JOIN Sales.Customer AS SC ON SOH.CustomerID = SC.CustomerID
WHERE SalesOrderID IS NULL;


-- Subquery

SELECT SC.CustomerID AS 'CustomerID With Subquery'
FROM Sales.Customer SC
WHERE SC.CustomerID NOT IN (SELECT CustomerID FROM Sales.SalesOrderHeader);

-- CTE

WITH CustomerWithZeroOrder(CustomerID )
AS(
	SELECT SC.CustomerID
	FROM Sales.SalesOrderHeader AS SOH
	RIGHT JOIN Sales.Customer AS SC
	ON SOH.CustomerID = SC.CustomerID
	WHERE SOH.SalesOrderID IS NULL
)
SELECT CustomerID AS 'CustomerID With CTE' FROM CustomerWithZeroOrder;


-- EXIST

SELECT SC.CustomerID AS 'CustomerID With Exists'
FROM Sales.Customer AS SC
WHERE NOT EXISTS( 
	SELECT SOH.CustomerID 
	FROM Sales.SalesOrderHeader AS SOH
	WHERE SC.CustomerID = SOH.CustomerID
);