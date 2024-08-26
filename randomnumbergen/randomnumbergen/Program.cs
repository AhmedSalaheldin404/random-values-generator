using System.Text;

namespace randomnumbergen
{
    internal class Program
    {
        //Random values generator
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("press 1 if you want to generetate a random number and press 2 if you want to genereate a random string");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                    randomnnumb();
                else if (option == 2)
                    randomval();
              
              else
                    Console.WriteLine("error");

       
                Console.WriteLine("----------------------");
            }
        }
        static void randomnnumb()
        {
            var rn = new Random();
            var val = rn.Next(0, 10000);
            Console.WriteLine($"Random number is {val}");
        }
        private const string index = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz12345678910!@$#^*&)(_+";
        static void randomval()
        {
            var word = new StringBuilder();
            var rnd = new Random();
            while (word.Length < 16)
            {
                var ranindex = rnd.Next(0, index.Length - 1);
                word.Append(index[ranindex]);
            }
            Console.WriteLine($"the Random value is {word}");
        }
    }
}
