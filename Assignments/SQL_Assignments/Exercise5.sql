/*
Write a Procedure supplying name information from the Person.
Person table and accepting a filter for the first name. 
Alter the above Store Procedure to supply Default Values if user does not enter any value.
( Use AdventureWorks)
*/

-- Connect DataBase
USE AdventureWorks2017

Select BusinessEntityID, FirstName 
FROM Person.Person
WHERE BusinessEntityID = 11;

-- PROCEDURE
GO
CREATE PROCEDURE Person.getNameByFilter
	(
		@ID int = -1
	)
	AS
	BEGIN
		SELECT FirstName 
		FROM Person.Person
		WHERE BusinessEntityID = @ID
	END
GO

Exec Person.getNameByFilter @ID = 11