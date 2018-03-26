using LekkerFood.Models;
using LekkerFood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository.Repository
{
    public interface IMeasurementTypeRepository : IGenericRepository<MeasurementType>
    {
        MeasurementType GetById(long id);
    }
}
