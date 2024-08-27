using System;
using System.Text;

namespace randomvalue2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("Press 1 if you want to generate a random number, and press 2 if you want to generate a random string");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the min and max values for the random number:");
                        randomnnumb();
                        break;
                    case 2:
                        Console.WriteLine("Enter the length of the string:");
                        int length = int.Parse(Console.ReadLine());

                        Console.WriteLine("Include capital letters? (yes=1, no=0):");
                        int includeCaps = int.Parse(Console.ReadLine());

                        Console.WriteLine("Include small letters? (yes=1, no=0):");
                        int includeSmalls = int.Parse(Console.ReadLine());

                        Console.WriteLine("Include numbers? (yes=1, no=0):");
                        int includeNumbers = int.Parse(Console.ReadLine());

                        Console.WriteLine("Include symbols? (yes=1, no=0):");
                        int includeSymbols = int.Parse(Console.ReadLine());

                        randomval(length, includeCaps, includeSmalls, includeNumbers, includeSymbols);
                        break;

                    default:
                        Console.WriteLine("Error: Invalid option");
                        break;
                }
                Console.WriteLine("----------------------");
            }
        }

        static void randomnnumb()
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var rn = new Random();
            var val = rn.Next(min, max);
            Console.WriteLine($"Random number is {val}");
        }

        private const string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string smalls = "abcdefghijklmnopqrstuvwxyz";
        private const string numbers = "1234567890";
        private const string symbols = "!@$#^*&)(_+";

        static void randomval(int length, int includeCaps, int includeSmalls, int includeNumbers, int includeSymbols)
        {
            var characterPool = new StringBuilder();

            if (includeCaps == 1)
                characterPool.Append(caps);
            if (includeSmalls == 1)
                characterPool.Append(smalls);
            if (includeNumbers == 1)
                characterPool.Append(numbers);
            if (includeSymbols == 1)
                characterPool.Append(symbols);

            if (characterPool.Length == 0)
            {
                Console.WriteLine("Error: No character types selected.");
                return;
            }

            var word = new StringBuilder();
            var rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                var ranindex = rnd.Next(0, characterPool.Length);
                word.Append(characterPool[ranindex]);
            }

            Console.WriteLine($"The random string is: {word}");
        }
    }
}
