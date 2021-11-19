using System;
using Products.Domain.Tests.Fixtures;
using Xunit;

namespace Products.Domain.Tests.Products
{
    public class WhenAdjustingSellPrice : IClassFixture<ProductFixture>
    {
        private readonly ProductFixture _fixture;

        public WhenAdjustingSellPrice(ProductFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void AdjustsSellGivenValidValue()
        {
            _fixture.Product.AdjustSell(100.00m);
            Assert.Equal(100.00m, _fixture.Product.Sell);
        }

        [Fact]
        public void ThrowsExceptionGivenValueLessThanCost()
        {
            Assert.Throws<Exception>(() =>
            {
                _fixture.Product.AdjustSell(1.00m);
            });
        }
    }
}