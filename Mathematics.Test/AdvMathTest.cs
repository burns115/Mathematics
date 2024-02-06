using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void TestArea()
        {
            var math = new AdvMath();
            var result = math.CalculateArea(5, 5);
            Assert.True(result == 25);
        }

        [Fact]
        public void TestAverage()
        {
            var math = new AdvMath();
            List<double> numbers = new List<double> { 2.4, 3.7, 4.1, 5.5 };
            var result = math.CalculateAverage(numbers);
            Assert.True( result == 3.925);
        }

        [Fact]
        public void TestPythagorean()
        {
            var math = new AdvMath();
            var result = math.CalculatePT(3, 4);
            Assert.True(result == 5);
        }

        [Fact]
        public void TestSquared()
        {
            var math = new AdvMath();
            var result = math.CalculateSquared(11);
            Assert.True(result == 121);
        }
    }
}
