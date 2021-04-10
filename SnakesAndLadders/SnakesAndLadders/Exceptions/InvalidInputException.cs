using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(String message) : base(message)
        {
        }
    }
}
