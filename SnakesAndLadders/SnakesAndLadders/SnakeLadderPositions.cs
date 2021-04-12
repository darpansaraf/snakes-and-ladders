using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    /// <summary>
    /// Represents Snake Positions.
    /// </summary>
    public class SnakeLadderPositions
    {
        /// <summary>
        /// Key represents the start position. Value Represents end position.
        /// </summary>
        public Dictionary<int,int> SnakePositions { get; set; }

        public SnakeLadderPositions(Dictionary<int, int> snakePositions)
        {
            SnakePositions = snakePositions;
        }
    }
}
