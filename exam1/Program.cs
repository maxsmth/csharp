using System;

namespace exam1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            long number;

            while (true)
            {
                Console.Write("Введите натуральное число: ");
                if (long.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное натуральное число!");
                }
            }

            var (factors, exponents) = GetPrimeFactors(number);
            PrintFactors(number, factors, exponents);
            Console.ReadKey();
        }

        static (long[], int[]) GetPrimeFactors(long number)
        {
            long[] factors = new long[100];
            int[] exponents = new int[100];
            int index = 0;

            while (number % 2 == 0)
            {
                if (index == 0 || factors[index - 1] != 2)
                {
                    factors[index] = 2;
                    exponents[index] = 1;
                    index++;
                }
                else
                {
                    exponents[index - 1]++;
                }
                number /= 2;
            }

            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    if (index == 0 || factors[index - 1] != i)
                    {
                        factors[index] = i;
                        exponents[index] = 1;
                        index++;
                    }
                    else
                    {
                        exponents[index - 1]++;
                    }
                    number /= i;
                }
            }

            if (number > 2)
            {
                factors[index] = number;
                exponents[index] = 1;
                index++;
            }

            long[] resultFactors = new long[index];
            int[] resultExponents = new int[index];
            Array.Copy(factors, resultFactors, index);
            Array.Copy(exponents, resultExponents, index);

            return (resultFactors, resultExponents);
        }

        static void PrintFactors(long originalNumber, long[] factors, int[] exponents)
        {
            Console.Write($"{originalNumber} = ");
            bool first = true;

            for (int i = 0; i < factors.Length; i++)
            {
                if (exponents[i] == 0) continue;

                if (!first)
                {
                    Console.Write(" * ");
                }
                first = false;

                Console.Write(factors[i]);
                if (exponents[i] > 1)
                {
                    Console.Write($"^{exponents[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}