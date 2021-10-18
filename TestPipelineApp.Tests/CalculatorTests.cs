using NUnit.Framework;

namespace TestPipelineApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void GetResult_10Minus5_Return5()
        {
            Calculator calculator = new Calculator(10, 5, Calculator.Operation.Subtract);

            int result = calculator.GetResult();

            Assert.AreEqual(5, result);
        }

        [Test]
        public void GetResult_2Plus5_Return7()
        {
            Calculator calculator = new Calculator(2, 5, Calculator.Operation.Add);

            int result = calculator.GetResult();

            Assert.AreEqual(8, result);
        }
    }
}
