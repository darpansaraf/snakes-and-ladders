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
        private static List<Snake> _snakes = new List<Snake>() { new Snake(14, 7) };

        static void Main(string[] args)
        {
            Board board = new Board(_snakes);
            PrintDetails();

            while (true)
            {
                Console.WriteLine("=================================\n");
                try
                {
                    Console.WriteLine("Enter Current Position:");
                    int currentPosition = int.TryParse(Console.ReadLine(), out currentPosition) ? currentPosition : -1;

                    int diceOutcome;
                    Console.WriteLine("Enter Dice Outcome:");
                    diceOutcome = int.TryParse(Console.ReadLine(), out diceOutcome) ? diceOutcome : -1;

                    int nextPosition = board.Play(currentPosition, diceOutcome);
                    Console.WriteLine($"Next Position:{nextPosition}");
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
        }
    }
}
