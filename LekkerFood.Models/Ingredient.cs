using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LekkerFood.Models
{
    public class Ingredient : Entity<int>
    {
        public Ingredient()
        {

        }

        public string Name { get; set; }

        public int IngredientCategoryId { get; set; }

        public virtual IngredientCategory IngredientCategory { get; set; }

        public int Calories { get; set; }
        public int Sodium { get; set; }  //Salt content
        public int Carbohydrates { get; set; }
        public int Protien { get; set; }
        public int Fibre { get; set; }
        public int Sugar { get; set; }
        public int Fat { get; set; }
    }
}
