using System;

namespace IfTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If Task One program will solve users put numbers if they're positive or negative.");
            Console.Write(" please give full number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if(userInputNumber == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} is zero!");
            }
            else
            {
                if(userInputNumber > 0)
                {
                    Console.WriteLine($"Numero {userInputNumber} is positive!");
                }
                else
                {
                    Console.WriteLine($"Luku {userInputNumber} is negative ");
                }
            }
        }
    }
}
