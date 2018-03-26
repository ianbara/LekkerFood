using LekkerFood.Models;
using LekkerFood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository.Repository
{
    public interface IRecipeIngredientRepository : IGenericRepository<RecipeIngredient>
    {
        RecipeIngredient GetById(long id);
    }
}
