using System;

namespace IfTask14
{
    /// <summary>
    /// Versio 0.1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will sort the numbers from smaalest to biggest. ");

            //Program will ask user the first number. 
            Console.WriteLine("Input first number: ");
            int x = int.Parse(Console.ReadLine());

            //Program will ask user the second number.
            Console.Write("Input second number: ");
            int y = int.Parse(Console.ReadLine());

            //Program will ask user the third number.
            Console.Write("Input third number: ");
            int z = int.Parse(Console.ReadLine());

            //Here is where the number sorting will happen. 
            if (x > y) { }
                if (y > z)
                    Console.WriteLine($"{z},{y},{x}");
                else if (x > z)
                    Console.WriteLine($"{y},{z},{x}");
                else Console.WriteLine($"{y},{x},{z}");
            if (y > x)
                if (x > z)
                    Console.WriteLine($"{z},{x},{y}");
                else if (y > z)
                    Console.WriteLine($"{x},{z},{y}");
                else Console.WriteLine($"{x},{y},{z}");

            //Message to use how to close program. 
            Console.WriteLine("Press any button to close program");
        }
    }
}
