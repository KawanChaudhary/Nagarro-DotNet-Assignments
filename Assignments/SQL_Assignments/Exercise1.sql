-- Connect to database
USE AdventureWorks2017;

/* 1 
Display the number of records in the [SalesPerson] table
*/

--SELECT COUNT(*) FROM Sales.SalesPerson;

/* 2 
Select both the FirstName and LastName of records from the Person table where the FirstName begins with the letter ‘B’.
*/

-- SELECT * FROM Person.Person ORDER BY FirstName ASC;

SELECT FirstName,LastName
FROM Person.Person
WHERE FirstName LIKE 'B%'
ORDER BY FirstName ASC;


/* 3 
Select a list of FirstName and LastName for employees where
Title is one of Design Engineer, Tool Designer or Marketing Assistant.
*/

-- SELECT * FROM Person.Person;
--SELECT * FROM HumanResources.Employee;

SELECT Person.Person.FirstName, Person.Person.LastName, HumanResources.Employee.JobTitle
FROM Person.Person INNER JOIN HumanResources.Employee 
ON HumanResources.Employee.BusinessEntityID = Person.Person.BusinessEntityID 
WhERE HumanResources.Employee.JobTitle IN ('Design Engineer', 'Tool Designer', 'Marketing Assistant');

/* 4 
Display the Name and Color of the Product with the maximum weight.
*/

--SELECT * FROM Production.Product;

SELECT Name, Color, Weight
FROM Production.Product
WHERE Weight = (SELECT MAX(Weight) FROM Production.Product)

/* 5 
Display Description and MaxQty fields from the SpecialOffer table. 
Some of the MaxQty values are NULL, in this case display the value 0.00 instead.
*/

-- SELECT * FROM Sales.SpecialOffer;
SELECT Description, ISNULL(MaxQty, 0.00) AS MAXQTY FROM Sales.SpecialOffer;


/* 6 
Display the overall Average of the [CurrencyRate].[AverageRate] values for the exchange rate ‘USD’ to ‘GBP’ 
for the year 2005 i.e. FromCurrencyCode = ‘USD’ and ToCurrencyCode = ‘GBP’. 
Note: The field [CurrencyRate].[AverageRate] is defined as 'Average exchange rate for the day.'
*/

--SELECT * FROM Sales.CurrencyRate WHERE ToCurrencyCode = 'GBP';
--Select COUNT(AverageRate) AS AVG, SUM(AverageRate) AS SUM FROM Sales.CurrencyRate WHERE ToCurrencyCode = 'GBP';

SELECT AVG(AverageRate) AS 'Average Exchange Rate for the day'
FROM Sales.CurrencyRate
WHERE FromCurrencyCode = 'USD' 
AND ToCurrencyCode = 'GBP' 
AND YEAR(CurrencyRateDate) = 2005;



/* 7
Display the FirstName and LastName of records from the Person table where FirstName contains the letters ‘ss’. 
Display an additional column with sequential numbers for each row returned beginning at integer 1.
(Schema(s) involved: Person)
*/

-- SELECT * FROM Person.Person;


SELECT ROW_NUMBER() OVER(ORDER BY FirstName, LastName) AS '#Row', FirstName, LastName
FROM Person.Person
WHERE FirstName LIKE '%ss%';



/* 8
Sales people receive various commission rates that belong to 1 of 4 bands. 
(Schema(s) involved: Sales)
Display the [SalesPersonID] with an additional column entitled ‘Commission Band’ 
indicating the appropriate band as above.
*/

--Select * FROM Sales.SalesPerson;

SELECT BusinessEntityID AS 'SalesPersonID',
CASE
WHEN CommissionPct = 0.0 then 'BAND 0'
WHEN CommissionPct > 0.0 AND CommissionPct <=0.01 then 'BAND 1'
WHEN CommissionPct > 0.01 AND CommissionPct <=0.015 then 'BAND 2'
WHEN CommissionPct > 0.015 then 'BAND 3'
END 
AS 'Commission Band'
FROM Sales.SalesPerson;

/* 9
Display the managerial hierarchy from Ruth Ellerbrock (person type – EM) up to CEO Ken Sanchez. 
Hint: use [uspGetEmployeeManagers] (Schema(s) involved: [Person], [HumanResources])
*/

--SELECT * FROM Person.Person;

SELECT BusinessEntityID 
FROM Person.Person 
WHERE FirstName = 'Ruth' 
AND LastName = 'Ellerbrock'
AND PersonType = 'EM';

/* 10
Display the ProductId of the product with the largest stock level. 
Hint: Use the Scalar-valued function [dbo]. [UfnGetStock]. (Schema(s) involved: Production)
*/

--SELECT * FROM Production.Product;

Select MAX(dbo.ufnGetStock(ProductID)) FROM Production.Product;