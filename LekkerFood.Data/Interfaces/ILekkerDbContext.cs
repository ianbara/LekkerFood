using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Data.Interfaces
{
    public interface ILekkerDbContext
    {
        DbSet<IngredientCategory> IngredientCategories { get; set; }
        DbSet<MeasurementType> MeasurementTypes { get; set; }
        DbSet<PreparationType> PreparationTypes { get; set; }
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        DbSet<RecipeCategory> RecipeCategories { get; set; }
        DbSet<Recipe> Recipes { get; set; }

    }
}
