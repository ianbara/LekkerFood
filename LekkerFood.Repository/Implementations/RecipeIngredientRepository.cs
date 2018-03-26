using LekkerFood.Models;
using LekkerFood.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository
{
    public class RecipeIngredientRepository : GenericRepository<RecipeIngredient>, IRecipeIngredientRepository
    {
        public RecipeIngredientRepository(DbContext context)
            : base(context)
        {

        }

        public RecipeIngredient GetById(long id)
        {
            return _dbset
                .Include("Recipe")
                .Include("Ingredient")
                .Include("PreparationType")
                .Include("MeasurementType")
                .Where(x => x.Id == id).FirstOrDefault();
        }

        public override IEnumerable<RecipeIngredient> GetAll()
        {
            return _dbset.Include("Ingredient.IngredientCategory").Include("Recipe.RecipeCategory");
        }
    }



}
