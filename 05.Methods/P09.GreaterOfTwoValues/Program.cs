using System;

namespace P09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string par1 = Console.ReadLine();
            string par2 = Console.ReadLine();

            string result = string.Empty;
            if (type == "int")
            {
               result = GetMax(int.Parse(par1), int.Parse(par2));
            }
            else if (type == "char")
            {
                result = GetMax(char.Parse(par1), char.Parse(par2));
            }
            else if(type == "string")
            {
                result = GetMax(par1, par2);
            }

            Console.WriteLine(result);
        }
        static string GetMax(int a, int b)
        {
            if (a > b)
            {
                return a.ToString();
            }
            return b.ToString();
        }
        static string GetMax(char a, char b)
        {
            if (a > b)
            {
                return a.ToString();
            }
            return b.ToString();
        }
        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            if(result < 0)
            {
                return b;
            }
            return string.Empty;
        }
        
    }
}
