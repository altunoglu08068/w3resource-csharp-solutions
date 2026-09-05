using System;

namespace ExchangeFirstAndLastCharacters
{
    class Program
    {
        // Kontrollü metin girişi için fonksiyonum.
        static string InputText(string prompt)
        {
            string text;

            do
            {
                Console.Write(prompt);
                text = Console.ReadLine() ?? "";

                if (text == "")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Text cannot be empty. Please try again.");
                    Console.ResetColor();
                }
            } while (text == "");

            return text;
        }

        // İlk ve son karakterleri yer değiştiren fonksiyonum.
        static char[] ChangeFirstAndLastCharacters(char[] chars)
        {
            char temp = chars[0];
            chars[0] = chars[chars.Length - 1];
            chars[chars.Length - 1] = temp;

            return chars;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string text = InputText("Enter a text: ");

            Console.WriteLine($"\nOriginal text\t: {text}");
            Console.WriteLine("--------------------------");

            // Metin tek karakterse aynen yazdırıp programı sonlandırıyorum.
            if (text.Length <= 1)
            {
                Console.WriteLine($"Exchanged text\t: {text}");
            }
            else
            {
                // string türündeki karakterleri char dizisine dönüştürüyorum.
                char[] chars = text.ToCharArray();

                // İlk ve son karakterleri yer değiştiriyorum.
                chars = ChangeFirstAndLastCharacters(chars);

                Console.WriteLine($"Exchanged text\t: {new string(chars)}");
            }

            Console.WriteLine("--------------------------\n");
        }
    }
}