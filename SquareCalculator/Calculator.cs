namespace SquareCalculator
{
    /// <summary>
    /// Подсчет площадей разных фигур
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Рассчитывает площадь фигуры
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>Площадь фигуры</returns>
        public static double CalculateSquare(IFigure figure) => figure.GetSquare();
    }
}