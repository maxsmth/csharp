using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите длину стороны правильного треугольника: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту пирамиды: ");
            double h = double.Parse(Console.ReadLine());

            double basearea = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);

            double v = (basearea * h) / 3;

            double l = Math.Sqrt(Math.Pow(((a * Math.Sqrt(3)) / 3), 2) + Math.Pow(h, 2));

            double sidearea = (3 * a * l) / 2;

            double fullarea = basearea + sidearea;

            Console.WriteLine($"Объем пирамиды = {v}");
            Console.WriteLine($"Площадь поверхности = {fullarea}");
            Console.ReadKey();
        }
    }
}
