using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0817PasswordValidatorFromFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartValidator();
        }

        #region Controller
        // Declare variables that will be used by multiple methods
        static string password;
        static ConsoleKeyInfo key;
        static string reason = "";

        /// <summary>
        /// By calling StartValidator() in Main method, start a while loop.
        /// Unless user input "Q" for quit, the program will keep validating new passwords
        /// </summary>
        private static void StartValidator()
        {
            while (key.Key != ConsoleKey.Q)
            {
                Console.Clear();
                ShowPasswordPolicy();
                AskForPassword();

                bool redValidator = RedValidator();
                if(redValidator == false)
                {
                    AskCheckAgainOrQuit();
                    key = TryAgainOrQuit();
                    continue;
                }

                bool yellowValidator = YellowValidator();
                if (yellowValidator == false)
                {
                    AskCheckAgainOrQuit();
                    key = TryAgainOrQuit();
                    continue;
                }
                else
                {
                    GreenPassword();
                    AskCheckAgainOrQuit();
                    key = TryAgainOrQuit();
                    continue;
                }
            }
            Bye();
            Console.ReadKey();
        }
        /// <summary>
        /// Validate the password after the last two requirements;
        /// If passes the check, present Green OK and ask newCheck or quit;
        /// if fails, present reason and ask ask newCheck or quit program
        /// </summary>
        /// <returns></returns>
        private static bool YellowValidator()
        {
            bool yellowValidator = true;
            //char[] passwordArr = password.ToCharArray();

            for (int i = 0; i < (password.Length - 3); i++)
            {
                if (password[i] == password[i + 1] && password[i] == password[i + 2] && password[i] == password[i + 3])
                {
                    reason += "Your password contains four identical chracters.";
                    yellowValidator = false;
                    YellowPassword(reason);
                    break;
                }
                else if (password[i] == (password[i + 1] - 1) && password[i] == (password[i + 2] - 2) && password[i] == (password[i + 3] - 3))
                {
                    reason += "Your password contains four consecutive chracters.";
                    yellowValidator = false;
                    YellowPassword(reason);
                    break;
                }
            }
            // reset reason string
            reason = "";
            return yellowValidator;
        }
        /// <summary>
        /// Validate the password after the first two requirements;
        /// If passes the check, go to validator for the last two requirements;
        /// if fails, present reason and ask check a new one or quit program
        /// </summary>
        /// <returns></returns>
        private static bool RedValidator()
        {
            bool redValidator = true;
            password = GetTrimmedPasseword();

            // Check length
            if (password.Length > 11 && password.Length < 65)
            {
                // Check digit
                if (password.Any(char.IsDigit))
                {
                    // Check Uppercase and Lowercase
                    if (password.Any(char.IsUpper) && password.Any(char.IsLower))
                    
                   {
                        // Check Special chars
                        foreach (char c in password)
                        {
                            if (!Char.IsDigit(c) && !Char.IsLower(c) && !Char.IsUpper(c))
                            {
                                redValidator = true;
                                break;
                            }
                        }
                        if (redValidator == false)
                        {
                            reason += "Your password does not contain a special character.";
                            redValidator = false;
                            RedPassword(reason);
                        }
                    }
                    else
                    {
                        reason += "Your password does not contain a uppercase/lowercase.";
                        redValidator = false;
                        RedPassword(reason);
                    }
                }
                else
                {
                    reason += "Your password does not contain a number.";
                    redValidator = false;
                    RedPassword(reason);
                }
            }
            else
            {
                reason += "Your password is either too long or too short.";
                redValidator = false;
                RedPassword(reason);
            }
            reason = "";
            return redValidator;
        }

        #endregion

        #region View
        private static void RedPassword(string reason)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Poor password: {0}", reason);
            Console.ResetColor();
        }
        private static void YellowPassword(string reason)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Weak password: {0}", reason);
            Console.ResetColor();
        }
        private static void GreenPassword()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK password.");
            Console.ResetColor();
        }
        private static void AskForPassword()
        {
            Console.WriteLine("Enter the password for check:");
        }

        private static void ShowPasswordPolicy()
        {
            Console.Title = "Password Validator";
            Console.WriteLine("Welcome to the Password Validator!\n");
            Console.WriteLine("Here are the rules for a good password:");
            
            Console.WriteLine("1. The length of password should between 12 and 64;");
            Console.WriteLine("2. Passwords need to contain a mixture of lowercase, uppercase, numbers and special characters;");
           
            Console.WriteLine("3. Passwords shall not contain four or more consecutive characters;");
            Console.WriteLine("4. Passwords may contain no more than four characters;\n"); 
            Console.Write("Passwords fail to meet requirments 1 and 2 will be graded as ");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Poor Passwords;");
            Console.ResetColor();
            Console.Write("Passwords fail to meet requirments 3 and 4 will be graded as ");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Weak Passwords;");
            Console.ResetColor();
            Console.Write("Passwords that meet all above requirments are ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK Passwords.\n");
            Console.ResetColor();
        }
        private static void AskCheckAgainOrQuit()
        {
            Console.WriteLine("Press Q to quit, or any other key to try again.");
        }
        private static void Bye()
        {
            Console.WriteLine("\nThank you for using Password Validator. See you next time.");
        }

        #endregion

        #region Modul
        

        private static ConsoleKeyInfo TryAgainOrQuit()
        {
            key = Console.ReadKey(true);
            return key;
        }

        private static string GetTrimmedPasseword()
        {
            password = Console.ReadLine().Trim();
            return password;
        }

        #endregion
    }
}