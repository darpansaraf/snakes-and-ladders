using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Validators
{
    /// <summary>
    /// Validates whether dice outcome is between 1 and 6 inclusive.
    /// </summary>
    public class DiceValidator : AbstractValidator<int>
    {
        public DiceValidator()
        {
            RuleFor(diceOutcome => diceOutcome)
                .InclusiveBetween(1, 6)
                .WithMessage("DiceOutcome is Invalid.");
        }
    }
}
