using SnakesAndLadders.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SnakesAndLadders
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {

            var snakeLadderPositions = new SnakeLadderPositions()
            {
                SnakePositions = new Dictionary<int, int>() { { 36, 19 } },
            };

            SnakesAndLaddersBoard _snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions);
            while (true)
            {
                int currentPosition = -1;
                int diceOutcome = -1;
                Console.WriteLine("=================================\n");
                try
                {
                    Console.WriteLine("Enter Current Position:");
                    currentPosition = int.TryParse(Console.ReadLine(), out currentPosition) ? currentPosition : -1;

                    Console.WriteLine("Enter Dice Outcome:");
                    diceOutcome = int.TryParse(Console.ReadLine(), out diceOutcome) ? diceOutcome : -1;

                    int nextPosition = _snakesAndLaddersBoard.Play(currentPosition, diceOutcome);
                    Console.WriteLine("Next Position:" + nextPosition);
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    //log error
                }
            }
        }
    }
}
