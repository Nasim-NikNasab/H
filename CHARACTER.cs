using System;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch0 = Console.ReadLine();
            char ch = Convert.ToChar(ch0);
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                /*This is an alphabet*/
                Console.WriteLine(ch);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
