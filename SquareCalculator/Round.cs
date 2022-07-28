namespace SquareCalculator
{
    public class Circle : IFigure
    {
        private double _radius;
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                {
                    this._radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double r)
        {
            this.Radius = r;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
