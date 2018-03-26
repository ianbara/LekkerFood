using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Repository.Configuration
{
    public class RecipeCategoryEntityConfiguration : EntityTypeConfiguration<RecipeCategory>
    {
        public RecipeCategoryEntityConfiguration()
        {
            this.HasMany(e => e.Recipes)
               .WithRequired(e => e.RecipeCategory)
               .WillCascadeOnDelete(false);

        }
    }
}
