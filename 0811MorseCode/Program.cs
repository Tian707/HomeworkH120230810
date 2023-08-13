namespace _0811MorseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Morse Code Converter!");

            try
            {
                Dictionary<char, string> morseDic = new Dictionary<char, string>
            {
                {'A', "·-"}, {'B', "-···"}, {'C', "-·-·"}, {'D', "-··"},
                {'E', "·"}, {'F', "··-·"}, {'G', "--·"}, {'H', "····"},
                {'I', "··"}, {'J', "·---"}, {'K', "-·-"}, {'L', "·-··"},
                {'M', "--"}, {'N', "-·"}, {'O', "---"}, {'P', "·--·"},
                {'Q', "--·-"}, {'R', "·-·"}, {'S', "···"}, {'T', "-"},
                {'U', "··-"}, {'V', "···-"}, {'W', "·--"}, {'X', "-··-"},
                {'Y', "-·--"}, {'Z', "--··"}, {'1', "·----"}, {'2', "-"},
                {'3', "··-"}, {'4', "···-"}, {'5', ".--"}, {'6', "-..-"},
                {'7', "-·--"}, {'8', "--··"}, {'9', "----·"}, {'0', "-"},
                {'Æ', "··-"}, {'Ø', "···-"}, {'Å', "·--"}, {'.', "-··-"},
                {',', "-·--"}, {':', "--··"}, {'(', "-·--"}, {')', "--··"}
            };

                // Get user input as char
                Console.WriteLine("What do you want to convert?");
                string userInput = Console.ReadLine().ToUpper().Trim();
                char[] input = userInput.ToCharArray();

                // Retrieve user input in chars
                string morseCode = "";
                foreach (char c in input)
                {
                    morseCode += (morseDic[c] + " ");
                }

                Console.WriteLine("Morse code for {0} is {1}.", userInput, morseCode);
            }
            catch
            {
                Console.WriteLine("Oops, part of your input is out of scope of this converter. We are working on it...");
            }



        }

    
    }
}