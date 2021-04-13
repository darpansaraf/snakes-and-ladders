using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadders
{
    public class CrookedEvenDiceStrategy : IDiceStrategy
    {
        private Random _random;
        private List<int> _validValues = new List<int>() { 2, 4, 6 };

        public CrookedEvenDiceStrategy()
        {
            _random = new Random();
        }
        public int Throw()
        {
            int index = _random.Next(_validValues.Count);
            return _validValues[index];
        }
    }
}
