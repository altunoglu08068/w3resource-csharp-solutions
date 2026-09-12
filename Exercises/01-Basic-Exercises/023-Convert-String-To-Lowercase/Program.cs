using System;

namespace ConvertStringToLowercase
{
    class Program
    {
        // Kontrollü metin girişi yapan fonksiyonum.
        static string TextInput(string prompt)
        {
            string input = "";

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine() ?? "";

                if (input.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n⚠️ Text cannot be empty. Please try again.");
                    Console.ResetColor();
                }
            } while (input.Trim() == "");

            return input;
        }

        // Metni kültüre takılmadan küçük harfe çeviren metot
        static string ToLowerCase(string text) => text.ToLowerInvariant();

        // Düzenli bir şekilde yazdıran fonksiyonum.
        static void PrintHeader(string originalText, string lowerText)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("       String to Lowercase Converter    ");
            Console.WriteLine("========================================\n");

            string line1 = $"Original text\t: {originalText}";
            string line2 = $"Lowercase text\t: {lowerText}";

            int maxLength = Math.Max(line1.Length, line2.Length);
            string divider = new string('-', maxLength + 8);

            Console.WriteLine(divider);
            Console.WriteLine(line1);
            Console.WriteLine(divider);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(line2);
            Console.ResetColor();
            Console.WriteLine($"{divider}\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string text = TextInput("Enter a text\t: ");
            string lowerCaseText = ToLowerCase(text);

            PrintHeader(text, lowerCaseText);
        }
    }
}