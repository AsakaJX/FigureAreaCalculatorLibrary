using FigureAreaCalculator.Figures;
using FigureAreaCalculator.Services;
using NUnit.Framework;

namespace FigureAreaCalculator.Tests.Services {
    [TestFixture]
    public class AreaCalculatorTest {
        [TestCaseSource(nameof(FigureAreaTestCases))]
        /// <summary>
        /// Tests if compile-time area calculation is calculates successfully.
        /// Acceptable misscalculation delta: 1e-10
        /// </summary>
        public void CalculateAreaTest(IFigure figure, double expectedArea) {
            double actualArea = AreaCalculator.CalculateArea(figure);
            // Delta is 1e-10 because of misscalculations due to precision of double type
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
        }

        /// <summary>
        /// Making it easier to add new figures for testing compile-time area calculation.
        /// </summary>
        private static IEnumerable<TestCaseData> FigureAreaTestCases() {
            yield return new TestCaseData(new Circle(5), Math.PI * 25).SetName("Circle with radius 5");
            yield return new TestCaseData(new Triangle(3, 4, 5), 6).SetName("Triangle with sides 3, 4, 5");
        }
    }
}