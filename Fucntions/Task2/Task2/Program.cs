using System;

namespace Task2
{
    /// <summary>
    /// Made by Lauri Ellonen
    /// Program versio 0.1.0 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /* User will input two number between zero and ten and then the program will 
               answer which of the input number is smaller.
             */
            Console.WriteLine("User will input two numbers and this program will tell which number is smaller.");
            Console.Write("please input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write( "please input second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Luku {GetMinNumber(a, b)} on pienempi kuin {GetMaxNumber(a, b)}");
        }
        static int GetMinNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber) //return firstNumber < secondNumber? firstNumber: secondNumber;
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
