using System;
using NUnit.Framework.Internal;
using NUnit.Framework;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
        public static string IsIsosceles(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return "Sides must be greater than zero.";
            }
            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "The triangle is isosceles.";
            }
            return "The triangle is NOT isosceles.";
        }
    }
}

