using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcSquareDll
{
    public class Rectangle : IFigure
    {

        private static int _accuracy;
        /// <summary>
        /// Функция берет элементы из массива за стороны теругольника и расчитывает площадь
        /// </summary>
        /// <param name="a">Массив double чисел</param>
        /// <param name="accuracy">Задаваемая точность результата</param>
        /// <returns>Площадь треугольника</returns>
        public static double CalcS(double[] a, int accuracy)
        {
            _accuracy = accuracy;
            double sum2 = 0; //сумма квадратов катетов
            double s = 0; //площадь
            double aMax = a.Max();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != aMax)
                {
                    sum2 += MathRound((a[i] * a[i]));
                }
            }

            if (MathRound(aMax * aMax) == sum2) 
            { 
                Console.WriteLine("Трегольник прямоугольный.");
                s = 1;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != aMax)
                    {
                        s *= a[i];
                    }
                }
                return MathRound(s /2, false);
            };

            double p = (a[0] + a[1] + a[2]) / 2;

            s = p;
            for (int i = 0; i < a.Length; i++)
            {
                s *= MathRound(p - a[i]);
            }

            return MathRound(Math.Sqrt(s), false);
        }
        public double CalcArea(double[] a)
        {
            return Circle.CalcS(a);
        }

        private static double MathRound(double input, bool ForCalc = true)
        {
            if (ForCalc)
            {
                return Math.Round(input, _accuracy + 3, MidpointRounding.AwayFromZero);
            }

            return Math.Round(input, _accuracy, MidpointRounding.AwayFromZero);
        }
    }
}
