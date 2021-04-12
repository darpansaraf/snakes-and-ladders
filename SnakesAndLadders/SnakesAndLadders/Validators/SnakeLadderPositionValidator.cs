using FluentValidation;
using SnakesAndLadders.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadders.Validators
{
    /// <summary>
    /// Validates whether Snakes have been configured correctly
    /// </summary>
    class SnakeLadderPositionValidator : AbstractValidator<SnakeLadderPositions>
    {
        public SnakeLadderPositionValidator()
        {
            /*
             * snakes' start position should always be less than its end position.
             * snakes' start position cannot be at 1 and it cannot be greater than or equal to 100
             * snakes' end position cannot be less than 1
             */
            RuleFor(snakePositions => snakePositions.SnakePositions)
               .Must(ValidateSnakePositions)
               .WithMessage("Snakes' Start Position cannot be greater than End position");

            RuleForEach(snakePositions => snakePositions.SnakePositions.Keys)
                .InclusiveBetween(2,100)
                .WithMessage("Invalid Snakes' Start Position");

            RuleForEach(snakePositions => snakePositions.SnakePositions.Values)
                .GreaterThan(1)
                .WithMessage("Invalid Snakes' End Position");

        }

        private bool ValidateSnakePositions(Dictionary<int, int> snakePositions)
        {
            if (snakePositions.Any(x => x.Key < x.Value))
                return false;
            return true;
        }
    }
}
