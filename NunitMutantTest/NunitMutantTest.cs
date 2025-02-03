using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidAngles_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expectedMessage = "The triangle is valid.";

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            ClassicAssert.AreEqual(expectedMessage, result);
        }
        [Test]
        public void IsIsosceles_TwoEqualSides_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5, side2 = 4, side3 = 7;
            string expectedMessage = "The triangle is isosceles.";

            // Act
            string result = Triangle.IsIsosceles(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expectedMessage, result);
        }
    }
}