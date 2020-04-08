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
            Assert.Throws<DivideByZeroException>(() => _sut.Calculate(10, 0, "/"));
        }

        [Fact]
        public void ThrowAnExceptionWhenWrongOperator()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Calculate(1, 1, "_"));
        }
    }
}
