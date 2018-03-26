using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LekkerFood.Models
{
    public class MeasurementType : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
