namespace P01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[8]
            {
                "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            int input = int.Parse(Console.ReadLine());
            while (true)
            {
                if (input == 1)
                {
                    Console.WriteLine(days[1]);
                    break;
                }
                if (input == 2)
                {
                    Console.WriteLine(days[2]);
                    break;
                }
                if (input == 3)
                {
                    Console.WriteLine(days[3]);
                    break;
                }
                if (input == 4)
                {
                    Console.WriteLine(days[4]);
                    break;
                }
                if (input == 5)
                {
                    Console.WriteLine(days[5]);
                    break;
                }
                if (input == 6)
                {
                    Console.WriteLine(days[6]);
                    break;
                }
                if (input == 7)
                {
                    Console.WriteLine(days[7]);
                    break;
                }
                else
                {
                    Console.WriteLine(days[0]);
                    break;
                }
            }
        }
    }
}
