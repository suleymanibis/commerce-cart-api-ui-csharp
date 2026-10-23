using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce_Cart_API_UI.Dto;
using FluentValidation;

namespace E_Commerce_Cart_API_UI.Validators
{
    internal class RegisterRequestValidator: AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.firstName).NotNull()
                .NotEmpty().WithMessage("First name cannot be empty!");

            RuleFor(x => x.lastName).NotNull()
                .NotEmpty().WithMessage("Last name cannot be empty!");

            RuleFor(x => x.email).NotNull()
                .NotEmpty().WithMessage("Email cannot be empty!")
                .EmailAddress().WithMessage("Email format must be valid!");

            RuleFor(x => x.password).NotNull()
                .NotEmpty().WithMessage("Password cannot be empty!")
                .MinimumLength(6).WithMessage("Password length must be at least 6");
        }
    }
}
