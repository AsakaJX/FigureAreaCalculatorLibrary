using FigureAreaCalculator.Figures;
using NUnit.Framework;

namespace FigureAreaCalculator.Tests.Figures {
    [TestFixture]
    public class TriangleTest {
        [Test]
        /// <summary>
        /// Tests if triangle area calculates successfully.
        /// Acceptable misscalculation delta: 1e-10
        /// </summary>
        public static void TriangleAreaTest() {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            // Delta is 1e-10 because of misscalculations due to precision of double type
            Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea).Within(1e-10));
        }
        /// <summary>
        /// Tests if triangle is rectangular.
        /// </summary>
        [Test]
        public static void RectangularTriangleTest() {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRectangular(), Is.True);
        }
        /// <summary>
        /// Tests if triangle is NOT rectangular.
        /// </summary>
        /// [Test]
        public static void NotRectangularTriangleTest() {
            var triangle = new Triangle(3, 4, 7);
            Assert.That(triangle.IsRectangular(), Is.False);
        }
    }
}