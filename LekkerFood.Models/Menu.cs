using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Models
{
    public class Menu : Entity<int>
    {
        [Key]
        public int MenuId { get; set; }
        public DateTime ScheduledDate { get; set; }

        public virtual ICollection<RecipeIngredient> MenuItems { get; set; }

    }

    
}
