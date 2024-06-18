namespace FigureAreaCalculator.Figures
{
    /// <summary>
    /// Creates a new circle object.
    /// </summary>
    /// <param name="radius">radius of the circle</param>
    public class Circle(double radius) : IFigure
    {
        public double Radius { get; } = radius;

        /// <summary>
        /// Calculates area based on circle's radius.
        /// </summary>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}