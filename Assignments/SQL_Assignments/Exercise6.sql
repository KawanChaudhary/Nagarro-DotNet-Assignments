/*
Write a trigger for the Product table to ensure the 
list price can never be raised more than 15 Percent in a single change. 
Modify the above trigger to execute its check code only if the ListPrice column is updated 
(Use AdventureWorks Database).
*/

--CONNECT TO DATABASE
USE AdventureWorks2017;

--SELECT * FROM Production.Product;

 --- Trigger

--GO
--CREATE TRIGGER CheckListPriceUpdate
--ON Production.Product
--	AFTER UPDATE
--	AS
--	IF EXISTS(
--		SELECT * 
--		FROM inserted AS I
--		JOIN deleted D
--		ON I.ProductID = D.ProductID
--		WHERE I.ListPrice > (D.ListPrice * 1.15)
--	)
--	BEGIN
--		RAISERROR('Price Should not be increased by 15 percent', 16, 1)
--		ROLLBACK TRANSACTION
--	END
--GO

UPDATE Production.Product
SET ListPrice = 700
Where ProductId = 822;
