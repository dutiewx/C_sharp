using System;
using System.Collections.Generic;
using System.Text;

namespace lab1c.sh
{
    class lab1
    {
        static void Main(string[] args)
        {
            double h, r;
            do
            {
                Console.Write("Введите h: \n");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите r: ");
                r = int.Parse(Console.ReadLine());
            } while (h <= 0 | r <= 0);

            double S = Math.PI * Math.Pow(r, 2);
            double V = (S * h) / 3;
            Console.WriteLine($"Обьем конуса равен {V}");
        }
    }
}
