using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ReferenceArchitecture.Application;

public static class DependencyInjection
{
    public static void RegisterApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}