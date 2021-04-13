using FluentValidation;
using SnakesAndLadders.Exceptions;
using SnakesAndLadders.Validators;
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
        // Initialize Snake Positions here
        private static Dictionary<int, int> _snakePositions = new Dictionary<int, int>() { { 36, 19 }, { 14, 7 } };

        static void Main(string[] args)
        {
            Console.WriteLine("Pick A Dice Strategy:");
            Console.WriteLine("Enter 1 for General Dice, 2 for Crooked Even Dice");
            int diceStrategyOption = int.TryParse(Console.ReadLine(), out diceStrategyOption) ? diceStrategyOption : -1;
            AbstractValidator<int> diceValidator;
            if (diceStrategyOption == 1)
                diceValidator = new DiceValidator();
            else
                diceValidator = new EvenDiceValidator();

            SnakeLadderPositions snakeLadderPositions = new SnakeLadderPositions(_snakePositions);
            SnakesAndLaddersBoard snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, diceValidator);

            if (snakeLadderPositions != null && snakeLadderPositions.SnakePositions != null)
                Console.WriteLine($"Snake Positions:{string.Join(",", snakeLadderPositions.SnakePositions)}");

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

                    int nextPosition = snakesAndLaddersBoard.Play(currentPosition, diceOutcome);
                    Console.WriteLine($"Next Position:{nextPosition}");
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
