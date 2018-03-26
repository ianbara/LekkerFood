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
    public class IngredientRepository : GenericRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(DbContext context)
            : base(context)
        {

        }

        Ingredient IIngredientRepository.GetById(long id)
        {
            return _dbset.Include(x => x.IngredientCategory).Where(x => x.Id == id).FirstOrDefault();
        }

        public override IEnumerable<Ingredient> GetAll()
        {
            return _dbset.Include(x => x.IngredientCategory);
        }
    }



}
