using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var word = "микросхема";
            var result1 = word.Remove(9).Remove(6, 2).Remove(3, 1).Remove(0, 2);
            result1 += word.Remove(6).Remove(0, 4);
            var result2 = word.Substring(6, 3);
            result2 = word.Substring(5, 1) + ReverseString(result2);
            Console.WriteLine(result1 + " и " + result2);
            Console.ReadKey();
        }

        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
