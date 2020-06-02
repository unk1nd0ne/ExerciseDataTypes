using System;

namespace ExerciseMoreNumericTypes
{
    class Program
    {
        private static void Main()
        {
            string input;
            double miles;
            double gas;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            miles = double.Parse(input);
            Console.WriteLine("How much gas (gal) did you use?");
            input = Console.ReadLine();
            gas = double.Parse(input);
            Console.WriteLine("You attained " + (miles / gas) + " miles per gallon.");
        }
    }
}
