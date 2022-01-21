using TriangleLib.Exceptions;

namespace TriangleLib
{
    public class TriangleTypeLib
    {
        /// <summary>
        /// Функция, определяющая тип треугольника по длине его сторон
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static TriangleType GetTriangleType(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new InvalidSideException();
                //throw new Exception("Размеры сторон должны быть больше 0");

            double[] sides = new double[] { a, b, c }
                .OrderBy(side => side)
                .ToArray();

            if (sides[0] + sides[1] <= sides[2])
                throw new NonExistentTriangleException();
                    //Exception("Недопустимые размеры сторон.");

            double piph = Math.Pow(sides[0],2) + Math.Pow(sides[1],2) - Math.Pow(sides[2],2);

            return piph == 0
                ? TriangleType.Right
                : piph < 0
                    ? TriangleType.Obtuse
                    : TriangleType.Acute;
        }

    }

    public enum TriangleType
    {
        /// <summary>
        /// Остроугольный
        /// </summary>
        Acute,
        /// <summary>
        /// Прямоугольный
        /// </summary>
        Right,
        /// <summary>
        /// Тупоугольный
        /// </summary>
        Obtuse,
    }
}