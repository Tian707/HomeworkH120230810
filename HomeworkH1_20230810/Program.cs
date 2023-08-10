using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace HomeworkH1_20230810
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SetStarBackgroundColor(); 
            PrintStars();
            SetHalfStripeBackgroundColor();
            SetStripeBackgroundColor();

            Console.ReadKey();

        }
        private static void SetStripeBackgroundColor()
        {
            for (int y1 = 12; y1 < 26; y1 += 4)
            {
                for (int x1 = 0; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.Red; 
                    Console.WriteLine(" ");
                }
            }
            for (int y1 = 13; y1 < 26; y1 += 4)
            {
                for (int x1 = 0; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                }
            }
            Console.ResetColor();

            for (int y1 = 11; y1 < 26; y1 += 4)
            {
                for (int x1 = 0; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                }
            }
            for (int y1 = 14; y1 < 26; y1 += 4)
            {
                for (int x1 = 0; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                }
            }
        }

        private static void SetHalfStripeBackgroundColor()
        {
            for(int y1 = 0; y1 < 10; y1 += 4)
            {
                for(int x1 = 44; x1 < 76;  x1 ++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                }
            }
            for (int y1 = 1; y1 < 10; y1 += 4)
            {
                for (int x1 = 44; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                }
            }

            for (int y1 = 2; y1 < 11; y1 += 4)
            {
                for (int x1 = 44; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                }
            }
            for (int y1 = 3; y1 < 11; y1 += 4)
            {
                for (int x1 = 44; x1 < 76; x1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                }
            }
        }
        private static void SetStarBackgroundColor()
        {
            for (int y1 = 0; y1 < 11; y1 ++)
            {
                for (int x1 = 0; x1 < 44; x1 ++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(" ");
                }
            }
        }
        private static void PrintStars()
        {
            for(int y1 = 2; y1 < 9; y1 += 2)
            {
                for(int x1 = 6; x1 < 44; x1 += 7)
                {
                    StarLocation(x1, y1);
                }               
            }
            for (int y1 = 1; y1 < 10; y1 += 2)
            {
                for (int x1 = 2; x1 < 44; x1 += 7)
                {
                    StarLocation(x1, y1);
                }
            }
        }
        private static void StarLocation(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
        }
    }
}