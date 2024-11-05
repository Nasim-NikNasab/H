using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n1");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter n2");
            string n2 = Console.ReadLine();
            int n1_int = Convert.ToInt32(n1);
            int n2_int = Convert.ToInt32(n2);
            for (int a = n1_int; a < n2_int; a++)
            {
                bool is_prime = true;
                if (a > 2)
                {
                    for (int i = 2; i <= a / 2; i++)
                    {
                        if (a % i == 0)
                        {
                            is_prime = false;
                            break;
                        }
                    }
                    if (is_prime)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }
}
