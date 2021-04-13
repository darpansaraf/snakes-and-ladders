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
        static void Main(string[] args)
        {
            Board board = new Board();
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
    }
}
