using System;

namespace SquareCalculator
{
    public class InvalidFigureException : Exception
    {
        public InvalidFigureException(string className)
            : base($"Такой фигуры не может существовать: " + className) {}
    }
}
