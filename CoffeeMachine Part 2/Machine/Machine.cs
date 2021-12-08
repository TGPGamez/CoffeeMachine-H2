using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_Part_2
{
    public abstract class Machine
    {
        public bool IsTurnedOn { get; protected set; }

        /// <summary>
        /// Turns on machine
        /// </summary>
        /// <returns></returns>
        public virtual string TurnOn()
        {
            if (IsTurnedOn)
            {
                return "Machine is already turned on.";
            }
            IsTurnedOn = true;
            return "Machine was turned on";
        }

        /// <summary>
        /// Turns off machine
        /// </summary>
        /// <returns></returns>
        public virtual string TurnOff()
        {
            if (!IsTurnedOn)
            {
                return "Machine is already turned off.";
            }
            IsTurnedOn = false;
            return "Machine was turned off";
        }

        public Machine()
        {
            IsTurnedOn = false;
        }
    }
}
