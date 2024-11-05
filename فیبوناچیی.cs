using System;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter n");
            string n = Console.ReadLine();
            int n_int = Convert.ToInt32(n);
            int a1 = 1;
            int a2 = 1;
            if (n_int == 1) 
            {
                Console.WriteLine("its in it");
            }
            int a3 = a1 + a2;
            int a = 1;
            while (a3 <= n_int)
            {

                a = a2 + a3;
                a2 = a3;
                a3 = a;
                if (n_int == a)
                {
                    Console.WriteLine("its in it");

                }
         
            }

            //        for(int i = 1; a3<=n;)
            //        if (n_int != a1|| n_int!=a2){

            //        }
            //        else{
            //            i = i++;
            //        }
            //ai+1=ai+ai


        }
    }
}
