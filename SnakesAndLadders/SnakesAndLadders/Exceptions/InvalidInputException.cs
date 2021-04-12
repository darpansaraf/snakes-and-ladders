using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Exceptions
{
    /// <summary>
    /// The Exception is thrown when the user input is incorrect/invalid.
    /// </summary>
    public class InvalidInputException : Exception
    {
        public InvalidInputException(String message) : base(message)
        {
        }
    }
}
