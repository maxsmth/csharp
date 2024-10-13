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
            
            double res = Func(2,3) + Func(3,7) + Func(5, 5);
            Console.WriteLine("x = " + res);

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        static double Func(int a, int b)
        {
            return Math.Sqrt(a + Math.Log(1 + Math.Sqrt(b)));
        }
    }
}