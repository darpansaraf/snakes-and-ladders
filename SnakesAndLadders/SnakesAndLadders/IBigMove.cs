using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    interface IBigMove
    {
        public int Start { get; set; }
        public int End { get; set; }

        int MakeBigMove();
    }
}
