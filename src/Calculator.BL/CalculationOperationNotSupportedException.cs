using System;

namespace Calculator.BL
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        private static readonly string DefaultMessage = "Specified operation was out of the range of valid values.";
        public string Operation { get; }
        public override string Message
        {
            get
            {
                string message = base.Message;

                if (Operation != null)
                {
                    return message + Environment.NewLine + $"Unsopported operation {Operation}";
                }

                return message;
            }
        }


        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException" /> with a predefined message.
        /// </summary>
        public CalculationOperationNotSupportedException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException" /> with the operation not supported.
        /// </summary>
        /// <param name="operation">The not supported operation</param>
        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException" /> with a user-supplied message and a wrapped exception.
        /// </summary>
        /// <param name="message">The user-supplied message</param>
        /// <param name="innerException">The wrapped exception</param>
        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException" /> with the operation not supported and a user-supplied message.
        /// </summary>
        /// <param name="operation">The not supported operation</param>
        /// <param name="message">The user-supplied message</param>
        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }
    }
}