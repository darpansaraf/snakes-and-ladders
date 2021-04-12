using SnakesAndLadders.Exceptions;
using SnakesAndLadders.Validators;
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
            
            Assert.Throws<InvalidInputException>(() => 
                snakesAndLaddersBoard.Play(currentPosition, diceOutcome));
        }

        [Fact]
        public void Test_InvalidCurrentPositionShouldThrowException()
        {
            int currentPosition = -7;
            int diceOutcome = 3;
           
            Assert.Throws<InvalidInputException>(() => 
                snakesAndLaddersBoard.Play(currentPosition, diceOutcome));
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
        public void Test_NextPositionGreaterThanMaxCellsReturnsCurrentPosition()
        {
            int currentPosition = 97;
            int diceOutcome = 5;
            int expectedNextPosition = 97;

            int actualNextPosition = snakesAndLaddersBoard.Play(currentPosition, diceOutcome);

            Assert.Equal(expectedNextPosition, actualNextPosition);
        }

        [Fact]
        public void Test_InvalidSnakesPositionsShouldThrowErrorAtInitialize()
        {
            //Contains invalid positions - { 36, 45 } - start position < end position
            var snakePositions = new Dictionary<int, int>() { { 36, 45 }, { 65, 35 }, { 87, 32 }, { 97, 21 } };
            
            var snakeLadderPositions = new SnakeLadderPositions(snakePositions);
            
            Assert.Throws<InvalidInputException>(() => 
                snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, new DiceValidator()));
        }

        [Fact]
        public void Test_InvalidSnakesStartOrEndPositionsShouldThrowErrorAtInitialize()
        {
            //Contains invalid positions - { 87, -32 }
            var snakePositions = new Dictionary<int, int>() { { 87, -32 }, { 97, 21 } };
            
            var snakeLadderPositions = new SnakeLadderPositions(snakePositions);
            
            Assert.Throws<InvalidInputException>(() => 
                snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, new DiceValidator()));
        }

        [Fact]
        public void Test_CrookedEvenDiceStrategyWithValidDiceOutcomeShouldMoveToNextPosition()
        {
            int currentPosition = 10, diceOutcome = 2, expectedNextPosition = 12;
            var snakePositions = new Dictionary<int, int>() { { 14, 7 } };
            var snakeLadderPositions = new SnakeLadderPositions(snakePositions);
            snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, new EvenDiceValidator());

            int actualNextPosition = snakesAndLaddersBoard.Play(currentPosition, diceOutcome);

            Assert.Equal(expectedNextPosition, actualNextPosition);
        }

        [Fact]
        public void Test_CrookedEvenDiceStrategyWithInvalidDiceOutcomeShouldThrowErrorAtPlay()
        {
            int currentPosition = 10, diceOutcome = 3;
            var snakePositions = new Dictionary<int, int>() { { 14, 7 } };
            var snakeLadderPositions = new SnakeLadderPositions(snakePositions);

            snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, new EvenDiceValidator());

            Assert.Throws<InvalidInputException>(() => snakesAndLaddersBoard.Play(currentPosition, diceOutcome));
        }
    }
}
