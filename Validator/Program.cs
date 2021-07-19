using System;
using System.Linq;

namespace Validator
{
    class Program
    {
        public static bool ValidatePin(string input)
        {
            string userPin = input;

                if (userPin.Any(char.IsDigit) && userPin.Length >= 4 && userPin.Length <= 8)
                {
                    Console.WriteLine("Your pin is valid");
                return true;
                }
                else
                {
                    Console.WriteLine("Invalid Pin - Please try again.");
                return false;
                }
        }
        public static bool ValidatePhone(string input)
        {
            string userPhone = input;
            char[] seperators = new char[] { '-', ' ', '(', ')' };
            string[] splitPhone = userPhone.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            string joinedPhone = string.Join("", splitPhone);
            string areaCode = joinedPhone.Substring(0, 3);
            if (joinedPhone.Length == 10 && joinedPhone.Any(char.IsDigit) && areaCode != "555")
            {
                Console.WriteLine("Your phone number is valid");
                return true;
            } else
            {
                Console.WriteLine("Invalid phone number");
                return false;
            }
                

        }
        static void Main(string[] args)
        {
            Program.ValidatePhone("412-905-(4151)");
            var runPin = true;
            var runPhone = true;
            while (runPin)
            {
                Console.WriteLine(@"
                                ------------------------------
                               |       Please enter pin       |
                                ------------------------------");
                var userInput = Console.ReadLine();
                
                bool pin = Program.ValidatePin(userInput);
                
                if (pin)
                {
                    runPin = false;
                }
            }
            while (runPhone)
            {
                Console.WriteLine(@"
                                ------------------------------
                               |       Please enter phone     |
                                ------------------------------");
                var userPhone = Console.ReadLine();
                bool phone = Program.ValidatePhone(userPhone);
                if (phone)
                {
                    runPhone = false;
                }
            }
           
        }
    }
}
