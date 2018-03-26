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

    public class RecipeCategoryService : EntityService<RecipeCategory>, IRecipeCategoryService
    {
        IUnitOfWork _unitOfWork;
        IRecipeCategoryRepository _RecipeCategoryRepository;

        public RecipeCategoryService(IUnitOfWork unitOfWork, IRecipeCategoryRepository RecipeCategoryRepository)
            : base(unitOfWork, RecipeCategoryRepository)
        {
            _unitOfWork = unitOfWork;
            _RecipeCategoryRepository = RecipeCategoryRepository;
        }


        public RecipeCategory GetById(int Id)
        {
            return _RecipeCategoryRepository.GetById(Id);
        }
    }
}
