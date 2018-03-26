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
    public class PreperationTypeRepository : GenericRepository<PreparationType>, IPreparationTypeRepository
    {
        public PreperationTypeRepository(DbContext context)
            : base(context)
        {

        }

        public PreparationType GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }



}
