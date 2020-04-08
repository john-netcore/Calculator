using System;

namespace Calculator.BL
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            if (operation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");
            }
        }

        private int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
