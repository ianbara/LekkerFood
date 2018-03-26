using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Service.Interfaces
{
    public interface IFoodService
    {
        IEnumerable<Recipe> GetRecipes();
        Recipe GetRecipeByID(int id);
        void CreateRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipeByID(int id);

        IEnumerable<Ingredient> GetIngredients();
        IEnumerable<Ingredient> GetIngredientsForRecipie(int recipeId);
        void GetIngredientById(int id);
        void CreateIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(int id);
    }
}
