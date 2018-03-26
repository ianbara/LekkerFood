using LekkerFood.Models;
using System.Collections.Generic;
using System.Linq;
using LekkerFood.Data.Mocks;


namespace LekkerFood.Data.Mocks
{
    public class MockLekkerDbContext
    {
        public List<IngredientCategory> IngredientCategories { get { return MockData.IngredientCategories; } }
        //public List<MeasurementType> MeasurementTypes { get; set; }
        //public List<PreparationType> PreparationTypes { get; set; }
        //public List<Ingredient> Ingredients { get; set; }
        //public List<RecipeIngredient> RecipeIngredients { get; set; }
        //public List<RecipeCategory> RecipeCategories { get; set; }
        public List<Recipe> Recipe { get { return MockData.Recipes;} }


    }
}
