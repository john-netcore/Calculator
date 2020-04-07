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
                System.Console.WriteLine("Unknown operation");
                return 0;
            }
        }

        private int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
