using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lABA11SHAPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Начальное приближение x0
            double x0 = 1.5; // В радианах

            // Точность вычислений
            double epsilon = 1e-6;

            int maxIterations = 100;

            for (int i = 0; i < maxIterations; ++i)
            {
                double f = Math.Sin(x0) - 2 * Math.Cos(x0);
                double df = Math.Cos(x0) + 2 * Math.Sin(x0); // Производная функции

                if (Math.Abs(df) < epsilon)
                {
                    Console.WriteLine("Производная близка к нулю.");
                    break;
                }

                double deltaX = -f / df;
                x0 += deltaX;

                if (Math.Abs(deltaX) < epsilon)
                {
                    Console.WriteLine($"Корень найден: x ≈ {x0}");
                    return;
                }
            }

            Console.WriteLine("Решение не найдено за допустимое количество итераций.");
            Console.WriteLine("Работу выполнил Шапкин");
            Console.ReadLine();
        }
    }
}
