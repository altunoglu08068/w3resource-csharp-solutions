using System;

namespace AgeMessage
{
    internal class Program
    {
        static int InputAge(string prompt)
        {
            int age;
            Console.Write(prompt);

            while (!int.TryParse(Console.ReadLine() ?? "", out age) || age < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ Please enter a valid non-negative age!");
                Console.ResetColor();
                Console.Write(prompt);
            }

            return age;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int age = InputAge("Enter your age: ");

            Console.WriteLine($"\nYou look older than {age}\n");
        }
    }
}