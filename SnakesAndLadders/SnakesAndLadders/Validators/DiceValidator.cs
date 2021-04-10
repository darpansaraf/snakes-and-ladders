using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Validators
{
    class DiceValidator : AbstractValidator<int>
    {
        public DiceValidator()
        {
            RuleFor(diceOutcome => diceOutcome)
                .InclusiveBetween(1, 6)
                .WithMessage("DiceOutcome is Invalid.");
        }
    }
}
