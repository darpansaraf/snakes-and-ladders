using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    /// <summary>
    /// Interface to define how number on a dice will be generated.
    /// </summary>
    public interface IDiceStrategy
    {
        int Throw();
    }
}
