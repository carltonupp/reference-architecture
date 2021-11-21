using System;
using System.Threading;
using System.Threading.Tasks;
using Products.Application.Products.Commands.CreateProduct;
using Xunit;

namespace Products.Application.Tests.Products.Commands.CreateProduct
{
    public class WhenExecutingCommandHandler : IClassFixture<CreateProductCommandFixture>
    {
        private readonly CreateProductCommandFixture _fixture;

        public WhenExecutingCommandHandler(CreateProductCommandFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task ReturnsProductIdGivenValidCommand()
        {
            var command = new CreateProductCommand
            {
                Name = "Playstation 6",
                Description = "This year's hot new console!",
                Category = Guid.NewGuid(),
                ProductCode = "PS62022",
                Cost = 199.99m,
                Sell = 299.99m
            };

            var response = await _fixture.Handler.Handle(command, new CancellationToken());
            Assert.NotEqual(Guid.Empty, response.ProductId);
        }
    }
}