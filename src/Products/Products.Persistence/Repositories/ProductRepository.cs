using System;
using System.Threading.Tasks;
using Products.Application.Interfaces.Persistence;
using Products.Domain.Products;
using Products.Persistence.Context;

namespace Products.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsContext _context;

        public ProductRepository(ProductsContext context)
        {
            _context = context;
        }

        public async Task<Guid> Create(Product product)
        {
            await _context.Products.AddAsync(product);
            return product.ProductId;
        }
    }
}