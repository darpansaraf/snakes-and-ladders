using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]
    public class GameTests
    {
        [Fact]
        public void Test_PlayersShouldBeAbleToPlayGameOneAfterOther()
        {
            var snakes = new List<Snake>() { new GreenSnake(14, 7), new Snake(46, 18) };
            var mockedDice = new Moq.Mock<IDiceStrategy>();
            mockedDice.CallBase = true;
            mockedDice.Setup(md => md.Throw()).Returns(4);
            var board = new Board(snakes);
            var player1 = new Player("John", 1);
            var player2 = new Player("Smith", 1);
            var players = new List<Player>() { player1, player2 };
            Game game = new Game(board, players, mockedDice.Object);
            int player1Nextposition = game.Play();
            var currentPlayer = game.CurrentPlayer;
            int player2Nextposition = game.Play();
            int player1NextpositionUpdated = game.Play();
            Assert.Equal(player1Nextposition + 4, player1NextpositionUpdated);
        }

        [Fact]
        public void Test_GreenSnakeShouldBiteOnlyOnceAndMovePlayerToTheTailOfSnake()
        {
            var snakes = new List<Snake>() { new GreenSnake(14, 7), new Snake(46, 18) };
            var mockedDice = new Moq.Mock<IDiceStrategy>();
            mockedDice.CallBase = true;
            mockedDice.Setup(md => md.Throw()).Returns(4);
            var board = new Board(snakes);
            var player1 = new Player("John", 10);
            var player2 = new Player("Smith", 10);
            var players = new List<Player>() { player1, player2 };
            Game game = new Game(board, players, mockedDice.Object);
            
            int player1Nextposition = game.Play(); // Snake bite only once
            Assert.Equal(7, player1Nextposition);

            var currentPlayer = game.CurrentPlayer;
            int player2Nextposition = game.Play(); // Since snake is dead, it wont bite.
            Assert.Equal(14, player2Nextposition);
        }
    }
}
