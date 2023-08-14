using System;
using System.Security.Cryptography.X509Certificates;

namespace _0814StarsAndStripes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorBackground(76, 26);
            StarsAndBackground(40, 11, ConsoleColor.Blue);
            Console.ReadKey();

            static void StarsAndBackground(int x, int y, ConsoleColor color)
            {
                int[,] coord = new int[x, y];

                for (int j = 0; j < coord.GetLength(1); j++)
                {
                    for (int i = 0; i < coord.GetLength(0); i++)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.BackgroundColor = color;
                        
                        // Print stars on the even- and uneven rows:
                        if(((j % 2 == 0 && i % 7 == 6) || (j % 2 == 1 && i % 7 == 2) ) && j != 0 && j != coord.GetLength(1) - 1)
                        {
                            Console.WriteLine("*");
                        }
                        else
                            Console.WriteLine(" ");
                    }
                }
                Console.ResetColor();
            }
            static void ColorBackground(int x, int y)
            {
                int[,] coord = new int[x, y];
                for (int j = 0; j < coord.GetLength(1); j++)
                {
                    bool changeColor = false;
                    ConsoleColor[] myColor = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.White };

                    if (j == 0 || j % 2 == 0)
                    {
                        changeColor = !changeColor;
                    }

                    for (int i = 0; i < coord.GetLength(0); i++)
                    {
                        Console.SetCursorPosition(i, j);
                        if (changeColor)
                        {
                            if (j % 4 == 0)
                            {
                                Console.BackgroundColor = myColor[0];
                            }
                            else if (j % 4 == 2)
                            {
                                Console.BackgroundColor = myColor[1];
                            }
                        }
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }
}