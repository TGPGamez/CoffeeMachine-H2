using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_Part_3
{
    public class Can
    {
        public Brewage Brewage { get; private set; }

        public Can(Brewage brewage)
        {
            Brewage = brewage;
        }

        public Can()
        {
            Empty();
        }

        public void Fill(Brewage brewage)
        {
            Brewage = brewage;
        }


        /// <summary>
        /// Emptys can
        /// </summary>
        /// <returns></returns>
        public string Empty()
        {
            Brewage = Brewage.ThinAir;
            return "Can is empty.";
        }
    }
}
