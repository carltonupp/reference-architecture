using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces.Persistence;
using Products.Persistence.Context;
using Products.Persistence.Repositories;

namespace Products.Persistence
{
    public static class DependencyInjection
    {
        public static void RegisterPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductsContext>(options =>
            {
                var connectionString = configuration["ConnectionStrings:Default"];
                options.UseSqlServer(connectionString);
            });
            
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}