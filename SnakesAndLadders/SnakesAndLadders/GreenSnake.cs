using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class GreenSnake : Snake
    {
        private bool _isAlive = true;

        public GreenSnake(int start, int end) : base(start, end)
        {

        }

        public override int MakeBigMove()
        {
            if (_isAlive)
            {
                _isAlive = false;
                return base.MakeBigMove();
            }
            return Start;
        }
    }
}
