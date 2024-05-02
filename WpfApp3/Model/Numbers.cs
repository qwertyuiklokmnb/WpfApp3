using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.ViewModel;

namespace WpfApp3.Model
{

    class AreaCalculator
    {
        public double CalculateSquareArea(double sideLength)
        {
            return sideLength * sideLength;
        }

        public double CalculateEquilateralTriangleArea(double sideLength)
        {
            // Площадь равностороннего треугольника: (сторона^2 * корень из 3) / 4
            return (sideLength * sideLength * Math.Sqrt(3)) / 4;
        }
    }
}