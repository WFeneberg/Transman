using Microsoft.Extensions.DependencyInjection;

namespace Transman.Common.Services;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        // collection.AddSingleton<IRepository, Repository>();
        // collection.AddTransient<BusinessService>();
        // collection.AddTransient<MainViewModel>();
    }
}