using System;

namespace ExmapleAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int i = 1;
            Console.Write("Ohjelma laskee annettujen lukujen keskiarvon." +
                " Kuinka monta lukua haluat syöttää? ");
            int lkm = int.Parse (Console.ReadLine());

            while(i<=lkm)
            {
                int x = int.Parse(Console.ReadLine());
                summa = summa + x;
                i = i + 1;
            }

            if(lkm > 0)
            {
                double ka = summa / lkm;
                Console.WriteLine("Lukujen keskiarvo on: " + ka);
            }

            else
            {
                Console.WriteLine("Lukuja ei ole syötetty! ");
                    
            }

            Console.WriteLine(lkm);

        }
    }
}
