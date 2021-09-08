using System;

namespace lab3c.sh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите 3 числа: ");
            Console.WriteLine("Число а = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Число b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Число c = ");
            int c = int.Parse(Console.ReadLine());
            if(a==b)
            {
                Console.Write("Числа a и b совпадают ");
            }
            else if(b==c)
            {
                Console.Write("Числа b и c совпадают ");
            }
            else if (a==c)
            {
                Console.Write("Числа a и c совпадают ");
            }
            else if (a!=b && b!=c && a!=c)
            {
                Console.Write("Числа не совпадают ");
            }
        }
    }
}
