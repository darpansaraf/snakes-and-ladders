using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Validators
{
    /// <summary>
    /// Validates whether the dice outcome is a even outcome. Ex - 2, 4, 6
    /// </summary>
    public class EvenDiceValidator : AbstractValidator<int>
    {
        public EvenDiceValidator()
        {
            RuleFor(diceOutcome => diceOutcome)
                .Must(ValidateDiceOutcome)
                .WithMessage("DiceOutcome is Invalid.");
        }

        private bool ValidateDiceOutcome(int diceOutcome)
        {
            var validDiceOutcome = new List<int> { 2, 4, 6 };
            if (!validDiceOutcome.Contains(diceOutcome))
                return false;
            return true;
        }
    }
}
