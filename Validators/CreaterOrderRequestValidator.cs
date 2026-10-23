using E_Commerce_Cart_API_UI.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Cart_API_UI.Validators
{
    public class CreaterOrderRequestValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreaterOrderRequestValidator()
        {
            RuleFor(x => x.deliveryAddress).NotNull()
                .NotEmpty().WithMessage("Delivery address cannot be empty!");
        }
    }
}
