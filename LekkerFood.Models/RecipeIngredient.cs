using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LekkerFood.Models
{
    public class RecipeIngredient : Entity<int>
    {

        public RecipeIngredient()
        {
        }

        public RecipeIngredient(int recipeId)
        {
            RecipeId = recipeId; 
        }

        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int Quantity { get; set; }

        public string QuantityDetails { get; set; }

        public int? MeasurementTypeId { get; set; }
        public virtual MeasurementType MeasurementType { get; set; }


        public int? PreparationTypeId { get; set; }
        public virtual PreparationType PreparationType { get; set; }

        public string PreparationDetails { get; set; }
    }
}
