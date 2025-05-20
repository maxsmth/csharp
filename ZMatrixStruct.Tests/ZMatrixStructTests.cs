using NUnit.Framework;
using ZMatrixStruct;

namespace ZMatrixStruct.Tests
{
    [TestFixture]
    public class ZMatrix2x2Tests
    {
        [Test]
        public void Constructor_ValidData_CreatesMatrix()
        {
            int[,] data = { { 1, 2 }, { 3, 4 } };
            var matrix = new ZMatrix2x2(data);
            Assert.That(matrix.ToString(), Is.EqualTo("1 2\n3 4"));
        }

        [Test]
        public void Constructor_InvalidSize_ThrowsException()
        {
            int[,] data = { { 1, 2, 3 }, { 4, 5, 6 } };
            Assert.That(() => new ZMatrix2x2(data), Throws.ArgumentException);
        }

        [Test]
        public void Track_CalculatesCorrectly()
        {
            var matrix = new ZMatrix2x2(new[,] { { 5, 3 }, { 2, 7 } });
            Assert.That(matrix.Track, Is.EqualTo(12));
        }

        [Test]
        public void Determinant_CalculatesCorrectly()
        {
            var matrix = new ZMatrix2x2(new[,] { { 4, 3 }, { 2, 5 } });
            Assert.That(matrix.Determinant, Is.EqualTo(14));
        }

        [Test]
        public void Equals_SameMatrices_ReturnsTrue()
        {
            var m1 = new ZMatrix2x2(new[,] { { 1, 2 }, { 3, 4 } });
            var m2 = new ZMatrix2x2(new[,] { { 1, 2 }, { 3, 4 } });
            Assert.That(m1 == m2, Is.True);
        }

        [Test]
        public void Addition_AddsCorrectly()
        {
            var m1 = new ZMatrix2x2(new[,] { { 1, 2 }, { 3, 4 } });
            var m2 = new ZMatrix2x2(new[,] { { 5, 6 }, { 7, 8 } });
            var result = m1 + m2;
            Assert.That(result.ToString(), Is.EqualTo("6 8\n10 12"));
        }

        [Test]
        public void MatrixMultiplication_MultipliesCorrectly()
        {
            var m1 = new ZMatrix2x2(new[,] { { 1, 2 }, { 3, 4 } });
            var m2 = new ZMatrix2x2(new[,] { { 2, 0 }, { 1, 2 } });
            var result = m1 * m2;
            Assert.That(result.ToString(), Is.EqualTo("4 4\n10 8"));
        }
    }
}