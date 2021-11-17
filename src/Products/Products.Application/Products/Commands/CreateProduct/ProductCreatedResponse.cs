using System;

namespace Products.Application.Products.Commands.CreateProduct
{
    public class ProductCreatedResponse
    {
        public Guid ProductId { get; }
        
        public ProductCreatedResponse(Guid productId)
        {
            ProductId = productId;
        }
    }
}