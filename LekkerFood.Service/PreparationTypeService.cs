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

    public class PreparationTypeService : EntityService<PreparationType>, IPreparationTypeService
    {
        IUnitOfWork _unitOfWork;
        IPreparationTypeRepository _PreparationTypeRepository;

        public PreparationTypeService(IUnitOfWork unitOfWork, IPreparationTypeRepository PreparationTypeRepository)
            : base(unitOfWork, PreparationTypeRepository)
        {
            _unitOfWork = unitOfWork;
            _PreparationTypeRepository = PreparationTypeRepository;
        }


        public PreparationType GetById(int Id)
        {
            return _PreparationTypeRepository.GetById(Id);
        }
    }
}
