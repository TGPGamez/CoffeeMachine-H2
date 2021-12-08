using System;

namespace CoffeeMachine_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeMachine = new CoffeeMachine();
            //Turn on machine
            Console.WriteLine(coffeMachine.TurnOn());
            Console.WriteLine();
            //Insert new filter into machine
            Console.WriteLine(coffeMachine.InsertFilter(new Filter("Coffee", 10)));
            //Fill machine with water
            Console.WriteLine(coffeMachine.FillWithWater(100));
            Console.WriteLine();

            //Creates empty can
            Can can = new Can();
            //Use empty can object as an reference to brew
            Console.WriteLine(coffeMachine.Brew(ref can));
            //Display information
            Console.WriteLine(can.Brewage.ToString());
            Console.WriteLine(coffeMachine.FilterHolder.Filter.ToString());
            Console.WriteLine();

            //Remove filter from machine
            Console.WriteLine(coffeMachine.RemoveFilter());
            Console.WriteLine();
            //Turn off machine
            Console.WriteLine(coffeMachine.TurnOff());
        }
    }
}
