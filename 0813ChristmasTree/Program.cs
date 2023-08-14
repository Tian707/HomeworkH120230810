namespace _0813ChristmasTree
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a height for your digital Christmas tree:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            for (int i = 1; i <= height; i++)
            {
                // For loop to print spaces
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                // For loop to print stars
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    // Define condition for red color
                    if(i % 2 == 0 &&  j % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    
                    Console.Write("*");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}