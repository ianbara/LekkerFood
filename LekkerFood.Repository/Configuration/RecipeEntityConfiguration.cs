
using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository.Configuration
{
    public class RecipeEntityConfiguration : EntityTypeConfiguration<Recipe>
    {
        public RecipeEntityConfiguration()
        {
            this.HasMany(e => e.RecipeIngredients)
               .WithRequired(e => e.Recipe)
               .WillCascadeOnDelete(false);

        }

    }
}
