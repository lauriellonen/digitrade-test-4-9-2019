using System;
/// <summary>
/// Tehdään ohjelma, joka tulostaa N:n arvon 
/// Tehtävä 3. Factional
/// Lauri Ellonen 
/// </summary>

namespace Kertoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int fact = 1;

            //Print a message to user
            Console.WriteLine("Kertoma laskenta");
            Console.WriteLine("Minkä luvun kertoma lasketaan ? ");
            n = int.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("Virheelinen Syöte!");
            }
            else
            {
                //Loop, where parameter is count. 
                while(n > 0)
                {
                    fact = fact * n;
                    n = n - 1;
                }
                Console.WriteLine("Vastaus: " + fact);
            }
        }
    }
}
