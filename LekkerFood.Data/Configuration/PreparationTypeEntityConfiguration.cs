using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Data.Configuration
{
    public class PreparationTypeEntityConfiguration : EntityTypeConfiguration<PreparationType>
    {
        public PreparationTypeEntityConfiguration()
        {
            this.HasMany(e => e.RecipeIngredients)
             .WithOptional(mt => mt.PreparationType)
              .WillCascadeOnDelete(false);


        }

    }
}
