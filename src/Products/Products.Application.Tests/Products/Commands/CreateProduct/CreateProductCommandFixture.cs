using System;
using Moq;
using Products.Application.Interfaces.Persistence;
using Products.Application.Products.Commands.CreateProduct;
using Products.Domain.Products;

namespace Products.Application.Tests.Products.Commands.CreateProduct
{
    public class CreateProductCommandFixture
    {
        public CreateProductCommandFixture()
        {
            var repository = new Mock<IProductRepository>();
            repository.Setup(repo => repo.Create(It.IsAny<Product>()))
                .ReturnsAsync(Guid.NewGuid);
            
            var validator = new CreateProductCommandValidator();
            Handler = new CreateProductCommandHandler(repository.Object, validator);
        }
        public CreateProductCommandHandler Handler { get; set; }
    }
}