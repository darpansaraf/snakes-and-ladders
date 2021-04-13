using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class NormalDiceStrategy : IDiceStrategy
    {
        private Random _random;
        public NormalDiceStrategy()
        {
            _random = new Random();
        }
        public int Throw()
        {
            return _random.Next(1, 6);
        }
    }
}
