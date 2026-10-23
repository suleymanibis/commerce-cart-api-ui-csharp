using E_Commerce_Cart_API_UI.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Validators
{
    public class CreateProductRequestValidator: AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(x => x.name).NotNull()
                .NotEmpty().WithMessage("Product name cannot be empty!");

            RuleFor(x => x.description).NotNull()
                    .NotEmpty().WithMessage("Product description cannot be empty!");

            RuleFor(x => x.price).NotNull()
                    .NotEmpty().WithMessage("Price cannot be empty!")
                    .GreaterThan(0).WithMessage("Price must be positive!");
        }
    }
}
