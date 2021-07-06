using System;
using Xunit;

namespace Calculator.Tests
{
    public class ArgumentParserTests
    {
        [Fact]
        public void Parses2Plus2()
        {
            var target = new ArgumentParser();
            var args = new string[] {"2", "+", "2"};
            var result = target.TryParse(args, out var left, out var op, out var right);
            Assert.True(result);
            Assert.Equal(2m, left);
            Assert.Equal('+', op);
            Assert.Equal(2m, right);
        }
    }
}
