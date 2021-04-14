using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    /// <summary>
    /// Defines a Snake.
    /// </summary>
    public class Snake : IBigMove
    {
        public Snake(int start, int end)
        {
            if (start >= 99)
                throw new ArgumentException("Invalid Snakes' Start Position");
            if (end < 1 )
                throw new ArgumentException("Invalid Snakes' End Position");
            if (start <= end)
                throw new ArgumentException("Snakes' Start Position cannot be Less than End position");

            this.Start = start;
            this.End = end;
        }

        public int Start { get; set; }

        public int End { get; set; }

        public virtual int MakeBigMove()
        {
            return End;
        }
    }
}
