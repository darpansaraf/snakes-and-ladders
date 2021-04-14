using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace SnakesAndLadders
{
    /// <summary>
    /// Game Class.
    /// </summary>
    public class Game
    {
        private static IDiceStrategy _diceStrategy;
        private List<Player> _players;
        private int _currentPlayerIndex;
        Board _board;

        public Player CurrentPlayer { get => _players[_currentPlayerIndex]; private set { }}

        public Game(Board board, List<Player> players, IDiceStrategy diceStrategy)
        {
            _players = players;
            _currentPlayerIndex = 0;
            _diceStrategy = diceStrategy;
            _board = board;
        }

        public int Play()
        {
            PrintDetails();
            Player _currentPlayer = _players[_currentPlayerIndex];
            try
            {
                int currentPosition = _currentPlayer.Position;
                int diceOutcome = _diceStrategy.Throw();
                Console.WriteLine($"Dice Outcome:{ diceOutcome }");
                _currentPlayer.Position = _board.Play(currentPosition, diceOutcome);
                UpdateNextPlayer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _currentPlayer.Position;
        }

        public void UpdateNextPlayer()
        {
            if (_currentPlayerIndex == _players.Count - 1)
                _currentPlayerIndex = 0;
            else
                _currentPlayerIndex++;
        }

        private void PrintDetails()
        {
            Console.WriteLine("\n----------------");
            Console.WriteLine($"Current Player: {_players[_currentPlayerIndex].Name}");
            Console.WriteLine($"Current Player Position: {_players[_currentPlayerIndex].Position}");
        }
    }
}
