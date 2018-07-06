using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        StringCalculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new StringCalculator();
        }

        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("1,2", 3)]
        [TestCase("2,2", 4)]
        [TestCase("3,3,3", 9)]
        public void Add_Returns_Expected_Value(string input, int expected)
        {
            var result = calc.Add(input);

            Assert.That(result, Is.EqualTo(expected));
        }



    }
}