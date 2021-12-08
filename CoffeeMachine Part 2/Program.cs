using System;

namespace CoffeeMachine_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeMachine = new CoffeeMachine();
            //Turn on machine
            Console.WriteLine(coffeMachine.TurnOn());
            
            Console.WriteLine();
            //Insert Coffee filter into machine
            Console.WriteLine("COFFEE IN CAN");
            Console.WriteLine(coffeMachine.InsertFilter(new Filter("Coffee", 20)));
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

            //Remove Coffee filter from machine
            Console.WriteLine(coffeMachine.RemoveFilter());
            //Insert Tea filter into machine
            Console.WriteLine("TEA IN CUP");
            Console.WriteLine(coffeMachine.InsertFilter(new Filter("Tea", 35)));
            //Fill machine with water
            Console.WriteLine(coffeMachine.FillWithWater(200));
            Console.WriteLine();

            //Empty can display
            Console.WriteLine(can.Empty());

            //Use empty can object as an reference to brew
            Console.WriteLine(coffeMachine.Brew(ref can));
            //Display information
            Console.WriteLine(can.Brewage.ToString());
            Console.WriteLine(coffeMachine.FilterHolder.Filter.ToString());
            Console.WriteLine();

            //Turn off machine
            Console.WriteLine(coffeMachine.TurnOff());
        }
    }
}
