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

--SELECT TOP 10 * FROM Sales.SalesOrderDetail;
--SELECT TOP 10 * FROM Sales.CurrencyRate;

--SELECT SalesOrderID, ProductID, UnitPrice
--FROM Sales.SalesOrderDetail 
--WHERE SalesOrderID = 43661;

--SELECT ToCurrencyCode, CurrencyRateDate, EndOfDayRate
--FROM Sales.CurrencyRate
--WHERE ToCurrencyCode = 'EUR' 
--AND CurrencyRateDate = '2011-08-17 00:00:00.000';

-- Function
GO
ALTER FUNCTION Sales.ufngetOrderDetails(@SalesOrderID int, @CurrencyCode nchar(3), @CurrencyRateDate dateTime)
	RETURNS TABLE
		AS
		RETURN			
			SELECT IT.ProductID, IT.OrderQty, IT.UnitPrice, IT.UnitPrice * SCR.EndOfDayRate AS 'Converted Price'
			FROM Sales.SalesOrderDetail AS IT, Sales.CurrencyRate AS SCR
			WHERE SCR.ToCurrencyCode = @CurrencyCode 
			AND SCR.CurrencyRateDate = @CurrencyRateDate 
			AND IT.SalesOrderID = @SalesOrderID;
GO

SELECT * FROM Sales.ufngetOrderDetails(43661, 'EUR', '2011-08-17 00:00:00.000');