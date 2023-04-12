-- Connect database
USE AdventureWorks2017;

/* Exercise 3
Show the most recent five orders that were purchased from account numbers 
that have spent more than $70,000 with AdventureWorks.
*/


SELECT A.* FROM 
(SELECT 
ROW_NUMBER() OVER(PARTITION BY AccountNumber ORDER BY OrderDate DESC) AS 'Sequence',
AccountNumber, SalesOrderID, CustomerID, OrderDate
FROM Sales.SalesOrderHeader
WHERE SubTotal > 70000) A 
WHERE Sequence < 6
ORDER BY AccountNumber;