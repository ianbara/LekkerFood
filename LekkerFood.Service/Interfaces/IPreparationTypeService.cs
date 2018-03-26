﻿using LekkerFood.Repository.Interfaces;
using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Service.Interfaces
{
    public interface IPreparationTypeService : IEntityService<PreparationType>
    {
        PreparationType GetById(int Id);
    }

}
