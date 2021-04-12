using SnakesAndLadders.Validators;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]
    public class TestsBase : IDisposable
    {
        protected SnakesAndLaddersBoard snakesAndLaddersBoard;
        private static Dictionary<int, int> _snakePositions = new Dictionary<int, int>() { { 36, 19 }, { 14, 7 } };

        public TestsBase()
        {
            var snakeLadderPositions = new SnakeLadderPositions(_snakePositions);
            snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, new DiceValidator());
        }

        public void Dispose()
        {
        }
    }
}
