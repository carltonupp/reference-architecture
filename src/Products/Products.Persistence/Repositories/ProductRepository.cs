using System;
using System.Threading.Tasks;
using Products.Application.Interfaces.Persistence;

namespace Products.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<Guid> Create()
        {
            return await Task.FromResult(Guid.NewGuid());
        }
    }
}