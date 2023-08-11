using System.ComponentModel.DataAnnotations;

namespace VolumeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetVolume();
            
        }

        static void GetVolume()
        {

            float length, width, height;
            float volume = 0;
            Console.Title = "Volume Calculator";

            while (volume == 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Volume Calculator for boxes!");
                    Console.WriteLine("Please enter the length:");
                    length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the width:");
                    width = float.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the height:");
                    height = float.Parse(Console.ReadLine());
                    volume = length * width * height;
                    if (volume < 0)
                    {
                        Console.WriteLine("The inputs cannot be negative, press any key to try again.");
                        Console.ReadKey();
                        GetVolume();
                    }
                    Console.WriteLine($"The volume of your box is {Math.Round(volume, 3)}.");
                }
                catch
                {
                    Console.WriteLine("Invalid number format. Please try again.");
                }
            }
        }


    }
}