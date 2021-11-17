using System;
using FluentValidation;

namespace Products.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.ProductCode).NotEmpty();
            RuleFor(x => x.Category).NotEqual(Guid.Empty);
            RuleFor(x => x.Cost).GreaterThan(0);
            RuleFor(x => x.Sell).GreaterThan(x => x.Cost);
        }
    }
}