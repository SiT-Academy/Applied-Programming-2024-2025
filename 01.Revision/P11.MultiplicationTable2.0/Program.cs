﻿namespace P11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int sum = num * i;
                    Console.WriteLine($"{num} X {i} = {sum}");
                }
            }
        }
    }
}
