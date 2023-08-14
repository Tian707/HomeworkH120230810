
using System;
using System.Diagnostics;
using System.Threading;

namespace _0814Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Danske Spil! \nUgens lottonumre udtrækkes nu...\n"); 
            
            // Declare an int array for eight numbers
            int[] lotto = new int[8];

            // Populate array with eight random numbers between 1 and 37
            for (int i = 0; i < 8; i++)
            {
                Random random = new Random();
                int lottoNr = random.Next(1, 37);
                lotto[i] = lottoNr;
            }

            // Save the last number as joker
            int joker = lotto[7];

            // Resize the array with the first seven numbers
            Array.Resize(ref lotto, 7);

            // Sort array in ascending order
            Array.Sort(lotto);

            // Resize the sorted array and opulate it with joker
            Array.Resize(ref lotto, 8);
            lotto[7] = joker;

            // Display result with 2 seconds' interval
            for (int i = 0; i < lotto.Length; i++)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(2000);
                stopWatch.Stop();
                if (i == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(lotto[i] + " ");
                Console.ResetColor();
            }
            Console.WriteLine("\n\nAre you the lucky one this time?");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}