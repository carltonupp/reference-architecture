using System;
using System.Threading.Tasks;

namespace Products.Application.Interfaces.Persistence
{
    public interface IProductRepository
    {
        Task<Guid> Create();
    }
}