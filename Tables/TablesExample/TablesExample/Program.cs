using System;

namespace TablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tables in Visual Studio are made with using arrays"); 
            int[] numbers = new int[] { 1, 3, 5, 7, 9 };
            //Asetaan arvo numbers taulukkoon
            numbers[4] = 11;

            //Read value from the table.
            Console.WriteLine(numbers[2]);

            //Reads the values ​​in the loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //this code will call the function, and then set the values ​​to the table. 
            numbers = SetNumber(5);

            Console.WriteLine("The number two second powers");
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Press any key to shut down program. ");
        }



        /// <summary>
        /// Sets values ​​to the table,
        /// arraySize will specifies the size of the table. 
        /// </summary>
        /// <returns></returns>
        static int[] SetNumber(int arraySize)
        {
            int[] arrayPower = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayPower[i] =(int)Math.Pow(2, i);
            }
            return arrayPower;
        }
    }
}
