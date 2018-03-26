USE LekkerFood

GO
CREATE TABLE IngredientCsv
(ID INT,
Name VARCHAR(250))
GO



BULK
INSERT IngredientCsv
FROM 'D:\dev\LekkerFood\LekkerFood.Data\Seed\lekkerdata.csv'
WITH
(
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
)
GO
--Check the content of the table.
SELECT name, SUBSTRING(name,1, DATALENGTH(name)-1)
FROM IngredientCsv
GO

SET IDENTITY_INSERT Ingredients ON
Insert into Ingredients (id, Name, [IngredientCategoryId], Calories, Sodium, Carbohydrates, Protien, Fibre, Sugar, Fat)
select Id, SUBSTRING(name,1, DATALENGTH(name)-1), 1, 0, 0, 0, 0, 0, 0, 0
FROM IngredientCsv
SET IDENTITY_INSERT Ingredients OFF

--Drop the table to clean up database.
DROP TABLE IngredientCsv
GO