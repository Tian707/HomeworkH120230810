using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0815Mozart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayMMusic();
            //PlayTMusic();
            GenerateWaltz();

            Console.ReadLine();
        }
        #region View

        static void Welcome()
        {
            Console.WriteLine("Welcome to the Mozart Wlatz Generator!");
            Console.WriteLine("Enjoy the music...");
        }
        static void Bye()
        {
            Console.WriteLine("Finish playing.");
        }

        #endregion

        #region Controller



        // Declare SoundPlayer fro playing music
        static System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        private static void GenerateWaltz()
        {
            Welcome();

            // Get random arrays of indexes for both menuets and trios
            int[] mRandom = GetMenuetsRandom();


            // Use for loop to play all menuets sound tracks by random generated numbers
            // Use mRandom[i] to generate mPath
            for (int i = 0; i < 16; i++)
            {
                sp.SoundLocation = @"C:\Wave\M" + mRandom[i] + ".wav";
                sp.Load();
                sp.PlaySync();
            }

            int[] tRandom = GetTriosRandom();
            // Use for loop to play all trios sound tracks by random generated numbers
            // Use tRandom[i] to generate tPath
            for (int i = 0; i < 16; i++)
            {
                sp.SoundLocation = @"C:\Wave\T" + tRandom[i] + ".wav";
                sp.Load();
                sp.PlaySync();
            }

            Bye();
        }
       
        // Play all sound tracks
        static void PlayMMusic()
        {
            // Use soundPlayer
            
            string[,] mPath = GetMPath();
            for(int i = 0; i< 11; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    sp.SoundLocation = mPath[i, j];
                    sp.Load();
                    sp.PlaySync();
                }
            }
        }
        static void PlayTMusic()
        {
            // Use soundPlayer
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            string[,] tPath = GetTPath();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    sp.SoundLocation = tPath[i, j];
                    sp.Load();
                    sp.PlaySync();
                }
            }
        }

       
        #endregion


        #region Modul

        //Generate index of the 16 random parts for meneuts
        static Random random = new Random();
        
        static int[] GetMenuetsRandom()
        {
            // Declare an int array
            int[] menuetsRandom = new int[16];
            // Loop through all 16 paths
            for (int i = 0; i < 16; i++)
            {
                // Roll 2 dice to generate a random number between 2 and 12
                // we set the range to 2 and 13 
                // the index of the 2d array for original data should be j - 2
                int j = random.Next(2, 13);
                menuetsRandom[i] = menuets[j - 2, i];
            }

            // Check menuetsRandom
            //foreach(int rand in menuetsRandom)
            //{
            //    Console.WriteLine(rand);
            //}
            return menuetsRandom;
        }

        static int[] GetTriosRandom()
        {
            // Declare an int array
            int[] triosRandom = new int[16];
            // Loop through all 16 paths
            for (int i = 0; i < 16; i++)
            {
                // Roll 2 dice to generate a random number between 1 and 6
                // we set the range to 1 and 7 
                // the index of the 2d array for original data should be j - 1
                int j = random.Next(1, 7);
                triosRandom[i] = trios[j - 1, i];
            }

            // Check menuetsRandom
            //foreach (int rand in triosRandom)
            //{
            //    Console.WriteLine(rand);
            //}
            return triosRandom;
        }

        // Save path to the files
        static string[,] GetMPath()
        {
            string[,] mPath = new string[11, 16];
            // Use nested for loop to add path to each files
            for(int i = 0; i < 11; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    mPath[i, j] = @"C:\Wave\M" + menuets[i, j] + ".wav";
                }
            }
            return mPath;
        }
        static string[,] GetTPath()
        {
            string[,] tPath = new string[6, 16];
            // Use nested for loop to add path to each files
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    tPath[i, j] = @"C:\Wave\T" + trios[i, j] + ".wav";
                }
            }
            return tPath;
        }

        // 2 2D arrays for Index of parts for meneuts[11, 16] and trios[6, 16]
        static int[,] menuets =
        {
            { 96, 22, 141, 41, 105, 122, 11, 30, 70, 121, 26, 9, 112, 49, 109, 14 },
            { 32, 6, 128, 63, 146, 46, 134, 81, 117, 39, 126, 56, 174, 18, 116, 83 },
            { 69, 95, 158, 13, 153, 55, 110, 24, 66, 139, 15, 132, 73, 58, 145, 79 },
            { 40, 17, 113, 85, 161, 2, 159, 100, 90, 176, 7, 34, 67, 160, 52, 170 },
            { 148, 74, 163, 45, 80, 97, 36, 107, 25, 143, 64, 125, 76, 136, 1, 93 },
            { 104, 157, 27, 167, 154, 68, 118, 91, 138, 71, 150, 29, 101, 162, 23, 151 },
            { 152, 60, 171, 53, 99, 133, 21, 127, 16, 155, 57, 175, 43, 168, 89, 172 },
            { 119, 84, 114, 50, 140, 86, 169, 94, 120, 88, 48, 166, 51, 115, 72, 111 },
            { 98, 142, 42, 156, 75, 129, 62, 123, 65, 77, 19, 82, 137, 38, 149, 8 },
            { 3, 87, 165, 61, 135, 47, 147, 33, 102, 4, 31, 164, 144, 59, 173, 78 },
            { 54, 130, 10, 103, 28, 37, 106, 5, 35, 20, 108, 92, 12, 124, 44, 131 }
        };
        static int[,] trios = 
        {
            { 72, 6, 59, 25, 81, 41, 89, 13, 36, 5, 46, 79, 30, 95, 19, 66 },
            { 56, 82, 42, 74, 14, 7, 26, 71, 76, 20, 64, 84, 8, 35, 47, 88 },
            { 75, 39, 54, 1, 65, 43, 15, 80, 9, 34, 93, 48, 69, 58, 90, 21 },
            { 40, 73, 16, 68, 29, 55, 2, 61, 22, 67, 49, 77, 57, 87, 33, 10 }, 
            { 83, 3, 28, 53, 37, 17, 44, 70, 63, 85, 32, 96, 12, 23, 50, 91 }, 
            { 18, 45, 62, 38, 4, 27, 52, 94, 11, 92, 24, 86, 51, 60, 78, 31 } 
        };

        #endregion





    }
}
