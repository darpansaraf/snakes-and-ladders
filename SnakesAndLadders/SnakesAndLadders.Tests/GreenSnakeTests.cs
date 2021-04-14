using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]
    public class GreenSnakeTests
    {
        [Fact]
        public void Test_FirstGreenSnakeBiteShouldReturnTheTailPosition()
        {
            GreenSnake _greenSnake = new GreenSnake(14,7);
            int expectedNextPosition = 7;

            int actualNextPosition = _greenSnake.MakeBigMove();

            Assert.Equal(expectedNextPosition, actualNextPosition);

        }

        [Fact]
        public void Test_IfDeadGreenSnakeShouldReturnTheStartPosition()
        {
            GreenSnake _greenSnake = new GreenSnake(14, 7);
            int expectedNextPosition = 14;

            int actualNextPosition = _greenSnake.MakeBigMove();
            actualNextPosition = _greenSnake.MakeBigMove();

            Assert.Equal(expectedNextPosition, actualNextPosition);
        }


    }
}
