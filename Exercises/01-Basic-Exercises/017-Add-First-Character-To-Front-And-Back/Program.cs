using System;

namespace AddFirstCharacterToFrontAndBack
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

                if (input == "")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Text cannot be empty. Please try again.");
                    Console.ResetColor();
                }
            } while (input == "");

            return input;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string input = TextInput("Enter a string: ");

            char firstChar = input[0];
            string result = $"{firstChar}{input}{firstChar}"; // string'in birleştirme özelliğini kullanarak ilk karakteri başa ve sona ekliyorum.

            // Yazdırılacak tam satırları oluşturuyorum.
            string originalLine = $"Original text\t: {input}";
            string resultLine = $"Resulting text\t: {result}";

            // En uzun satırın genişliğini bulup ona göre dinamik çizgi üretiyorum.
            int maxLineLength = Math.Max(originalLine.Length, resultLine.Length);
            string divider = new string('-', maxLineLength + 8); // Tab (\t) boşluğunu da kapsayacak pay

            Console.WriteLine($"\n{originalLine}");
            Console.WriteLine(divider);
            Console.WriteLine(resultLine);
            Console.WriteLine($"{divider}\n");
        }
    }
}