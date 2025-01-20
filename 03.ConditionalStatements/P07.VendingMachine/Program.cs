namespace P07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty; // input = "";
            double totalMoney = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }

                double money = double.Parse(input);
                switch (money)
                {
                    case 0.1:
                        totalMoney = totalMoney + money;
                        break;
                    case 0.2:
                        totalMoney = totalMoney + money;
                        break;
                    case 0.5:
                        totalMoney = totalMoney + money;
                        break;
                    case 1:
                        totalMoney = totalMoney + money;
                        break;
                    case 2:
                        totalMoney = totalMoney + money;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {money}");
                        break;
                }

            }

            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine($"Change: {totalMoney:f2}");
                    break;
                }

                switch (input)
                {
                    case "Nuts":
                        if (totalMoney - 2 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalMoney = totalMoney - 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (totalMoney - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalMoney = totalMoney - 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (totalMoney - 1.5 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalMoney = totalMoney - 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (totalMoney - 0.8 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalMoney = totalMoney - 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (totalMoney - 1 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalMoney = totalMoney - 1;
                            Console.WriteLine("Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
        }
    }
}
