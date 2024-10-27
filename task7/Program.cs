using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var k = GetNumber("k");
            var m = GetNumber("m");
            var n = GetNumber("n");

            if (IsStatementTrue(k, m, n))
                Console.WriteLine("Утверждение верное");
            else Console.WriteLine("Утверждение не верное");

            Console.ReadKey();
        }

        static bool IsStatementTrue(int k, int m, int n)
        {
            return (k % 2 == m % 2) && (m % 2 == n % 2);
        }
        static int GetNumber(string numberName)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}