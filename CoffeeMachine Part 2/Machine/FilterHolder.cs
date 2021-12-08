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

        /// <summary>
        /// Inserts a filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public string InsertFilter(Filter filter)
        {
            if (Filter == null)
            {
                Filter = filter;
                return "Filter was inserted.";
            }
            return "There is already a filter in the holder.";
        }

        /// <summary>
        /// Removes current filter
        /// </summary>
        /// <returns></returns>
        public string RemoveFilter()
        {
            Filter = null;
            return "Filter was removed.";
        }

        /// <summary>
        /// Checks if filter has ingredients available
        /// </summary>
        /// <returns></returns>
        public bool HasCleanFilterWithIngredient()
        {
            return (Filter != null) && (!Filter.IsSoaked) && (Filter.IngredientAmount > 0);
        }

        /// <summary>
        /// Returns whether filter has holder or not.
        /// </summary>
        /// <returns></returns>
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
