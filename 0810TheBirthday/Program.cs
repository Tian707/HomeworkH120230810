using System.Globalization;
using System.Threading.Channels;

namespace _0810TheBirthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AskBirthday();
            string inputBirthday = Console.ReadLine();

            DateTime birthday;
            DateTime today = DateTime.Today;

            while (!DateTime.TryParseExact(inputBirthday, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthday))
            {
                //birthday = DateTime.ParseExact(inputBirthday, "ddMMyyyy", null);
                Console.WriteLine("Invalid input, please enter the birthday in the required format.");
                Console.Clear();
                AskBirthday();
            }

            int yearNow = today.Year;
            int yearBirthday = birthday.Year;
            int years = yearNow - yearBirthday;

            int dayNow = today.DayOfYear;
            int dayBirthday = birthday.DayOfYear;
            int days = dayNow - dayBirthday;

            if(days < 0)
            {
                years -= 1;
                days += 365;
                Console.WriteLine($"You are {years} years and {days} days old.");
            }
            else if (days == 0)
            {
                Console.WriteLine($"You are {years} years old.");
            }
            else
                Console.WriteLine($"You are {years} years and {days} days old.");
        }

        public static void AskBirthday()
        {
            Console.WriteLine("Welcome to the Birthday Converter!");
            Console.WriteLine("Please enter your kid's birthday in the following format: ddMMyyyy");
        }
    }
}