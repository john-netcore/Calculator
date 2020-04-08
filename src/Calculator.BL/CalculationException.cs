using System;

namespace Calculator.BL
{
    public class CalculationException : Exception
    {
        private static readonly string DefaultMessage =
                @"An error occurred during calculation. 
                Ensure that the operator is supported and the values are withing the valid range.";

        /// <summary>
        /// Creates a new <see cref="CalculationException" /> with a predefined message.
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException" /> with a user-supplied message.
        /// </summary>
        /// <param name="message">The user-supplied message</param>
        public CalculationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException" /> with a predefined message and a user-supplied wrapped exception.
        /// </summary>
        /// <param name="exception">The user-supplied exception</param>
        public CalculationException(Exception exception) : base(DefaultMessage, exception)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException" /> with a user-supplied message and a wrapped exception.
        /// </summary>
        /// <param name="message">The user-supplied message</param>
        /// <param name="exception">The user-supplied exception</param>
        public CalculationException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}