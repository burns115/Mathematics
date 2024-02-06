using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {
        public double CalculateArea(double width, double height)
        {
            return width * height;
        }

        public double CalculateAverage(List<double> values)
        {
            if (values == null || values.Count == 0)
            {
                return 0;
            }

            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }
            return sum / values.Count;
        }

        public double CalculateSquared(double num1)
        {
            return num1 * num1;
        }

        public double CalculatePT(double num1, double num2)
        {
            return Math.Sqrt(Math.Pow(num1, 2) + Math.Pow(num2, 2));
        }

    }
}
