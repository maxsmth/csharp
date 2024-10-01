using System;

internal class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ConsoleColor originalColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Береза");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Белые красавицы");
        Console.WriteLine("Вышли на показ.");
        Console.WriteLine("Не волнуйтесь, нравится");
        Console.WriteLine("Каждая из вас.");
        Console.ForegroundColor = originalColor;
        Console.WriteLine("Цвет текста возвращен в исходное состояние.");
        Console.ReadKey();
    }
}