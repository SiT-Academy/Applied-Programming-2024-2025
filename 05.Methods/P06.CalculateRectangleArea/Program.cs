using System;

namespace P06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = Result(a, b);

            Console.WriteLine(result);
            Console.WriteLine(Result(a, b));
        }

        static int Result(int a, int b)
        {
            return a * b;
        }
    }
}
