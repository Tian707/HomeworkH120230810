namespace _0811BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetBMI();
        }
        
        private static void GetBMI()
        {
            string weight, height;
            float kg, m;
            float bmi = 0;
            ConsoleKeyInfo keyPressed = default(ConsoleKeyInfo);
            do
            {
                // Get user input and validate format and value.
                
                Console.WriteLine("Welcome to the BMI caculator!");
                Console.WriteLine("Please enter your weight in kilogram:");
                weight = Console.ReadLine();
                if (!Single.TryParse(weight, out kg) || kg <= 0)
                {
                    Console.WriteLine("Wrong input format. Please try again.");
                    
                    continue;
                }
                
                Console.WriteLine("Please enter your height in meter:");
                height = Console.ReadLine();
                if (!Single.TryParse(height, out m) || m <= 0)
                {
                    Console.WriteLine("Wrong input format. Please try again.");
                    continue;
                }

                bmi = (float)Math.Round(kg / (m * m), 2);

                if(bmi > 16 && bmi < 18.5)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"BMI: {bmi}, body weight deficit.");
                    Console.ResetColor();
                }
                else if (bmi >= 18.5 && bmi < 24)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"BMI: {bmi}, norm.");
                    Console.ResetColor();
                }
                else if (bmi >= 24 && bmi < 30)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"BMI: {bmi}, weight over.");
                    Console.ResetColor();
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"BMI: {bmi}, obesity: first degree.");
                    Console.ResetColor();
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"BMI: {bmi}, obesity: second degree.");
                    Console.ResetColor();
                }
                else if (bmi >= 40)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"BMI: {bmi}, obesity: third degree.");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Error with data. Please try again.");
                }
                Console.WriteLine("Press Q to quit, or any other key to continue");
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
            }
            while (keyPressed.Key != ConsoleKey.Q);
        }
    }
}