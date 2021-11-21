using System;
using System.Threading.Tasks;
using Products.Application.Interfaces.Persistence;
using Products.Domain.Products;

namespace Products.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<Guid> Create(Product product)
        {
            return await Task.FromResult(product.ProductId);
        }
    }
}