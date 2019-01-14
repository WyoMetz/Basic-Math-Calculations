using BasicMathLib;
using System;

namespace Test_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleCalculations CircleCalc = new CircleCalculations(); //BasicMathLib.CircleCalculations
            HemisphereCalculations HemiCalc = new HemisphereCalculations(); //BasicMathLib.HemisphereCalculations
            TriangleCalculation TriCalc = new TriangleCalculation(); //BasicMathLib.TriangleCalculations
            QuadraticCalculation QuadCalc = new QuadraticCalculation(); //BasicMathLib.QuadraticCalculations

            Console.WriteLine("Provide a Circle Radius");
            string input = Console.ReadLine();

            try
            {
                Console.WriteLine
                    (
                    "\nArea is " + CircleCalc.Area(double.Parse(input))
                    );
                Console.WriteLine
                    (
                    "\nCircumference is " + CircleCalc.Circumference(double.Parse(input))
                    );
                Console.WriteLine
                    (
                    "\nHemisphere Volume is " + HemiCalc.Volume(double.Parse(input))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Ocurred during execution. Error: " + ex.Message.ToString());
            }

            Console.WriteLine("\nProvide three sides of a triangle.");

            Console.WriteLine("Side A");
            string sideA = Console.ReadLine();

            Console.WriteLine("Side B");
            string sideB = Console.ReadLine();

            Console.WriteLine("Side C");
            string sideC = Console.ReadLine();

            try
            {
                Console.WriteLine
                    (
                    "\nThe Area of the Triangle is " + TriCalc.Area(int.Parse(sideA), int.Parse(sideB), int.Parse(sideC))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could Not Parse Values" + ex.Message.ToString());
            }

            Console.WriteLine("\nProvide A, B, and C values for a Quadratic Calculation");

            Console.WriteLine("Value A");
            string ValA = Console.ReadLine();

            Console.WriteLine("Value B");
            string valB = Console.ReadLine();

            Console.WriteLine("Value C");
            string valC = Console.ReadLine();

            try
            {
                Console.WriteLine
                    (
                    "\n" + QuadCalc.Quadratic(double.Parse(ValA), double.Parse(valB), double.Parse(valC))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error Parsing Values " + ex.Message.ToString());
            }

            Console.ReadLine();
        }
    }
}
