using System;

namespace ReverseWordsInSentence
{
    internal class Program
    {
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

        static string[] ReverseWords(string[] words)
        {
            string[] reversedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
                reversedWords[i] = words[words.Length - 1 - i];

            return reversedWords;
        }

        static void PrintReversedWords(string text, string[] reversedWords)
        {
            Console.WriteLine("\n" + new string('=', text.Length + 42));
            Console.WriteLine("Original sentence\t\t\t: " + text);
            Console.WriteLine(new string('-', text.Length + 42));
            Console.WriteLine($"Reversed words in the sentence\t\t: {string.Join(" ", reversedWords)}");
            Console.WriteLine(new string('=', text.Length + 42) + "\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string text = TextInput("Enter a sentence: ");
            string[] words = text.Split(' ');
            string[] reversedWords = ReverseWords(words);
            PrintReversedWords(text, reversedWords);
        }
    }
}
