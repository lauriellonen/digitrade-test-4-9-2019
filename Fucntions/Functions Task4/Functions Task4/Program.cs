using System;

namespace Functions_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa syötetyistä luvuista suurimman luvun");
            MaxNumberCalculator();
        }
        static string MaxNumberCalculator()
        {
            Console.WriteLine("Syötä 10 kokonaislukua");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.");
            }
            return "";
        }
    }
}
