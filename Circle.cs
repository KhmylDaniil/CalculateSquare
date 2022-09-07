namespace CalculateSquare
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
            => Radius = radius > 0 ? radius : throw new ArgumentOutOfRangeException($"{nameof(radius)} must be positive number");

        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double Square()
             => Math.Pow(Radius, 2) * Math.PI;
    }
}