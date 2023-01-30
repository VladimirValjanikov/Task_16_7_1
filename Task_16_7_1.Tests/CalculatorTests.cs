using NUnit.Framework;

namespace Task_16_7_1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalTest()
        {
            var calculator = new Calculator();
            
            Assert.Equals(8, calculator.Additional(6, 2));
        }

        [Test]
        public void SubtractionTest()
        {
            var calculator = new Calculator();
            
            Assert.Equals(4, calculator.Subtraction(6, 2));
        }

        [Test]
        public void MiltiplicationTest()
        {
            var calculator = new Calculator();

            Assert.Equals(12, calculator.Miltiplication(6, 2));
        }

        [Test]
        public void DivisionTest()
        {
            var calculator = new Calculator();

            Assert.Equals(3, calculator.Division(6, 2));
        }
    }
}