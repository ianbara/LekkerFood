//using LekkerFood.Service.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using LekkerFood.Repository.Interfaces;
//using LekkerFood.Models;

//namespace LekkerFood.Service
//{
//    public class FoodService : IFoodService
//    {
//        private IUnitOfWork _uow;
//        private IRepository<Recipe> _Recipe;
//        private IRepository<Ingredient> _Ingredient;

//        public FoodService(IUnitOfWork uow)
//        {
//            _uow = uow;
//            _Recipe = _uow.GetRepository<Recipe>();
//            _Ingredient = _uow.GetRepository<Ingredient>();
//        }

//        public IEnumerable<Recipe> GetRecipes()
//        {
//            return _Recipe.GetAll().ToList();
//        }


//        public Recipe GetRecipeByID(int id)
//        {
//            try
//            {
//                return _Recipe.GetAll().Where(s => s.RecipeId == id).SingleOrDefault();
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Failure getting note", ex);
//            }
//        }

//        public void CreateRecipe(Recipe recipe)
//        {
//            _Recipe.Add(recipe);
//            _uow.Save();
//        }

//        public void UpdateRecipe(Recipe recipe)
//        {
//            _Recipe.Update(recipe);
//            _uow.Save();
//        }

//        public void DeleteRecipeByID(int id)
//        {
//            try
//            {
//                Recipe model = _Recipe.GetAll().Where(s => s.RecipeId == id).SingleOrDefault();
//                _Recipe.Delete(model);
//                _uow.Save();
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Failure deleting recipe", ex);
//            }
//        }


//        public IEnumerable<Ingredient> GetIngredients()
//        {
//            return _Ingredient.GetAll().ToList();
//        }

//        public IEnumerable<Ingredient> GetIngredientsForRecipie(int recipeId)
//        {
//            throw new NotImplementedException();
//        }

//        public void GetIngredientById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void CreateIngredient(Ingredient ingredient)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateIngredient(Ingredient ingredient)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteIngredient(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
