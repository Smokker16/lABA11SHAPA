using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA11SHAPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInRadians = Math.Atan(2);// Вычислим арктангенс от числа 2
            Console.WriteLine("Общее решение уравнения sin(x) - 2*cos(x) = 0:");
            Console.WriteLine($"x = {angleInRadians:F4} + n*π, где n — целое число");
            Console.WriteLine("Работу выполнил Шапкин");
            
        }
    }
}
