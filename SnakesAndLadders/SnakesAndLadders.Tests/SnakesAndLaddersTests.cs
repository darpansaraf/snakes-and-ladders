using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]

    public class SnakesAndLaddersTests : TestsBase
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
    }
}
