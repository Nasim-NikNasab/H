using System;

namespace Mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter number2");
            string n2 = Console.ReadLine();
             int n1_int = Convert.ToInt32(n1);
            int n2_int = Convert.ToInt32(n2);
            if (n1_int < 10)
            {
                Console.WriteLine("error");
            }
            for (int a = n1_int; a <= n2_int; a++)
            {
                int z0 = a % 10;
                if (z0 != 0)
                {
                    for (int i = 1; i <= n2.Length; i++)
                    {
                        int d = (int)(a / Math.Pow(10, i));
                        if (d != 0)
                        {
                            for (int f = i; f <= (n2.Length - 1); f++)
                            {
                                int z = a % 10;
                                z *= (int)(Math.Pow(10, f));
                                z += d;
                                if (z == a)
                                {
                                    Console.WriteLine(a);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}