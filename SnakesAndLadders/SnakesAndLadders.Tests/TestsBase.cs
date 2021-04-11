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
        public TestsBase()
        {
            var snakeLadderPositions = new SnakeLadderPositions()
            {
                SnakePositions = new Dictionary<int, int>() { { 14, 7 } }
            };

            snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, new DiceValidator());
        }

        public void Dispose()
        {
        }
    }
}
