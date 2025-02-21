using System.Diagnostics;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country1 = Console.ReadLine();
            
            PrintNumbers(3, 10);
            
        }
        static void Destination(string country)
        {
            switch (country)
            {
                case "Bulgaria": Console.WriteLine("Home");
                    break;
                case "Serbia": Console.WriteLine("Vacation");
                    break;
                default: Console.WriteLine("Not found");
                    break;
            }
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
