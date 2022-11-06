using System;
using Xunit;

namespace TestSquareDll
{
    public class CalcAreaTests
    {

        [Fact]
        public void Test1()
        {
            //1. Подготовка данных
            //Для площади круга
            double[,] circlesRadius = new double[4, 1] { { 10.28 }, { 1.24 }, { 3.17 }, { 4.24 } };
            double[] circlesArea = new double[4] { 331.9984850831235, 4.830512864159666, 31.569550416658473, 56.47829608917587 };

            //Для треугольника
            double[,] rectanglesSides = new double[4, 3] { { 1.1, 2.3, 1.4 }, { 3.96, 4.01, 5.78 }, { 3, 4, 5 }, { 20, 21, 29 } };
            double[] rectanglesArea = new double[4] { 0.559, 7.929, 6, 210 };

            //2. Исполнение тестируемого метода
            //3. Сравнение эталонного результатата
            double[] resCirclesArea = new double[4];
            for (int i = 0; i < circlesRadius.Length; i++)
            {
                resCirclesArea[i] = CalcSquareDll.CalcArea.CalcAreaFigures(new double[] { circlesRadius[i,0] });
                Assert.IsAssignableFrom<double>(resCirclesArea[i]);
                Assert.Equal(circlesArea[i], resCirclesArea[i]);
            }

            double[] resRectanglesArea = new double[4];
            for (int i = 0; i < circlesRadius.Length; i++)
            {
                resRectanglesArea[i] = CalcSquareDll.CalcArea.CalcAreaFigures(new double[] { 
                    rectanglesSides[i, 0], 
                    rectanglesSides[i, 1], 
                    rectanglesSides[i, 2] 
                });
                Assert.IsAssignableFrom<double>(resRectanglesArea[i]);
                Assert.Equal(rectanglesArea[i], resRectanglesArea[i]);
            }

        }
    }
}
