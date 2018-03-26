using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LekkerFood.Models
{
    public class PreparationType : Entity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
