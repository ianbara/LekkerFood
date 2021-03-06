﻿using LekkerFood.Repository.Interfaces;
using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Service.Interfaces
{
    public interface IIngredientService : IEntityService<Ingredient>
    {
        Ingredient GetById(int Id);
    }

}
