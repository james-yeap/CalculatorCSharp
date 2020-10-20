using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class AdditionCalculatorTest
    {

        [Test]
        public void SumOf1And2EqualTo3()
        {
            var result1 = Calculator.DoOperation(1, 2, "a");
            Assert.AreEqual(3, result1);
        }
    }

    [TestFixture]
    public class SubtractionCalculatorTest
    {

        [Test]
        public void DifferenceOf10And2EqualTo8()
        {
            var result1 = Calculator.DoOperation(10, 2, "s");
            Assert.AreEqual(8, result1);
        }

        [Test]
        public void DifferenceOf2And10EqualTo8()
        {
            var result1 = Calculator.DoOperation(2, 10, "s");
            Assert.AreEqual(-8, result1);
        }
    }

    [TestFixture]
    public class MultiplicationCalculatorTest
    {

        [Test]
        public void MultiplicationOf10And2EqualTo20()
        {
            var result1 = Calculator.DoOperation(10, 2, "m");
            Assert.AreEqual(20, result1);
        }
    }

    [TestFixture]
    public class DivisionCalculatorTest
    {

        [Test]
        public void DivisionOf10And2EqualTo5()
        {
            var result1 = Calculator.DoOperation(10, 2, "d");
            Assert.AreEqual(5, result1);
        }
    }
}