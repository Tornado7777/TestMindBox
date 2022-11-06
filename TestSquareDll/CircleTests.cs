using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestSquareDll
{
    public class CircleTests
    {
        [Theory]
        [InlineData(new double[] { 10.28 })]
        [InlineData(new double[] { 1.24 })]
        [InlineData(new double[] { 3.17 })]
        [InlineData(new double[] { 4.24 })]
        public void RectangleAreaTest(double[] radius)
        {
            double[] circlesArea = new double[4] { 331.9984850831235, 4.830512864159666, 31.569550416658473, 56.47829608917587 };
            var result = CalcSquareDll.Circle.CalcS(radius);
            Assert.IsAssignableFrom<double>(result);
            Assert.Contains<double>(result, circlesArea);
        }
    }
}
