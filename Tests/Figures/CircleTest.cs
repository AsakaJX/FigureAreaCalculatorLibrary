using FigureAreaCalculator.Figures;
using NUnit.Framework;

namespace FigureAreaCalculatorTests.Figures {
    [TestFixture]

    public class CircleTest {
        [Test]

        /// <summary>
        /// Tests if circle area calculates successfully.
        /// Acceptable misscalculation delta: 1e-10
        /// </summary>
        public static void CircleAreaTest() {
            var circle = new Circle(5);

            double expectedArea = Math.PI * 25;
            // Delta is 1e-10 because of misscalculations due to precision of double type
            Assert.That(circle.CalculateArea(), Is.EqualTo(expectedArea).Within(1e-10));
        }
    }
}