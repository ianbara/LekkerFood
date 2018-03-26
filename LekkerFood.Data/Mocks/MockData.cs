using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LekkerFood.Data.Mocks
{
    public static class MockData
    {
        public static List<IngredientCategory> IngredientCategories
        {
            get
            {
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

                return ingredientCategories.ToList();
            }
        }

        public static List<Recipe> Recipes
        {
            get
            {

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

                return recipes.ToList();
            }
        }



    }
}
