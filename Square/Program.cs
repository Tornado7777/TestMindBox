using CalcSquareDll;
using System;

namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета площади круга или треугольника.");
            Console.WriteLine("Выберите тип фигуры:");
            Console.WriteLine("1. Кург.");
            Console.WriteLine("2. Треугольник.");
            var key = Console.ReadKey(true).Key;

            Console.Clear();
            Console.Write("Разделение десятичных знаков запятой ',' !!! ");

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Write("Введите радиус: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double s = CalcArea.CalcAreaFigures(new double[] { r });
                    Console.WriteLine($"Площадь круга: {s}");
                    break;

                case ConsoleKey.D2:
                    double[] a = new Double[3];
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write($"Введите длину стороны {i + 1} треугольника : ");
                        a[i]= Convert.ToDouble(Console.ReadLine());
                    }
                    double s3 = CalcArea.CalcAreaFigures(a);
                    Console.WriteLine($"Площадь треугольника: {s3}");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
