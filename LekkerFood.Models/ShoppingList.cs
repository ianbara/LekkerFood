using LekkerFood.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Models
{
    public class ShoppingList : AuditableEntity<long>
    {
        [Key]
        public int ShoppingListId { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
