namespace CalculateSquare
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Создание геометрической фигуры в зависимости от количества параметров
        /// </summary>
        /// <param name="input">Входящие данные</param>
        /// <returns>Конкретная геометрическая фигура</returns>
        public static Shape Create(params double[] input)
        {
            switch (input.Length)
            {
                case 0:
                    throw new ArgumentNullException(nameof(input), "Cant create a geometric shape without parameters");
                case 1:
                    return new Circle(input[0]);
                case 3:
                    return new Triangle(input);
                default: throw new ArgumentOutOfRangeException(nameof(input), $"{input.Length}-sided shapes are not implemented in this exersice for now");
            }
        }

        /// <summary>
        /// Метод вычисления площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Square();
    }
}
