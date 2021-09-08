using System;
using System.Collections.Generic;
using System.Text;

namespace lab4c.sh
{
    class lab4
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Количество элементов массива: \t");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0);
            int[] Num = new int[N];
            int min = Num[0];
            int max = Num[0];
            for (int i = 0; i < N; i++)
            {
                Num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if (Num[i] > max)
                {
                    max = Num[i];

                }
                if (Num[i] < min)
                {
                    min = Num[i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (Num[i] > 0)
                {
                    Num[i] = max;

                }
                if (Num[i] < 0)
                {
                    Num[i] = min;
                }
            }
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("min = {0}", min);

            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(Num[i]);
            }
        }
    }
}
