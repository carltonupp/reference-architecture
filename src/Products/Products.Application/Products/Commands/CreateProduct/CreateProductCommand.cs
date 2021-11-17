using System;
using MediatR;

namespace Products.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ProductCreatedResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public Guid Category { get; set; }
        public decimal Cost { get; set; }
        public decimal Sell { get; set; }
    }
}