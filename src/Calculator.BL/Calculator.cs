using System;

namespace Calculator.BL
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    //Wrapping an exception.
                    throw new ArithmeticException("An error occurred during calculation.", ex);
                }

            }
            else
            {
                throw new CalculationOperationNotSupportedException();
            }
        }

        private int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
