using LekkerFood.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Models
{
    public class MenuItem : AuditableEntity<long>
    {
        [Key]
        public int MenuItemId { get; set; }

        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
