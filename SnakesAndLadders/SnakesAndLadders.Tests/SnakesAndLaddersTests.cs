using SnakesAndLadders.Exceptions;
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

        [Fact]
        public void Test_OnSnakeBitePieceNextPositionShouldBeSnakesTail()
        {
            int currentPosition = 10;
            int diceOutcome = 4;
            int expectedNextPosition = 7;

            int actualNextPosition = snakesAndLaddersBoard.Play(currentPosition, diceOutcome);

            Assert.Equal(expectedNextPosition, actualNextPosition);
        }

        [Fact]
        public void Test_InvalidSnakesPositionsShouldThrowErrorAtInitialize()
        {
            var snakeLadderPositions = new SnakeLadderPositions()
            {
                //Contains invalid positions - { 36, 45 } - start position < end position
                SnakePositions = new Dictionary<int, int>() { { 36, 45 }, { 65, 35 }, { 87, 32 }, { 97, 21 } } 
            };
            Assert.Throws<InvalidInputException>(() => snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions));
        }

        [Fact]
        public void Test_InvalidSnakesStartOrEndPositionsShouldThrowErrorAtInitialize()
        {
            var snakeLadderPositions = new SnakeLadderPositions()
            {
                //Contains invalid positions - { 87, -32 }
                SnakePositions = new Dictionary<int, int>() { { 1, 35 }, { 87, -32 }, { 97, 21 } }
            };
            Assert.Throws<InvalidInputException>(() => snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions));
        }

    }
}
