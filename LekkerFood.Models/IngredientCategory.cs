using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LekkerFood.Models
{
    public class IngredientCategory : Entity<int>
    {
        public string Name { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }

    }
}
