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

    public class MeasurementTypeService : EntityService<MeasurementType>, IMeasurementTypeService
    {
        IUnitOfWork _unitOfWork;
        IMeasurementTypeRepository _measurementTypeRepository;

        public MeasurementTypeService(IUnitOfWork unitOfWork, IMeasurementTypeRepository measurementTypeRepository)
            : base(unitOfWork, measurementTypeRepository)
        {
            _unitOfWork = unitOfWork;
            _measurementTypeRepository = measurementTypeRepository;
        }

        MeasurementType IMeasurementTypeService.GetById(int Id)
        {
            return _measurementTypeRepository.GetById(Id);
        }
    }
}
