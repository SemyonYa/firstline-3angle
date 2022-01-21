namespace TriangleLib.Exceptions
{
    public class NonExistentTriangleException : Exception
    {
        override
        public string Message
        { get; } = "Треугольника с такими сторонами не существует";
    }
}
