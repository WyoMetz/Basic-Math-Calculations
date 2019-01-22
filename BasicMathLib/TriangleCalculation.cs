using System;

namespace BasicMathLib
{
    public class TriangleCalculation
    {
        /// <summary>
        /// Returns the Area of a Triangle given the three sides as a string
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public string Area(int sideA, int sideB, int sideC)
        {
            double[] sides = { sideA, sideB, sideC };
            double fracTop = 0;

            foreach (var side in sides)
            {
                fracTop = fracTop + side;
            };

            double p = fracTop / 2;

            double[] sidesSqr = { p - sideA, p - sideB, p - sideC };

            double preSqr = p * (sidesSqr[0] * sidesSqr[1] * sidesSqr[2]);

            double area = Math.Sqrt(preSqr);
            return area.ToString();

            //TEST !!
        }
    }
}
