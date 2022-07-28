namespace SquareCalculator
{
    public class Triangle : IFigure
    {
        private double _sideA;
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double SideA
        {
            get { return _sideA; }
            set {
                if (value > 0)
                {
                    this._sideA = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        private double _sideB;
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value > 0)
                {
                    this._sideB = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        private double _sideC;
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (value > 0)
                {
                    this._sideC = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidFigureException"></exception>
        public Triangle(double a, double b, double c)
        {
            this.SideA = a;
            this.SideB = b;
            this.SideC = c;
            if (a + b < c || b + c < a || c + a < b)
            {
                throw new InvalidFigureException(nameof(Triangle));
            }
        }

        public bool IsRight =>
            this._sideA * this._sideA + this._sideB * this._sideB == this._sideC * this._sideC ||
            this._sideB * this._sideB + this._sideC * this._sideC == this._sideA * this._sideA ||
            this._sideC * this._sideC + this._sideA * this._sideA == this._sideB * this._sideB;

        public double GetSquare()
        {   
            var p = (this._sideA + this._sideB + this._sideC) / 2;
            return Math.Sqrt(p * (p - this._sideA) * (p - this._sideB) * (p - this._sideC)); ;
        }
    }
}
