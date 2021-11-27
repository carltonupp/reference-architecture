using System;
using Products.Domain.Products;
using Xunit;

namespace Products.Domain.Tests.Products
{
    public class WhenCreatingProduct
    {
        [Fact]
        public void CreatesSuccessfullyGivenValidParameters()
        {
            var product = new Product(
                "Halfords Essentials Downtube Mudguard 2018",
                "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                "537156", 2.50m, 5.00m);
            Assert.NotNull(product);
        }

        [Fact]
        public void ThrowsExceptionGivenEmptyName()
        {
            Assert.Throws<Exception>(() =>
            {
                var product = new Product(
                    "",
                    "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                    "537156", 2.50m, 5.00m);
            });
        }

        [Fact]
        public void ThrowsExceptionGivenEmptyDescription()
        {
            Assert.Throws<Exception>(() =>
            {
                var product = new Product(
                    "Halfords Essentials Downtube Mudguard 2018",
                    "",
                    "537156", 2.50m, 5.00m);
            });
        }

        [Fact]
        public void ThrowsExceptionGivenEmptyProductCode()
        {
            Assert.Throws<Exception>(() =>
            {
                var product = new Product(
                    "Halfords Essentials Downtube Mudguard 2018",
                    "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                    "", 2.50m, 5.00m);
            });
        }

        [Fact]
        public void ThrowsExceptionGivenNegativeCostPrice()
        {
            Assert.Throws<Exception>(() =>
            {
                var product = new Product(
                    "Halfords Essentials Downtube Mudguard 2018",
                    "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                    "537156", -2.50m, 2.00m);
            });
        }

        [Fact]
        public void ThrowsExceptionGivenSellLessThanCost()
        {
            Assert.Throws<Exception>(() =>
            {
                var product = new Product(
                    "Halfords Essentials Downtube Mudguard 2018",
                    "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                    "537156", 2.50m, 2.00m);
            });
        }

        [Fact]
        public void ThrowsExceptionGivenNegativeSellPrice()
        {
            Assert.Throws<Exception>(() =>
            {
                var product = new Product(
                    "Halfords Essentials Downtube Mudguard 2018",
                    "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                    "537156", -2.50m, -2.00m);
            });
        }
    }
}