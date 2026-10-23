using E_Commerce_Cart_API_UI.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Validators
{
    public class LoginRequestValidator: AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.email).NotNull()
                .NotEmpty().WithMessage("Email cannot be empty!")
                .EmailAddress().WithMessage("Email format must be valid!");

            RuleFor(x => x.password).NotNull()
                .NotEmpty().WithMessage("Password cannot be empty!")
                .MinimumLength(6).WithMessage("Password length must be at least 6");
        }
    }
}
