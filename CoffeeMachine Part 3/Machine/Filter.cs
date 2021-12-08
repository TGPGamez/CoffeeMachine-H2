using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_Part_3
{
    public class Filter
    {
        public string IngredientName { get; set; }
        public int IngredientAmount { get; set; }
        public bool IsSoaked { get; set; } = false;


        public Filter(string ingredientName, int ingredientAmount)
        {
            IngredientName = ingredientName;
            IngredientAmount = ingredientAmount;
        }

        /// <summary>
        /// Pour water in brewage
        /// </summary>
        /// <param name="mlAmount"></param>
        /// <returns></returns>
        public Brewage PourWater(int mlAmount)
        {
            IsSoaked = true;
            return new Brewage(mlAmount, IngredientAmount, IngredientName);
        }

        public override string ToString()
        {
            return $"The filter has {IngredientAmount}g {IngredientName} in it";
        }
    }
}
