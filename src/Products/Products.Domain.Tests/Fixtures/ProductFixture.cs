using System;
using Products.Domain.Products;

namespace Products.Domain.Tests.Fixtures
{
    public class ProductFixture
    {
        public Product Product { get; }
        
        public ProductFixture()
        {
            Product = new Product(
                "Halfords Essentials Downtube Mudguard 2018",
                "The Halfords Essentials Downtube Mudguard  is for 20\" to 27.5\" wheels and fits by straps to the downtube of the frame. We also offer a wide selection of other cycle parts. Halfords offer a fantastic range of Bike Parts and Bike Accessories at competitive prices!",
                "537156", Guid.NewGuid(), 2.50m, 5.00m);
        }
    }
}