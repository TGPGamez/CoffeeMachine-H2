using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    public class CoffeeMachine : Machine
    {
        public FilterHolder FilterHolder { get; private set; } = new FilterHolder();
        public int WaterMlAmount { get; private set; } = 0;

        public string InsertFilter(Filter filter) => FilterHolder.InsertFilter(filter);
        public string RemoveFilter() => FilterHolder.RemoveFilter();
        public string FillWithWater(int mlAmount)
        {
            WaterMlAmount += mlAmount;
            return $"Added {mlAmount}ml Water to the machine";
        }

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
