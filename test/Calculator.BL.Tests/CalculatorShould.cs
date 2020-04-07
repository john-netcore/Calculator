using System;
using Xunit;

namespace Calculator.BL.Tests
{
    public class CalculatorShould
    {
        private readonly Calculator _sut;

        public CalculatorShould()
        {
            _sut = new Calculator();
        }


        [Fact]
        public void ThrowAnExceptionWhenDividingByZero()
        {
            // var actual = _sut.Calculate(10, 0, "/");

            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Calculate(10, 0, "/"));
        }
    }
}
