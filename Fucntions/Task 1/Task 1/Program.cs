using System;

namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Main Program. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("The program will print the number of stars according to the number user is input");
            Console.Write("Input full number: ");
            int userInputNumber = int.Parse(Console.ReadLine());
            if (IsValidNumber(userInputNumber))
            {
                string strStars = StarAmountGenerator(userInputNumber);
                Console.WriteLine(strStars);
                //Console.WriteLine(StarAmountGenerator(userInput))
            }
            else
            {
                Console.WriteLine($"{userInputNumber} Is invalid! ");
            }

        }
        
        static bool IsValidNumber(int userInputNumber)
        {
            return userInputNumber > 0;

            /*if (userInputNumber > 0)
            {
                return true;
            }
            return false;
            */
        }

        /// <summary>
        /// The Program will generate the parameter amount of star. 
        /// </summary>
        /// <param name="StarsCounter"></param>
        /// <returns></returns>

        static string StarAmountGenerator(int StarsCounter)
        {
            string stars = "";
            for (int i = 0; i < StarsCounter; i++)
            {
                stars = stars + "*";    //old way. 
                /*stars += "*"; */      //Microsoft's new recomended way to do this thing. 
            }
            return stars;
        }
    }
}
