using System;

namespace P01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberType(int.Parse(Console.ReadLine()));
        }

        static void NumberType(int number)
        {

            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
