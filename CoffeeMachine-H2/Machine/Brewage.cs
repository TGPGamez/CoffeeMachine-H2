using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    public class Brewage
    {
        public int MlAmount { get; private set; }
        public double Concentration { get; private set; }
        public string Name { get; private set; }
        public static Brewage ThinAir { get => new Brewage(0,0, "Thin air"); }

        public Brewage(int mlAmount, int ingredientAmount, string name)
        {
            MlAmount = mlAmount;
            //Calculate concentration
            Concentration = (mlAmount / 100.0) * ingredientAmount;
            Name = name;
        }

        /// <summary>
        /// Checks if brewage is Thin air
        /// </summary>
        /// <returns></returns>
        public bool CheckIsThinAir()
        {
            if (Name == "Thin air")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns information of brewage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Brewage consists of {MlAmount}ml {Name} with a concentration of {Concentration}%";
        }
    }
}
