using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SnakesAndLadders
{
    /// <summary>
    /// Main Class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    class Program
    {
        //Initialize Snakes and Dice Strategy here
        private static List<Snake> _snakes = new List<Snake>() { new Snake(14, 7) };
        private static IDiceStrategy _diceStrategy = new NormalDiceStrategy();

        static void Main(string[] args)
        {
            Board board = new Board(_snakes);
            PrintDetails();

            while (true)
            {
                try
                {
                    Console.WriteLine("\nEnter Current Position:");
                    int currentPosition = int.TryParse(Console.ReadLine(), out currentPosition) ? currentPosition : -1;

                    int diceOutcome = _diceStrategy.Throw();
                    Console.WriteLine($"Dice Outcome:{diceOutcome}");

                    int nextPosition = board.Play(currentPosition, diceOutcome);
                    Console.WriteLine($"Next Position:{nextPosition}");

                    Console.WriteLine("=================================\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void PrintDetails()
        {
            if (_snakes != null && _snakes.Count > 0)
            {
                foreach (var snake in _snakes)
                {
                    Console.Write($"Snake Positions: [{snake.Start},{snake.End}]");
                }
            }
            Console.WriteLine($"\nDice Strategy:{_diceStrategy.GetType().Name}");
        }
    }
}
