using System.Threading.Tasks;
using Products.Domain.Categories;

namespace Products.Application.Interfaces.Persistence
{
    public interface ICategoryRepository
    {
        Task<int> Create(Category category);
    }
}