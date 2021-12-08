using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_Part_2
{
    public class CoffeeMachine : Machine
    {
        public FilterHolder FilterHolder { get; private set; } = new FilterHolder();
        public int WaterMlAmount { get; private set; } = 0;

        /// <summary>
        /// Inserts a filter to filterholder
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public string InsertFilter(Filter filter) => FilterHolder.InsertFilter(filter);
        
        /// <summary>
        /// Removes filter from filterholder
        /// </summary>
        /// <returns></returns>
        public string RemoveFilter() => FilterHolder.RemoveFilter();
        
        /// <summary>
        /// Fills coffeemachine with water
        /// </summary>
        /// <param name="mlAmount"></param>
        /// <returns></returns>
        public string FillWithWater(int mlAmount)
        {
            WaterMlAmount += mlAmount;
            return $"Added {mlAmount}ml Water to the machine";
        }

        /// <summary>
        /// Brews ingredients in machine
        /// </summary>
        /// <param name="can"></param>
        /// <returns></returns>
        public string Brew(ref Can can)
        {
            if ((!FilterHolder.HasCleanFilterWithIngredient()) || (WaterMlAmount <= 0))
            {
                return "Couldn't brew!";
            }
            else
            {
                Brewage brewage = FilterHolder.Filter.PourWater(WaterMlAmount);
                can.Fill(brewage);

                WaterMlAmount = 0;

                return $"{FilterHolder.Filter.IngredientName} was brewed in can.";
            }
        }
    }
}
