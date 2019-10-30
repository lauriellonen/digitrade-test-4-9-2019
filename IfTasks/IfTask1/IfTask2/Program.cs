using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton tai parillinen");
            Console.Write("Syötä kokonaisia numeroita " );

            int userInputNumber = int.Parse(Console.ReadLine());

            if(userInputNumber % 2 == 0 )
            {
                Console.WriteLine($"Numero {userInputNumber} on parillinen");
            }
            else
            {
                Console.WriteLine($"Numero {userInputNumber} on pariton");
            }
        }
    }
}
