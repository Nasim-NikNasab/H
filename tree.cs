using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you hungry?");
            string ansanswer1 = Console.ReadLine();
            if (ansanswer1 == "yes")
            {
                Console.WriteLine("is it middle of the day?");
                string ansanswer2 = Console.ReadLine();
                if (ansanswer2 == "yes") 
                {
                    Console.WriteLine("eat lunch");
                }
                else 
                {
                    Console.WriteLine("is it after 6 pm?");
                    string ansanswer3 = Console.ReadLine();
                    if (ansanswer3 == "yes") 
                    {
                        Console.WriteLine("eat dinner");
                    }
                    else 
                    {
                        Console.WriteLine("eat snack");
                    }
                }
            }
            else 
            {
                Console.WriteLine("do you have any job to do?");
                string ansanswer4 = Console.ReadLine();
                if (ansanswer4 == "yes") 
                {
                    Console.WriteLine("do it");
                }
                else 
                {
                    Console.WriteLine("did you exercise?");
                    string ansanswer5 = Console.ReadLine();
                    if (ansanswer5 == "yes") 
                    {
                        Console.WriteLine("watch tv");
                    }
                    else 
                    {
                        Console.WriteLine("go to gym");
                    }
                }
            }
        }
    }
}