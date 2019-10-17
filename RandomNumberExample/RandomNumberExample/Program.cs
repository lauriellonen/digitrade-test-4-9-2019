using System;
/// <summary>
/// This is my random number program example
/// made by Lauri Ellonen 
/// </summary>
namespace RandomNumberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input... ");
            int userInput = int.Parse(Console.ReadLine());

            new Random();
        }
    }
}
