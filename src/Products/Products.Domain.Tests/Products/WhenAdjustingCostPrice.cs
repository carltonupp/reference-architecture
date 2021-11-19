using System;
using Products.Domain.Tests.Fixtures;
using Xunit;

namespace Products.Domain.Tests.Products
{
    public class WhenAdjustingCostPrice : IClassFixture<ProductFixture>
    {
        private readonly ProductFixture _fixture;

        public WhenAdjustingCostPrice(ProductFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void AdjustsCostGivenValidValue()
        {
            _fixture.Product.AdjustCost(3.00m);
            Assert.Equal(3.00m, _fixture.Product.Cost);
        }

        [Fact]
        public void ThrowsExceptionGivenValueHigherThanSellPrice()
        {
            Assert.Throws<Exception>(() =>
            {
                _fixture.Product.AdjustCost(10.00m);
            });
        }

        [Fact]
        public void ThrowsExceptionGivenValueLessThanZero()
        {
            Assert.Throws<Exception>(() =>
            {
                _fixture.Product.AdjustCost(-10.00m);
            });
        }
    }
}