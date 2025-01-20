using System.Diagnostics;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

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
    }
}
