using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try parse example");
            string userInput = Console.ReadLine();

            /* double.tryParse 
             * int.tryParse
             *  In the Visual Studio in Finland, the comma is used as a decimal separator.
             */
            bool isNumber = double.TryParse(userInput, out double userNumber);
            if (isNumber == true)
            {
                double dummy = userNumber * 10;
                string dummyString = dummy.ToString();
                Console.WriteLine($"Syöte {userInput} on luku {dummy}");
            }
            else
            {
                Console.WriteLine($"Syöte {userInput} on merkkijono, muuttujan" + 
                    $"userNumber arvo on {userNumber}");
            }
        }
    }
}
