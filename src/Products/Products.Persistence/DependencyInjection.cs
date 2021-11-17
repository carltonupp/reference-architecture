using System;
using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces.Persistence;
using Products.Persistence.Repositories;

namespace Products.Persistence
{
    public static class DependencyInjection
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}