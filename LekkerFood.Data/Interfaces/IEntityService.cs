using LekkerFood.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LekkerFood.Data.Interfaces
{
    public interface IEntityService<T> : IService
     where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
