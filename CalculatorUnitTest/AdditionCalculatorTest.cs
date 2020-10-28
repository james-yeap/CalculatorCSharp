using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class AdditionCalculatorTest
    {
        private readonly ICalculator _calculate = new Calculate();
        [Test]
        public void SumOf1And2EqualTo3()
        {
            var result1 = _calculate?.Add(1, 2);
            Assert.AreEqual(3, result1);
        }
    }

    [TestFixture]
    public class SubtractionCalculatorTest
    {
        private readonly ICalculator _calculate = new Calculate();
        [Test]
        public void DifferenceOf10And2EqualTo8()
        {
            
            var result1 = _calculate?.Subtract(10, 2);
            Assert.AreEqual(8, result1);
        }

        [Test]
        public void DifferenceOf2And10EqualTo8()
        {
            var result1 = _calculate?.Subtract(2, 10);
            Assert.AreEqual(-8, result1);
        }
    }

    [TestFixture]
    public class MultiplicationCalculatorTest
    {
        private readonly ICalculator _calculate = new Calculate();
        [Test]
        public void MultiplicationOf10And2EqualTo20()
        {
            var result1 = _calculate?.Multiply(10, 2);
            Assert.AreEqual(20, result1);
        }
    }

    [TestFixture]
    public class DivisionCalculatorTest
    {
        private readonly ICalculator _calculate = new Calculate();
        [Test]
        public void DivisionOf10And2EqualTo5()
        {
            var result1 = _calculate?.Divide(10, 2);
            Assert.AreEqual(5, result1);
        }
    }
}