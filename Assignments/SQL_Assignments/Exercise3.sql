-- Connect database
USE AdventureWorks2017;

/* Exercise 3
Show the most recent five orders that were purchased from account numbers 
that have spent more than $70,000 with AdventureWorks.
*/

-- SELECT * FROM Sales.SalesOrderHeader;

SELECT TOP 5 SalesOrderID, CustomerID, AccountNumber, OrderDate, SubTotal
FROM Sales.SalesOrderHeader
WHERE AccountNumber 
IN (SELECT AccountNumber
    FROM Sales.SalesOrderHeader
	GROUP BY AccountNumber
    HAVING SUM(SubTotal) > 70000
);