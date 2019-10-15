using System;

namespace Ehto32Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program will calculate N number multiply");
            Console.Write("Input number ");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 0; i <= userInput; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
