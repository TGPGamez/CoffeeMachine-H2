using System;

namespace CoffeeMachine_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeMachine = new CoffeeMachine();
            //Turn on machine
            Console.WriteLine(coffeMachine.TurnOn());

            Console.WriteLine();
            Console.WriteLine("COFFEE IN CAN");
            //Insert Coffee filter into machine
            Console.WriteLine(" - " + coffeMachine.InsertFilter(new Filter("Coffee", 20)));
            //Fill machine with water
            Console.WriteLine(" - " + coffeMachine.FillWithWater(100));
            //Creates empty can
            Can can = new Can();
            //Use empty can object as an reference to brew
            Console.WriteLine(" - " + coffeMachine.Brew(ref can));
            //Display information
            Console.WriteLine(" - " + can.Brewage.ToString());
            Console.WriteLine(" - " + coffeMachine.FilterHolder.Filter.ToString());
            Console.WriteLine();

            //Remove Coffee filter from machine
            Console.WriteLine(coffeMachine.RemoveFilter());

            Console.WriteLine();
            Console.WriteLine("TEA IN CUP");
            //Insert Tea filter into machine
            Console.WriteLine(" - " + coffeMachine.InsertFilter(new Filter("Tea", 35)));
            //Fill machine with water
            Console.WriteLine(" - " + coffeMachine.FillWithWater(200));
            //Empty can display
            Console.WriteLine(" - " + can.Empty());
            //Use empty can object as an reference to brew
            Console.WriteLine(" - " + coffeMachine.Brew(ref can));
            //Display information
            Console.WriteLine(" - " + can.Brewage.ToString());
            Console.WriteLine(" - " + coffeMachine.FilterHolder.Filter.ToString());
            Console.WriteLine();

            //Remove Coffee filter from machine
            Console.WriteLine(coffeMachine.RemoveFilter());

            Console.WriteLine();
            Console.WriteLine("EKSPRESSO IN CUP");
            //Insert Ekspresso filter into machine
            Console.WriteLine(" - " + coffeMachine.InsertFilter(new Filter("Ekspresso", 40)));
            //Fill machine with water
            Console.WriteLine(" - " + coffeMachine.FillWithWater(50));
            Cup cup = new Cup();
            //Use empty cup object as an reference to brew
            Console.WriteLine(" - " + coffeMachine.Brew(ref cup));
            //Display information
            Console.WriteLine(" - " + cup.Brewage.ToString());
            Console.WriteLine(" - " + coffeMachine.FilterHolder.Filter.ToString());
            Console.WriteLine();

            //Turn off machine
            Console.WriteLine(coffeMachine.TurnOff());
        }
    }
}
