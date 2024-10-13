using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите кол-во секунд: ");
            int n = int.Parse(Console.ReadLine());

            int hours = n / 3600;
            int minutes = (n % 3600) / 60;
            int seconds2 = n % 60;

            Console.WriteLine($"{hours} часов, {minutes} минут, {seconds2} секунд");
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
