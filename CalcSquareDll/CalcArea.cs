using System;

namespace CalcSquareDll
{
    /*
     Изначально считаю, что массив не нужно проверять на правильность и делать исключения
     */
    public class CalcArea
    {
        /// <summary>
        /// Функция по кол-ву парметров определяется тип фигуры
        /// </summary>
        /// <param name="a">Массив double чисел</param>
        /// <returns>Фозвращает площадь фигуры</returns>
        public static double CalcAreaFigures(double[] a)
        {
            double s = 0;

            switch (a.Length)
            {
                case 1:
                    s = Circle.CalcS(a);
                    break;
                case 3:
                    s = Rectangle.CalcS(a, 3);
                    break;
                default: 
                    Console.WriteLine("Фигуры с таким количеством параметров нет");
                    break;
            }

            return s;
        }
    }
}
