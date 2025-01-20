namespace P07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            decimal priceBeforeDiscount = 0m;
            decimal discount = 0m;
            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceBeforeDiscount = peopleCount * 8.45m;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceBeforeDiscount = peopleCount * 9.80m;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceBeforeDiscount = peopleCount * 10.46m;
                }

                if (peopleCount >= 30)
                {
                    discount = priceBeforeDiscount * 0.15m;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleCount >= 100)
                {
                    peopleCount = peopleCount - 10;
                }

                if (dayOfTheWeek == "Friday")
                {
                    priceBeforeDiscount = peopleCount * 10.90m;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceBeforeDiscount = peopleCount * 15.60m;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceBeforeDiscount = peopleCount * 16m;
                }

                
            }
            else if (groupType == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceBeforeDiscount = peopleCount * 15m;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceBeforeDiscount = peopleCount * 20m;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceBeforeDiscount = peopleCount * 22.50m;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    discount = priceBeforeDiscount * 0.05m;
                }
            }

            decimal totalPrice = priceBeforeDiscount - discount;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
