using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Data.Repository
{
    public class IngredientCategoryRepository : GenericRepository<IngredientCategory>, IIngredientCategoryRepository
    {
        public IngredientCategoryRepository(LekkerDbContext context)
            : base(context)
        {

        }

        //public override IEnumerable<IngredientCategory> GetAll()
        //{
        //    return _entities.Set<Person>().Include(x => x.Country).AsEnumerable();
        //}

        public IngredientCategory GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
            //return _dbset.Include(x => x.Country).Where(x => x.Id == id).FirstOrDefault();
        }
    }
   

}
