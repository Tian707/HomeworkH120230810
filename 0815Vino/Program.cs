using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _0815Vino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataPresentation();
            // Correct data in the year of 2014 with + 35432
            ChangeOfData(5, +35432);
            Console.WriteLine("\n======================================================= DATA UPDATED =======================================================\n");
            // Print updated data
            DataPresentation();
            Console.WriteLine("\n======================================================= DATA SORTED =======================================================\n");
            SortData();
            Console.ReadLine();
        }


        #region View
        // Data representation: How stars should look like on the screen
        public static void PrintStars(int[,] my2dArray)
        {
            // Add years to the 2D array
            // Print stars
            for(int i = 0; i < my2dArray.GetLength(0); i++)
            {
                Console.Write("Year: " + my2dArray[i, 0] + ": ");
                for (int j = 0; j < my2dArray[i, 1]; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" " + my2dArray[i, 1]);

                Console.WriteLine();
            }
        }
        #endregion

        #region Controller
        // Sorting sales in descending order,
        // use the sorted 2d Array with years and star numbers to PrintStars
        static void SortData()
        {
            
            // Declare an array for star numbers and an array for years
            int[] starSorting = new int[11];
            int[] year = new int[11];

            // Save starsnumber in the array 
            for (int i = 0; i < 11; i++)
            {
                starSorting[i] = stars[i, 1];
            }

            // Sorting star numbers in descending order
            Array.Sort(starSorting);
            Array.Reverse(starSorting);

            /* Match sorted star numbers with year
            * Check all elements in star numbers, if they are identical with the one
            * in stars; if yes, add the year number to the year array 
            */
            for (int i = 0; i < 11; i++)
            {
                for(int j = 0;j < 11; j++)
                {
                    if (starSorting[i] == stars[j, 1])
                    {
                        year[i] = stars[j, 0];
                    }
                }
            }

            // Check if the two arrays work
            //foreach (var y in year)
            //{
            //    Console.WriteLine(y);
            //}
            //foreach (var y in starSorting)
            //{
            //    Console.WriteLine(y);
            //}

            // Push data from the two arrays to a 2D array so we can call PrintStars to present results
            int[,] descendingstars = new int[11, 2];
            for (int i = 0; i < 11; i++)
            {
                descendingstars[i, 0] = year[i];
                descendingstars[i, 1] = starSorting[i];
            }
            PrintStars(descendingstars);

        }
        static int[,] stars = new int[,] { };
        // Get numbers of stars, then call GUI to draw stars
        static void DataPresentation()
        {
            stars = StarilizeWineConsumption();
            PrintStars(stars);
        }

        // Save years and numbers of stars in a 2D array
        static int[,] StarilizeWineConsumption()
        {
            int[,] stars = new int[11, 2];
            
            for (int i = 0; i < 11; i++)
            {
                stars[i, 1] = GetStars(wineSales[i, 1]);
                stars[i, 0] = wineSales[i, 0];
            }
            return stars;
        }

        // Asks for data from modul and calculate numbers of stars
        static int GetStars(int sale)
        {
            int maxSale = 175388;
            int maxStar = 100;
            return sale * maxStar / maxSale;
        }
        
        #endregion

        #region Modul
        static int[,] wineSales =
        {
            {2009, 175134},
            {2010, 175388},
            {2011, 172818},
            {2012, 142709},
            {2013, 161437},
            {2014, 152620},
            {2015, 150979},
            {2016, 152210},
            {2017, 149450},
            {2018, 154398},
            {2019, 150160} 
        };

        // Data for a certain year is wrong, should be adjusted with changeAmount:
        static void ChangeOfData(int yearIndex, int changeAmont)
        {
            wineSales[yearIndex, 1] += changeAmont;
        }
        #endregion
    }
}
