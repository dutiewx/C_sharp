using System;
using System.Collections.Generic;
using System.Text;

namespace lab3c.sh
{
    class lab3
    {
        static void Main(string[] args)
        {

            bool check = true;
            Console.WriteLine("Напишите 3 числа: ");
            Console.Write("Число а = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Число c = ");
            int c = int.Parse(Console.ReadLine());
            if (a == b | b == c | a == c)
            {
                Console.Write(check);
            }
            else if (a != b && b != c && a != c)
            {
                Console.Write(!check);
            }
        }
    }
}
