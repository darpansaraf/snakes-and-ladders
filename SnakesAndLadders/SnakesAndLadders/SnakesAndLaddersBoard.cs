using FluentValidation.Results;
using SnakesAndLadders.Exceptions;
using SnakesAndLadders.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadders
{
    public class SnakesAndLaddersBoard
    {
        private const int MAX_CELLS = 100;
        private DiceValidator _diceValidator;
        private PositionValidator _positionValidator;

        public SnakesAndLaddersBoard()
        {
            _diceValidator = new DiceValidator();
            _positionValidator = new PositionValidator();
        }

        public int Play(int currentPosition, int diceOutcome)
        {
            ValidateInputs(currentPosition, diceOutcome);
            int nextPosition = currentPosition + diceOutcome;
            if (nextPosition > MAX_CELLS)
                nextPosition = currentPosition;

            return nextPosition;
        }

        private void ValidateInputs(int currentPosition, int diceOutcome)
        {
            ValidationResult results = _diceValidator.Validate(diceOutcome);
            if (results.IsValid == false)
                throw new InvalidInputException(string.Join("||", results.Errors.Select(e => e.ErrorMessage)));

            results = _positionValidator.Validate(currentPosition);
            if (results.IsValid == false)
                throw new InvalidInputException(string.Join("||", results.Errors.Select(e => e.ErrorMessage)));
        }
    }
}
