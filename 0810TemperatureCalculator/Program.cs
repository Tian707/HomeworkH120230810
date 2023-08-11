namespace _0810TemperatureCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed;
            do
            {
                ConvertCelsius();
                Console.WriteLine("Press Q to quit, or any other keys to continue...");
                keyPressed = Console.ReadKey();
                Console.Clear();
            }
            while (keyPressed.Key!= ConsoleKey.Q);

        }

        static void ConvertCelsius()
        {
            Console.WriteLine("Hi, what temperature in Celsius would you like to convert to Fahrenheit and Reaumur?");
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();


            while (!Single.TryParse(input, out float cels))
            {
                Console.WriteLine("Oops, wrong format. Please try again.");
                Console.Clear();
                ConvertCelsius();

            }
            float celsius = (float)Convert.ToSingle(input);

            if (celsius < -273.15)
                ConvertCelsius();

            float fahrenheit = (float)(celsius * 1.8 + 32);
            float reaumur = (float)(celsius * 0.8);
            Console.WriteLine($"{celsius} °C is {Math.Round(fahrenheit, 2)} °F and {Math.Round(reaumur, 4)} °R.");


        }

    }
}