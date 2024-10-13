using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());

            double res = Func(x);
            Console.WriteLine("f(x) = " + res);
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        static double Func(int x)
        {
            return (Math.Sqrt(x + 1) + Math.Sqrt(x - 1)) / Math.Sqrt(x);
        }
    }
}