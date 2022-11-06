using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSquareDll
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Функция берет 0 элемент из массива за радиус и расчитывает площадь круга
        /// </summary>
        /// <param name="a">Массив double чисел</param>
        /// <returns>Площадь круга</returns>
        public static double CalcS(double[] a)
        {
            return a[0] * a[0] * Math.PI;
        }

        public double CalcArea(double[] a)
        {
            return Circle.CalcS(a);
        }
    }
}
