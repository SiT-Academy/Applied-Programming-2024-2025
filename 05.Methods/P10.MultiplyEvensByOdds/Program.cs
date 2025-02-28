using System;

namespace P10.MultiplyEvensByOdds
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            string numberToString = input.ToString();
            int[] numbersArray = numberToString
                .Select(digit => int.Parse(digit.ToString())).ToArray();
            int result = MultiplyEvensByOdds(numbersArray);

            Console.WriteLine(result);
        }
        static int MultiplyEvensByOdds(int[] numbers)
        {
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];
                if (currNumber % 2 == 0)
                {
                    evenSum += currNumber;
                }
                else
                {
                    oddSum += currNumber;
                }
            }
            return evenSum * oddSum;
        }
    }
}
