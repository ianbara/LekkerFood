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
    public class IngredientCategoryRepository : GenericRepository<IngredientCategory>, IIngredientCategoryRepository
    {
        public IngredientCategoryRepository(DbContext context)
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
