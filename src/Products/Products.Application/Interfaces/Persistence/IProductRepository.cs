using System;
using System.Threading.Tasks;
using Products.Domain.Products;

namespace Products.Application.Interfaces.Persistence
{
    public interface IProductRepository
    {
        Task<Guid> Create(Product product);
    }
}