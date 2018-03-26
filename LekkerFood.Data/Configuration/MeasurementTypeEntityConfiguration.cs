using LekkerFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Data.Configuration
{
    public class MeasurementTypeEntityConfiguration : EntityTypeConfiguration<MeasurementType>
    {
        public MeasurementTypeEntityConfiguration()
        {
            this.HasMany(e => e.RecipeIngredients)
             .WithOptional(mt => mt.MeasurementType)
              .WillCascadeOnDelete(false);

        }

    }
}
