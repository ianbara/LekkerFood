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

    public class IngredientCategoryService : EntityService<IngredientCategory>, IIngredientCategoryService
    {
        IUnitOfWork _unitOfWork;
        IIngredientCategoryRepository _ingredientCategoryRepository;

        public IngredientCategoryService(IUnitOfWork unitOfWork, IIngredientCategoryRepository ingredientCategoryRepository)
            : base(unitOfWork, ingredientCategoryRepository)
        {
            _unitOfWork = unitOfWork;
            _ingredientCategoryRepository = ingredientCategoryRepository;
        }


        public IngredientCategory GetById(int Id)
        {
            return _ingredientCategoryRepository.GetById(Id);
        }
    }
}
