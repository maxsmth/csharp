using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого слона");
            var whiteBishop = Console.ReadLine();
            int column, row;
            DecodePosition(whiteBishop, out column, out raw);

            Console.ReadLine();
        }

        static void DecodePosition(string position, out int column, out int raw)
        {
            column = (int)position[0] - 0x60;
            row = int.Parse(position[1].ToString());
        }
    }
}
