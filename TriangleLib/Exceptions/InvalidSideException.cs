namespace TriangleLib.Exceptions
{
    public class InvalidSideException : Exception
    {
        override
        public string Message
        { get; } = "Недопустимая длина стороны треугольника. Параметры должны быть больше 0";
    }
}
