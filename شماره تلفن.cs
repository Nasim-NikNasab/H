using static System.Runtime.InteropServices.JavaScript.JSType;

namespace  Phone
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter phone number = ");
            string txt = Console.ReadLine();
            int txt_numeric = Convert.ToInt32(txt);
            int count = 0;

            if (txt_numeric < 999999999 && txt_numeric > 99999999)
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    for (int j = i + 1; j < txt.Length; j++)

                        if (txt[i] == txt[j])

                        {
                            count++;

                        }
                }
                if (count >= 2)
                {
                    Console.WriteLine("Error");
                }

                else
                {
                    Console.WriteLine("0" + txt_numeric);
                }

            }
            else 
            {
                Console.WriteLine("Error");
            }

        }
    }
}