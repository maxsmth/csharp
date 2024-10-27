using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты x и y через пробел");
            var input = Console.ReadLine();
            var index = input.IndexOf(" ");

            var x = double.Parse(input.Substring(0, index));
            var y = double.Parse(input.Substring(index + 1));

            if (IsInArea(x, y))
                Console.WriteLine("Точка входит в область");
            else Console.WriteLine("Точка не входит в область");
            Console.ReadKey();
        }

        static bool IsInArea(double x, double y)
        {
            return (x >= -1 && x <= 1.5) && (y <= 2 && y >= -0.5);
        }
    }
}
