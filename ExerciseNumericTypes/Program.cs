using System;

namespace ExerciseNumericTypes
{
    class Program
    {
        static void Main()
        {
            string input;
            int length;
            int width;

            Console.WriteLine("What is the length of the rectangle?");
            input = Console.ReadLine();
            length = int.Parse(input);
            Console.WriteLine("What is the width of the rectangle?");
            input = Console.ReadLine();
            width = int.Parse(input);
            Console.WriteLine("The area of the rectangle is: " + (length * width));
        }
    }
}
