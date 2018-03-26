using LekkerFood.Models;
using LekkerFood.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository
{
    public class MeasurementTypeRepository : GenericRepository<MeasurementType>, IMeasurementTypeRepository
    {
        public MeasurementTypeRepository(DbContext context)
            : base(context)
        {

        }
        public MeasurementType GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }



}
