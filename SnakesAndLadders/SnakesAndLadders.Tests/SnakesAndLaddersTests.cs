using SnakesAndLadders.Exceptions;
using System;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class SnakesAndLaddersTests : TestsBase
    {

        [Fact]
        public void Test_ValidCurrentPositionAndValidDiceOutcomeShouldReturnTheNextPosition()
        {
            int currentPosition = 4;
            int diceOutcome = 5;
            int expectedNextPosition = 9;

            int actualNextPosition = snakesAndLaddersBoard.Play(currentPosition, diceOutcome);

            Assert.Equal(expectedNextPosition, actualNextPosition);
        }

        [Fact]
        public void Test_InvalidDiceOutcomeShouldThrowException()
        {
            int currentPosition = 7;
            int diceOutcome = 8;
            Assert.Throws<InvalidInputException>(() => snakesAndLaddersBoard.Play(currentPosition, diceOutcome));
        }

        [Fact]
        public void Test_InvalidCurrentPositionShouldThrowException()
        {
            int currentPosition = -7;
            int diceOutcome = 3;
            Assert.Throws<InvalidInputException>(() => snakesAndLaddersBoard.Play(currentPosition, diceOutcome));
        }



    }
}
