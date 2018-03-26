using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekkerFood.Models
{
    public class CheckList : Entity<int>
    {
        public CheckList()
        {
            Ingredients = new List<Ingredient>();
        }

        public int CheckListId { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
