using System;

namespace BasicMathLib
{
    public class HemisphereCalculations
    {
        private double Pi = Math.PI;

        /// <summary>
        /// Returns the volume of a Hemisphere with the given radius
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public string Volume(double radius)
        {
            double volume = ((4/3) * Pi * (radius * radius * radius)) / 2;
            return volume.ToString();
        }
    }
}
