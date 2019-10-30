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

            Console.WriteLine("For ehto ---------------------------------");
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("WHILE ------------------------------------");
            int j = 0;                          //Calculate parameter
            while(j < userInput)                //Loop is done until it is False 
            {
                Console.WriteLine(j + 1);
                j = j + 1;                      //Increase the counter
                                                //or j++;
            }

            Console.WriteLine("WHILE none stop loop ----------------------");
            int k = 0;
            while (true)                        //none stop loop 
            {
                k++;
                Console.WriteLine(j);           
                if (k >= userInput)
                    break;
            }

            Console.WriteLine("Do-WHILE ----------------------------------");
            int n = 0;
            do
            {
                n++;
                Console.WriteLine(n);

            } while (n < userInput);
        }
    }
}
