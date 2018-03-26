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

    public class RecipeIngredientService : EntityService<RecipeIngredient>, IRecipeIngredientService
    {
        IUnitOfWork _unitOfWork;
        IRecipeIngredientRepository _recipeIngredientRepository;

        public RecipeIngredientService(IUnitOfWork unitOfWork, IRecipeIngredientRepository recipeIngredientRepository)
            : base(unitOfWork, recipeIngredientRepository)
        {
            _unitOfWork = unitOfWork;
            _recipeIngredientRepository = recipeIngredientRepository;
        }


        public RecipeIngredient GetById(int Id)
        {
            return _recipeIngredientRepository.GetById(Id);
        }

    }
}
