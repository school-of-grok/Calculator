using Xunit;

namespace Calculator.Tests
{
    public class CalculatorEngineTests
    {
        [Fact]
        public void Adds2Plus2()
        {
            var target = new CalculatorEngine();

            var actual = target.Calculate("2+2");

            Assert.Equal(4, actual);
        }

        [Fact]
        public void RemembersLastValue()
        {
            var target = new CalculatorEngine();

            target.Calculate("2+2");
            var actual = target.Calculate("+2");
            
            Assert.Equal(6, actual);
        }
    }
}
