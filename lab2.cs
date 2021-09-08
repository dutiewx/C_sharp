using System;
using System.Collections.Generic;
using System.Text;

namespace lab2c.sh
{
    class lab2
    {
        static void Main(string[] args)
        {
            double sum;

            int n1, n2;
            while (true)
            {
                sum = 0;
                do
                {
                    Console.Write("input n1: \n");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("input n2: ");
                    n2 = int.Parse(Console.ReadLine());
                } while (n1 <= 0 && n2 <= n1);

                if ((n1 >= 0) && (n2 >= n1))
                {
                    for (int k = n1; k <= n2; k++)
                    {
                        sum += (k * k + Math.Pow(-1.0, k - 1) * 2 * k - 1) / (k * k + 8);
                    }
                    Console.Write($"Сумма: {sum}");
                    Console.Write("\n");
                }

                Console.Write("Запустить программу снова: 1 - да, 0 - нет \n");
                int runProgramAgain = int.Parse(Console.ReadLine());

                if (runProgramAgain != 1)
                {
                    break;
                }
            }
        }
    }
}
