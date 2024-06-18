namespace FigureAreaCalculator.Figures
{
    /// <summary>
    /// Creates a new triangle object.
    /// </summary>
    public class Triangle(double sideA, double sideB, double sideC) : IFigure
    {
        public double SideA { get; } = sideA;
        public double SideB { get; } = sideB;
        public double SideC { get; } = sideC;

        /// <summary>
        /// Calculates area based on three sides of a triangle.
        /// </summary>
        public double CalculateArea()
        {
            // Semi perimeter
            double sp = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(sp * (sp - SideA) * (sp - SideB) * (sp - SideC));
        }

        /// <summary>
        /// Checks if triangle is rectangular.
        /// Acceptable misscalculation delta: 1e-10 (10^-10)
        /// </summary>
        public bool IsRectangular()
        {
            double[] sides = [SideA, SideB, SideC];

            // Default sorting is in *ascending* order
            Array.Sort(sides);

            // 1e-10 because there's misscalculations due to precision of double type
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }
}