using FluentValidation;
using SnakesAndLadders.Exceptions;
using SnakesAndLadders.Validators;
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
            Console.WriteLine("Pick A Dice Strategy:");
            Console.WriteLine("Enter 1 for General Dice, 2 for Crooked Even Dice");
            int diceStrategyOption = int.TryParse(Console.ReadLine(), out diceStrategyOption) ? diceStrategyOption : -1;

            AbstractValidator<int> diceValidator;
            if (diceStrategyOption == 1)
                diceValidator = new DiceValidator();
            else
                diceValidator = new EvenDiceValidator();
            // Initialize Snake Positions & Dice Strategy here

            var snakeLadderPositions = new SnakeLadderPositions()
            {
                SnakePositions = new Dictionary<int, int>() { { 36, 19 } },
            };
            SnakesAndLaddersBoard _snakesAndLaddersBoard = new SnakesAndLaddersBoard(snakeLadderPositions, diceValidator);
            
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
