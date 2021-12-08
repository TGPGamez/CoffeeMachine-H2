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
            Concentration = (mlAmount / 100.0) * ingredientAmount;
            Name = name;
        }

        public bool CheckIsThinAir()
        {
            if (Name == "Thin air")
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Brewage consists of {MlAmount}ml {Name} with a concentration of {Concentration}%";
        }
    }
}
