using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        private const string DefaultMessage =
            "Specified operation was out of the range of valid values.";

        public string Operation { get; }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a 
        /// predefined message.
        /// </summary>
        public CalculationOperationNotSupportedException()
            : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a predefined
        /// message and a wrapped inner exception.
        /// </summary>
        public CalculationOperationNotSupportedException(Exception innerException)
            : base(DefaultMessage, innerException)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a 
        /// user-supplied message and a wrapped inner exception.
        /// </summary>
        public CalculationOperationNotSupportedException(string message,
            Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the 
        /// a default message and the operation that is not supported.
        /// </summary>
        public CalculationOperationNotSupportedException(string operation)
            : base(DefaultMessage) => Operation = operation;

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the 
        /// operation that is not supported and a user-supplied message.
        /// </summary>
        public CalculationOperationNotSupportedException(string operation, string message)
            : base(message) => Operation = operation;

        public override string ToString()
        {
            if (Operation == null)
            {
                return base.ToString();
            }

            return base.ToString() + Environment.NewLine + $"Unsupported operation: {Operation}";
        }
    }
}
