using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var snakes = new List<Snake>() { new GreenSnake(14, 7) };
            IDiceStrategy diceStrategy = new NormalDiceStrategy();
            var board = new Board(snakes);
            var player1 = new Player("John", 1);
            var player2 = new Player("Smith", 1);
            var players = new List<Player>() { player1, player2 };
            Game game = new Game(board, players, diceStrategy);
            game.Play();
        }
    }
}
