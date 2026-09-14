using System;

namespace FindLongestWord
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
                    Console.WriteLine("\n⚠️ Text cannot be empty. Please enter a valid sentence.");
                    Console.ResetColor();
                }
            } while (input.Trim() == "");

            return input;
        }

        // Kelime dizisinden en uzun olanını seçen algoritmam.
        static string FindLongest(string[] words)
        {
            string longestWord = "";

            foreach (string rawWord in words)
            {
                // Ekstra boşluklardan oluşan boş elemanları temizliyorum.
                string word = rawWord.Trim();

                // Eğer kelime boş değilse ve uzunluğu en uzun kelimeden büyükse, en uzun kelimeyi güncelliyorum.
                if (word != "" && word.Length > longestWord.Length)
                    longestWord = word;
            }

            return longestWord;
        }

        // Daha düzgün bir çıktı için hazırladığım metodum.
        static void PrintHeader(string sentence, string longestWord)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("        Find Longest Word in String     ");
            Console.WriteLine("========================================\n");

            string line1 = $"Input Sentence\t: {sentence}";
            string line2 = $"Longest Word\t: {longestWord}";
            string line3 = $"Character Count\t: {longestWord.Length}";

            int maxLength = Math.Max(line1.Length, Math.Max(line2.Length, line3.Length));
            string divider = new string('-', maxLength + 8);

            Console.WriteLine(divider);
            Console.WriteLine(line1);
            Console.WriteLine(divider);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.ResetColor();
            Console.WriteLine($"{divider}\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string text = TextInput("Enter a sentence\t: ");

            // Texti kelimelere ayırmak için boşluk karakterini kullanıyorum.
            string[] words = text.Split(' ');

            string longestWord = FindLongest(words);

            PrintHeader(text, longestWord);
        }
    }
}