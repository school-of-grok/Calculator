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
            var result = target.TryParse("2+2", out var left, out var op, out var right);
            Assert.True(result);
            Assert.Equal(2m, left);
            Assert.Equal('+', op);
            Assert.Equal(2m, right);
        }

        [Fact]
        public void Parses2Plus2WithSpaces()
        {
            var target = new ArgumentParser();
            var result = target.TryParse("2 + 2", out var left, out var op, out var right);
            Assert.True(result);
            Assert.Equal(2m, left);
            Assert.Equal('+', op);
            Assert.Equal(2m, right);
        }

        [Fact]
        public void Parses3Minus3()
        {
            var target = new ArgumentParser();
            var result = target.TryParse("3 - 3", out var left, out var op, out var right);
            Assert.True(result);
            Assert.Equal(3m, left);
            Assert.Equal('-', op);
            Assert.Equal(3m, right);
        }

        [Fact]
        public void ParsesPlus2()
        {
            var target = new ArgumentParser();
            var result = target.TryParse("+2", out var left, out var op, out var right);
            Assert.True(result);
            Assert.Null(left);
            Assert.Equal('+', op);
            Assert.Equal(2, right);
        }
    }
}
