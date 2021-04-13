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

        private List<Snake> _snakes;

        public Board(List<Snake> snakes)
        {
            _snakes = snakes;
        }

        public int Play(int currentPosition, int diceOutcome)
        {
            int nextPosition = currentPosition + diceOutcome;
            
            if (nextPosition > MAX_BOARD_SIZE)
                nextPosition = currentPosition;
            
            Snake snake = _snakes != null ? _snakes.Find(s => s.Start.Equals(nextPosition)) : null;
            if (snake != null)
                return snake.MakeBigMove();

            return nextPosition;
        }
    }
}
