using LekkerFood.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Models
{
    public class Recipe : Entity<int>
    {
        public Recipe()
        {
            RecipeIngredients = new List<RecipeIngredient>();
        }

        public Recipe(int recipeId)
        {
        }

        public string Name { get; set; }
        public byte[] Photo { get; set; }

        public string PhotoThumbUrl
        {
            get { return "http://lorempixel.com/100/100/food"; }
        }
        public int Rating { get; set; }
        public bool Freezable { get; set; }
        public int Servings { get; set; }
        public int PrepTime { get; set; }
        public int CookingTime { get; set; }
        
        public int TotalTime
        {
            get {
                return PrepTime + CookingTime;

            }
        }

        public string Method { get; set; }

        public string RecipeLink { get; set; }
        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }
        public bool GlutenFree { get; set; }
        public bool ContainsNuts { get; set; }

        public float Cost { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }

        public int RecipeCategoryId { get; set; }

        public virtual RecipeCategory RecipeCategory { get; set; }
    }  

    
}
