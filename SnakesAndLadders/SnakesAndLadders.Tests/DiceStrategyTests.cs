using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]
    public class DiceStrategyTests
    {
        private IDiceStrategy _diceStrategy;

        [Fact]
        public void Test_NormalDiceThrowShouldGenerateANumberBetween1And6()
        {
            _diceStrategy = new NormalDiceStrategy();
            int diceoutcome = _diceStrategy.Throw();

            Assert.InRange(diceoutcome, 1, 6);
        }

        [Fact]
        public void Test_CrookedEvenDiceThrowShouldGenerateAEvenNumberBetween1And6()
        {
            _diceStrategy = new CrookedEvenDiceStrategy();
            List<int> _validValues = new List<int>() { 2, 4, 6 };

            int diceoutcome = _diceStrategy.Throw();

            Assert.Contains(diceoutcome, _validValues);
        }
    }
}
