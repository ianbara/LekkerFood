using LekkerFood.Data.Interfaces;
using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Data.Repository
{
    public interface IIngredientCategoryRepository : IGenericRepository<IngredientCategory>
    {
        IngredientCategory GetById(long id);
    }
}
