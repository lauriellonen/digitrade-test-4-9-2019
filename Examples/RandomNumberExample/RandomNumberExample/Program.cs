using System;
/// <summary>
/// Make a program that will prints integers 1-10 and their square roots.
/// made by Lauri Ellonen
/// Saimia UAS 17.10.19
/// </summary>
namespace RandomNumberExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hello world: ");
            //Random number generation
            Random rnd = new Random();
            #region
            //Loop that prints the rows 
            for (int r = 0; r < 4; r++)
            {
                Console.WriteLine($"Rivi{r+1}: ");

                for (int i = 0; i < 5; i++)
                {
                    if (i < 4)
                    {
                        Console.WriteLine($"{rnd.Next(0, 51)}, ");
                    }

                    else
                    {
                        Console.Write(rnd.Next(0, 51));
                        
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}
