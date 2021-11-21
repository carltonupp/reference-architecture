using System;
using Products.Domain.Products;
using Xunit;

namespace Products.Domain.Tests.Products
{
    public class WhenUsingFactoryMethod
    {
        [Fact]
        public void CreatesProductWithProductId()
        {
            var product = Product.Create("Halfords Essentials Downtube Mudguard 2018",
                "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                "537156", 2.50m, 5.00m);
            
            Assert.NotEqual(Guid.Empty, product.ProductId);
        }
    }
}