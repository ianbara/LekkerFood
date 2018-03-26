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
    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(DbContext context)
            : base(context)
        {

        }

        Recipe IRecipeRepository.GetById(long id)
        {
            return _dbset.Include(x => x.RecipeCategory)
                .Include("RecipeIngredients.Recipe")
                .Include("RecipeIngredients.Ingredient")
                .Include("RecipeIngredients.MeasurementType")
                .Include("RecipeIngredients.PreparationType")
                .Where(x => x.Id == id).FirstOrDefault();
        }

        public override IEnumerable<Recipe> GetAll()
        {
            return _dbset.Include(x => x.RecipeCategory);
        }
    }



}
