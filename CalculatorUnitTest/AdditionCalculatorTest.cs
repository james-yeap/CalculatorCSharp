using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class AdditionCalculatorTest
    {
        Calculate _Calculate;
        [Test]
        public void SumOf1And2EqualTo3()
        {
            _Calculate = new Calculate();
            var result1 = _Calculate?.Add(1, 2);
            Assert.AreEqual(3, result1);
        }
    }

    [TestFixture]
    public class SubtractionCalculatorTest
    {
        Calculate _Calculate;
        [Test]
        public void DifferenceOf10And2EqualTo8()
        {
            _Calculate = new Calculate();
            var result1 = _Calculate?.Subtract(10, 2);
            Assert.AreEqual(8, result1);
        }

        [Test]
        public void DifferenceOf2And10EqualTo8()
        {
            _Calculate = new Calculate();
            var result1 = _Calculate?.Subtract(2, 10);
            Assert.AreEqual(-8, result1);
        }
    }

    [TestFixture]
    public class MultiplicationCalculatorTest
    {
        Calculate _Calculate;
        [Test]
        public void MultiplicationOf10And2EqualTo20()
        {
            _Calculate = new Calculate();
            var result1 = _Calculate?.Multiply(10, 2);
            Assert.AreEqual(20, result1);
        }
    }

    [TestFixture]
    public class DivisionCalculatorTest
    {
        Calculate _Calculate;
        [Test]
        public void DivisionOf10And2EqualTo5()
        {
            _Calculate = new Calculate();
            var result1 = _Calculate?.Divide(10, 2);
            Assert.AreEqual(5, result1);
        }
    }
}