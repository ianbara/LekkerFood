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

    public class IngredientService : EntityService<Ingredient>, IIngredientService
    {
        IUnitOfWork _unitOfWork;
        IIngredientRepository _ingredientRepository;

        public IngredientService(IUnitOfWork unitOfWork, IIngredientRepository ingredientRepository)
            : base(unitOfWork, ingredientRepository)
        {
            _unitOfWork = unitOfWork;
            _ingredientRepository = ingredientRepository;
        }


        public Ingredient GetById(int Id)
        {
            return _ingredientRepository.GetById(Id);
        }

    }
}
