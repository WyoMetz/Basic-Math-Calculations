using System;

namespace BasicMathLib
{
    public class CircleCalculations
    {
        private double Pi = Math.PI;

        /// <summary>
        /// Returns the Circumference of a circle with the given radius as a string
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public string Circumference(double radius)
        {
            double Pi2 = Pi * 2;
            double circ = Pi2 * radius;
            return circ.ToString();
        }

        /// <summary>
        /// Returns the Area of a circle with the given radius as a string
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public string Area(double radius)
        {
            double radiusSqr = radius * radius;
            double area = Pi * radiusSqr;
            return area.ToString();
        }
    }
}
