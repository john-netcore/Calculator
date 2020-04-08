using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.BL.Tests
{
    public class CalculatorShould
    {
        private readonly ITestOutputHelper _output;
        private readonly Calculator _sut;

        public CalculatorShould(ITestOutputHelper output)
        {
            _output = output;
            _sut = new Calculator();
        }


        [Fact]
        public void ThrowAnExceptionWhenDividingByZero()
        {
            var ex = Assert.Throws<ArithmeticException>(() => _sut.Calculate(10, 0, "/"));
            _output.WriteLine(ex.ToString());
        }

        [Fact]
        public void ThrowAnExceptionWhenWrongOperator()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Calculate(1, 1, "_"));
            _output.WriteLine(ex.ToString());
        }

        [Fact]
        public void ThrowAnExceptionWhenOperatorIsNull()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _sut.Calculate(1, 1, null));
            _output.WriteLine(ex.ToString());
        }
    }
}
