using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    /// <summary>
    /// Interface to be used when you want to move a piece by several steps
    /// </summary>
    interface IBigMove
    {
        public int Start { get; set; }
        public int End { get; set; }

        int MakeBigMove();
    }
}
