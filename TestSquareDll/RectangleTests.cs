using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestSquareDll
{
    public class RectangleTests
    {
        [Theory]
        [InlineData( new double[] { 1.1, 2.3, 1.4 })]
        [InlineData(new double[] { 3.96, 4.01, 5.78 })]
        [InlineData(new double[] { 3, 4, 5 })]
        [InlineData(new double[] { 20, 21, 29 })]
        public void RectangleAreaTest(double[] sides)
        {
            double[] rectanglesArea = new double[4] { 0.559, 7.929, 6, 210 };
            var result = CalcSquareDll.Rectangle.CalcS(sides, 3);
            Assert.IsAssignableFrom<double>(result);
            Assert.Contains<double>(result,rectanglesArea);
        }
    }
}
