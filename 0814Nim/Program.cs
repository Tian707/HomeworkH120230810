namespace _0814Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game of Nim!");
            Console.WriteLine("We start with seven matchsticks: \nYou can take one or two or three matchstick(s).");
            // declare variables
            ConsoleKeyInfo keyPressed = default(ConsoleKeyInfo);
            int remain = 7; ;

            do
            {
                while (true) {
                    
                try
                {
                    Console.WriteLine("Enter number: 1 or 2 or 3: ");
                    // UserMove
                    int userMove = Convert.ToInt32(Console.ReadLine());
                    if (userMove > 3 || userMove >= remain)
                    {
                        Console.WriteLine("Invalid, please try again.");
                        continue;
                    }

                    else
                    {
                        remain -= userMove;
                        if (remain == 1)
                        {
                            Console.WriteLine("One matchstick left, you Win.");
                            Console.WriteLine("Press enter to play again, or Esc to quit game.");
                            keyPressed = Console.ReadKey();
                            break;

                        }
                        else
                            Console.WriteLine($"{remain} matchstick(s) left.");
                    }


                    // ComputerMove
                    Random random = new Random();
                    int computerMove = random.Next(1, 4);
                    // Validate computerMover is less than remain
                    while (computerMove >= remain)
                    {
                        computerMove = random.Next(1, 4);
                    }

                    remain -= computerMove;
                    if (remain == 1)
                    {
                        Console.WriteLine($"The computer takes {computerMove} matchsticks, {remain} matchstick(s) left.\nYou lose.");
                        Console.WriteLine("Press enter to play again, or Esc to quit game.");
                        keyPressed = Console.ReadKey();
                        break;

                    }
                    else
                        Console.WriteLine($"The computer takes {computerMove} matchsticks, {remain} matchstick(s) left.");

                }


                catch
                {
                    Console.WriteLine("Wrong number format. Please try again.");
                    continue;
                }
                }
                remain = 7;
            }
            while (keyPressed.Key != ConsoleKey.Escape);

        }
    }
}