namespace _0811Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the dice game!");
            ConsoleKeyInfo keyPressed;
            do
            {
                Random random = new Random();
                int dice = random.Next(1, 7);

                switch (dice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You hit a one!");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You hit a two!");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You hit a three!");
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You hit a four!");
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You hit a five!");
                        Console.ResetColor();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You hit a six!");
                        Console.ResetColor();
                        break;
                }
                Console.WriteLine("Press enter to continue, or Esc to quit game.");
                keyPressed = Console.ReadKey();
                

            }
            while(keyPressed.Key != ConsoleKey.Escape);
        }
    }
}