using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Services
{
    public static class AreaCalculator
    {
        /// <summary>
        /// Invokes CalculateArea method of IFigure interface of given figure.
        /// </summary>
        public static double CalculateArea(IFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}