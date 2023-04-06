-- Connect Database
USE AdventureWorks2017;

/*
Create a function that takes as inputs a SalesOrderID, a Currency Code, and a date, 
and returns a table of all the SalesOrderDetail rows for that Sales Order including 
Quantity, ProductID, UnitPrice, and the unit price converted to the target currency 
based on the end of day rate for the date provided. 
Exchange rates can be found in the Sales.CurrencyRate table. 
(Use AdventureWorks)
*/

--SELECT SalesOrderID, ProductID, UnitPrice
--FROM Sales.SalesOrderDetail 
--WHERE SalesOrderID = 43661;

--SELECT ToCurrencyCode, CurrencyRateDate, EndOfDayRate
--FROM Sales.CurrencyRate
--WHERE ToCurrencyCode = 'EUR' 
--AND CurrencyRateDate = '2011-08-17 00:00:00.000';

-- Function
GO
CREATE FUNCTION Sales.ufngetOrderDetails(@SalesOrderID int, @CurrencyCode nchar(3), @CurrencyRateDate dateTime)
	RETURNS TABLE
		AS
		RETURN
			With Items
			AS (
				SELECT * 
				FROM Sales.SalesOrderDetail AS SOR
				WHERE SOR.SalesOrderID = @SalesOrderID
			)
			SELECT IT.ProductID, IT.OrderQty, IT.UnitPrice, IT.UnitPrice * SCR.EndOfDayRate AS 'Converted Price'
			FROM Items AS IT, Sales.CurrencyRate AS SCR
			WHERE SCR.ToCurrencyCode = @CurrencyCode AND SCR.CurrencyRateDate = @CurrencyRateDate;
GO

--SELECT * FROM Sales.ufngetOrderDetails(43661, 'EUR', '2011-08-17 00:00:00.000');