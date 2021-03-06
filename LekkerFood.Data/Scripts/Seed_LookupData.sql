Use LekkerFood



--Recipe Categrories
SET IDENTITY_INSERT RecipeCategories ON
insert into RecipeCategories (Id, Name) values (1, 'Uncategorised')
insert into RecipeCategories (Id, Name) values (2, 'Reduced Carb')
insert into RecipeCategories (Id, Name) values (3, 'Refull Carb')
insert into RecipeCategories (Id, Name) values (4, 'Snack')
insert into RecipeCategories (Id, Name) values (5, 'Naughty')
insert into RecipeCategories (Id, Name) values (6, 'Salad')
SET IDENTITY_INSERT RecipeCategories OFF
  
--Measurement Types
SET IDENTITY_INSERT MeasurementTypes ON
insert into MeasurementTypes (Id, Name, Description) values (1, 'tsp', 'Teaspoon')
insert into MeasurementTypes (Id, Name, Description) values (2, 'tbsp', 'Tablespoon')
insert into MeasurementTypes (Id, Name, Description) values (3, 'fl oz', 'Fluid Ounce')
insert into MeasurementTypes (Id, Name, Description) values (4, 'gill', '1/2 Cup')
insert into MeasurementTypes (Id, Name, Description) values (5, 'cup', 'cup')
insert into MeasurementTypes (Id, Name, Description) values (6, 'pt', 'pint')
insert into MeasurementTypes (Id, Name, Description) values (7, 'quat', 'q, qt')
insert into MeasurementTypes (Id, Name, Description) values (8, 'gallon', 'q, qt')
insert into MeasurementTypes (Id, Name, Description) values (9, 'ml', 'milliliter')
insert into MeasurementTypes (Id, Name, Description) values (10, 'l', 'litre')
insert into MeasurementTypes (Id, Name, Description) values (11, 'dl', 'deciliter')
insert into MeasurementTypes (Id, Name, Description) values (12, 'lb', 'pound')
insert into MeasurementTypes (Id, Name, Description) values (13, 'oz', 'once')
insert into MeasurementTypes (Id, Name, Description) values (14, 'mg', 'miligram')
insert into MeasurementTypes (Id, Name, Description) values (15, 'g', 'gramme')
insert into MeasurementTypes (Id, Name, Description) values (16, 'kg', 'kilogram')
insert into MeasurementTypes (Id, Name, Description) values (17, 'mm', 'millimeter')
insert into MeasurementTypes (Id, Name, Description) values (18, 'm', 'metre')
insert into MeasurementTypes (Id, Name, Description) values (19, 'cm', 'centimeter')
insert into MeasurementTypes (Id, Name, Description) values (20, 'inch', 'in / ""')
insert into MeasurementTypes (Id, Name, Description) values (21, 'No.', 'individual')
insert into MeasurementTypes (Id, Name, Description) values (22, 'clove', 'clove')
insert into MeasurementTypes (Id, Name, Description) values (23, 'tin', 'tin')
SET IDENTITY_INSERT MeasurementTypes OFF

--Preparation Types
SET IDENTITY_INSERT PreparationTypes ON
insert into PreparationTypes (Id, Name) values (1, 'Chopped')
insert into PreparationTypes (Id, Name) values (2, 'Sliced')
insert into PreparationTypes (Id, Name) values (3, 'Diced')
insert into PreparationTypes (Id, Name) values (4, 'Crushed')
insert into PreparationTypes (Id, Name) values (5, 'Zest')
insert into PreparationTypes (Id, Name) values (6, 'Juiced')
SET IDENTITY_INSERT PreparationTypes OFF


 --Ingredient Categories
SET IDENTITY_INSERT IngredientCategories ON
insert into IngredientCategories (Id, Name) values (1, 'Uncategorised')
insert into IngredientCategories (Id, Name) values (2, 'Poultry')
insert into IngredientCategories (Id, Name) values (3, 'Meat')
insert into IngredientCategories (Id, Name) values (4, 'Fish')
insert into IngredientCategories (Id, Name) values (5, 'Herbs & Spices')
insert into IngredientCategories (Id, Name) values (6, 'Fruit')
insert into IngredientCategories (Id, Name) values (7, 'Sauces')
insert into IngredientCategories (Id, Name) values (8, 'Cheese')
insert into IngredientCategories (Id, Name) values (9, 'Salad')
insert into IngredientCategories (Id, Name) values (10, 'Vegetables')
insert into IngredientCategories (Id, Name) values (11, 'Oils/Butter')
insert into IngredientCategories (Id, Name) values (12, 'Dairy')

SET IDENTITY_INSERT IngredientCategories OFF


 