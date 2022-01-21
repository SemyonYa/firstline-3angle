using TriangleLib;
using TriangleLib.Exceptions;
using Xunit;

namespace TriangleLibUnitTest
{
    public class TriangeTest
    {
        [Fact]
        public void TestOnResult_TypeAcute()
        {
            double sideA = 10;
            double sideB = 10;
            double sideC = 10;

            TriangleType result = TriangleTypeLib.GetTriangleType(sideA, sideB, sideC);

            Assert.Equal(TriangleType.Acute, result);
        }

        [Fact]
        public void TestOnResult_TypeRight()
        {
            double sideA = 3;
            double sideB = 5;
            double sideC = 4;

            TriangleType result = TriangleTypeLib.GetTriangleType(sideA, sideB, sideC);

            Assert.Equal(TriangleType.Right, result);
        }

        [Fact]
        public void TestOnResult_TypeObtuse()
        {
            double sideA = 5;
            double sideB = 6.23;
            double sideC = 10;

            TriangleType result = TriangleTypeLib.GetTriangleType(sideA, sideB, sideC);

            Assert.Equal(TriangleType.Obtuse, result);
        }

        [Fact]
        public void TestOnException_ZeroParam()
        {
            double sideA = 10;
            double sideB = 10;
            double sideC = 0;

            Assert.Throws<InvalidSideException>(() => TriangleTypeLib.GetTriangleType(sideA, sideB, sideC));
        }

        [Fact]
        public void TestOnException_NegativeParam()
        {
            double sideA = 10;
            double sideB = -2;
            double sideC = 11;

            Assert.Throws< InvalidSideException>(() => TriangleTypeLib.GetTriangleType(sideA, sideB, sideC));
        }

        [Fact]
        public void TestOnException_ImposibleParams()
        {
            double sideA = 10;
            double sideB = 10;
            double sideC = 21;

            Assert.Throws<NonExistentTriangleException>(() => TriangleTypeLib.GetTriangleType(sideA, sideB, sideC));
        }

    }
}