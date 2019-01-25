using System;

namespace BasicMathLib
{
    public class QuadraticCalculation
    {
        /// <summary>
        /// returns the positive and negative x values in string format
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string Quadratic(double a, double b, double c)
        {
            double root1, root2;

            double discriminant = (b * b) - (4 * a * c);

            if(a == 0)
            {
                return "Not a Quadratic equation";
            }
            
            if(discriminant < 0)
            {
                Console.WriteLine("\nRoots are Imaginary");
                root1 = (-b) / (2 * a);
                root2 = Math.Sqrt(-discriminant) / (2 * a);
                return string.Format("Positive x is {0:#.##} + i {1:#.##} and Negative x is {0:#.##} - i {1:#.##}", root1, root2);
            }

            if(discriminant == 0)
            {
                Console.WriteLine("\nRoots are Equal");
                root1 = root2 = (-b) / (2 * a);
                return string.Format("Positive x is {0:#.##} + i {1:#.##} and Negative x is {0:#.##} - i {1:#.##}", root1, root2);
            }

            if(discriminant > 0)
            {
                Console.WriteLine("\nRoots are Distinct\n");
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                return string.Format("Positive x is {0:#.##} + i {1:#.##} and Negative x is {0:#.##} - i {1:#.##}", root1, root2);
            }

            return "Quadratic Complete";
        }
    }
}
