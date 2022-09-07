namespace CalculateSquare
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        public double[] Sides { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sides">Стороны треугольника</param>
        internal Triangle(double[] sides)
             => Sides = IsValid(sides) ? sides : throw new ArgumentOutOfRangeException(nameof(sides), "Triangle with theese sides cant exist.");

        /// <summary>
        /// Проверка возможности создания треугольника с такими сторонами 
        /// </summary>
        /// <param name="sides">Стороны</param>
        /// <returns>Треугольник возможен</returns>
        private static bool IsValid(double[] sides)
            => sides[0] > 0 && sides[1] > 0 && sides[2] > 0 && sides[0] + sides[1] > sides[2] && sides[1] + sides[2] > sides[0] && sides[0] + sides[2] > sides[1];

        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double Square()
        {
            double P = (Sides[0] + Sides[1] + Sides[2]) / 2;

            return Math.Sqrt(P * (P - Sides[0]) * (P - Sides[1]) * (P - Sides[2]));
        }

        /// <summary>
        /// Является ли треугольник правильным
        /// </summary>
        /// <returns>Треугольник правильный</returns>
        public bool IsRight()
        {
            double temp;
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (Sides[i] < Sides[j])
                    {
                        temp = Sides[i];
                        Sides[i] = Sides[j];
                        Sides[j] = temp;
                    }
                }
            }
            return Sides[0] == Math.Sqrt(Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2));
        }
    }
}
