using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_Part_2
{
    public class FilterHolder
    {
        public Filter Filter { get; set; } = null;

        public string InsertFilter(Filter filter)
        {
            if (Filter == null)
            {
                Filter = filter;
                return "Filter was inserted.";
            }
            return "There is already a filter in the holder.";
        }

        public string RemoveFilter()
        {
            Filter = null;
            return "Filter was removed.";
        }

        public bool HasCleanFilterWithIngredient()
        {
            return (Filter != null) && (!Filter.IsSoaked) && (Filter.IngredientAmount > 0);
        }

        public override string ToString()
        {
            if (Filter == null)
            {
                return "No filter in the holder";
            }
            return "Filter in the holder";
        }
    }
}
