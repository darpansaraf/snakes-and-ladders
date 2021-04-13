using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadders
{
    /// <summary>
    /// Represents Snakes Ladders Board. 
    /// </summary>
    public class Board
    {
        private const int MAX_BOARD_SIZE = 100;

        public int Play(int currentPosition, int diceOutcome)
        {
            int nextPosition = currentPosition + diceOutcome;
            if (nextPosition > MAX_BOARD_SIZE)
                nextPosition = currentPosition;
            return nextPosition;
        }
    }
}
