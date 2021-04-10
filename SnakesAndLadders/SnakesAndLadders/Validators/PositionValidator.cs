using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Validators
{
    class PositionValidator : AbstractValidator<int>
    {
        public PositionValidator()
        {
            RuleFor(currentPosition => currentPosition)
                .InclusiveBetween(0, 99)
                .WithMessage("CurrentPosition is Invalid.");
        }
    }
}
