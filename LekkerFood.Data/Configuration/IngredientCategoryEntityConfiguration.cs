using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Data.Configuration
{
    public class IngredientCategoryEntityConfiguration : EntityTypeConfiguration<IngredientCategory>
    {
        public IngredientCategoryEntityConfiguration()
        {
            this.HasMany(e => e.Ingredients)
               .WithRequired(e => e.IngredientCategory)
               .WillCascadeOnDelete(false);

        }
    }
}
