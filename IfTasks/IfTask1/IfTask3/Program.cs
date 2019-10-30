using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen " +
                "ja onko luku negatiivinen vai positiivinen");
            Console.Write("Syötä Luku ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber == 0)
            {
                Console.WriteLine($"Numero {userInputNumber} on nolla ja se on positiivinen!");
            }
            else
            {
                if (userInputNumber > 0)
                {
                    Console.WriteLine($"Numero {userInputNumber} on positiivinen!");
                }
                else
                {
                    Console.WriteLine($"Numero {userInputNumber} on negatiivinen");
                }
                if (userInputNumber % 2 == 0)
                {
                    Console.WriteLine($"ja {userInputNumber} on parillinen");
                }
                else
                {
                    Console.WriteLine($"ja {userInputNumber} on pariton");
                }

            }
        }
    }
}