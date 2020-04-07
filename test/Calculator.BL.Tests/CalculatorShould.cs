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
    }
}
