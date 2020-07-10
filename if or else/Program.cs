using System;

namespace if_or_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);
            if (x == 228)
            {
                Console.WriteLine("Число равно 228");
            }
            else
            {
                Console.WriteLine("Число не 228");
            }
            Console.ReadLine();
        }
        
    }
}
