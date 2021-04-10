using FluentValidation;
using SnakesAndLadders.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadders.Validators
{
    class SnakeAndLadderPositionValidator : AbstractValidator<SnakeLadderPositions>
    {
        public SnakeAndLadderPositionValidator()
        {
            /*
             * snakes' start position should always be less than its end position.
             * Also, a snake start position cannot be at 1 and it cannot be greater than or equal to 100
             */
            RuleFor(snakePositions => snakePositions.SnakePositions)
               .Must(ValidateSnakePositions)
               .WithMessage("Invalid Snakes' Start or End position");
        }

        private bool ValidateSnakePositions(Dictionary<int, int> snakePositions)
        {
            if (snakePositions.Any(x => x.Key < 2) || snakePositions.Any(x => x.Key >= 100))
                return false;

            if (snakePositions.Any(x => x.Key < x.Value))
                return false;

            if (snakePositions.Any(x => x.Value < 1))
                return false;

            return true;
        }
    }
}
