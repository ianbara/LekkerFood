﻿using LekkerFood.Models;
using LekkerFood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository.Repository
{
    public interface IRecipeCategoryRepository : IGenericRepository<RecipeCategory>
    {
        RecipeCategory GetById(long id);
    }
}
