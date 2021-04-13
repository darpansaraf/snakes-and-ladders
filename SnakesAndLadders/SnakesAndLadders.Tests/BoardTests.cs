using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]

    public class BoardTests : TestsBase
    {
        [Fact]
        public void Test_ValidCurrentPositionAndValidDiceOutcomeShouldReturnTheNextPosition()
        {
            //Arrange.
            int currentPosition = 4, diceOutcome = 5, expectedNextPosition = 9;

            //Act
            int actualNextPosition = board.Play(currentPosition, diceOutcome);

            //Assert
            Assert.Equal(expectedNextPosition, actualNextPosition);
        }

        [Fact]
        public void Test_NextPositionGreaterThanMaxCellsReturnsCurrentPosition()
        {
            //Arrange
            int currentPosition = 97, diceOutcome = 5, expectedNextPosition = 97;

            //Act
            int actualNextPosition = board.Play(currentPosition, diceOutcome);

            //Assert
            Assert.Equal(expectedNextPosition, actualNextPosition);
        }

        

        [Fact]
        public void Test_OnSnakeBitePieceNextPositionShouldBeSnakesTail()
        {
            int currentPosition = 10, diceOutcome = 4, expectedNextPosition = 7;

            int actualNextPosition = board.Play(currentPosition, diceOutcome);

            Assert.Equal(expectedNextPosition, actualNextPosition);
        }
    }
}
