using LekkerFood.Repository;
using LekkerFood.Repository.Interfaces;
using LekkerFood.Models;
using LekkerFood.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LekkerFood.Repository.Repository;

namespace LekkerFood.Service
{

    public class RecipeService : EntityService<Recipe>, IRecipeService
    {
        IUnitOfWork _unitOfWork;
        IRecipeRepository _recipeRepository;

        public RecipeService(IUnitOfWork unitOfWork, IRecipeRepository recipeRepository)
            : base(unitOfWork, recipeRepository)
        {
            _unitOfWork = unitOfWork;
            _recipeRepository = recipeRepository;
        }


        public Recipe GetById(int Id)
        {
            return _recipeRepository.GetById(Id);
        }

    }
}
