using System;

namespace RemoveCharacterByIndex
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

        // Kontrollü indeks girişi yapan fonksiyonum.
        static int IndexInput(string prompt, int maxIndex)
        {
            int index;
            Console.Write(prompt);

            while (!int.TryParse(Console.ReadLine() ?? "", out index) || index < 0 || index >= maxIndex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"⚠️ Invalid input. Please enter a valid index between 0 and {maxIndex - 1}.");
                Console.ResetColor();
                Console.Write(prompt);
            }

            return index;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            string text = TextInput("Enter a text: ");
            Console.WriteLine($"\nYou entered: {text}");
            Console.WriteLine("--------------------------");

            int index = IndexInput($"Enter an index (0 - {text.Length - 1}): ", text.Length); // Hangi indexteki karakteri silmek istediğini soruyorum ve kullanıcıyı doğru index aralığını girmesi için yönlendiriyorum.
            string result = text.Remove(index, 1); // Hangi indexte kaç karekter silineceğini belirtiyorum.

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Resulting text\t: {result}");
            Console.WriteLine("--------------------------\n");
        }
    }
}