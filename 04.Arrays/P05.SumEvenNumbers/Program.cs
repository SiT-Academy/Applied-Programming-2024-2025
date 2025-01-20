namespace P05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int index = 0; index < nums.Length; index++)
            {
                int currentNum = nums[index];
                if (currentNum % 2 == 0)
                {
                    sum = sum + currentNum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
