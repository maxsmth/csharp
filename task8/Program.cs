using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = MyFunction(x);
            Console.WriteLine($"f({x}) = {result}");
            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            if (x < -4)
            {
                return 46;
            }
            else if (x > 2)
            {
                return 10;
            }
            else
            {
                return 3 * x * x - 2;
            }
        }
    }
}
