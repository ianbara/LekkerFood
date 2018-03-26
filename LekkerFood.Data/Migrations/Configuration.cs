using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using LekkerFood.Models;
using System.Collections.Generic;

namespace LekkerFood.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LekkerFood.Data.LekkerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;            
        }

        protected override void Seed(LekkerFood.Data.LekkerDbContext context)
        {
            IList<RecipeCategory> recipeCategories = new List<RecipeCategory>();

            recipeCategories.Add(new RecipeCategory() { RecipeCategoryId = 1, Name = "Reduced Carb" });
            recipeCategories.Add(new RecipeCategory() { RecipeCategoryId = 2, Name = "Refull Carb" });
            recipeCategories.Add(new RecipeCategory() { RecipeCategoryId = 3, Name = "Snack" });
            recipeCategories.Add(new RecipeCategory() { RecipeCategoryId = 4, Name = "Naughty" });

            foreach (var recipeCategory in recipeCategories)
            {
                context.RecipeCategories.Add(recipeCategory);
            }




            IList<MeasurementType> measurementTypes = new List<MeasurementType>();
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 1, Name = "tsp", Description = "Teaspoon" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 2, Name = "tbsp", Description = "Tablespoon" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 3, Name = "fl oz", Description = "Fluid Ounce" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 4, Name = "gill", Description = "1/2 Cup" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 5, Name = "cup", Description = "Cup" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 6, Name = "pt", Description = "pint" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 7, Name = "quart", Description = "q, qt" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 8, Name = "gallon", Description = "g, gal" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 9, Name = "ml", Description = "milliliter" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 10, Name = "l", Description = "litre" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 11, Name = "dl", Description = "deciliter" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 12, Name = "lb", Description = "pound" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 13, Name = "oz", Description = "ounce" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 14, Name = "mg", Description = "miligram" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 15, Name = "g", Description = "gramme" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 16, Name = "kg", Description = "kilogram" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 17, Name = "mm", Description = "millimeter" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 18, Name = "cm", Description = "centimeter" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 19, Name = "m", Description = "metre" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 20, Name = "inch", Description = "in / ''" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 21, Name = "No.", Description = "Number of" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 22, Name = "Clove", Description = "Clove" });
            measurementTypes.Add(new MeasurementType() { MeasurementTypeId = 23, Name = "Tin", Description = "Tin" });

            foreach (MeasurementType measurementType in measurementTypes)
                context.MeasurementTypes.Add(measurementType);


            IList<PreparationType> prepartationTypes = new List<PreparationType>();
            prepartationTypes.Add(new PreparationType() { PreparationTypeId = 1, Name = "Chopped" });
            prepartationTypes.Add(new PreparationType() { PreparationTypeId = 2, Name = "Sliced" });
            prepartationTypes.Add(new PreparationType() { PreparationTypeId = 3, Name = "Diced" });
            prepartationTypes.Add(new PreparationType() { PreparationTypeId = 4, Name = "Crushed" });
            prepartationTypes.Add(new PreparationType() { PreparationTypeId = 5, Name = "Zest" });
            prepartationTypes.Add(new PreparationType() { PreparationTypeId = 6, Name = "Juiced" });


            foreach (PreparationType preparationType in prepartationTypes)
                context.PreparationTypes.Add(preparationType);

            IList<IngredientCategory> ingredientCategories = new List<IngredientCategory>();
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 1, Name = "Poultry" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 2, Name = "Meat" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 3, Name = "Fish" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 4, Name = "Herbs & Spices" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 5, Name = "Fruit" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 6, Name = "Sauces" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 7, Name = "Cheese" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 8, Name = "Salad" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 9, Name = "Vegetables" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 10, Name = "Oils/Butter" });
            ingredientCategories.Add(new IngredientCategory() { IngredientCategoryId = 11, Name = "Dairy" });

            foreach (var ingredientCategory in ingredientCategories)
                context.IngredientCategories.Add(ingredientCategory);

            context.SaveChanges();

            IList<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { IngredientId = 1, Name = "Chicken Breast", IngredientCategoryId = 1 });
            ingredients.Add(new Ingredient() { IngredientId = 2, Name = "Chicken Thigh", IngredientCategoryId = 1 });
            ingredients.Add(new Ingredient() { IngredientId = 3, Name = "Chicken Wings", IngredientCategoryId = 1 });
            ingredients.Add(new Ingredient() { IngredientId = 4, Name = "Beef Joint", IngredientCategoryId = 2 });
            ingredients.Add(new Ingredient() { IngredientId = 5, Name = "Beef Mince", IngredientCategoryId = 2 });
            ingredients.Add(new Ingredient() { IngredientId = 6, Name = "Steak", IngredientCategoryId = 2 });
            ingredients.Add(new Ingredient() { IngredientId = 7, Name = "Salmon Fillet", IngredientCategoryId = 3 });
            ingredients.Add(new Ingredient() { IngredientId = 8, Name = "Trout", IngredientCategoryId = 3 });
            ingredients.Add(new Ingredient() { IngredientId = 9, Name = "Fish Cakes", IngredientCategoryId = 3 });
            ingredients.Add(new Ingredient() { IngredientId = 10, Name = "Cheddar Cheese", IngredientCategoryId = 7 });
            ingredients.Add(new Ingredient() { IngredientId = 11, Name = "Mozzarella", IngredientCategoryId = 7 });
            ingredients.Add(new Ingredient() { IngredientId = 12, Name = "Goats Cheese", IngredientCategoryId = 7 });
            ingredients.Add(new Ingredient() { IngredientId = 13, Name = "Feta Cheese", IngredientCategoryId = 7 });
            ingredients.Add(new Ingredient() { IngredientId = 14, Name = "Parmesan Cheese", IngredientCategoryId = 7 });
            ingredients.Add(new Ingredient() { IngredientId = 15, Name = "Apple", IngredientCategoryId = 5 });
            ingredients.Add(new Ingredient() { IngredientId = 16, Name = "Pear", IngredientCategoryId = 5 });
            ingredients.Add(new Ingredient() { IngredientId = 17, Name = "Orange", IngredientCategoryId = 5 });
            ingredients.Add(new Ingredient() { IngredientId = 18, Name = "Mango", IngredientCategoryId = 5 });
            ingredients.Add(new Ingredient() { IngredientId = 19, Name = "Pineapple", IngredientCategoryId = 5 });
            ingredients.Add(new Ingredient() { IngredientId = 20, Name = "Lucy bee Coconut (Oil)", IngredientCategoryId = 10 });
            ingredients.Add(new Ingredient() { IngredientId = 21, Name = "Olive Oil", IngredientCategoryId = 10 });
            ingredients.Add(new Ingredient() { IngredientId = 22, Name = "Tobasco Sauce", IngredientCategoryId = 6 });
            ingredients.Add(new Ingredient() { IngredientId = 23, Name = "Chopped Tomatoes", IngredientCategoryId = 9 });
            ingredients.Add(new Ingredient() { IngredientId = 24, Name = "White Onions", IngredientCategoryId = 9 });
            ingredients.Add(new Ingredient() { IngredientId = 25, Name = "Red Onions", IngredientCategoryId = 9 });
            ingredients.Add(new Ingredient() { IngredientId = 26, Name = "Garlic", IngredientCategoryId = 4 });
            ingredients.Add(new Ingredient() { IngredientId = 27, Name = "Ginger", IngredientCategoryId = 4 });
            ingredients.Add(new Ingredient() { IngredientId = 28, Name = "Fresh Basil", IngredientCategoryId = 4 });
            ingredients.Add(new Ingredient() { IngredientId = 29, Name = "Fresh Corriander", IngredientCategoryId = 4 });
            ingredients.Add(new Ingredient() { IngredientId = 30, Name = "Salt", IngredientCategoryId = 4 });

            foreach (var ingredient in ingredients)
                context.Ingredients.Add(ingredient);



            IList<Recipe> recipes = new List<Recipe>();

            recipes.Add(new Recipe()
            {
                RecipeId = 1,
                Name = "Turkey Meatballs",
                RecipeCategoryId = 1,
                Rating = 10,
                PrepTime = 15,
                CookingTime = 60,
                Cost = 10,
                Description = "Tasy, heathly, fun.",
                RecipeIngredients = new List<RecipeIngredient>
        {
           new RecipeIngredient() { RecipeIngredientId = 1, IngredientId = 1, PreparationTypeId = 1, Quantity = 2 },
           new RecipeIngredient() { RecipeIngredientId = 2, IngredientId = 20, PreparationTypeId = 3, MeasurementTypeId = 5, Quantity = 1 },
           new RecipeIngredient() { RecipeIngredientId = 3, IngredientId = 26, PreparationTypeId = 5, MeasurementTypeId = 6, Quantity = 1 }
        }
            });

            foreach (Recipe recipe in recipes)
                context.Recipes.Add(recipe);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
