using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_Part_3
{
    public class Cup
    {
        public Brewage Brewage { get; private set; }

        public Cup(Brewage brewage)
        {
            Brewage = brewage;
        }

        public Cup()
        {
            Empty();
        }

        public void Fill(Brewage brewage)
        {
            Brewage = brewage;
        }

        public string Empty()
        {
            Brewage = Brewage.ThinAir;
            return "Cup is empty.";
        }
    }
}
